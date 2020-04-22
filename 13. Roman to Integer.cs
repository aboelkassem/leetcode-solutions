    public static int RomanToInt(string s)
    {
        int result = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'I')
            {
                result += 1;
            }
            else if (s[i] == 'V')
            {
                if (i != 0)
                {
                    if (s[i - 1] == 'I')
                    {
                        result += 3;
                    }
                    else
                    {
                        result += 5;
                    }
                }
                else
                {
                    result += 5;
                }
            }
            else if (s[i] == 'X')
            {
                if (i != 0)
                {
                    if (s[i - 1] == 'I' && i > 0)
                    {
                        result += 8;
                    }
                    else
                    {
                        result += 10;
                    }
                }
                else
                {
                    result += 10;
                }
            }
            else if (s[i] == 'L')
            {
                if (i != 0)
                {
                    if (s[i - 1] == 'X' && i > 0)
                    {
                        result += 30;
                    }
                    else
                    {
                        result += 50;
                    }
                }
                else
                {
                    result += 50;
                }
            }
            else if (s[i] == 'C' )
            {
                if (i != 0)
                {
                    if (s[i - 1] == 'X' && i > 0)
                    {
                        result += 80;
                    }
                    else
                    {
                        result += 100;
                    }
                }
                else
                {
                    result += 100;
                }
            }
            else if (s[i] == 'D')
            {
                if (i != 0)
                {
                    if (s[i - 1] == 'C' && i > 0)
                    {
                        result += 300;
                    }
                    else
                    {
                        result += 500;
                    }
                }
                else
                {
                    result += 500;
                }
            }
            else if (s[i] == 'M')
            {
                if (i != 0)
                {
                    if (s[i - 1] == 'C' && i > 0)
                    {
                        result += 800;
                    }
                    else
                    {
                        result += 1000;
                    }
                }
                else
                {
                    result += 1000;
                }
            }
        }
        return result;
    }