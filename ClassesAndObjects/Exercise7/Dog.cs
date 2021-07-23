using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise7
{
    class Dog
    {
        public string Name;
        public string Sex;
        public string Father = "";
        public string Mother = "";

        public Dog(string name, string sex)
        {
            this.Name = name;
            this.Sex = sex;
        }

        public Dog(string name, string sex, string father, string mother)
        {
            this.Name = name;
            this.Sex = sex;
            this.Father = father;
            this.Mother = mother;
        }

        public string FathersName()
        {
            return this.Father switch
            {
                "" => "Unknown",
                _ => this.Father
            };
        }

        public bool HasSameMotherAs(Dog otherDog)
        {
            if (otherDog.Mother == this.Mother) return true;
            return false;
        }


    }
}
