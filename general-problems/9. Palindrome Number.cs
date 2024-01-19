public class Solution {
    public bool IsPalindrome(int x) {
        // reverse x as string
        StringBuilder result = new StringBuilder();
        char[] numbers = x.ToString().ToCharArray();
        Array.Reverse(numbers);
        foreach (var number in numbers)
        {
            result.Append(number);
        }

        string reversedString = result.ToString();
        string originalString = x.ToString();

        if (reversedString == originalString)
            return true;
        else
            return false;
    }
}

/*
===============> another solution without convert to string <==========
    public static bool IsPalindrome(int x)
    {
        // Special cases:
        // As discussed above, when x < 0, x is not a palindrome.
        // Also if the last digit of the number is 0, in order to be a palindrome,
        // the first digit of the number also needs to be 0.
        // Only 0 satisfy this property.
        if (x < 0 || (x % 10 == 0 && x != 0))
        {
            return false;
        }

        // reverse int
        int revertedNumber = 0;
        while (x > revertedNumber)
        {
            revertedNumber = (revertedNumber * 10) + (x % 10);
            x /= 10;
        }

        // When the length is an odd number, we can get rid of the middle digit by revertedNumber/10
        // For example when the input is 12321, at the end of the while loop we get x = 12, revertedNumber = 123,
        // since the middle digit doesn't matter in palindrome(it will always equal to itself), we can simply get rid of it.
        return x == revertedNumber || x == revertedNumber / 10;
    }
*/