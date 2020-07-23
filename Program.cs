using System;

namespace prototipo
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            p1.Age = 42;
            p1.BirthDate = Convert.ToDateTime("2020-01-01");
            p1.Name = "Jack Daniels";
            p1.IdInfo = new IdInfo(666);

            // Realiza una copia superficial de p1 y asígnela a p2.
            Persona p2 = p1.CopiaSuperficial();
            // Haga una copia profunda de p1 y asígnela a p3.
            Persona p3 = p1.CopiaProfunda();

            //Imprimimos Valores de p1, p2 y p3
            Console.WriteLine("Valores de p1, p2, p3:");
            Console.WriteLine("   Valores de p1: ");
            ImprimirValores(p1);
            Console.WriteLine("   Valores de p2:");
            ImprimirValores(p2);
            Console.WriteLine("   Valores de p3:");
            ImprimirValores(p3);
        }

        public static void ImprimirValores(Persona p)
        {
            //Metodo para mostrar la información
            Console.WriteLine("      Nombre: {0:s}, Edad: {1:d}, Fecha de Nacimiento: {2:MM/dd/yy}",
                p.Name, p.Age, p.BirthDate);
            Console.WriteLine("      ID#: {0:d}", p.IdInfo.IdNumber);
        }
    }
}
