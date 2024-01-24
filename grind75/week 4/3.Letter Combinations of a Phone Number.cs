// Link: https://leetcode.com/problems/letter-combinations-of-a-phone-number

// Using recursion
// Time: O(4^n) which 4 is max length of digit number '9', "wxyz” or '7', "pqrs”
// Space: O(4^n)
public class Solution {
    Dictionary<char, string> map = new()
    {
        {'2', "abc" }, {'3', "def"},
        {'4', "ghi"}, {'5', "jkl"}, {'6', "mno"},
        {'7', "pqrs"}, {'8', "tuv"}, {'9', "wxyz"}
    };

    public IList<string> LetterCombinations(string digits) {
        List<string> combinations = new();

        void Traverse(int index, string curStr){

            // base case, a combination found
            if (curStr.Length == digits.Length)
            {
                combinations.Add(curStr);
                return;
            }

            foreach (var c in map[digits[index]])
                Traverse(index + 1, curStr + c);
        }

        if (!string.IsNullOrEmpty(digits))
            Traverse(0, "");

        return combinations;
    }
}