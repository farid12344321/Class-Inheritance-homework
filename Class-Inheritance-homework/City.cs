using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Inheritance_homework
{
    internal class City
    {
        private string _name;
        private int _population;
        public string Name { 
            get 
            {

                return _name;
            }
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                   if (value.Length > 3 && value.Length < 20)
                   {
                          _name = value;
                   }
                }
            }
        }
        public int Population 
        {
            get
            {
                return _population;
            }
            set
            {
                if (value > 0)
                {
                    _population = value;
                }
            }
        }

       

    }
}
