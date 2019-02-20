using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            //ObjectStructure
            Loja loja = new Loja();

            //Visitor
            PrecoEquipamentoVisitor visitor = new PrecoEquipamentoVisitor();

            //Element
            loja.addEquipamento(new Geladeira("Geladeira ABC", 1000.0));
            loja.addEquipamento(new Geladeira("Geladeira Duplex XYZ", 2500.0));
            loja.addEquipamento(new TV("TV LED 58 pol. ZZZ", 4000.0));
            loja.addEquipamento(new Fogao("Fog�o 6 bocas branco ABC", 1500.0));

            //Visita todos os elementos
            foreach (Equipamento e in loja.getEquipamentoList())
            {
                e.Accept(visitor);
            }

            Console.ReadKey();
        }
    }
}
