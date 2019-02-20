using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class Futebol : Game
    {
        public override void EndPlay()
        {
            Console.WriteLine("Termina a partida de futebol.");
        }

        public override void Initialize()
        {
            Console.WriteLine("11 jogadores");
        }

        public override void StartPlay()
        {
            Console.WriteLine("Inicia a partida de futebol");
        }
    }
}
