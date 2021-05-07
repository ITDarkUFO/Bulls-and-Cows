using System;
namespace Program
{
    class EntryPoint : GameManager
    {
        private static void Main(string[] args)
        {
            Core Riddle = new Core();
            Riddle.Generate();
        }

    }
}
