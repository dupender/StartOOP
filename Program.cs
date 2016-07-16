using System;
using Zoo;

namespace StartOOP
{
    public class Program
    {
        //Main is an entry point
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting Program...");
            Animal my_animal = new Animal ();//Creates an instance of type "Animal"
            Console.WriteLine(my_animal.ToString());
            Console.WriteLine("The Animal is.." + my_animal.sleep());
            Dog my_dog = new Dog(); //Bring a Dog to life
            Console.WriteLine("the Dog is: " + my_dog.sleep());
            Console.WriteLine("Animal dancing?" + my_animal.dance());
            Console.WriteLine("Dog dancing?" + my_dog.dance());
            Cat my_cat = new Cat();
            Console.WriteLine("The cat said..." + my_cat.meow());
            Console.WriteLine("The cat said..." + my_cat.meow(2));
            Console.WriteLine("The cat said..." + my_cat.meow(-5));

            Console.WriteLine("Then the Cat said: " + my_cat.meowThenPurr()); // my_cat.purr() is not available directly

            //my_cat.swim() is inaccessible here because swim method is "protected" & can't be used outside of Cat, Dog & Animal

            Console.WriteLine("Ending Program...");
        }
    }
}

