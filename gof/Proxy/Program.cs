using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Image image1 = new ProxyImage("HiRes_10MB_Photo1;");
            Image image2 = new ProxyImage("HiRes_10MB_Photo2;");

            image1.DisplayImage();
            image2.DisplayImage();

            Console.ReadKey();
        }
    }
}
