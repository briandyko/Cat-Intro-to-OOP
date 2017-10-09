using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_OOP
{
    class Cat
    {
        //STATES
        //fields
        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true;    // every time we have a cat, the cat is hungry


        //Properties
        public string Name
        {
            get { return this.name; }                //get returns value to user and put in program class, allows access to name
            set { this.name = value; }               // if we're in program class, that value gets assigned to name. comes from program

        }


        //BEHAVIORS 

        //Constructors
        public Cat()    // allows us to create a cat object with no pre-constructed values
        {
            //default constructor because it takes no parameters in the parenthesis
        }

        public Cat(string name, int age, string furColor)   // this is an overloaded constructor - allows us to name something the same -- also, it's a method. A constructor is a type of method that allows us to create an object. In this constructor, the values are defined as parameters
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }
    }
}
