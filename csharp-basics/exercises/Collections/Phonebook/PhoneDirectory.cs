using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private SortedDictionary<string, string> _data;

        public PhoneDirectory()
        {
            _data = new SortedDictionary<string, string>();
        }

        public string GetNumber(string name) 
        {
            if (GetName(name)) 
            {
                return _data[name];
            } 
            else 
            {
                return null;
            }
        }

        public void PutNumber(string name, string number) 
        {
            if (name == null || number == null) 
            {
                throw new Exception("name and number cannot be null");
            }

            if (GetName(name)) 
            {
                _data[name] = number;
            }
            else 
            {
                _data.Add(name, number);
            }
        }

        public bool GetName(string name)
        {
            if (_data.ContainsKey(name))
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