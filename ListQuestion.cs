using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ListQuestion
{
    class Program
    {

        public string ShowData(params int[] data)
        {
            string output = "";
            for (int i = 0; i < data.Length; i++)
            {
                output += data[i] + ",";
            }
            output += data[data.Length - 1];
            return output;
        }
        public static void Main()
        {
            List<int> ab = new List<int>();
            ab.Add(1);
            ab.Add(2);
            ab.Add(3);
            ab.Add(4);  
            ab.Add(5);
            ab.Add(6);
            ab.Add(7);
            ab.Add(8);
            ab.Add(9);
            ab.Add(10);

            
            Program xy = new Program();

            string ouptut1 = xy.ShowData(ab.ToArray());
            Console.WriteLine(ouptut1);
            Console.ReadLine();
            
            //Simple Method 


            //string commaseparatedValues = "";

            //for(int i = 0; i < ab.Count-1; i++)
            //{
            //    commaseparatedValues += ab[i] + ",";
            //}
            //commaseparatedValues += ab[ab.Count-1];
            //Console.WriteLine(commaseparatedValues);
            //Console.ReadLine();
        }
       

    }
}
