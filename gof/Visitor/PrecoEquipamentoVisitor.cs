using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class PrecoEquipamentoVisitor : EquipamentoVisitor
    {
        public override void VisitGeladeira(Geladeira geladeira)
        {
            Console.WriteLine("Pre�o da geladeira " + geladeira.GetNome() + " = $ " + geladeira.GetPreco() +
                    " com +4% de impostos, total $ " + geladeira.GetPreco() * 1.04);
        }

        public override void VisitTV(TV tv)
        {
            Console.WriteLine("Pre�o da TV " + tv.GetNome() + " = $ " + tv.GetPreco() +
                    " com +7% de impostos, total $ " + tv.GetPreco() * 1.07);
        }

        public override void VisitFogao(Fogao fogao)
        {
            Console.WriteLine("Preço do Fogão " + fogao.GetNome() + " = $ " + fogao.GetPreco() +
                    " com +5% de impostos, total $ " + fogao.GetPreco() * 1.05);
        }
    }
}
