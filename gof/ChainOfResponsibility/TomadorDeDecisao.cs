using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public abstract class TomadorDeDecisao
    {
        protected TomadorDeDecisao sucessor;

        public void SetSucessor(TomadorDeDecisao sucessor)
        {
            this.sucessor = sucessor;
        }

        public abstract void Aprova(Compra compra);
    }
}
