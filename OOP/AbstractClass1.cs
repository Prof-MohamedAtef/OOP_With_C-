using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    //abstract class Inherits from one or Multiple Interfaces
     
    public abstract class AbstractClass1 
    {
        public abstract void Print();

        public abstract void Rename();
    }

    public abstract class Inherite_Abstract : AbstractClass1
    {
        public override abstract void Print();
        //{
        //    Console.WriteLine("Hellow Abstract ... ");
        //}

        public override abstract void Rename();
        //{
        //    Console.WriteLine("Rename Abstract ... ");
        //}
    }

    
}
