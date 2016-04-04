using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            PetFactory factory = new PetFactory();
            IPet Pet = factory.CreatePet("Bow");
            Console.WriteLine(Pet.petSound());

            IPet AnotherPet = factory.CreatePet("Meow");
            Console.WriteLine(AnotherPet.petSound());

            Console.ReadLine();
        }
    }
}
