using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicesessions
{

     // --------- Abstraction defintion  ----------------

     //Abstraction is "To represent the essential feature without representing the background details."

     //Abstraction lets you focus on what the object does instead of how it does it.

     //Abstraction provides you a generalized view of your classes or objects by providing relevant information.

     //Abstraction is the process of hiding the working style of an object, and showing the information of an object in an understandable manner



    // -----------Abstract class information  ----------------
    //abstract class cannot be used to create the object
    //but abstract class can be used to inheritance like child class (Dog) can inherit the abstract class/parent class (AbstractionAnimalDemo)



    // -----------Abstract Method information  ---------------
    //Abstract method can only be used inside a abstract class
    //Abstract method does not have the body it has only the method definition
    //Abstract method can be inherited and we can provide or write the body in the derived class for the method
    //we use the override keyword to override the base class method         



    public abstract class AbstractionAnimalDemo
    {
        //declare some functions/methods related to animals
        public abstract void AnimalSound();

        public void Food()
        {
            Console.WriteLine("I will eat everything");
        }
    }

    public class Dog : AbstractionAnimalDemo //inheritance
    {
        // overriding the method from the base class
        // writing body to the abstract method overrided from the base/parent class 
        public override void AnimalSound()
        {
            Console.WriteLine("Dogs says BOW - BOW");
        }
    }

    public class Cat : AbstractionAnimalDemo 
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Cat says MEOW - MEOW");
        }

        public void Food()
        {
            Console.WriteLine("I will drink milk");
        }
    }
}
