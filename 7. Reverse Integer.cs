public class Solution {
    public int Reverse(int x) {
        long reversed = 0;
        while (x != 0)
        {
            reversed = (reversed * 10) + (x % 10);  // get last digit and add to reversed instead of 0 digit coming from (multiple * 10)
            x /= 10;    // remove last digit from x
        }

        // over flow
        if (reversed > int.MaxValue || reversed < int.MinValue)
            return 0;

        return x < 0 ? (-1 * (int)reversed) : (int)reversed;
        // return (int)reversed;
    }
}