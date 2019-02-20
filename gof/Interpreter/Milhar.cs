using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public class Milhar : Expressao
    {
        public override String Um() { return "M"; }
        public override String Quatro() { return " "; }
        public override String Cinco() { return " "; }
        public override String Nove() { return " "; }
        public override int Multiplicador() { return 1000; }
    }
}
