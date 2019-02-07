using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Programador : Empregado
    {
        public Programador(string nome, double salario) : base(nome, salario)
        {
        }

        public override void Add(Empregado e)
        {
            Console.WriteLine("Não é possível adicionar empregado subordinado do programador");
        }

        public override void Print()
        {
            Console.WriteLine(base.Nome + ", $" + base.salario);
        }

        public override void Remove(Empregado e)
        {
            Console.WriteLine("Não é possível remover empregado subordinado do programador");
        }
    }
}
