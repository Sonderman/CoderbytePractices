using System;


// Bracket Combinations
//Have the function BracketCombinations(num) read num which will be an integer greater than or equal to zero,
//and return the number of valid combinations that can be formed with num pairs of parentheses.
//For example, if the input is 3, then the possible combinations of 3 pairs of parenthesis,
//namely: ()()(), are()()(), ()(()), (())(), ((())), and(()()).
//There are 5 total combinations when the input is 3, so your program should return 5.


internal class BracketCombinations
{
    public void run()
    {
        int variable = 0;
        Console.Write("Please enter a number: ");
        if (Int32.TryParse(Console.ReadLine(), out variable))
        {
            int result = 1;
            string pattern = fixedP(variable);


            Console.WriteLine(pattern);

        }
        else Console.WriteLine("Null Returned");
    }

    private string fixedP(int variable)
    {
        string tmp = "";
        if (variable > 0) tmp = "()";
        for(int i = 1; i < variable; i++)
        {
            tmp += ",()";
        }
        return tmp;
    }

    private string myrecursive()
    {
        return "";
    }
}

