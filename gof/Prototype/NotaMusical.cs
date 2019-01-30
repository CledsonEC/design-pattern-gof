using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public abstract class NotaMusical : ICloneable
    {
        public object Clone()
        {
            Object clone = null;
            try
            {
                clone = base.MemberwiseClone();
            }
            catch(Exception e)
            {
                System.Console.WriteLine(e.Message);
            }

            return clone;
        }

        public abstract void desenha();
    }
}
