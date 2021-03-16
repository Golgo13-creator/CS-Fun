using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceClasses
{
    public class Cats : Animals //cats inherits from animals
    {
        public Cats()
        {
            Console.WriteLine("This is a cat constructor");
            IsMammal = true;
            DietType = DietType.Carnivore;
        }
        public bool IsEvil { get; set; }
        public int NumberOfWhiskers { get; set; }
        public string Color { get; set; }
        public string HairLength { get; set; }

        public virtual void MakeSound()
        {
            Console.WriteLine("Now");
        }
        public override void Move()
        {
            Console.WriteLine($"The {GetType().Name} moves quickly");
        }
    }
    public class Liger : Cats
    {
        public Liger()
        {
            Console.WriteLine("This is the Liger constructor");
        }
        public override void Move()
        {
            Console.WriteLine($"The {GetType().Name} stalks its prey");
        }
        public override void MakeSound()
        {
            Console.WriteLine("Roar");
        }
    }
    public class Lion : Cats
    { 
        public Lion()
        {
            Console.WriteLine("This is a Lion constructor");
        }
        public override void MakeSound()
        {
            Console.WriteLine("Twinkle Toes");
        }


    }
}
