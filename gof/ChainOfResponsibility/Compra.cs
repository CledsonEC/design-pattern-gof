using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class Compra
    {
        private float valor;

        public Compra(float valor)
        {
            this.valor = valor;
        }

        public float GetValor()
        {
            return valor;
        }
    }
}
