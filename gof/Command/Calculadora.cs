using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class Calculadora
    {
        private int valor = 0;

        public int GetValor()
        {
            return valor;
        }

        public void setValor(int valor)
        {
            this.valor = valor;
        }
    }
}
