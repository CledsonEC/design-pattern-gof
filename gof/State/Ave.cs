using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public abstract class Ave
    {
        public abstract void SetComportamentoVoar(Comportamento c);
        public abstract void voar();
        public abstract void SetComportamentoGrasnar(Comportamento c);
        public abstract void Grasnar();
    }
}
