using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class Vendedor
    {
        private String nome = "";
        private float totalVendas = 0.0F;

        public Vendedor(String nome, float totalVendas)
        {
            this.nome = nome;
            this.totalVendas = totalVendas;
        }

        public String GetNome()
        {
            return nome;
        }

        public void SetNome(String nome)
        {
            this.nome = nome;
        }

        public float GetTotalVendas()
        {
            return totalVendas;
        }

        public void SetTotalVendas(float totalVendas)
        {
            this.totalVendas = totalVendas;
        }

        public Memento CreateMemento()
        {
            Memento m = new Memento(nome, totalVendas);
            return m;
        }

        public void restoreMemento(Memento m)
        {
            this.nome = m.GetNome();
            this.totalVendas = m.GetTotalVendas();
        }

    }
}
