using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public class Centena : Expressao
    {
        public override String Um() { return "C"; }
        public override String Quatro() { return "CD"; }
        public override String Cinco() { return "D"; }
        public override String Nove() { return "CM"; }
        public override int Multiplicador() { return 100; }

    }
}
