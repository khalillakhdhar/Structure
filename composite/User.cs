using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.composite
{
    class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string photo { get; set; }

        public List<Message> messages{ get; set; }



    }
}
