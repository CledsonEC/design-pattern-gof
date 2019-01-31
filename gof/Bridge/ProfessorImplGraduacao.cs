using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class ProfessorImplGraduacao : Implementador
    {
        public override void opImplt()
        {
            Console.WriteLine("Implementação porf. Graduação");
            Console.WriteLine("Tchau");
        }
    }
}
