using System;

namespace ManBoyPolymorphismApp.Model
{
    public class Boy:Man
    {
        public override void Play()
        {
            Console.WriteLine("Boy is Playing");
        }
        public void Eat()
        {
            Console.WriteLine("Boy is Eating");
        }
    }
}
