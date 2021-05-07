using System;
namespace Core
{
    class Program
    {
        int length = 4;

        static int[] GenerateNums(int length)
        {
            Random rnd = new Random();
            int[] output = new int[length];

            for (int i = 0; i < length; i++)
            {
                output[i] = rnd.Next(0, 9);
            }

            return output;
        }

        static bool isDigitOnly(String input)
        {   
            if (input.Length != 4)
                return false;

            foreach (char c in input)
                if (c < '0' || c > '9')
                    return false;

            return true;
        }

        static int[] CheckAttempt(string input, int[] nums)
        {
            int[] output = new int[2];

            int[] vector = new int[length];

            for (int i = 0; i < length; i++)
            {
                vector[i] = input[i] - '0';
            }

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Проверка символа.");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Игра начата.");

            int[] nums = GenerateNums(length);

            for (int i = 0; i < length; i++)
            {
                Console.Write(nums[i]);
            }

            Console.WriteLine();

            int counter = 5;

            while (counter > 0)
            {
                String attept = Console.ReadLine();

                Console.WriteLine(isDigitOnly(attept));

                if (isDigitOnly(attept))
                {
                    CheckAttempt(attept, nums);
                }
            }

            Console.WriteLine("Игра завершена.");
            Console.ReadLine();
        }
    }
}