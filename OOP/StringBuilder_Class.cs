using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    class StringBuilder_Class
    {
    }

    public class stringbuilder_string
    {
        public void string_Concatenate()
        {
            string str = "C# ";
            str += "Video ";
            str += "Tutorial ";
            str += "for ";
            str += "Beginners ";

            Console.WriteLine(str);
        }

        public void StringBuilder_Append()
        {
            StringBuilder strbuild = new StringBuilder("C# ");
            strbuild.Append("Video ");
            strbuild.Append("Tutorial");
            strbuild.Append("for ");
            strbuild.Append("Beginners ");

            Console.WriteLine(strbuild.ToString());

        }

        public void String_Test()
        {
            String str = string.Empty;
            for (int i = 0; i <= 10000 ; i++)
            {
                str += i.ToString() + " ";
            }
            Console.WriteLine(str);
        }
    }
}
