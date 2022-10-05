using System;
namespace Uppgift313
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Du får välja en låt, skriv in låtens tid här.");
            int minuter =int.Parse(Console.ReadLine());
            int sekunder = int.Parse(Console.ReadLine());

            int sekunder2 = (minuter * 60 + sekunder);
            if (minuter >=165  && minuter <=260 )
            {
                 Console.WriteLine("Din sång kan få spelas.");
            }
            else
            {
                Console.WriteLine("Din sång kan inte spelas");
            }



        }
    }
}