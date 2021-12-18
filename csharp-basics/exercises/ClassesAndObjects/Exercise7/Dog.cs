using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    internal class Dog
    {
        private string _name;
        private Dog _father;
        private Dog _mother;

        public Dog(string name, string sex, Dog mother, Dog father)
        {
            _name = name;
            _father = father;
            _mother = mother;
        }
        
        public Dog(string name, string sex)
        {
            _name = name;
        }

        public string FathersName()
        {
            if (Object.ReferenceEquals(null, _father))
            {
                return "Unknown";
            }
            else
            {
                return $"{_father._name}";
            }
        }

        public bool HasSameMotherAs(Dog other)
        {
            if (_mother._name == other._mother._name)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
