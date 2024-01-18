using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal sealed class ProgrammingStudent : Student
    {
        public sealed override void DoHomework()
        {
            Console.WriteLine("I am writing code");
        }
    }
}
