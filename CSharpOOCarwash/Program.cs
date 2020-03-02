using System;

namespace CSharpOOCarwash
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture voiture = new Voiture("1-ABC-001");

            Carwash carwash = new Carwash();
            carwash.Traiter(voiture);
            Console.WriteLine();

            CarwashAnonymousMethod carwashAnonymousMethod = new CarwashAnonymousMethod();
            carwashAnonymousMethod.Traiter(voiture);
            Console.WriteLine();
        }
    }
}
