using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public class Unidade : Expressao
    {
        public override String Um() { return "I"; }
        public override String Quatro() { return "IV"; }
        public override String Cinco() { return "V"; }
        public override String Nove() { return "IX"; }
        public override int Multiplicador() { return 1; }
    }
}
