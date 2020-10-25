using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelado
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string line;

            // Leo el archivo TestDaiana.txt 
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"C:\Users\54934\Desktop\Daiana\EjercicioFantommer\TestDaiana.txt");
            while ((line = file.ReadLine()) != null)
            {
                //System.Console.WriteLine(line);
                counter++;
            }

            file.Close();
            //System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.  
            System.Console.ReadLine();
        }
    }
}
