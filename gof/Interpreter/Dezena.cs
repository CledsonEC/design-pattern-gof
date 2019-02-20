using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public class Dezena : Expressao
    {
        public override String Um() { return "X"; }
        public override String Quatro() { return "XL"; }
        public override String Cinco() { return "L"; }
        public override String Nove() { return "XC"; }
        public override int Multiplicador() { return 10; }
    }
}
