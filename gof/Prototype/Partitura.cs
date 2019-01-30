using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Partitura
    {
        private static Dictionary<String, NotaMusical> notaMap = new Dictionary<string, NotaMusical>();

        public static void CarregarNotas()
        {
            Do notaDo = new Do();
            notaMap.Add("Do", notaDo);

            Re notaRe = new Re();
            notaMap.Add("Re", notaRe);

            Mi notaMi = new Mi();
            notaMap.Add("Mi", notaMi);

            Fa notaFa = new Fa();
            notaMap.Add("Fa", notaFa);

            Sol notaSol = new Sol();
            notaMap.Add("Sol", notaSol);

            La notaLa = new La();
            notaMap.Add("La", notaLa);

            Si notaSi = new Si();
            notaMap.Add("Si", notaSi);
        }

        public static NotaMusical GetNota(String nome)
        {
            NotaMusical nota = notaMap[nome];

            return (NotaMusical)nota.Clone();
        }
    }

   
}
