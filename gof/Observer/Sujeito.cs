using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    interface Sujeito
    {
        void RegistrarObservador(Observador o);
        void RemoverObservador(Observador o);
        void NotificarObservadores();
    }
}
