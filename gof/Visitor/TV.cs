﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class TV : Equipamento
    {

        public TV(String nome, double preco) : base(nome, preco)
        {
        }

        public override void Accept(EquipamentoVisitor visitor)
        {
            visitor.VisitTV(this);
        }

    }
}
