using System;
namespace Core
{
    class Program
    {
        static void Main(string[] args)
        {
            int length;
            Console.WriteLine("Введите длину угадываемого числа.");
            try
            {
                length = Console.ReadLine();
            }
            catch (System.Exception)
            {
                Console.WriteLine("1!");
                throw;
            }

        }
    }
}