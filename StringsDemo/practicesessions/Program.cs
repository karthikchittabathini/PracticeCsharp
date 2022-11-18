// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Microsoft.VisualBasic;
using practicesessions;
using System;

public class DemoMain
{
    //string name = "Karthik Chittabathini";

    /*
    // ---------- WORKING WITH STRUCTURES ---------------------
    // Task 1 [date = 08-11-2022]
    struct Book
    {
        public int bookid { get; set; }
        public string title { get; set; }
        public int price { get; set; }
        
        enum bookType 
        {
            Magazine, 
            Novel, 
            ReferenceBook, 
            Miscellaneous
        }


        public void AssignValues(int b, string t, int p)
        {
            this.bookid = b;
            this.title = t;
            this.price = p;
        }

        public void DisplayValues()
        {
            Console.WriteLine(this.bookid);
            Console.WriteLine(this.title);
            Console.WriteLine(this.price);
            Console.WriteLine(bookType.ReferenceBook);
        }

    }
    //------- END OF WORKING WITH STRUCTURES --------------- 
    */
    public static void Main()
    {
        //string name = "chittabathini karthik";
        /*
         
        // program to find given number is prime or not 

        Console.WriteLine("Enter the number of string Names you want to enter ");
        int n = Convert.ToInt32(Console.ReadLine());

        string[] names = new string[n];
        Console.WriteLine("Please enter the names :");
        for(int i = 0; i < n; i++)
        {
            names[i] = Console.ReadLine();
        }

        Console.WriteLine(" - - - - - - - - - - - - - - - -  ");
       
        Console.WriteLine("The names you entered are : ");
        for(int j = 0; j < names.Length; j++)
        {
            Console.WriteLine(names[j]);
        }

        */


        /*

        // -------- Abstraction ----------

        Dog rocky = new Dog();
        rocky.AnimalSound();
        rocky.Food();

        Cat milly = new Cat();
        milly.AnimalSound();
        milly.Food();

        */


        /*

        // --------- Encapsulation ---------- 

        EncapsulationDemo enc = new EncapsulationDemo();

        enc.Name = "karthik";
        Console.WriteLine(enc.Name);

        enc.Organization = "capgemini";
        Console.WriteLine(enc.Organization);

        */



        /*
         
        // ------- Inheritance -----------

        //InheritanceChildDemo child = new InheritanceChildDemo();
        //child.triggers();

        InheritanceChildSubChildDemo subchild = new InheritanceChildSubChildDemo();
        subchild.triggers();

        */

        /*
        // ---- polymorphism ------

        PolymorphismDemo demo = new PolymorphismDemo();
        //int result = demo.add(10, 7);
        Console.WriteLine(demo.add(10, 7));
        Console.WriteLine(demo.add(1,2,7));
        */


        //DemoMain dm = new DemoMain();
        //Console.WriteLine(dm.name);

        /*
        for(int i = 0; i < 10; i++)
        {
            //Console.WriteLine(i);
        }

        int a = 5, b = 6;
        double avg = a + b/2.0;
        Console.WriteLine(avg);
        */

        /*
        // Program to check given Number is Prime or Not 

        Console.WriteLine("Please enter a number to check whether it is a prime number or not :");
        int number =  Convert.ToInt32(Console.ReadLine());

        int count = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count = count + 1;
            }
        }

        if(count == 2)
        {
            Console.WriteLine("Yes, it's a Prime Number");
        }
        else
        {
            Console.WriteLine("No, it's not a Prime Number");
        }

        */





        /*

        // ------------------ CALCULATOR CODE STARTS --------------------------------

        // Task 1 [date = 08-11-2022]
        // Simple calculator demo

        Console.WriteLine("Welcome to Simple Calculator");
        bool iteration = true;
        while (iteration)
        {
            Console.WriteLine("Arthemetic Operations Available");
            Console.WriteLine("Addition - Press 1");
            Console.WriteLine("Subtraction - Press 2");
            Console.WriteLine("Multiplication - Press 3");
            Console.WriteLine("Division - Press 4");

            Console.WriteLine("To exit - press 0");

            Console.WriteLine("please enter the input :");
            int ans = Convert.ToInt32(Console.ReadLine());

            if(ans == 0)
            {
                iteration = false;
            }
            else
            {
                Console.WriteLine("please enter the first number :");
                int fn = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("please enter the second number :");
                int sn = Convert.ToInt32(Console.ReadLine());

                switch (ans) 
                { 
                    case 1:
                        Console.WriteLine("The output is :" + (fn+sn));
                        break;
                    case 2:
                        Console.WriteLine("The output is :" + (fn-sn));
                        break;
                    case 3:
                        Console.WriteLine("The output is :" + (fn*sn));
                        break;
                    case 4:
                        Console.WriteLine("The output is :" + (fn/sn));
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input");
                        break;
                }

            }
        }

        // ---------------------- CALCULATOR CODE ENDS --------------------------------
        // CODE ENDS
        */




        /*
        // ------------------------ AVERAGE MARKS OF FIVE STUDENTS & DISPLAY HIGHEST MARKS OBTAINED ------------------------
        // Task 1 [date = 08-11-2022]
        // CODE STARTS

        double[] AverageMarks = new double[5];
        for(int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Student " + i + " please enter the marks");
            Console.WriteLine("Enter marks obtained in maths");
            int maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks obtained in physics");
            int physics = Convert.ToInt32(Console.ReadLine());

            double avg = (maths + physics) / 2;

            AverageMarks[i - 1] = avg;
        }

        int stdno = 1;
        double highest = AverageMarks[0];
        for(int i = 0; i<=4; i++)
        {

            if (AverageMarks[i] > highest)
            {
                highest = AverageMarks[i];
                stdno = i+1;
            }
        }

        Console.WriteLine("The highest marks are obtained by student "+stdno+ " = "+highest);


        // ------------------------ AVERAGE MARKS OF FIVE STUDENTS & DISPLAY HIGHEST MARKS OBTAINED CODE ENDS ------------------------
        //----------- CODE ENDS -----------------
        */




        /*
        // --------- SUM OF INTEGERS FROM ARRAY -----------------
        // Task 1 [date = 08-11-2022]
        // CODE STARTS

        int[] input = { 10, 20, 30, 40};
        int output  = arraysum.CalculateArraySum(input);
        Console.WriteLine("The sum of array of integers are = " + output);

        // --------- SUM OF INTEGERS FROM ARRAY -----------------
        // CODE ENDS
        */




        /*
        // ---------- SWAPPING THE NUMBERS ---------------------
        // Task 1 [date = 08-11-2022]
        // CODE STARTS

        swapnumbers sn = new swapnumbers();
        sn.swapping(2, 5);

        // ---------- SWAPPING THE NUMBERS -----------------
        // CODE ENDS
        */



        /*
        //---------- Circle circumference and area ------------
        // Task 1 [date = 08-11-2022]
        //CODE STARTS

        circle c = new circle();
        (double circumference, double area) = c.CircumferenceAndArea(2);
        Console.WriteLine("The circumference of the circle was :" + circumference);
        Console.WriteLine("The area of the circle was :" + area);

        //---------- Circle circumference and area ------------
        //CODE ENDS
        */



        /*
        // ----------- W0RKING WITH STRUCTURES(BOOK) --------------------
        // Task 1 [date = 08-11-2022]
        //CODE STARTS

        Book b = new Book();
        b.AssignValues(1, "ThinkBig", 170);
        b.DisplayValues();

        */






    }
}
