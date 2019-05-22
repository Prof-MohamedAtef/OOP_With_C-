using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    class MethodOverloading
    {

        // Type & Number of paramters included in signature
        public void Add(int FN, int SN, int Sum)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }
        // Out Keyword included in signature
        public void Add(int FN, int SN, out int Sum)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
            Sum = FN + SN;
        }
        
        public int Minus(int FN, int SN, int Sum)
        {
            Console.WriteLine("Sum = {0}", FN + SN + Sum);
            // Return Type doesn't included in signature
            return FN + SN + Sum;
        }


        // Params Keyword doesn't included in signature
        public void Add(int FN, int SN, params int[] Sum)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
            
        }
        

    }
}
