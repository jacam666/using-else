using System;

namespace using_else
{
    class Program
    {
        static void Main(string[] args)
        {
            double payment = Convert.ToInt32(Console.ReadLine());
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
