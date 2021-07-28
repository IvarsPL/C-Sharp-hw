using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private SortedDictionary<string,string> _phoneDictionary;
        public PhoneDirectory()
        {
            _phoneDictionary = new SortedDictionary<string, string>();
        }

        public string GetNumber(string name)
        {
            return _phoneDictionary[name];
          
        }

        public void PutNumber(string name, string number)
        {
            if (name == null || number == null)
            {
                throw new Exception("name and number cannot be null");
            }
            _phoneDictionary.Add(name,number);
        }
    }
}