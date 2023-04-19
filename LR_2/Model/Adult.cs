using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Model
{
    
    public class Adult : PersonBase
    {
        /// <summary>
        /// Прописываем базовый конструктор.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        public Adult(string name, string surname, int age, Gender gender) 
            : base (name, surname, age, gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;

        }


        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Adult()
        {

        }

        public override int AgeMin => 18;

        public override int AgeMax => 150;

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

        public const uint MinNumberPassport = 000000001;
        public const uint MaxNumberPassport = 999999999;

        /// <summary>
        /// Поле для паспорта.
        /// </summary>
        public uint _passport;
       
        /// <summary>
        /// Данные паспорта.
        /// </summary>
        public uint Passport
        {
            get => _passport;
            set
            {

                if (value < MinNumberPassport || value > MaxNumberPassport)
                {
                    throw new Exception($"Введен некоректный номер " +
                        $"пасспорта! Введите число от" +
                        $" {MinNumberPassport} до {MaxNumberPassport}");
                }
                else 
                {
                    _passport = value;

                }
               
            }
        }

        /// <summary>
        /// Семейное положение.
        /// </summary>
        public MaritalStatus MaritalStatus { get; set; }


        private Adult? _partner;

        public Adult Partner
        {
            get => _partner;
            set
            {
                if(value == null)
                {
                    throw new ArgumentNullException($"{nameof(Partner)}" +
                        "такого имени не существует.");
                }
                else if (MaritalStatus == MaritalStatus.Married &&
                    value.MaritalStatus == MaritalStatus.Married)
                {
                    _partner = value;
                }
                else
                {
                    throw new Exception("Проверьте статус обоих партнеров!");
                }
            }
        }


        /// <summary>
        /// Место работы.
        /// </summary>
        public Job Job { get; set; }




        public override string GetInfo
        {
            get
            {
                var personInfo = base.GetInfo +
                    $"\n Номер паспорта: {Passport}";
                if (MaritalStatus == MaritalStatus.Married)
                {
                    personInfo += $"\nСемейное положение: женат"
                       + $"\nСупруг: {Partner.Name} {Partner.Surname}";
                }
                if (MaritalStatus == MaritalStatus.Divorced)
                {
                    personInfo += $"\nСемейное положение: не женат";
                }
                if (Job != Job.Безработный)
                {
                    personInfo += $"Специальность: {Job}";
                }
                if (Job == Job.Безработный)
                {
                    personInfo += "Не работает"; 
                }
                return personInfo;
            }
        }



    }
}
