    public static string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0)
            return "";

        string prefix = strs[0];    // make first string default prefix 
        for (int i = 0; i < strs.Length; i++)
        {
            while (strs[i].IndexOf(prefix) != 0)    // comparing the next element with prefix(first element) and substring the difference
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
            }
        }

        return prefix;
    }