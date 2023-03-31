using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCsharpProgram.Entities
{
    internal class Dog : Pet
    {
        public Dog() : base()
        {
            Console.WriteLine("In Dog parameterless constructor.");
            this.Name = "aaaa"; //pay attention! Name is defined in Pet, not in Dog
        }

        public Dog(string name) : base(name)
        {
            Console.WriteLine("In Dog(name) constructor.");
        }

        ~Dog() //finalizer or destructor, called when object's lifecycle is over
        {

        }
    }
}
