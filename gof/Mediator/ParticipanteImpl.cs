using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class ParticipanteImpl : Participante
    {
        public ParticipanteImpl(String nome, Mediator mediator) : base(nome, mediator)
        {

        }
        public override void EnviaMensagem(string destinatario, string mensagem)
        {
            Mediator mediador = this.GetMediador();
            mediador.EnviarMensagem(this.GetNome(), destinatario, mensagem);
        }

        public override void RecebeMensagem(string remetente, string mensagem)
        {
            Console.WriteLine(remetente + " escrever: " + mensagem);
        }
    }
}
