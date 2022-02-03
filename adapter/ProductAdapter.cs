using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Adapter
{
  public  class ProductAdapter : ProductInterface
    {
        public string Serialize(Product p)
        {
            return "le produit de id: "+p.Id+" "+" marque "+p.Nom+" prix: "+p.Prix+" description "+p.Description;
        }
    }
}
