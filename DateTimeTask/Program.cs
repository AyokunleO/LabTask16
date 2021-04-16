using System;

namespace DateTimeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // Take in DoB from user
            Console.WriteLine("Enter your Year of birth: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Month of birth: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your day of birth: ");
            int day = Convert.ToInt32(Console.ReadLine());
            
            DateTime UserDoB = new DateTime(year, month, day);
            DateTime PresentDate = DateTime.Now;
            TimeSpan ageDiff = PresentDate.Subtract(UserDoB);
            DateTime Age = DateTime.MinValue.AddDays(ageDiff.Days);

            if((Age.Year - 1) > 0 && (Age.Year - 1) <= 120)
            {
                Console.WriteLine($"{Age.Year-1} years");
            }else if(Age.Year<PresentDate.Year){
                Console.WriteLine("Age is impossible child!");
            }else{
                Console.WriteLine("Age is impossible!");
            }
            // Check if it's User's Birthday
            if(UserDoB.Year != PresentDate.Year && UserDoB.Month == PresentDate.Month && UserDoB.Day == PresentDate.Day)
            {
                Console.WriteLine("Happy birthday great man!");
            }
        }
    }
}
