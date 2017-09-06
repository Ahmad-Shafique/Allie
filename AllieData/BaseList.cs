using System;
using System.Collections.Generic;
using System.Text;

namespace AllieData
{
    //This class is for manipulating the item list
    //And extra methods needed for all the classes can be added here
    public class BaseList<T>
    {
        public IEnumerable<T> List { get; set; }
    }
}
