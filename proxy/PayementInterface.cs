using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.proxy
{
    interface PayementInterface
    {
        void checkAutorisation(AchatModel ac,double prix);
    }
}
