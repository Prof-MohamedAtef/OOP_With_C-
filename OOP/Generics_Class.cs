using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    class Generics_Class<T>
    {
        //public static bool Integers(int Value1, int Value2)
        //{
        //    return Value1 == Value2;
        //}

        //public void Validate_Integers()
        //{
        //    bool Equal = Integers(10, 20);
        //    if (Equal)
        //    {
        //        Console.WriteLine("Equal Values");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Not Equal Values");
        //    }
        //}
        ////--------------------------------------------------
        //public static bool Strings(string Value1, string Value2)
        //{
        //    return Value1 == Value2;    
        //}
        //public void Validate_Strings()
        //{
        //    bool Equal = Strings("A", "A");
        //    if (Equal)
        //    {
        //        Console.WriteLine("Equal Values");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Not Equal Values");
        //    }
        //}
        ////------------------------------------------------------
        //// Here There are some problems due to ( Boxing & unboxing )
        //public static bool Anydatatype_Input(object Value1, object Value2)
        //{
        //    return Value1 == Value2;
        //}
        //public void Validate_Anydatatype_Input()
        //{
        //    bool Equal = Anydatatype_Input("a",10);
        //    if (Equal)
        //    {
        //        Console.WriteLine("Equal Values");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Not Equal Values");
        //    }
        //}
        //------------------------------- To avoid Problems we follow Generics
        public static bool Generic_2_Avoid_Boxing<T>(T Value1, T Value2)
        {
            return Value1.Equals(Value2);
        }
        public void Validate_Generic()
        {
            bool Equal = Generic_2_Avoid_Boxing<double>(5.5, 5.5);
            if (Equal)
            {
                Console.WriteLine("Equal Values");
            }
            else
            {
                Console.WriteLine("Not Equal Values");
            }
        }
        //------------------------------------------------------------------------------------------------------------------
        //To generic a class ( we must cancel Generic in methods ) so all the class will operate on that type of generic
        public static bool Generic_3_Avoid_Boxing(T Value1, T Value2)
        {
            return Value1.Equals(Value2);
        }
        public void Validate_Generic_3()
        {
            bool Equal = Generics_Class<double>.Generic_3_Avoid_Boxing(5.5, 5.4);
            if (Equal)
            {
                Console.WriteLine("Equal Values");
            }
            else
            {
                Console.WriteLine("Not Equal Values");
            }
        }
    }
}
