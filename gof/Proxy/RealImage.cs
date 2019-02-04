using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class RealImage : Image
    {
        public String filename { get; set; }

        public RealImage(string filename)
        {
            this.filename = filename;
            LoadImageFromDisk();
        }

        private void LoadImageFromDisk()
        {
            Console.WriteLine("Loading " + filename);
        }

        public override void DisplayImage()
        {
            Console.WriteLine("Displaying " + filename); 
        }
    }
}
