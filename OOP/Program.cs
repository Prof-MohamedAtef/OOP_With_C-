using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    
    public class ParentClass
    {
        public virtual void print()
        {
            Console.WriteLine("I'm Parent Class Print Method");
        }

        public ParentClass()
        {
            Console.WriteLine("Parent Class Constructor Called");
        }

        public ParentClass(string Message)
        {
            Console.WriteLine(Message);
        }
    }
    public class ChildClass : ParentClass
    {
        public new void print()
        {
            Console.WriteLine("I'm Child Class Print Method");
        }
        public ChildClass() : base("MOHAMED")
        {
            Console.WriteLine("Child Class Constructor Called");
        }
    }

    public abstract class customer
    {
        public void print()
        {
            Console.WriteLine("Print Method");
        }

    }
    public class Program : customer
    {
        static void Main(string[] args)
        {
            Generics_Class<double> GC = new Generics_Class<double>();
            //GC.Validate_Integers();
            //GC.Validate_Strings();
            //GC.Validate_Anydatatype_Input();
            GC.Validate_Generic_3();
        }
    }

    class Enter_Numbers
    {
        public int N1;
        public int N2;
        public int N3;
        public void Enter()
        {
            Console.WriteLine("Enter First Number");
            N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int N2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Third Number");
            int N3 = int.Parse(Console.ReadLine());
        }
    }
    class calculate : Enter_Numbers
    {
        public int n_Plus;
        public int divisor;
        public int result;
        public void Plus()
        {
            n_Plus = N1 + N2 + N3;
            Console.WriteLine("All numbers :  " + n_Plus.ToString());
            Console.ReadLine();
        }
        public void Enter_Divided()
        {
            Console.WriteLine("Enter Divided Number");
            divisor = int.Parse(Console.ReadLine());
        }
        public void calculat_Average()
        {
            Console.ReadLine();
            result = n_Plus / divisor;
            Console.WriteLine("Average =  "+result.ToString());
        }
    }
 
    public class parent
    {
        public parent()
        {
            Console.WriteLine("Parent Constructor");
        }
    }
    public class child:parent
    {
        public child()
        {
            Console.WriteLine("child constructor");
        }
    }
}
