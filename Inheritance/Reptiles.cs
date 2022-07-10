using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptiles : Animal
    {
        public int NumberOfLegs { get; set; }
        public bool HaveScales { get; set; }
        public bool Poisonous { get; set; }

        public int NumberOfTeeth { get; set; }  
    }
}
