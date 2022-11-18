using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using CapgDemo_lib;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capgDemo_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //class1_vehicle bike = new class1_vehicle();
            //bike.display_details("red","triumph","tiger");
            //Console.ReadKey();

            /*
            Getterandsetter gs = new Getterandsetter("karthik", "computers", 14217);
            gs.Student_rollno = 14218;
            gs.display();
            string sname = gs.StudentName;
            Console.WriteLine(sname);
            */

            /*
            CoordinatesExample c1 = new CoordinatesExample(3, 2);
            CoordinatesExample c2 = new CoordinatesExample(13, 17);
            CoordinatesExample c3 = c1 + c2;
            Console.WriteLine(c3.ToString());
            */

            //bike bk = new bike();
            //bk.bikeName();

            /*
            bike bike1 = new honda();
            bike1.bikeName();

            bike bike2 = new bajaj();
            bike2.bikeName();


            void displayDetail(bike bk)
            {
                bk.bikeName();
            }
            */

            /*
            IAlexaHomeAssist hall = new HallRoom();
            //hall room information 
            Console.WriteLine("APPLIANCES STATUS IN HALL ROOM");
            hall.fan = true;
            hall.FanInformation(hall.fan);
            hall.light = false;
            hall.LightInformation(hall.light);


            IAlexaHomeAssist bedroom = new Bedroom();
            //bed room information
            Console.WriteLine("APPLIANCES STATUS IN BED ROOM");
            bedroom.fan = true;
            bedroom.light = true;
            bedroom.LightInformation(bedroom.light);
            bedroom.FanInformation(bedroom.fan);
            */

            /*
            Indexers indexer = new Indexers();
            Console.WriteLine(indexer.temperatures[0]);
            Console.WriteLine(indexer[2]);
            */

            /*
            Arrays arr = new Arrays();
            Console.WriteLine(arr.array1[0]);
            Console.WriteLine(arr.array2.GetValue(0,0));
            */

            /*
            AnonmysDemo ad = new AnonmysDemo();
            ad.AnonymousDemo();
            Console.WriteLine(StaticclassAndconstructor.name);
            StaticclassAndconstructor.ItsAStaticMethod();


            //try and catch
            int numerator = 150;
            int denominator = 0;
            try
            {
                int quotient = numerator / denominator;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("It's the end");
            }
            */
            Console.WriteLine("hii, ");
            Debug.WriteLine("it was debugged");
            Trace.WriteLine("in trace");






            Console.ReadLine();
        }
    }
}
