using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class ChatMediator : Mediator
    {
        private Dictionary<String, Participante> participantes = new Dictionary<string, Participante>();
        private List<String> palavrasProibidas = new List<string>();

        public ChatMediator()
        {
            palavrasProibidas.Add("xxxxx");
            palavrasProibidas.Add("@!xxx");
            palavrasProibidas.Add("###@!");
        }

        public void RegistraParticipante(Participante p)
        {
            if (!participantes.ContainsKey(p.GetNome()))
            {
                participantes.Add(p.GetNome(), p);
            }
            else
            {
                Console.WriteLine("Usuário Já cadastrado");
            }
        }

        public override void EnviarMensagem(string remetente, string destinatario, string mensagem)
        {
            //Verifica se o remetente e o destinatario est�o na sala de chat.
            if (participantes.ContainsKey(remetente) && participantes.ContainsKey(destinatario))
            {
                //Obt�m o usu�rio remetente
                Participante pRemetente = participantes[remetente];
                //Obt�m o usu�rio destinat�rio
                Participante pDestinatario = participantes[destinatario];

                //Verifica se a mensagem cont�m palavras proibidas.
                foreach (var proibido in palavrasProibidas)
                {
                    if (mensagem.Contains(proibido))
                    {
                        pRemetente.RecebeMensagem("Mediador", "Voc� escreveu uma mensagem contendo palavras impr�prias.");
                        return;
                    }

                }
              

                //Se n�o h� palavras proibidas na mensagem, ent�o ela � enviada ao destinat�rio
                pDestinatario.RecebeMensagem(remetente, mensagem);
            }
        }
    }
}
