using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public class Contexto
    {
        private String input;
        private int output;

        public Contexto(String input)
        {
            this.input = input;
        }

        public String GetInput()
        {
            return input;
        }

        public void SetInput(String input)
        {
            this.input = input;
        }

        public int GetOutput()
        {
            return output;
        }

        public void SetOutput(int output)
        {
            this.output = output;
        }

    }
}
