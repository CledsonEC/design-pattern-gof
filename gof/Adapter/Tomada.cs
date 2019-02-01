using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public abstract class Tomada <T> where T : class
    {
        public abstract String Conecta(T plug);

        public abstract String GetNomeRede();
    }
}
