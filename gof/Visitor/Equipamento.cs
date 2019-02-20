using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public abstract class Equipamento
    {
        private String nome;
        private double preco;

        public Equipamento(String nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
        }

        public String GetNome()
        {
            return nome;
        }

        public void SetNome(String nome)
        {
            this.nome = nome;
        }

        public double GetPreco()
        {
            return preco;
        }

        public void SetPreco(double preco)
        {
            this.preco = preco;
        }

        public abstract void Accept(EquipamentoVisitor visitor);

    }
}
