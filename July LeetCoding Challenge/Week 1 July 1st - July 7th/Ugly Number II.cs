public class Solution {
    public int NthUglyNumber(int n) {
            int[] result = new int[n];

            int index2 = 0;
            int index3 = 0;
            int index5 = 0;

            result[0] = 1;

            for (int i = 1; i < n; i++)
            {
                int min = Math.Min(result[index2] * 2, Math.Min(result[index3] * 3, result[index5] * 5));

                result[i] = min;

                if (min == result[index2] * 2)
                {
                    index2++;
                }

                if (min == result[index3] * 3)
                {
                    index3++;
                }

                if (min == result[index5] * 5)
                {
                    index5++;
                }                
            }

            return result[n - 1];
    }
}