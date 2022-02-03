using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Adapter
{
    public class Product : ProductAdapter
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public double Prix { get; set; }
        public string Description { get; set; }

        public Product(int id, string nom, double prix, string description)
        {
            Id = id;
            Nom = nom;
            Prix = prix;
            Description = description;
        }

        public Product()
        {
        }
    }
}
