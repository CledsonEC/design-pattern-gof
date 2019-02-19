using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public abstract class Mediator
    {
        public abstract void EnviarMensagem(String remetente, String destinatario, String mensagem);
    }
}
