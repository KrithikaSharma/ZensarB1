using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsolePrj
{
    class MethodsnParameters
    { 
     //eg. for call by value
     public static void SimpleMethod(int a)
        {
            a = 200;
        }

        //eg. for call by ref 

        public static void SimpleRefMethod(ref int a) //being called - callee
        {
            a = 200;
            Console.WriteLine(a);
        }

        //eg. for out parameter (when we want more return values from a function)
        public static int Calculate(int a, int b, out int sum, out int prod )
        {
            
            sum = a + b;
            prod = a * b;
            return a - b;
        }

        //eg. for params (parameter Array)

        public int AddElements(params int[] arr)
        {
            int sum = 0;
            foreach(int i in arr)
            {
                sum += i;
            }
            return sum;
        }

        //eg 2 for params

        public static void ParamsMethod(params int[] arr)
        {
            Console.WriteLine("There are {0} elements", arr.Length);
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }
        static void Main()
        {
            int x = 100;
            // SimpleMethod(x);
            //  Console.WriteLine(x);
            // SimpleRefMethod(ref x); //calling a function - caller
            // Console.WriteLine(x);
           // int Total, Product = 0;
           //int diff= Calculate(10, 20, out Total, out Product);
           // Console.WriteLine("Sum ={0} and Product={1}, Difference={2}",Total,Product,diff);
            MethodsnParameters mnp = new MethodsnParameters();
            int SumElements = mnp.AddElements();
            Console.WriteLine("Sum of all Elements is:{0}",SumElements);
            int[] num = new int[3];
            num[0] = 10;
            num[1] = 20;
            num[2] = 30;
            ParamsMethod(); //0 Arguments
            ParamsMethod(num); // arraylist
            ParamsMethod(1, 2, 3, 4, 5, 6); //comma seperated values;

            Console.Read();

        }
    }
}
