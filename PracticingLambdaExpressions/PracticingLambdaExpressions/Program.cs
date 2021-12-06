using System;
using System.Linq;
using System.Collections.Generic;

namespace PracticingLambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listPersonsInCity = new List<Person>();
            AddRecords(listPersonsInCity);

            Retreiving_TopTwoRecords_ForAge_LessThanSixty(listPersonsInCity);
            Retreiving_AllData_Between_13And18(listPersonsInCity);
            Retreiving_AverageAge(listPersonsInCity);
            Checking_NameInList(listPersonsInCity);
            SkipRecords_ForAge_LessThanSixty(listPersonsInCity);
        }



        //UC1
        private static void AddRecords(List<Person> listPersonsInCity)
        {
            listPersonsInCity.Add(new Person("1", "John", "118 main street Delhi", 15));
            listPersonsInCity.Add(new Person("2", "Sam ", "121 new Road jaipur", 18));
            listPersonsInCity.Add(new Person("3", "Elan", "147 mg riad indore  ", 67));
            listPersonsInCity.Add(new Person("4", "Smith", "87 main street bhopal ", 36));

        }

        //UC2
        private static void Retreiving_TopTwoRecords_ForAge_LessThanSixty(List<Person> listPersonInCity)
        {
            Console.WriteLine("UC2_Retreiving_TopTwoRecords_ForAge_LessThanSixty");
            foreach (Person person in listPersonInCity.FindAll(e => (e.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name " + person.Name + "\t\tAge : " + person.Age);
            }
        }
        //UC3
        private static void Retreiving_AllData_Between_13And18(List<Person> listPersonInCity)
        {
            Console.WriteLine("UC3_Retreiving_AllData_Between_13And18");
            foreach (Person person in listPersonInCity.FindAll(e => (e.Age > 13 && e.Age < 18)).ToList())
            {
                Console.WriteLine("Name " + person.Name + "\t\tAge : " + person.Age);
            }
        }
        //UC4
        private static void Retreiving_AverageAge(List<Person> listPersonInCity)
        {
            Console.WriteLine("UC4_Retreiving_AverageAge");
            double AverageAge = listPersonInCity.Average(e => e.Age);
            Console.WriteLine("Average age is: " + AverageAge);
        }
        // UC5
        private static void Checking_NameInList(List<Person> listPersonInCity)
        {
            Console.WriteLine("UC5_Checking_NameInList");
            if (listPersonInCity.Exists(e => e.Name == "John"))
                Console.WriteLine("John is in the list");
            else
                Console.WriteLine("John is not in the list");
        }

        //UC6
        private static void SkipRecords_ForAge_LessThanSixty(List<Person> listPersonInCity)
        {
            Console.WriteLine("UC6_SkipRecords_ForAge_LessThanSixty");
            foreach (Person person in listPersonInCity.SkipWhile(e => (e.Age < 60)))
            {
                Console.WriteLine("Name " + person.Name + "\t\tAge : " + person.Age);
            }
        }



    }
}
