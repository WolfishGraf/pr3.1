using System;

namespace pr3._1
{
    class Person
    {
        public string firstName;
        public string lastName;
        public int age;
        public Genders gender;

        public Person(string _firstName, string _lastName, int _age, Genders _gender)
        {
            firstName = _firstName; lastName =
            _lastName; age = _age; gender = _gender;
        }

        public enum Genders : int { Male, Female };

        public override string ToString()
        {
            return firstName + " " + lastName + " (" + gender + "), age " + age;
        }

    }

    class Manager : Person
    {
        public int phoneNumber;
        public string officeLocation;

        public Manager(string _firstName, string _lastName, int _age, Genders _gender, int
 _phoneNumber, string _officeLocation) : base(_firstName, _lastName, _age, _gender)
        {
            phoneNumber = _phoneNumber;
            officeLocation = _officeLocation;
        }

        public override string ToString()
        {
            return base.ToString() + ", " + phoneNumber + ", " + officeLocation;
        }

        class Program
        {
            static void Main(string[] args)
            {
                Person p = new Manager("Tony", "Allen", 32, Person.Genders.Male,797728782, "Chekhov");
                Console.WriteLine(p.ToString());
            }
        }
    }
}
