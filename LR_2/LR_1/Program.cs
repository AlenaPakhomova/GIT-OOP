using Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace LabRab_1
{
    /// <summary>
    /// Класс для выполнения программы
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        /// <param name="args"> Списки </param>
        public static void Main(string[] args)
        {

            var personList = new List<PersonBase>
            { 
                GetPerson(0),
                GetPerson(1),
                GetPerson(0),
                GetPerson(1),
                GetPerson(0),
                GetPerson(1),
                GetPerson(0)


            };

         
            foreach (var personTmp in personList) //программное определение типа
            {
                switch(personTmp)
                {
                    case Child child:

                        break;
                    case Adult adult:
                        
                        break;
                }

                Console.WriteLine($" Current person is: {personTmp.GetInfo()}");
            }

            Console.WriteLine("Please input person Type 0 for Child, 1 for Adult: \n");
            var inputValue = Console.ReadLine();
            int.TryParse(inputValue, out int personType);
            PersonBase person = GetPerson(personType);
            Console.WriteLine($" Current person is: {person.GetInfo()}");

            //partner.Name = "Иван";         
            //Console.WriteLine($"Person name is {((Adult)partner).Name}");
            Console.ReadKey();

           
        }


        public static PersonBase GetPerson(int person)
        {
            switch(person)
            {
                case 0:
                    return new Child("Анастасия", "Кузнецова", 10, Gender.Female);
                default:
                    return new Adult("Иван", "Иванов", 20, Gender.Male);
            }
        }




        /// <summary>
        /// Печать списка.
        /// </summary>
        /// <param name="list">Список людей</param>
        /// <param name="stroka">Наименование списка</param>
        public static void PrintList(PersonList list, string stroka)
        {
            Console.WriteLine(stroka);
            int count = list.CountPersonInList();
            for (int i = 0; i < count; i++)
            {
                PersonBase person = list.FindPersonByIndex(i);
                Console.WriteLine(person.GetInfo());
            }
        }       
        
        
        /// <summary>
        /// Добавление людей через консоль
        /// </summary>
        /// <returns> Новых людей </returns>
        /// <exception cref="ArgumentException"> Неправильный тип 
        /// данных </exception>
        public static PersonBase AddConsolePerson()
        {
           // PersonBase newPerson = new PersonBase();

            List<Action> actions = new List<Action>()
            {
                new Action(() =>
                {
                    Console.Write("Name: ");
                    newPerson.Name = Console.ReadLine();

                }),
                new Action(() =>
                {
                    Console.Write("Surname: ");
                    newPerson.Surname = Console.ReadLine();
                }),
                new Action(() =>
                {
                    Console.Write("Age: ");
                    string ageStr = Console.ReadLine();
                    if(!Int32.TryParse(ageStr, out int age))
                    {
                        throw new ArgumentException("Неправильный тип данных!");
                    }
                    newPerson.Age = age;
                }),
                new Action(() =>
                {
                    Console.Write("Sex (0 - Male, 1 - Female): ");
                    int genderStr = Int32.Parse(Console.ReadLine());
                    CheckingGender(genderStr);
                    newPerson.Gender = (Gender)Enum.Parse(typeof(Gender),
                                       Convert.ToString(genderStr));
                }),

            };
            actions.ForEach(SetAction);
            return newPerson;
        }

        /// <summary>
        /// Вывод делегата 
        /// </summary>
        /// <param name="action"> делегат </param>
        public static void SetAction(Action action)
        {
            while (true)
            {
                try
                {
                    action.Invoke();
                    return;
                }
                catch (Exception s)
                {
                    Console.WriteLine($"\n{s.Message}\n");
                }
            }
        }

        
        /// <summary>
        /// Проверка пола человека
        /// </summary>
        /// <param name="number"> пол </param>
        /// <returns> Возвращает пол </returns>
        /// <exception cref="Exception">Несуществующий пол</exception>
        public static int CheckingGender(int number)
        {
            if (number < 0 || number > 1)
            {
                throw new Exception("Введите 0 или 1, где 0 - Male," +
                    "1 - Female!");
            }
            else
            {
                return number;
            }
        }
        

        

    }
}