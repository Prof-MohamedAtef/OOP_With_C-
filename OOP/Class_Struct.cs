using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    class Class_Struct
    {

    }

    public struct Lion
    {
        //Fields
        int _id;
        string _name;
        //Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //Constructor
        public Lion(int ID, string Name)
        {
            this._id = ID;
            this._name = Name;
        }
        //method
        public void PrintDetails()
        {
            Console.WriteLine("ID ={0} && Name = {1}",_id,_name);
        }

    }
}
