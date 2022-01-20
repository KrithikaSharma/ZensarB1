using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsolePrj
{
    class ConvertEg
    {
        //implicit and explicit conversions
        static void Main()
        {
            int i = 100;
            float f = i; //implicit conversion
            Console.WriteLine(f);
            f = 125456845778.65f;
            //i = (int)f;  //explicit conversion;
            // Console.WriteLine(i);
           // i = Convert.ToInt32(f);//another way to convert explicitly
          //  i = int.Parse("12548.65");

           // Console.WriteLine(i);

            string str1 = "345678";
            //TryParse() takes a string as input and return boolean true and outputs the converted no.
            //if success else returns only false. Does not throw any exception like parse or convert
            int res = 0;
            bool success = int.TryParse(str1, out res);
            if(success)
            {
                Console.WriteLine(res);
            }
            else
                Console.WriteLine("Invalid input.. could not convert");
            Console.Read();

        }
    }
}
