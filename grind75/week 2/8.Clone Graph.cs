// Link: https://leetcode.com/problems/clone-graph

// using DFS
// Time: O(n)
// Space: O(n)

/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if (node == null)
            return null;

        var result = new Node(node.val);

        if (node.neighbors.Count == 0)
            return result;
        else
        {
            Dictionary<Node, Node> map = new Dictionary<Node, Node> //key: Node , Val : copy of Node
            {
                { node, new Node(node.val) }
            };
            
            DFS(node, map);
            
            //DFS end
            return map[node];
        }
    }

    private static void DFS(Node node, Dictionary<Node, Node> map)
    {
        if (node == null)
            return;

        foreach (var neighbor in node.neighbors)
        {
            // check by reference
            if (!map.ContainsKey(neighbor))
            {
                //Deep copy
                map.Add(neighbor, new Node(neighbor.val));
                DFS(neighbor, map);
            }

            //add neighbor's copy to node's copy
            map[node].neighbors.Add(map[neighbor]);
        }
    }
}