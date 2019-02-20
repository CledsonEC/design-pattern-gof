using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class Geladeira : Equipamento
    {

        public Geladeira(String nome, double preco) : base(nome, preco)
        {
        }

        public override void Accept(EquipamentoVisitor visitor)
        {
            visitor.VisitGeladeira(this);
        }

    }
}
