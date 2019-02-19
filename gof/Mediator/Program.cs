using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cria-se o objeto mediador
            ChatMediator salaChat = new ChatMediator();

            //Criam-se os objetos participantes
            Participante joao = new ParticipanteImpl("João", salaChat);
            Participante maria = new ParticipanteImpl("Maria", salaChat);
            Participante carlos = new ParticipanteImpl("Carlos", salaChat);
            Participante renato = new ParticipanteImpl("Renato", salaChat);

            //Registra todos os participantes na sala de chat
            salaChat.RegistraParticipante(joao);
            salaChat.RegistraParticipante(maria);
            salaChat.RegistraParticipante(carlos);
            salaChat.RegistraParticipante(renato);

            //Inicia a conversa entre os participantes
            joao.EnviaMensagem("Maria", "Olá Maria, tudo bem ?");

            maria.EnviaMensagem("João", "Oi tudo! E com voc� ?");

            carlos.EnviaMensagem("Renato", "Renato, vocé é um @!xxx.");

            joao.EnviaMensagem("Maria", "Você está no trabalho agora ?");

            Console.ReadKey();
        }
    }
}
