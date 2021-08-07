using System;

namespace ManBoyPolymorphismApp.Model
{
    public class Man
    {
        public virtual void Play()
        {
            Console.WriteLine("Man is Playing");
        }
        public void Read()
        {
            Console.WriteLine("Man is Reading");
        }
    }
}
