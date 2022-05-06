using System;


// Bracket Combinations (Hard)
//Have the function BracketCombinations(num) read num which will be an integer greater than or equal to zero,
//and return the number of valid combinations that can be formed with num pairs of parentheses.
//For example, if the input is 3, then the possible combinations of 3 pairs of parenthesis,
//namely: ()()(), are()()(), ()(()), (())(), ((())), and(()()).
//There are 5 total combinations when the input is 3, so your program should return 5.


internal class BracketCombinations
{
    int variable = 0;
    int result = 0;
    string pattern = "";
    public void run()
    {
        Console.Write("Please enter a number: ");
        if (Int32.TryParse(Console.ReadLine(), out variable))
        {
            treeRecursive(variable, variable, "(");
            Console.WriteLine("Result: " + result + "\nPattern: " + pattern.TrimEnd(','));

        }
        else Console.WriteLine("Null Returned");
    }

    private string treeRecursive(int left, int right, string str)
    {
        if (left == 0 || right == 0) return str;
        treeRecursive(left - 1, right, str + '(');
        str = treeRecursive(left, right - 1, str + ')');
        checkValidity(str);
        return str;
    }

    private void checkValidity(string str)
    {
        var array = str.ToCharArray();
        int a = 0, b = 0;
        foreach (char c in array)
        {
            if (c == '(')
            {
                a++;
            }
            else b++;
        }
        if (a == b && a == variable)
        {
            if (!pattern.Contains(new string(array)))
            {
                var tmp = new string(array);
                
                while (tmp.Contains("()"))
                {
                    for (int i = 0; i < tmp.Length - 1; i++)
                    {
                        if (tmp[i] == '(' && tmp[i + 1] == ')')
                        {
                            tmp = tmp.Remove(i, 2);
                        }
                    }
                }
                if (tmp.Length == 0)
                {
                    result++;
                    pattern += new string(array) + ",";
                }
            }
        }
    }

}

