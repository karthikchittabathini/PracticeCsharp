using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GenericsDemo
{
    public class DataStore<T>
    {
        public T Data { get; set; }
    }
    public class GenericDemo
    {
        public static void CreateIntDataStore()
        {
            DataStore<int> intDataStore = new DataStore<int>();
            intDataStore.Data = 100;
            Console.WriteLine(intDataStore.Data.GetType().ToString());
        }
        public static void CreateStringDataStore()
        {
            DataStore<string> stringDataStore = new DataStore<string>();
            stringDataStore.Data = "Hello World";
            Console.WriteLine(stringDataStore.Data.GetType().ToString());
        }
    }
}