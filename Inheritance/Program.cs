using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            Bird penguin = new Bird();
            penguin.BeakSize = "long"; //used
            penguin.CanFly = false;//used
            penguin.Color = "black and white";//used
            penguin.EggColor = "white";//used
            penguin.Migrates = false;//used
            penguin.Name = "penguin";//used
            penguin.NumberOfLegs = 2;//used
            penguin.Size = "medium";//used

            Console.WriteLine($" A {penguin.Name} is a {penguin.Size}-sized bird, with a {penguin.BeakSize} beak." +
                $" They are {penguin.Color}, have {penguin.NumberOfLegs} legs, and lay {penguin.EggColor} eggs. " +
                $"It is {penguin.CanFly} to say that penguins can fly or that they migrate. Penguins are birds that" +
                $" cannot fly and do not have to migrate because they are in the arctic.");

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */


            Reptile turtle = new Reptile();
            turtle.Color = "green";//used
            turtle.IsPoisinous = false;
            turtle.LaysEggs = true;
            turtle.LivesIn = "water";//used
            turtle.Name = "turtle";//used
            turtle.NumberOfLegs = 4;//used
            turtle.Size = "small"; //used
            turtle.TailSize = "small";//used

            Console.WriteLine("                      ");
            Console.WriteLine($"{turtle.Name} - {turtle.Size} reptile.");
            Console.WriteLine("_______________________");
            Console.WriteLine($"Color : {turtle.Color}");
            Console.WriteLine($"Lives in : {turtle.LivesIn}");
            Console.WriteLine($"Number of legs : {turtle.NumberOfLegs}");
            Console.WriteLine($"Tail size : {turtle.TailSize}");
            Console.WriteLine($"Poisinous : {turtle.IsPoisinous}");
            Console.WriteLine($"Can lay eggs : {turtle.LaysEggs}");


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
