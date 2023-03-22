using Model;
using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Xml.Linq;

namespace LabRab_1
{
    public class Program
    {
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            PersonList list1 = new PersonList();
            PersonList list2 = new PersonList();

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();

            Console.WriteLine("Шаг 1. Создание двух списков персон, в каждом из которых есть три человека");
            Console.ReadKey();

            Console.WriteLine("\nШаг 2. Вывод содержимого списков на экран");
            Console.ReadKey();

            list1.AddPerson(new Person() { Name = "Иван", Surname = "Петров", Age = 15, Gender = Gender.Male });
            list1.AddPerson(new Person() { Name = "Вася", Surname = "Николенко", Age = 20, Gender = Gender.Male });
            list1.AddPerson(new Person() { Name = "Вероника", Surname = "Иванова", Age = 30, Gender = Gender.Female });

            list2.AddPerson(new Person() { Name = "Кристина", Surname = "Измайлова", Age = 25, Gender = Gender.Female });
            list2.AddPerson(new Person() { Name = "Владимир", Surname = "Касьянов", Age = 18, Gender = Gender.Male });
            list2.AddPerson(new Person() { Name = "Кирилл", Surname = "Абрамов", Age = 28, Gender = Gender.Male });


            Console.WriteLine("\nList № 1");
            int count1 = list1.CountPersonInList();
            for (int i = 0; i < count1; i++)
            {
                Person person = list1.FindPersonByIndex(i);
                Console.WriteLine(person.GetInfo());
            }
            


            Console.WriteLine("\nList № 2");
            int count2 = list2.CountPersonInList();
            for (int i = 0; i < count2; i++)
            {
                Person person = list2.FindPersonByIndex(i);
                Console.WriteLine(person.GetInfo());
            }


            Console.WriteLine("\nШаг 3. Добавление нового человека в первый список");
            Console.ReadKey();
            list1.AddPerson(new Person("Никита", "Семенов", 23, Gender.Male));
            Console.WriteLine("\nList № 1");
            int count3 = list1.CountPersonInList();
            for (int i = 0; i < count3; i++)
            {
                Person person = list1.FindPersonByIndex(i);
                Console.WriteLine(person.GetInfo());
            }

            
            Console.ReadKey();
            Console.WriteLine("\nШаг 4. Копирование второго человека из " +
                "первого списка в конец второго списка");
            Console.ReadKey();
            Console.WriteLine("\nСкопированный человек находится в двух списках");
            list2.AddPerson(list1.FindPersonByIndex(1));
            Console.WriteLine("\nList № 1");
            int count7 = list1.CountPersonInList();
            for (int i = 0; i < count7; i++)
            {
                Person person = list1.FindPersonByIndex(i);
                Console.WriteLine(person.GetInfo());
            }
            Console.WriteLine("\nList № 2");
            int count8 = list2.CountPersonInList();
            for (int i = 0; i < count8; i++)
            {
                Person person = list2.FindPersonByIndex(i);
                Console.WriteLine(person.GetInfo());
            }


            Console.WriteLine("\nШаг 5. Удаление второго человека из первого списка");
            Console.ReadKey();
            list1.RemovePersonByIndex(1);
            Console.WriteLine("\nList № 1");
            int count4 = list1.CountPersonInList();
            for (int i = 0; i < count4; i++)
            {
                Person person = list1.FindPersonByIndex(i);
                Console.WriteLine(person.GetInfo());
            }
            Console.WriteLine("\nList № 2");
            int count5 = list2.CountPersonInList();
            for (int i = 0; i < count5; i++)
            {
                Person person = list2.FindPersonByIndex(i);
                Console.WriteLine(person.GetInfo());
            }
            Console.WriteLine("\nУдаление человека из первого списка не привело " +
                "к уничтожению этого человека во втором списке");
            Console.ReadKey();

            Console.WriteLine("\nШаг 6. Очистка второго списка");
            Console.ReadKey();
            list2.ClearPerson();
            Console.WriteLine("\nList № 2");
            int count6 = list2.CountPersonInList();
            for (int i = 0; i < count6; i++)
            {
                Person person = list2.FindPersonByIndex(i);
                Console.WriteLine(person.GetInfo());
            }

        }

        


    }
}