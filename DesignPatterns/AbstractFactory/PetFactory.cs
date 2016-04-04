using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class PetFactory
    {
        public IPet CreatePet(string PetType)
        {
            IPet pet = null;

            if ("Bow".Equals(PetType))
                pet = new Dog();
            else if ("Meow".Equals(PetType))
                pet = new Cat();

            return pet;
        }

    }
}
