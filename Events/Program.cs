using System;

namespace Events
{
    public class Program
    {
        private static object unpackService;

        public static void Main(string[] args)
        {
            var file = new File() { Title = "File 1" };
            var downloadHelper = new DownloadHelper(); // publisher

            var unpackService = new UnpackService(); // receiver
            downloadHelper.FileDownloaded += unpackService.OnFileDownloaded;

            var notificationService = new NotificationService();
            downloadHelper.FileDownloaded += notificationService.OnFileDownloaded;

            downloadHelper.Download(file);

            // create service NotificationService with onFileDownloaded method and add it to our FileDownloaded event handler
        }
    }

    
}
