// Link: https://leetcode.com/problems/counting-bits

// Time: O(n)
// Space: O(n)

// using dynamic programming

public class Solution {
    public int[] CountBits(int n) {
        int[] result = new int[n + 1];
        result[0] = 0; // base case
        for (int i = 0; i <= n; i++)
        {
            // reuse the previous result
            result[i] = result[i / 2] + i % 2;
        }
        
        return result;
    }
}


// using brute force
public class Solution {
    public static int[] CountBits(int n)
    {
        // solve it using divide and mod
        int[] result = new int[n + 1];
        for (int i = 0; i <= n; i++)
        {
            int count = 0;
            int num = i;
                    // loop bits
            while (num > 0)
            {
                // mod 2 and divide by 2 to get binary representation
                // Check if the least significant bit is 1, and if so, increment the count. Right-shift the number by 1 to move to the next bit.
                if (num % 2 == 1)
                    count++;
                num = num / 2;
                Console.WriteLine(i + "=>" + count);
            }
            Console.WriteLine("================");
            result[i] =     ;
        }
        return result;
    }
}
