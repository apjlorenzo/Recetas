using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_POO
{
    internal class Receta
    {
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public string Ingredientes { get; set;}
        public double Tiempo { get; set; }
        public Receta(string tipo, string nombre, string ingredientes, double tiempo)
        {
            Tipo = tipo;
            Nombre = nombre;
            Ingredientes = ingredientes;
            Tiempo = tiempo;
        }
    }
}
