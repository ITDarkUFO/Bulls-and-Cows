using System;
namespace Program
{
    class EntryPoint
    {
        private static void Main()
        {
            Riddle myRiddle = new Riddle();
            myRiddle.GetSequence();

            while (true)
            {
                try
                {
                    Console.Write("> ");
                    var result = myRiddle.CheckAnswer(Console.ReadLine());

                    Console.WriteLine("Быков: {0}, коров: {1}", result["Bulls"], result["Cows"]);

                    if (result["Bulls"] == 4)
                        break;
                }
                catch (Exception e) { Console.WriteLine($"Ошибка: {e.Message}"); }
                Console.WriteLine();
            }
        }
    }
}
