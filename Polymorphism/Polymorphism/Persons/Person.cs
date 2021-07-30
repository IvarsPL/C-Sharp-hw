namespace Persons
{
    class Person
    {
        private string _firstName;
        private string _lastName;
        private string _address;
        private int _id;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Id { get; set; }

        public Person() { }

        public Person(string firstName, string lastName, string address, int id)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
            _id = id;
        }

        public virtual void Display()
        {

        }
    }
}
