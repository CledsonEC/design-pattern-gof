using System;
using System.Collections.Generic;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            String romano = "MCMXXVIII";
            Contexto context = new Contexto(romano);

            //Lista de expressoes
            List<Expressao> tree = new List<Expressao>();
            tree.Add(new Milhar());
            tree.Add(new Centena());
            tree.Add(new Dezena());
            tree.Add(new Unidade());

            //Interpreter
            foreach (Expressao exp in tree)
            {
                exp.Interpret(context);
            }

            Console.WriteLine(context.GetOutput());
            Console.ReadKey();
        }
    }
}
