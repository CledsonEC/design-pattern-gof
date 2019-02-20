using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public abstract class EquipamentoVisitor
    {

        public abstract void VisitGeladeira(Geladeira geladeira);
        public abstract void VisitTV(TV tv);
        public abstract void VisitFogao(Fogao fogao);
    }
}
