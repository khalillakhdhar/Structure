using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.decorator
{
    class SMSNotification : SendInterface
    {
        public Notification notification { get; set; }
        public void sendNotification(Notification notification)
        {
            throw new NotImplementedException();
        }
    }
}
