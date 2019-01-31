using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public abstract class Professor
    {
        protected Implementador imp = new ProfessorImplGraduacao();

        protected Professor(Implementador imp)
        {
            imp = imp;
        }

        public abstract void op();
    }
}
