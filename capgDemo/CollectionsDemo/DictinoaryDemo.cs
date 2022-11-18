using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public class DictinoaryDemo
    {
        Dictionary<int, string> dict = new Dictionary<int, string>();

        public void DictionaryStuff()
        {
            dict.Add(14218, "karthik");
            dict.Add(14111, "Nysha");

            foreach(var item in dict)
            {
                Console.WriteLine(item.Key + " "+ item.Value);
            }
        }
    }
}
