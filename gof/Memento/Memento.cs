using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class Memento
    {
        private String nome = "";
        private float totalVendas = 0.0F;

        public Memento(String nome, float totalVendas)
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

    }
}
