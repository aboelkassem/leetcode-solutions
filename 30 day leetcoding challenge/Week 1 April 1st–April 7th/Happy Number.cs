public class Solution {
    public bool IsHappy(int n) {
        List<int> seen = new List<int>();
        while (n != 1)
        {
            if (seen.Contains(n))
                return false;

            seen.Add(n);
            int newNum = 0;
            while (n > 0)
            {
                newNum += (int)Math.Pow(n % 10, 2); // power of first number
                n /= 10; //get next number
            }
            n = newNum;
        }
        return true;
    }
}