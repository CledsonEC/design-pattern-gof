using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Fogao : Equipamento
    {

        public Fogao(String nome, double preco) : base(nome, preco)
        {
        }

        public override void Accept(EquipamentoVisitor visitor)
        {
            visitor.VisitFogao(this);
        }

    }
}
