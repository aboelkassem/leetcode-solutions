// Link: https://leetcode.com/problems/coin-change-ii

// Time: O(n)
// Space: O(n)

public class Solution {
  public int Change(int amount, int[] coins) {
    var dpMemory = new Dictionary<string, int>();
    return Recursive(amount, coins, 0, dpMemory);
  }

  private static int Recursive(int remain, int[] coins, int index,
                               Dictionary<string, int> dpMemory) {
    string key = index + "," + remain;
    if (dpMemory.ContainsKey(key))
      return dpMemory[key];

    // return 1 if solution is valid and 0 if solution is invalid
    if (remain == 0)
      return 1;

    if (remain < 0 || index >= coins.Length)
      return 0;

    // two options to get all combinations count
    // count1: use the coin at index
    // count2: skip the coin at index
    var count1 =
        Recursive(remain - coins[index], coins, index,
                  dpMemory); // the same index= You may assume that you have an
                             // infinite number of each kind of coin.
    var count2 = Recursive(remain, coins, index + 1, dpMemory);
    var result = count1 + count2;

    dpMemory[key] = result;

    return result;
  }
}