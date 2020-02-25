using System;

namespace TestConsole
{
    class Gamer
    {
        private string _Name;
        private DateTime _DayOfBirth;

        public string Name
        {
            get
            {
                //return _Name ?? string.Empty;
                return _Name == null ? string.Empty : _Name;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(value));
                _Name = value;
            }
        }

        public Gamer(string name, DateTime birthday)
        {
            this._Name = name;
            this._DayOfBirth = birthday;
        }

        //public void SetName(string name)
        //{
        //    _Name = name;
        //}
        //public string GetName()
        //{
        //    return _Name;
        //}


        protected int GetNameLength()
        {
            return Name.Length;
        }

        public void SayYourName()
        {
            Console.WriteLine($"My name is {_Name} - {_DayOfBirth:dd.MM.yyyy HH:mm:ss}");
        }
    }

}
