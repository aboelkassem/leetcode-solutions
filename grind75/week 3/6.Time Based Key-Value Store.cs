// Link: https://leetcode.com/problems/time-based-key-value-store

// Using Binary Search
// Time: O(logn)
// Space: O(n)
public class TimeMap {
  Dictionary<string, List<(int, string)>> map =
      new Dictionary<string, List<(int, string)>>();
  public TimeMap() {}

  public void Set(string key, string value, int timestamp) {
    if (!map.ContainsKey(key)) {
      map[key] = new List<(int, string)>();
    }
    map[key].Add((timestamp, value));
  }

  public string Get(string key, int timestamp) {
    if (!map.ContainsKey(key)) {
      return "";
    }
    var list = map[key];
    int left = 0, right = list.Count() - 1;
    while (left <= right) {
      int mid = (left + right) / 2;
      if (list[mid].Item1 == timestamp) {
        return list[mid].Item2;
      } else if (list[mid].Item1 < timestamp) {
        left = mid + 1;
      } else {
        right = mid - 1;
      }
    }
    return left == 0 ? string.Empty : list[left - 1].Item2;
  }
}

/**
 * Your TimeMap object will be instantiated and called as such:
 * TimeMap obj = new TimeMap();
 * obj.Set(key,value,timestamp);
 * string param_2 = obj.Get(key,timestamp);
 */
