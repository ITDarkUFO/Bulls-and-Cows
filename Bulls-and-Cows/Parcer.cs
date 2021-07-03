using System;
using System.IO;

namespace Bulls_and_Cows
{
    class Parcer
    {
        static Parcer()
        {
            try
            {
                var path = AppDomain.CurrentDomain.BaseDirectory;
                Console.WriteLine(path);
                // using (FileStream fs = File.Open(path + "settings.json", FileMode.Open, FileAccess.Write))
                // {
                    
                // }
            }
            finally
            {
                
            }
        }
    }
}