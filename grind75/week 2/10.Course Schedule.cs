// Link: https://leetcode.com/problems/course-schedule

// using DFS and Graph Adjacency list
// Time: O(n+p)
// Space: O(n+p)

public class Solution {
  public bool CanFinish(int numCourses, int[][] prerequisites) {
    var preMap =
        new Dictionary<int, List<int>>(); // setup a map-- map will store course
                                          // and all its prereq

    // initilaize map with number of courses - #nodes(graph) and list is empty
    for (int i = 0; i < numCourses; i++) {
      preMap[i] = new List<int>();
    }

    // Add pre req for each course in map-- pre req can be a list
    //  c->a,b
    foreach (var pair in prerequisites) {
      int crs = pair[0];
      int pre = pair[1];

      preMap[crs].Add(pre);
    }
    // creating set to check if there are any loops.. if there is a loop means
    // course is already added in set --> return false
    var visited = new HashSet<int>();

    bool DFS(int crs) {
      if (visited.Contains(crs)) {
        return false;
      }
      // for a particular course there is no pre req -- mark the value as 0
      if (preMap[crs].Count == 0) {
        return true;
      }
      // start with current node and add to the set
      visited.Add(crs);
      // for all its pre req (values from hashmap ) run the DFS
      foreach (int p in preMap[crs]) {
        if (!DFS(p)) {
          return false;
        }
      }
      // since all processing is done on that crs-- remove from set and make the
      // value 0 inside the map
      visited.Remove(crs);
      preMap[crs].Clear();

      return true;
    }

    // we will do this for each node , because graph can be disconnect
    // 1->2
    // 3->4
    for (int c = 0; c < numCourses; c++) {
      if (!DFS(c)) {
        return false;
      }
    }

    return true;
  }
}
