// See https://aka.ms/new-console-template for more information
using System;
namespace LambadaExpressionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Welcome To Lambda Expression-----");
            Console.WriteLine();

            //list object creation with person 
            List<Person> list = new List<Person>();

            //method call
             AddingPersonDetails(list);
            //SkipLessThan60(list);
             // RetrieveTop2(list);
             //FindAvgAgeForAll(list);
            //Retrieve(list);
            SearchPerson(list);
            Console.ReadLine();
        }

        //UC1 person management
        public static void AddingPersonDetails(List<Person> personList) //creating method
        {
            personList.Add(new Person() { SSN = 1, Age = 16, Name = "Ankita", Address = "Pune" });
            personList.Add(new Person() { SSN = 2, Age = 18, Name = "sachin", Address = "Pune" });
            personList.Add(new Person() { SSN = 3, Age = 25, Name = "priya", Address = "Bangalore" });
            personList.Add(new Person() { SSN = 5, Age = 75, Name = "nilima", Address = "pune" });
            personList.Add(new Person() { SSN = 6, Age = 86, Name = "Tina", Address = "Nashik" });
            personList.Add(new Person() { SSN = 7, Age = 15, Name = "anvi", Address = "Hyderabad" });

        }
        //UC6 skip less than 60
        public static void SkipLessThan60(List<Person> list)
        {
            try
            {
                var result = list.FindAll(x => x.Age < 60);
                foreach (Person person in result)
                {

                    Console.WriteLine("Age\t" + person.Age + "Name\t" + person.Name + "\t" + "Address\t" + person.Address);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //UC2 Retrieve top two age less than 60
        public static void RetrieveTop2(List<Person> list)
        {
            var result = list.FindAll(x => x.Age < 60).OrderBy(x => x.Age).Take(2);
            foreach (Person person in result)
            {
                Console.WriteLine("Age\t" + person.Age + "Name\t" + person.Name + "\t" + "Address\t" + person.Address);

            }
        }
        //UC3 Retrieve age between 13 to 18 
        public static void Retrieve(List<Person> list)
        {
            try
            {
                var result = list.FindAll(x => x.Age > 13 && x.Age < 30);
                foreach (Person person in result)
                {
                    Console.WriteLine("Age\t" + person.Age + "\t" + "Name\t" + person.Name + "\t" + "Address\t" + person.Address);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //UC4 Retrieve average age in the list
        public static void FindAvgAgeForAll(List<Person> list)
        {
            try
            {
                var result = list.Average(x => x.Age);

                Console.WriteLine("Average age among all persons\t" + result);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //UC5 Check for specific name present in list or not
        public static void SearchPerson(List<Person> list)
        {
            try
            {
                var person = list.Where(x => x.Name == "nilima").First();
                if (person != null)
                {
                    Console.WriteLine("person present");

                    Console.WriteLine("Age\t" + person.Age + "Name\t" + person.Name + "\t" + "Address\t" + person.Address);
                }
                else
                {
                    Console.WriteLine("person not exist in a list");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
