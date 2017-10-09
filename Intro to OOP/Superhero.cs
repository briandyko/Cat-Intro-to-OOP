using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_OOP
{
    class Superhero
    {
        //field
        private string catchPhrase;
        private int evilEnergy;
        private string ultimateWeapon;
        private string evilLair;


        //Properties

        public string CatchPhrase
        {
            get { return this.catchPhrase; }
            set { this.catchPhrase = value; }
        }

        public int EvilEnergy
        {
            get { return this.evilEnergy; }
            set { this.evilEnergy = value; }
        }

        public string UltimateWeapon
        {
            get { return this.ultimateWeapon; }
            set { this.ultimateWeapon = value; }
        }

        public string EvilLair
        {
            get { return this.evilLair; }
            set { this.evilLair = value; }
        }


        //Constructors
        public Superhero()
        {

        }

        public Superhero(string catchPhrase, int evilEnergy)
        {
            this.catchPhrase = catchPhrase;
            this.evilEnergy = evilEnergy;
        }

        public Superhero(string ultimateWeapon, string evilLair)
        {
            this.ultimateWeapon = ultimateWeapon;
            this.evilLair = EvilLair;
        }

        //Methods

        public void Taunt()
        {
            catchPhrase = "The world will soon be mine!";
            evilEnergy+=1000;
        }

        public void PowerUp()
        {
            ultimateWeapon = "BRAIN ZAP!!!!!!";
            evilEnergy += 30000;
        }

        public void Escape()
        {
            evilLair = "Welcome Evil One!";
        }

    }
}
