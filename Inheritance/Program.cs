using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common



            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird bird1 = new Bird()
            {
                TopAge = 80,
                Class = "Aves",
                Movement = "fly",
                Color = "multicolored",
                WingSpanInInches = 51,
                TopSpeed = 35,
                Migrate = false,
                BeakSize = 20

            };

            Console.WriteLine($"Today we are going to learn abouts parrots. Parrots can live until the age of {bird1.TopAge}. They mostly" +
                $" get around by {bird1.Movement}ing but it is {bird1.Migrate} that they" +
                $" migrate. most parrots are {bird1.Color} and have a average wingspan of {bird1.WingSpanInInches} inches. another couple fun facts is that" +
                $" parrots have an average beak size of {bird1.BeakSize} inches and can reach a top speed of {bird1.TopSpeed} MPH. ");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Reptiles reptiles1 = new Reptiles()
            {
                TopAge = 80,
                Class = "Reptile",
                Movement = "walk and swim",
                Color = "green",
                NumberOfLegs = 4,
                HaveScales = false,
                Poisonous = false,
                NumberOfTeeth = 0,
            };

            Console.WriteLine($"\n\n\nMy buddy has a pet turtle, turtles in general are {reptiles1.Class} not Amphibians." +
                $" his turtle is 10 years old but could live until he is {reptiles1.TopAge}. He can {reptiles1.Movement} and has {reptiles1.NumberOfLegs} legs." +
                $" He is the color {reptiles1.Color} and it is {reptiles1.HaveScales} that turtles have scales. alot of reptiles are poisonous but it is " +
                $"also {reptiles1.Poisonous} that turltes are. one thing i didnt know about turtles is they have {reptiles1.NumberOfTeeth} teeth.");


        }
    }
}
