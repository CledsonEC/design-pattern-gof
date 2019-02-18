using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class Pato : Ave
    {
        private Comportamento comportamentoVoar;
        private Comportamento comportamentoGrasnar;
        public  Pato()
        {
            comportamentoVoar = new Voar();
            comportamentoGrasnar = new Grasnar();
        }

        public override void Grasnar()
        {
            comportamentoGrasnar.exec();
        }

        public override void SetComportamentoGrasnar(Comportamento c)
        {
            comportamentoGrasnar = c;
        }

        public override void SetComportamentoVoar(Comportamento c)
        {
            comportamentoVoar = c;
        }

        public override void voar()
        {
            comportamentoVoar.exec();
        }
    }
}
