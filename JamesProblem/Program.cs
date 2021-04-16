using System;
using System.Collections.Generic;

namespace JamesProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            ICollection<string> CodeLines = new List<string>();

            Console.WriteLine("Enter the lines of code(N)");
            int linesOfCode = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < linesOfCode; i++)
            {
                Console.WriteLine("Enter the code: ");
                string codeInput = Console.ReadLine();
                CodeLines.Add(codeInput);
            }
            
        }
    }
}
