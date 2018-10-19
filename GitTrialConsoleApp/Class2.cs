using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTrialConsoleApp
{
    class Class2
    {
        int a;
        string b;

        public Class2()
        {
            Console.WriteLine("I've been created");

            Console.WriteLine("Almakása");

            Console.WriteLine("Akármi");

            Console.WriteLine("Lakodalom");

            a = 5;
        }


        public void TestMethod()
        {
            Console.WriteLine("Kiir valamit");
        }

        public void TestMethod2()
        {
            Console.WriteLine("SargaBarack");
        }

        public void TestMethod3()
        {
            Console.WriteLine("Testszöveg3");
            Console.WriteLine("Akarmi");
            Console.WriteLine("jajaj");

            Console.WriteLine("asfasf");
        }


        public int SomeNewFunction(int d)
        {
            return d % 2;
        }
    
}
}
