using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class ProxyImage : Image
    {
        public String filename { get; set; }
        public RealImage image { get; set; }

        public ProxyImage(String filename)
        {
            this.filename = filename;
        }

        public override void DisplayImage()
        {
            if (image == null) {
                image = new RealImage(filename);
            }

            image.DisplayImage();
        }
    }
}
