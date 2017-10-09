using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_OOP
{
    class Dog
    {
        //fields
        private string furLength;
        private float height;
        private string runningSpeed;
        private int weight;

        //Properties
        public string FurLength
        {
            get { return this.furLength; }
            set { this.furLength = value; }
        }

        public float Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public string RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
        }
        
        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        //Constructors
        public Dog()
        {

        }

        //overloaded constructor
        public Dog(string furLength, float height)
        {
            this.furLength = furLength;
            this.height = height;
        }
    }
}
