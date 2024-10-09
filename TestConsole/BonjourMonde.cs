using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    internal class BonjourMonde
    {
        private string nom;

        public BonjourMonde(string nom)
        {
            this.nom = nom;
        }
        public string Salutation()
        {
            string Salutation = $"Salutation nouvel aventurier {nom}";
            return Salutation;
        }
    }
}
