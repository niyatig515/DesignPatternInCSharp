using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class NotificationFactory
    {
        public  INotification createNotification(string type)
        {
            return type.ToLower() switch 
            {
                "email" => new EmailNotification(),
                "sms" => new SMSNotification(),
                "push" => new PushNotification(),
                _=> throw new ArgumentException("Invalid notification type")
            };

        }
    }
}
