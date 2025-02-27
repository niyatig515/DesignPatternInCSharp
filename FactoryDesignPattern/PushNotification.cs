using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    internal class PushNotification:INotification
    {
        public void sendNotification(string recipient, string message)
        {
            Console.WriteLine($"Push Notification Sent to {recipient} with message {message}");
        }
    }
}
