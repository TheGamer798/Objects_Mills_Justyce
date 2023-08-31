using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Mills_Justyce
{
    internal class Computer : IBootUp//Creates a Computer class that implements the IBootUp interace
    {
        public bool IsOn { get; set; }//Creates bool automatic properties for IsOn
        public string Brand { get; set; }//Creates string automatic properties for Brand
        public string Type { get; set; }//Creates string automatic properties for Type

        public Computer(bool isOn, string brand, string type)// constructor with parameters brand, type, and isOn
        {
            IsOn = isOn;//Assigns isOn to IsOn
            Brand = brand;//Assigns brand to Brand
            Type = type;//Assigns type to Type
        }   

        public void PowerOnOff()//Defines the PowerOnOff method
        {
            IsOn = !IsOn;//sets IsOn to the opposite of the current value
            if (IsOn==true)//Prints a message depending if the computer is on or off
            {
                Console.WriteLine("The computer is booting up");
            }
            else
            {
                Console.WriteLine("The computer is shutting down");
            }
        }

        public override string ToString()//an override function that returns a string and is called ToString
        {
            return $"This computer is made by {Brand} and is a {Type} computer.";//ToString return, "This computer is made by <Brand> and is a <Type> computer."
        }
    }
}
