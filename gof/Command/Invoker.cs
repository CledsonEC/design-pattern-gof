using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class Invoker
    {
        public List<Command> commands = new List<Command>();
        private int current = 0;

        public void Compute(Command command)
        {
            command.Execute();
            commands.Add(command);
            current++;
        }

        public void Undo(int levels)
        {
            for (int i = 0; i < levels; i++)
            {
                if (current > 0)
                {
                    Command command = commands[--current];
                        commands.Remove(command);
                    command.Undo();
                }

            }
        }
    }
}
