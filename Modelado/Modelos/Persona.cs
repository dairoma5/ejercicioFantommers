using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ejercicioFantommers.Modelos
{

    public class Persona : DbContext 
    {
        public Persona(string dni, string nombre, Boolean estado, decimal altura) : base("Persona") 
        {
            this.DNI = dni;
            this.Nombre = nombre;
            this.Estado = estado;
            this.Altura = altura;
        }
        private string DNI { get; set; }
        private string Nombre { get; set; }
        private bool Estado { get; set; }
        private decimal Altura { get; set; }

        public void mostrarDatos()
        {
            System.Console.WriteLine(this.DNI);
            System.Console.WriteLine(this.Nombre);
            System.Console.WriteLine(this.Estado);
            System.Console.WriteLine(this.Altura);
        }
    }
}
