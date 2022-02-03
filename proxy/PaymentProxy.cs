using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.proxy
{
    class PaymentProxy : PayementInterface
    {
        public void checkAutorisation(AchatModel ac,double prix)
        {
            if(ac.Montant< prix)
            {
                Console.WriteLine("autorisé");
                // appel de la méthode de payement
            }
            else
            {
                Console.WriteLine("non autorisé");
                //pas d'appel
            }
        }
    }
}
