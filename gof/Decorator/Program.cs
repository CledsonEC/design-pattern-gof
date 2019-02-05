using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Arvore a = new ArvoreNatal();

            a = new Estrela(a);
            a = new Bola(a);
            a = new Bola(a);
            a = new Bola(a);
            a = new Bola(a);
            a = new Bola(a);
            a = new PiscaPisca(a);

            a.ShowEnfeites();
            Console.ReadKey();
        }
    }
}
