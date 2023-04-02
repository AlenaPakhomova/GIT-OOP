﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Model
{
    /// <summary>
    /// Класс людей.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Имя человека.
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия человека.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Возраст человека.
        /// </summary>
        private int _age;

        /// <summary>
        /// Имя
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = ToUpperFirst(CorrectNameAndSurname(value));
                if (_surname != null)
                {
                    CheckingLanguage(_name, _surname);
                }

            }
        }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = ToUpperFirst(CorrectNameAndSurname(value));
                if(_name != null)
                {
                    CheckingLanguage(_name, _surname);
                }
            }
        }

        /// <summary>
        /// Возраст
        /// </summary>
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = CheckingAge(value);
            }
        }

        /// <summary>
        /// Пол человека
        /// </summary>
        public Gender Gender { get; set; }


        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Person()
        { }

        /// <summary>
        /// Конструктор класса Персон.
        /// </summary>
        /// <param name="name">//TODO: XML имя </param>
        /// <param name="surname"> фамилия </param>
        /// <param name="age"> возраст </param>
        /// <param name="gender"> пол человека </param>
        public Person(string name, string surname, int age, Gender gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }


        /// <summary>
        /// Проверка имени и фамилии.
        /// </summary>
        /// <param name="value"> имя или фамилия </param>
        /// <returns> имя или фамилию </returns>
        public static bool CheckingNameAndSurname(string value)
        {
            var regex = new Regex(@"(^[А-я]+(-| [А-я])?[А-я]*$)" +
                "|(^[A-z]+(-| [A-z])?[A-z]*$)");

            return regex.IsMatch(value);

        }

        /// <summary>
        /// Проверка на пустые строки и на непонятные символы
        /// </summary>
        /// <param name="value"> имя или фамилия </param>
        /// <returns> Возвращает имя или фамилию </returns>
        /// <exception cref="Exception">Проверка на пустую строку
        /// и неправльные символы</exception>
        public static string CorrectNameAndSurname(string value)
        {

            if (value == string.Empty)
            {
                throw new Exception("Пустая строка!");
            }

            if (!CheckingNameAndSurname(value))
            {
                throw new Exception("Имя и фамилия должны содержать " +
                    "только символы латиницы или кириллицы!");
            }
            else
            {
                return value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public void CheckingLanguage(string name, string surname)
        {

            Language nameLanguege = DefineLanguage(name);
            Language surnameLanguege = DefineLanguage(surname);
            if (nameLanguege != surnameLanguege)
            {
                throw new ArgumentException("Язык имени и фамилии" +
                    " должен совпадать.");
            }
        }
        
        /// <summary>
        /// Проверка на язык.
        /// </summary>
        /// <param name="str"></param>
        /// <returns> Languege.</returns>
        private Language DefineLanguage(string word) 
        {
            Regex latin = new Regex(@"[a-zA-Z]");
            Regex cyrillic = new Regex(@"[а-яА-Я]");

            if (latin.IsMatch(word))
            {
                return Language.Latin;
            }
            else if (cyrillic.IsMatch(word))
            {
                return Language.Cyrillic;
            }
            else
            {
                throw new ArgumentException("Язык не распознан.\n" +
                    "Разрешено вводить только символы кирицицы и латиницы.");
            }
        }
        

       

        /// <summary>
        /// Максимальный возраст человека
        /// </summary>
        public static int AgeMax = 130;

        /// <summary>
        /// Минимальный возраст человека
        /// </summary>
        public static int AgeMin = 0;

        /// <summary>
        /// Проверка возраста 
        /// </summary>
        /// <param name="number"> возраст </param>
        /// <returns> возраст </returns>
        /// <exception cref="Exception"> Входит ли число 
        /// в диапазон возрастов</exception>
        public static int CheckingAge(int number)
        {
            if (number < AgeMin || number > AgeMax)
            {
                throw new Exception("Возраст должен быть в диапазоне " +
                    $"от {AgeMin} до {AgeMax} лет!");
            }
            else
            {
                return number;
            }
        }

        /// <summary>
        /// Пребразование в правильные регистры
        /// </summary>
        /// <param name="value"> имя или фамилия </param>
        /// <returns> Возращает имя или фамилию </returns>
        public static string ToUpperFirst(string value)
        {
            var symbols = new[] { " ", "-" };
            foreach (var symbol in symbols)
            {
                if (value.Contains(symbol))
                {
                    string[] words = value.Split(' ', '-');
                    string firstword = words[0];
                    string secondword = words[1];

                    firstword = char.ToUpper(firstword[0]) +
                        firstword.Substring(1).ToLower();
                    secondword = char.ToUpper(secondword[0]) +
                        secondword.Substring(1).ToLower();
                    string fullword = firstword + symbol + secondword;

                    return fullword;
                }
            }
            return char.ToUpper(value[0]) + value.Substring(1).ToLower();
        }

        /// <summary>
        /// Вывод информации о человеке
        /// </summary>
        /// <returns>Строку с информацией о человеке</returns>
        public string GetInfo()
        {
            return $"Name: {Name}, Surname: {Surname}," +
               $" Age: {Age}, Gender: {Gender} ";
        }
    }
}