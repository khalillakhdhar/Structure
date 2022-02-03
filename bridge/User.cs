using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.bridge
{
    class User
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public User(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }

        public User()
        {
        }
    }
}
