using System;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;
using System.Security.Cryptography;
namespace Program
{
    internal class Riddle
    {
        /// <summary>
        /// Загаданная последовательность чисел.
        /// </summary>
        private readonly List<int> Sequence = new List<int>();

        /// <summary>
        /// Длина последовательности чисел.
        /// </summary>
        public int Length { get; private set; }

        /// <summary>
        /// Generate empty sequence
        /// </summary>
        public Riddle() { }

        /// <summary>
        /// Генерирует новую комбинацию чисел указанной длины.
        /// </summary>
        /// <param name="length">Длина последовательности. Не может быть меньше 2.</param>
        public Riddle(int length)
        {
            try
            {
                if (length <= 1)
                    throw new Exception("Длина последовательности должна быть больше 1 символа.");
                else
                {
                    Length = length;
                    RegenerateSequence();
                }
            }
            catch (Exception) { throw; }
        }

        public Riddle(int length, string sentence)
        {
            try
            {
                List<int> Sentence = sentence.ToCharArray().Select(c => int.Parse(c.ToString())).ToList();

                if (Sequence.Count != length)
                    throw new Exception("Длина введенной последовательности отличается от заявленной длины последовательности.");

                Sequence.Clear();
                Length = length;

                for (int i = 0; i < Length; i++)
                    Sequence.Add(Sequence[i]);
            }
            catch (Exception) { throw; }
        }

        public void RegenerateSequence()
        {
            Sequence.Clear();
            RNGCryptoServiceProvider rnd = new RNGCryptoServiceProvider();
            List<int> digits = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < Length; i++)
            {
                byte[] j = new byte[1];
                rnd.GetBytes(j);
                Sequence.Add(digits[j[0] % digits.Count]);
                digits.Remove(digits[j[0] % digits.Count]);
            }

            rnd.Dispose();
        }

        /// <summary>
        /// Метод для получения сгенерированной последовательности. Доступен только в Debug.
        /// </summary>
        [Conditional("DEBUG")]
        public void GetSequence() { Console.WriteLine(string.Join(",", Sequence.ToArray())); }

        public Dictionary<string, int> CheckAnswer(string input)
        {
            Dictionary<string, int> result = new Dictionary<string, int>
            {
                { "Bulls", 0 },
                { "Cows", 0 }
            };

            try
            {
                List<int> answer = input.ToCharArray().Select(c => int.Parse(c.ToString())).ToList();

                if (Length != answer.Count)
                    throw new Exception("Длины загаданной и введенной последовательностей не совпадают.");

                if (new HashSet<int>(answer).Count != Length)
                    throw new Exception("Числа в последовательности не должны повторяться.");

                for (int i = 0; i < Length; i++)
                {
                    if (Sequence[i] == answer[i])
                        result["Bulls"]++;
                    else if (Sequence.Contains(answer[i]))
                        result["Cows"]++;
                }
            }
            catch (Exception) { throw; }

            return result;
        }
    }
}