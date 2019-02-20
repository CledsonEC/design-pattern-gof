using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public abstract class Expressao
    {
        public void Interpret(Contexto context)
        {
            if (context.GetInput().Length == 0)
                return;

            if (context.GetInput().StartsWith(Nove()))
            {
                context.SetOutput(context.GetOutput() + (9 * Multiplicador()));
                context.SetInput(context.GetInput().Substring(2));
            }
            else if (context.GetInput().StartsWith(Quatro()))
            {
                context.SetOutput(context.GetOutput() + (4 * Multiplicador()));
                context.SetInput(context.GetInput().Substring(2));
            }
            else if (context.GetInput().StartsWith(Cinco()))
            {
                context.SetOutput(context.GetOutput() + (5 * Multiplicador()));
                context.SetInput(context.GetInput().Substring(1));
            }

            while (context.GetInput().StartsWith(Um()))
            {
                context.SetOutput(context.GetOutput() + (1 * Multiplicador()));
                context.SetInput(context.GetInput().Substring(1));
            }
        }

        public abstract String Um();
        public abstract String Quatro();
        public abstract String Cinco();
        public abstract String Nove();
        public abstract int Multiplicador();
    }
}
