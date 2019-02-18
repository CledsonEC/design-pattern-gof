using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    interface Observador
    {
        void Atualizar(Sujeito sujeito);
    }
}
