using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();

            Invoker invoker = new Invoker();

            invoker.Compute(new Soma(calculadora, 10));
            invoker.Compute(new Soma(calculadora, 5));
            invoker.Compute(new Soma(calculadora, 10));
            //Desfazer as duas �ltimas opera��es
            invoker.Undo(2);


            Console.ReadKey();
        }
    }
}
