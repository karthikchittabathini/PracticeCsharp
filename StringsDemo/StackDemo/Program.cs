// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

public class StackException : Exception {
    public StackException()
    {

    }

    public StackException(string message) : base(message)
    {

    }
}


class StackDemo {
    public static void Main(string[] args) {
        Stack s = new Stack(10);
        //pushtostack(10);
        //pushtostack(20);
        //pushtostack(30);
        //pushtostack(40);
        //pushtostack(50);
        //pushtostack(60);
        //pushtostack(70);
        //pushtostack(80);
        //pushtostack(90);
        //pushtostack(100);
        //pushtostack(100);

        popfromstack();
       
        Console.WriteLine("The total items/count of the stack is");
        Console.WriteLine(s.Count);
        Console.WriteLine("\n");
        

        void pushtostack(object x)
        {
            try
            {
                if(s.Count != 10)
                {
                    s.Push(x);
                }
                else
                {
                    //throw exception
                    throw(new StackException("Stack is full, You cannot insert into it ..."));
                }

            }
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("\n");
            }
        }


        void popfromstack()
        {
            try
            {
                object k = s.Pop();

                if(k == null)
                {
                    // throw exception 
                    throw (new StackException("stack is empty, Nothing is there to pop out..."));
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("\n");
            }
        }



        //display the items in the stack
        Console.WriteLine("The items in the stack are : ");
        foreach(var x in s)
        {
            Console.WriteLine(x);
        }
       
    }
    
}

