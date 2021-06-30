using System;
using System.IO;

namespace Bulls_and_Cows
{
    static class Parcer
    {
        public Parcer()
        {
            try
            {
                var path = AppDomain.CurrentDomain.BaseDirectory;

                using (FileStream fs = File.Open(path + "settings.json", FileMode.Open, FileAccess.Write))
                {
                    
                }
            }
        }
    }
}