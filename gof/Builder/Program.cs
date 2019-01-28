using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Cozinha cozinha = new Cozinha();

            //Builders
            SanduicheBuilder b1 = new HamburgerBuilder();
            SanduicheBuilder b2 = new FishBuilder();

            cozinha.FazSanduiche(b1);
            b1.GetSanduiche();
            Console.ReadKey();
        }
    }
}
