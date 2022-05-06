//Codeland Username Validation
//Have the function CodelandUsernameValidation(str) take the str parameter being passed and determine
//if the string is a valid username according to the following rules:

//1. The username is between 4 and 25 characters.
//2. It must start with a letter.
//3. It can only contain letters, numbers, and the underscore character.
//4. It cannot end with an underscore character.

//    If the username is valid then your program should return the string true, otherwise return the string false.

using System;
using System.Linq;

namespace CoderBytePractices.Solutions.Easy
{
    public static class CodeLandUsernameValidation
    {
        public static void Run()
        {
            var str = Console.ReadLine();
            
            if (str != null)
            {
                Console.WriteLine(IsValid(str));
            }
            
        }

        private static bool IsValid(string str)
        {
            var valid = (str.Length >= 4 && str.Length <= 25);
            var array = str.ToCharArray();
            if (!(array[0] >= 97 && array[0] <= 122 || array[0] >= 65 && array[0] <= 90)) valid = false;
            foreach (var vl in array)
            {
                if (!(vl >= 97 && vl <= 122 || vl >= 65 && vl <= 90 || vl == 95 || vl >= 48 && vl <= 57)) valid = false;
            }
            if (array.Last() == 95) valid = false;
            return valid;
        }
    }
}