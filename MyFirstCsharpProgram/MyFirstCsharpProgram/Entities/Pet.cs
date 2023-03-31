using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCsharpProgram.Entities
{
    internal class Pet
    {
        private string _name; //private field
        public string Name { get => _name; set
            {
                if(value.ToLower() == "pepe")
                {
                    throw new Exception("Your pet can not be called Pepe.");
                }
            } 
        } //property

        public string Id { get; private set; } //only property, no private field

        public Pet()
        {
            Console.WriteLine("In Pet parameterless constructor.");
        }

        public Pet(string name) : this()
        {
            this.Name = name;
            Console.WriteLine("In Pet(name) constructor.");
        }

        public static void Rename(Pet somePet,
            string newName)
        {
            somePet.Name = newName; //calls modifier
            string name = somePet.Name; //calls access method
        }
    }
}
