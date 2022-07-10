using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Double WingSpanInInches { get; set; }
        public double TopSpeed { get; set; }    
        public bool Migrate { get; set; }
        public double BeakSize { get; set; }
    }
}
