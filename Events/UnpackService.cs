using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public class UnpackService
    {
        public void OnFileDownloaded(object source, FileEventArgs e)
        {
            Console.WriteLine("Unpacker service: unpacking the file..." + e.File.Title);
        }
    }
}
