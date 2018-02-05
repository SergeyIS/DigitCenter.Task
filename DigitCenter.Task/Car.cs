using System;

namespace DigitCenter.Task
{
    class Car : EntryObject
    {
        public Car(String title, int year) : base()
        {
            if(String.IsNullOrEmpty(title) || year < 1800 || year > DateTime.Today.Year)
            {
                throw new ArgumentException("Аргумент имеет некорректное значение");
            }

            this.title = title;
            this.year = year;
        }

        public String Title
        {
            get { return title; }
        }

        public int Year
        {
            get { return year; }
        }

        public override string ToString()
        {
            return $"[{creationTime}][Car] {title}, {year}";
        }

        private String title;
        private int year;
    }
}
