using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Config conf1 = Config.GetInstance();

            conf1.paramGlobal = "Param 1";
            Console.WriteLine(conf1.paramGlobal);

            Config conf2 = Config.GetInstance();

            conf2.paramGlobal = "Param 2";
            Console.WriteLine(conf2.paramGlobal);
            Console.WriteLine(conf1.paramGlobal);

            Console.ReadKey();
        }
    }
}
