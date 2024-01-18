using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Cat:Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"I am Cat. Name:{Name}-Age:{Age}");
        }
    }
}
