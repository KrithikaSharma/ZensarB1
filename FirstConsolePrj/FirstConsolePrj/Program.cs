using System;


namespace FirstConsolePrj
{
    class Program
    {
        public int Id;
        public string Name;
        DateTime Doj;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Id = 5;
            p.Name = "Zensar";
            p.Doj = Convert.ToDateTime("01-01-2022");
            Program p1 = new Program();
            p1.Id = 10;
            p1.Name = ".Net";
            Console.WriteLine("Id of Object :{0}, Name of the Object:{1}, Doj of the Object:{2}", p.Id, p.Name, p.Doj);//placeholders
            Console.WriteLine("Id of Object P1" + " " + p1.Id + " " + p1.Name);//concatenation
            display();
            p.TestFunc();
            p1.TestFunc();
            MyClass mc = new MyClass();
            mc.Accept();
            MyClass.Show();
            Employee e = new Employee();
            e.GetEmp();
            Console.Read();

        }
        static public void display()
        {

            Console.WriteLine("Hello Static");

        }

        public void TestFunc()
        {
            Console.WriteLine("Hello public from Object P");
        }

    }
    class MyClass
    {
        static string empname;
        static int empid;
        public void Accept()
        {
            Console.WriteLine("Please Enter your Name:");
            empname = Console.ReadLine();
            Console.WriteLine("Enter your Id:");
            empid = Convert.ToInt32(Console.ReadLine());
        }

        public static void Show()
        {
            Console.WriteLine("The Employee Id Is: {0} and the Name is :{1}", empid, empname);
        }

        
    }
}
