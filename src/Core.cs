using System;
using System.Collections.Generic;
namespace Program
{
    internal class Core
    {
        private int[] Sequence;

        private readonly int Length = 4;

        public void Generate()
        {
            Random rnd = new Random();
            var digits = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < Length; i++)
            {
                int r = rnd.Next(1, digits.Count);
                Sequence[i] = digits[i];
                digits.Remove(digits[i]);
            }
        }

        /*public void createNewSequence()
        {
            _sequence = new int[Length];
            Random random = new Random();

            for (int i = 0; i < Length; i++)
            {
                _sequence[i] = random.Next() % 10;
            }
        }*/

        /*public void createNewSequence(string input)
        {
            _sequence = new int[Length];

            for (int i = 0; i < Length; i++)
            {
                _sequence[i] = input[i] - 48;
            }
        }*/

        /*public void tryToSolve(string input, out int bulls, out int cows)
        {
            bulls = cows = 0;

            if (!int.TryParse(input, out int num))
            {
                Console.WriteLine("Это не число!");
                return;
            }
            if (input.Length != Length)
            {
                Console.WriteLine("Число неверной длины!");
                return;
            }

            int[] attempt = new int[Length];

            for (int i = 0; i < Length; i++)
            {
                attempt[i] = input[i] - 48;
            }

            int[] trueSequence = new int[Length];

            for (int i = 0; i < Length; i++)
            {
                trueSequence[i] = _sequence[i];
            }

            for (int i = 0; i < Length; i++)
            {
                if (attempt[i] == trueSequence[i])
                {
                    bulls++;
                    attempt[i] = trueSequence[i] = -1;
                }
            }

            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    if (attempt[i] == trueSequence[j] && attempt[i] != -1)
                    {
                        cows++;
                        attempt[i] = trueSequence[j] = -1;
                    }
                }
            }
        }*/

        /*private void checkInput()
        {

        }*/

        /*public void playGame()
        {
            Console.WriteLine("Вы всегда можете ввести \"help\" для получения справки или \"exit\" для выхода из игры.");

            while (true)
            {
                Console.WriteLine("Введите количество символов для угадываемого числа.");

                if (!int.TryParse(Console.ReadLine(), out int input))
                {
                    Console.WriteLine("Это не число!");
                    continue;
                }

                Length = input;
                break;
            }

            while (true)
            {
                Console.WriteLine("Попытайтесь угадать задуманное число.");

                string attempt = Console.ReadLine();

                if (attempt.ToLower() == "stop")
                {
                    Console.WriteLine("Конец игры!");
                    return;
                }

                if (!int.TryParse(attempt, out int num))
                {
                    Console.WriteLine("Это не число.");
                    continue;
                }

                if (attempt.Length != Length)
                {
                    Console.WriteLine("Длины введенного и заданного чисел не совпадают.");
                    continue;
                }

                tryToSolve(attempt, out int bulls, out int cows);

                Console.Write(bulls);

                Console.Write(cows);

                if (bulls == Length)
                {
                    Console.WriteLine("Вы угадали!");
                    return;
                }
            }
        }*/
    }
}