using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Child : PersonBase
    {

        public Child(string name, string surname, int age, Gender gender)
           : base(name, surname, age, gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Child()
        {

        }

        public Adult? Mother { get; set; }

        public Adult? Father { get; set; }


        public override int AgeMin => 1;

        public override int AgeMax => 17;

        public override int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < AgeMin || value > AgeMax)
                {
                    throw new Exception("Возраст должен быть в диапазоне " +
                        $"от {AgeMin} до {AgeMax} лет!");
                }
                else
                {
                    _age = value;
                }
            }

        }


        public School School { get; set; }


        public override string GetInfo()
        {
            var personInfo = base.GetInfo();
            if (Mother != null)
            {
                personInfo += $"\nМама: {Mother.Name} " +
                    $"{Mother.Surname}";
            }
            if (Father != null)
            {
                personInfo += $"\nПапа: {Father.Name} " +
                    $"{Father.Surname}";
            }
            if (Mother == null)
            {
                personInfo += "\nНет мамы.";
            }
            if (Father == null)
            {
                personInfo += "\nНет папы.";
            }
            if (Mother == null && Father == null)
            {
                personInfo += "\nСирота";
            }
            if (School != School.Бездельник)
            {
                personInfo += $"\nШкола: {School}";
            }
            if (School == School.Бездельник)
            {
                personInfo += $"\nБездельник";
            }
            return personInfo;

        }
     

    }
}
