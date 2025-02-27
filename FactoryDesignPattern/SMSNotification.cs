using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    internal class SMSNotification:INotification
    {
        public void sendNotification(string recipient, string message)
        {
            Console.WriteLine($"SMS Sent to {recipient} with message {message}");
        }
    }
}
