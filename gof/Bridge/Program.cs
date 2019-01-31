using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor grad = new ProfessorGraduacao(new ProfessorImplGraduacao());
            grad.op();
            Console.ReadKey();
        }
    }
}
