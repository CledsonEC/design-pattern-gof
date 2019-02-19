using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public abstract class Participante
    {
        private String nome;
        private Mediator mediador;

        public Participante(String nome, Mediator mediador)
        {
            this.nome = nome;
            this.mediador = mediador;
        }

        public String GetNome()
        {
            return nome;
        }

        public void SetNome(String nome)
        {
            this.nome = nome;
        }

        public Mediator GetMediador()
        {
            return mediador;
        }

        public void SetMediador(Mediator mediator)
        {
            this.mediador = mediator;
        }

        public abstract void EnviaMensagem(String destinatario, String mensagem);

        public abstract void RecebeMensagem(String remetente, String mensagem);


    }
}
