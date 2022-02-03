using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.decorator
{
    class Notification 
    {
        public string Text { get; set; }
        public  string DateHeur { get; set; }

        public Notification(string text, string dateHeur)
        {
            Text = text;
            DateHeur = dateHeur;
        }
    }
}
