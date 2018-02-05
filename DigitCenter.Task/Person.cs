using System;

namespace DigitCenter.Task
{
    class Person : EntryObject
    {
        public Person(String firstName, String lastName, int age) : base()
        {
            if(String.IsNullOrEmpty(firstName) || String.IsNullOrEmpty(lastName) ||
                age < 0 || age > 120)
            {
                throw new ArgumentException("Аргумент имеет некорректное значение");
            }

            this.firstName = firstName;
            this.lastName = lastName;
            this.age = (byte)age;
        }

        public String FirstName
        {
            get { return firstName; }
        }

        public String LastName
        {
            get { return lastName; }
        }

        public int Age
        {
            get { return (int)age; }
        }

        public override string ToString()
        {
            return $"[{creationTime}][Person] {firstName} {lastName}, {age}";
        }

        private String firstName;
        private String lastName;
        private byte age;
    }
}
