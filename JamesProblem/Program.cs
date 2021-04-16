using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace JamesProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            ICollection<string> CodeLines = new List<string>();

            Console.WriteLine("Enter the lines of code(N)");
            int linesOfCode = Convert.ToInt32(Console.ReadLine());
                
            Console.WriteLine("Enter the code: ");

            
            bool multiLineFlag = false;

            for (int i = 0; i < linesOfCode; i++)
            {
                string filteredCode;
                string codeInput = Console.ReadLine();

                if (new Regex(@"\/\/.*$").IsMatch(codeInput))
                {
                    filteredCode = RemoveSingleComment(codeInput);
                } else if (new Regex(@"\/\*.*$").IsMatch(codeInput))
                {
                    filteredCode = RemoveMultiComment(codeInput);
                    multiLineFlag = true;
                } else if (multiLineFlag && new Regex(@"\*\/.*$").IsMatch(codeInput) == false)
                {
                    filteredCode = "";
                } else if (multiLineFlag && new Regex(@"\*\/.*$").IsMatch(codeInput) == true)
                {
                    filteredCode = RemoveMultiComment(codeInput, true);
                    multiLineFlag = false;
                } else {
                    filteredCode = codeInput;
                }

                if (filteredCode != "")
                {
                    CodeLines.Add(filteredCode);
                }
            }


            foreach (var line in CodeLines)
            {
                Console.WriteLine(line);
            }
            
        }

        static string RemoveSingleComment(string code)
        {
            var regex = new Regex(@"\/\/.*$");
            string filteredCode = regex.Replace(code, "");
            return filteredCode;
        }

        static string RemoveMultiComment(string code, bool closing = false)
        {
            Regex regex;
            string filteredCode;

            if (!closing)
            {
                regex = new Regex(@"\/\*.*$");
                filteredCode = regex.Replace(code, "");
                return filteredCode;
            }

            regex = new Regex(@"^.*\*\/");
            filteredCode = regex.Replace(code, "");
            return filteredCode;
        }
    }
}
