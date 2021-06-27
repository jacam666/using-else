using System;

namespace using_else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Total bill is :");
            double payment = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Total balance is :");
            double balance = Convert.ToInt32(Console.ReadLine());

            if (balance >= payment)
            {
                Console.WriteLine("Completed");
            }
            else
            {
                Console.WriteLine("Insufficient funds");
            }
        }
    }
}
