using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    // contains only declaration and no implementation
    
    interface IA 
    {
        void AMethod();
    }
    class A : IA,IB,IInterface
    {   
        public void IIMethod()
        {
            Console.WriteLine("Class A IMethod from IInterface ");
        }
        public void AMethod()
        {
            Console.WriteLine("A");
        }
        public void BMethod()
        {
            Console.WriteLine("B");
        }
    }

    interface IB 
    {
        void BMethod();
    }

    class B :IB
    {
        public void BMethod()
        {
            Console.WriteLine("B");
        }
    }
    interface IInterface 
    {
        void IIMethod();
    }
    class Interface :IInterface
    {
        public void IIMethod()
        {
            Console.WriteLine("Class Interface IIMethod from IInterface");
        }
    }
}
