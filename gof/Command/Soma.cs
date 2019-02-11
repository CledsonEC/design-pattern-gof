using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class Soma : Command
    {
        private Calculadora calculadora;
        private int numero;

        public Soma(Calculadora calculadora, int numero)
        {
            this.calculadora = calculadora;
            this.numero = numero;
        }

        public override void Execute()
        {
            calculadora.setValor(calculadora.GetValor() + numero);
            Console.WriteLine(calculadora.GetValor());
        }

        public override void Undo()
        {
            calculadora.setValor(calculadora.GetValor() - numero);
            Console.WriteLine(calculadora.GetValor());
        }
    }
}
