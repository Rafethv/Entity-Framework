using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkSQL4.Helpers
{
    public static class CommonMethods
    {
        public static string GetStringInput(string output)
        {
            string input;
        TryAgain:
            Console.WriteLine($"pls enter your {output}: ");
            input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine($"{output} cant be empty!");
                goto TryAgain;
            }
            return input;
        }

        public static int GetIntInput(string output)
        {
            string input;
            int convInput;
        TryAgain:
            input = GetStringInput(output);
            try
            {
                convInput = Convert.ToInt32(input);
            }
            catch (Exception)
            {

                Console.WriteLine("Enter Digits pls");
                goto TryAgain;
            }
            return convInput;
        }
    }
}
