using ejercicioFantommers.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ejercicioFantommers
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string fila;

            // Leo el archivo TestDaiana.txt 
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"C:\Users\54934\Desktop\Daiana\EjercicioFantommer\TestDaiana.txt");
            CultureInfo culture = new CultureInfo("en-US");
            char[] delimiterChars = { ',' };
            
            while ((fila = file.ReadLine()) != null)
            {
                Boolean estado = false;
                string[] campos = fila.Split(delimiterChars);
                if (campos[3] == " ACTIVO")
                {
                    estado = true;
                }
                //using(Modelos.DataBaseContainer db= new Modelos.DataBaseContainer())
                Persona nueva_persona = new Persona(campos[1], campos[0],estado,decimal.Parse(campos[2],culture));
                nueva_persona.mostrarDatos();            
                counter++;
            }

            file.Close();
            //System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.  
            System.Console.ReadLine();
        }
    }
}
