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
                                                     // need a new Property for each field in order to interact with it. Mama bear allows access to see Baby Bear
        }


        //BEHAVIORS 

        //Constructors
        public Cat()    // allows us to create a cat object with no pre-constructed values -- always need a default constructor w/out parameters in order to create a constructor with parameters
        {
            //default constructor because it takes no parameters in the parenthesis...can have stuff here in the curly braces, like this.age....but no parameters in ().
        }

        public Cat(string name, int age, string furColor)   // this is an overloaded constructor - allows us to name something the same -- also, it's a method. A constructor is a type of method that allows us to create an object. In this constructor, the values are defined as parameters
        {
            this.name = name;                           // field name "name" = parameter name "name"
            this.age = age;                             // field name "age" = parameter name "age"
            this.furColor = furColor;
        }

        //Methods

        public void Eat()  // whenever a cat is hungry, we use the Eat() method to feed it, so it's no longer hungry.
        {
            if(isHungry == true)  // checking if they are equal
            {
                isHungry = false;  // I am setting it to false
            }

            Console.WriteLine("Is the cat hungry? " + isHungry);
        }

        public void WorkOut()
        {
            if(isHungry == false)
            {
                isHungry = true;
            }

            Console.WriteLine("The cat worked out. Hungry now? " + isHungry);
        }

    }

}
