using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public abstract class Empregado
    {
        protected String Nome { get; set; }
        protected double salario { get; set; }

        protected Empregado(string nome, double salario)
        {
            Nome = nome;
            this.salario = salario;
        }

        public abstract void Print();
        public abstract void Add(Empregado e);
        public abstract void Remove(Empregado e);
    }
}
