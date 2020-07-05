    public static int HammingDistance(int x, int y)
    {
        string xString = Convert.ToString(x, 2);
        string yString = Convert.ToString(y, 2);

        // make the length of both strings the same by padding '0' on the left...
        if (xString.Length > yString.Length)
        {
            yString = yString.PadLeft(xString.Length, '0');
        }
        else
        {
            xString = xString.PadLeft(yString.Length, '0');
        }

        //loop through both strings and count the difference of bit values...
        int diffCount = 0;
        for (int i = 0; i < xString.Length; i++)
        {
            if (xString[i] != yString[i]) diffCount++;
        }

        return diffCount;
    }

    /* ============== another solution ============
    public static int HammingDistance(int x, int y)
    {
        // Make XOR with the two number and store the result
        int z = x ^ y;
        int n = 0;
        // Loop to get the distance until reach to 0000 and count the loops time (distance)
        while (z > 0)
        {
            z = z & (z - 1);
            ++n;
        }
        return n;
     }
    */