public class Solution {
    public int FindComplement(int num) {

        string binary = Convert.ToString(num, 2);
        string complement = null;

        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[i] == '1')
                complement += '0';
            else if (binary[i] == '0')
                complement += '1';
        }
        return Convert.ToInt32(complement.ToString(), 2);
    }
}