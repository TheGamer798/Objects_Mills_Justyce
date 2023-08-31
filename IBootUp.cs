using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Mills_Justyce
{
    internal interface IBootUp
    {
        public bool IsOn { get; set; }//Adds a boolean property called IsOn with an automatic getter and setter to the interface
        public void PowerOnOff();//declare a method called PowerOnOff in the interface
    }
}
