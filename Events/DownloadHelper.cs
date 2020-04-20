using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Events
{

    public class DownloadHelper
    {
        // Create Delegate
        //public delegate void FileDownloadedEventHandler(object source, FileEventArgs args);

        // use the C# event handler
        public override EventHandler<FileEventArgs>

        // Create an event based on that delegate
        public event EventHandler<FileEventArgs> FileDownloaded;

        // Prepare the event
        protected  virtual void OnFileDownloaded(File file)
        {
            if (FileDownloaded != null)
            {
                // Triggered
                FileDownloaded(this, new FileEventArgs(){ File = file});
            }
        }

        public void Download(File file)
        {
            Console.WriteLine("Downloading file... ");
            Thread.Sleep(4000);

            // Raise the event
            OnFileDownloaded(file);
        }
    }
}
