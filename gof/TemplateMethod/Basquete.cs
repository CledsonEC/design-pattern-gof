using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class Basquete : Game
    {
        public override void EndPlay()
        {
            Console.WriteLine("Termina a partida de basquete");
        }

        public override void Initialize()
        {
            Console.WriteLine("5 jogadores");
        }

        public override void StartPlay()
        {
            Console.WriteLine("Inicia a partida de basquete.");
        }
    }
}
