using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public abstract class Game
    {
        public abstract void Initialize();
        public abstract void StartPlay();
        public abstract void EndPlay();

        public void Play()
        {
            this.Initialize();
            this.StartPlay();
            this.EndPlay();
        }
    }
}
