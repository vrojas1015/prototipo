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
        }
    }
}
