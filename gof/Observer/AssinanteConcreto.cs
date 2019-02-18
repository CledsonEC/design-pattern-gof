using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class AssinanteConcreto : Observador
    {
        private EditoraConcreta objetoObservado;

        public AssinanteConcreto(EditoraConcreta o)
        {
            objetoObservado = o;
            objetoObservado.RegistrarObservador(this);
        }

        public void Atualizar(Sujeito sujeito)
        {
            if (sujeito == objetoObservado)
            {
                Console.WriteLine("[Aviso] - A editora alterou o seu estado para : " + objetoObservado.getEdicao());
            }
        }
    }
}
