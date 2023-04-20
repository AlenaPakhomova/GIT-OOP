using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс для ребёнка
    /// </summary>
    public class Child : PersonBase
    {
        /// <summary>
        /// Базовый конструктор
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        public Child(string name, string surname, int age, Gender gender)
           : base(name, surname, age, gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Child()
        {

        }

        /// <summary>
        /// Мама
        /// </summary>
        public Adult? Mother { get; set; }

        /// <summary>
        /// Папа
        /// </summary>
        public Adult? Father { get; set; }

        /// <summary>
        /// Переопределение минимального возраста
        /// </summary>
        public override int AgeMin => 1;

        /// <summary>
        /// Переопределние максимального возраста
        /// </summary>
        public override int AgeMax => 17;

        //TODO: duplication
        /// <summary>
        /// Переопределние возраста  человека
        /// </summary>
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

        /// <summary>
        /// Школа
        /// </summary>
        public School School { get; set; }

        /// <summary>
        /// Переопределение метода о выводе информации человеке
        /// </summary>
        /// <returns>информация о ребёнке</returns>
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
