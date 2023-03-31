using MyFirstCsharpProgram.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCsharpProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog somePet = new Dog(""); //called Pet(name) constructor
            somePet.Name = "Perrito";
            Pet.Rename(somePet, "Pablito");

            IEnumerable<Pet> pets = new List<Pet>();
            pets.Append(somePet);
            foreach (Pet pet in pets)
            {
                Console.WriteLine(pet.Name);
            }
            Console.ReadLine();
        }

        private static void WillItChange(ref int num)
        {
            num = 5;
        }

    }
}
