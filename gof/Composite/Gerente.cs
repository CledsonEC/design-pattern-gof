using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Gerente : Empregado
    {
        private List<Empregado> listaSubordinados = new List<Empregado>();

        public Gerente(string nome, double salario) : base(nome, salario)
        {
        }

        public override void Add(Empregado e)
        {
            listaSubordinados.Add(e);
        }

        public override void Print()
        {
            Console.WriteLine(base.Nome + ", $" + base.salario);
            foreach (Empregado a in listaSubordinados)
            {
                a.Print();
            }
        }

        public override void Remove(Empregado e)
        {
            listaSubordinados.Remove(e);
        }
    }
}
