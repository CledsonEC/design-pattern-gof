﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class PlugAmericano : Plug
    {
        public override string ObtemEletrecidade()
        {
            return "Plug Americano conectado a ";
        }
    }
}
