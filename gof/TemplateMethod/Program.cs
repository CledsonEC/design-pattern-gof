using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Futebol();

            game.Play();
            Console.ReadKey();
        }
    }
}
