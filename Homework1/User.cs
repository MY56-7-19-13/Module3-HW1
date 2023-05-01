using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public class User : IComparable<User>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(User? other)
        {
            return Age.CompareTo(other.Age);
        }

        public override string ToString()
        {
            return $"Name: {Name} | Age: {Age}";
        }
    }
}
