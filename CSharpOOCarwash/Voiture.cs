using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOCarwash
{
    public class Voiture
    {
        public string Plaque { get; private set; }

        public Voiture(string plaque)
        {
            Plaque = plaque;
        }
    }
}
