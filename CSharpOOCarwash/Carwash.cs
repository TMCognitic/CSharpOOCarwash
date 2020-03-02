using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOCarwash
{
    public class Carwash
    {
        private CarwashHandler _handler;

        public Carwash()
        {
            _handler += Preparer;
            _handler += Laver;
            _handler += Secher;
            _handler += Finaliser;
        }

        private void Preparer(Voiture voiture)
        {
            Console.WriteLine($"Je prépare la voiture {voiture.Plaque}");
        }

        private void Laver(Voiture voiture)
        {
            Console.WriteLine($"Je lave la voiture {voiture.Plaque}");
        }

        private void Secher(Voiture voiture)
        {
            Console.WriteLine($"Je sèche la voiture {voiture.Plaque}");
        }

        private void Finaliser(Voiture voiture)
        {
            Console.WriteLine($"Je termine la voiture {voiture.Plaque}");
        }

        public void Traiter(Voiture voiture)
        {
            _handler?.Invoke(voiture);
        }
    }
}
