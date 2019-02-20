using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cria objeto vendedor
            Vendedor vendedor = new Vendedor("João", 10000.0F);

            Console.WriteLine(vendedor.GetNome() + " - Total de vendas: " + vendedor.GetTotalVendas());

            //Salva estado interno
            VendasMemory memory = new VendasMemory();
            memory.SetMemento(vendedor.CreateMemento());

            //Altera os valores dos atributos do objeto vendedor
            vendedor.SetNome("Pedro");
            vendedor.SetTotalVendas(50000.0F);

            Console.WriteLine(vendedor.GetNome() + " - Total de vendas: " + vendedor.GetTotalVendas() );

            //Restaura memento
            vendedor.restoreMemento(memory.GetMemento());

            Console.WriteLine(vendedor.GetNome() + " - Total de vendas: " + vendedor.GetTotalVendas() + "\n");

            Console.ReadKey();
        }
    }
}
