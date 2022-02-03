using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.bridge
{
    class Employee :User
    {
        public string job { get; set; }


        public Employee(string job)
        {
            this.job = job;
        }
        //teste
    }
}
