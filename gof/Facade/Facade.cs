using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class Facade
    {
        private SubsistemaUm sis1;
        private SubsistemaDois sis2;
        private SubsistemaTres sis3;

        public Facade()
        {
            sis1 = new SubsistemaUm();
            sis2 = new SubsistemaDois();
            sis3 = new SubsistemaTres();
        }

        public void MetodoA()
        {
            sis1.MetodoUm();
            sis2.MetodoDois();
            sis3.MetodoTres();
        }

        public void MetodoB()
        {
            sis3.MetodoTres();
            sis2.MetodoDois();
            sis1.MetodoUm();
        }
    }
}
