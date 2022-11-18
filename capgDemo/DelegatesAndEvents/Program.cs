using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public class Program
    {
        static void Main(string[] args)
        {
            Publisher isOnlive = new Publisher();
            NotificationService notificationService = new NotificationService();

            isOnlive.Islive += notificationService.Onlive;

            isOnlive.IsliveStarted();
            Console.ReadLine();
        }
    }
    public class NotificationService
    {
        public void Onlive(object source, EventArgs e)
        {
            Console.WriteLine("Notification Service : Sending a notification to the subscriber....");
        }

    }
}
