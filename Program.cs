using Actividad_POO;
using System;

internal class Program
{
    static List<Receta> recetas = new List<Receta>();
    static int cantidad = 0;
    static string tipoReceta = null;
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("____SISTEMA DE RECETAS_____");
            Console.WriteLine("1.Ingresar recetas.");
            Console.WriteLine("2.Buscar recetas por nombre.");
            Console.WriteLine("3.Mostrar recetas.");
            Console.Write("Ingrese una opción: ");
            
            try
            {
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        RegistrarRecetas();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        BuscarReceta();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        MostrarRecetas();
                        Console.ReadKey();
                        break;

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        static void RegistrarRecetas()
        {
            Console.Write("Ingrese el numero de recetas que quiere ingresar: ");
            cantidad = int.Parse(Console.ReadLine());
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write("Ingrese el nombre de la receta: ");
                string nombre = Console.ReadLine().ToUpper();
                Console.Write("Ingese los ingredientes de la receta (separados con coma): ");
                string ingredientes = Console.ReadLine().ToUpper();
                Console.Write("Ingrese el tiepo de preparación en horas: ");
                double tiempo = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el tipo de receta");
                Console.Write("La recete es saludable SI/NO: ");
                string entrada = Console.ReadLine().ToUpper();
                if (entrada == "SI")
                {
                    tipoReceta = "Saludable";
                    recetas.Add(new Receta(tipoReceta, nombre, ingredientes, tiempo));
                }
                else if (entrada == "NO")
                {
                    tipoReceta = "No saludable";
                    recetas.Add(new Receta(tipoReceta, nombre, ingredientes, tiempo));
                }
                else
                {
                    Console.WriteLine("No es una opción válida.");
                }
            }
            Console.Clear();
            Console.WriteLine("Productos registrados correctamente.");
            Console.Write("\n Presione una tecla para continuar:");
        }
        static void BuscarReceta()
        {
            Console.Write("Ingrese el nombre de la receta que quiere buscar: ");
            string nombre = Console.ReadLine().ToUpper();
            Receta encontrar = recetas.Find(p=>p.Nombre == nombre);
            if (encontrar != null)
            {
                Console.WriteLine("Información de la receta: ");
                Console.WriteLine($"El tipo de la receta es {encontrar.Tipo}");
                Console.WriteLine($"El nombre de la receta es {encontrar.Nombre}");
                Console.WriteLine($"Los ingredientes de la receta es {encontrar.Ingredientes}");
                Console.WriteLine($"El tiempo de la receta es {encontrar.Tiempo} horas");
            }
            else
            {
                Console.WriteLine("No hay ninguna receta con ese nombre.");
            }
        }
        static void MostrarRecetas()
        {
            Console.WriteLine("Las recetas registradas son: ");
            foreach (Receta receta in recetas)
            {
                Console.WriteLine($"\nEl tipo de la receta es {receta.Tipo}");
                Console.WriteLine($"El nombre de la receta es {receta.Nombre}");
                Console.WriteLine($"Los ingredientes de la receta es {receta.Ingredientes}");
                Console.WriteLine($"El tiempo de la receta es {receta.Tiempo} horas");
            }
        }
    }
}