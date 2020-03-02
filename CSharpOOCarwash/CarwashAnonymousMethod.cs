using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOCarwash
{
    public class CarwashAnonymousMethod
    {
        private CarwashHandler _handler;

        public CarwashAnonymousMethod()
        {
            _handler += delegate(Voiture voiture) { Console.WriteLine($"Je prépare la voiture {voiture.Plaque}"); };
            _handler += delegate(Voiture voiture) { Console.WriteLine($"Je lave la voiture {voiture.Plaque}"); };
            _handler += delegate(Voiture voiture) { Console.WriteLine($"Je sèche la voiture {voiture.Plaque}"); };
            _handler += delegate(Voiture voiture) { Console.WriteLine($"Je termine la voiture {voiture.Plaque}"); };
        }

        public void Traiter(Voiture voiture)
        {
            _handler?.Invoke(voiture);
        }
    }
}
