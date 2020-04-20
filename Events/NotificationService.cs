using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public class NotificationService
    {
        public void OnFileDownloaded(object source, FileEventArgs e)
        {
            Console.WriteLine("Notification service: Download is done." + e.File.Title);
        }
    }
}
