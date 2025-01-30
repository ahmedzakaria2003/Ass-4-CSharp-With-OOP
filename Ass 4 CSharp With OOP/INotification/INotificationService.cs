using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_4_CSharp_With_OOP.INotification
{
   public interface INotificationService
    {

        void SendNotification(string recipient , string message);
    }
}
