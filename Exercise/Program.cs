using Exercise.Enums;
using System;

namespace Exercise
{

 
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome Ya Man in Environment!");
            Console.WriteLine("=============================================================================");

            #region 1.Create an enum called "WeekDays"

            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}
            #endregion

            #region 2.	Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.

            //Console.WriteLine("Enter Count of person do you want to Regester it :");
            //int count = int.Parse(Console.ReadLine());

            //Person[] persons = new Person[count];
            //for (int i = 0; i < count; i++)
            //{
            //    Console.WriteLine($"Enter Name And Age of Person {i+1}:");

            //    persons[i] = new Person { Name = Console.ReadLine(), Age = int.Parse(Console.ReadLine()) };

            //}
            //Console.Clear();
            //Console.WriteLine($"Name\t\tAge");
            //Console.WriteLine("=======================");


            //foreach (Person person in persons)
            //{
            //    Console.WriteLine($"{person.Name}\t\t{person.Age}");
            //}                         
            #endregion

            #region 3.	Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //Console.Write("Please, Enter The Season from  (Spring, Summer, Autumn, Winter): ");
            //bool Result = Enum.TryParse<Season>(Console.ReadLine(), true, out Season season);
            //Console.Clear();

            //if (Result == true)
            //{
            //    Console.WriteLine("Of Course ");

            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Spring: March to May");
            //            break;

            //        case Season.Summer:
            //            Console.WriteLine("Summer: june to august ");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Autumn :September to November ");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Winter: December to February");
            //            break;

            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Season");
            //}



            #endregion

            #region 4.	Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.

            //Don't Know What I should do here

            #endregion

            #region 5.	Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            //Console.WriteLine("Enter Color to tell you if it Primary or not:");
            //bool Res = Enum.TryParse<Colors>(Console.ReadLine(), true, out Colors color);

            //if (Res ==true)
            //    Console.WriteLine("Primary Color");
            //else
            //    Console.WriteLine("Not Primary Color");
            #endregion

            #region 6.	Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            //Console.WriteLine("Enter First Point (x1:");

            //double x1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter First Point y1):");
            //double y1 = double.Parse(Console.ReadLine());

            //Point point01 = new Point(x1, y1);
            //Console.WriteLine("========================):");
            //Console.WriteLine("Enter Second Point (x2:");
            //double x2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Second Point (y2:");
            //double y2 = double.Parse(Console.ReadLine());
            //Point point = new Point();
            //Point point02 = new Point(x2, y2);
            //Console.WriteLine("=================================):");

            //Console.WriteLine($"The Distance Between 2 Point :{point.Distance(point01, point02)}");

            #endregion


            #region 7.	Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            //Console.WriteLine("Enter Count of person do you want to Regester it :");
            //int count = int.Parse(Console.ReadLine());

            //Person[] persons = new Person[count];
            //for (int i = 0; i < count; i++)
            //{
            //    Console.WriteLine($"Enter Name And Age of Person {i + 1}:");

            //    persons[i] = new Person { Name = Console.ReadLine(), Age = int.Parse(Console.ReadLine()) };

            //}
            //// Console.Clear();
            //Console.WriteLine("=======================");
            //Console.WriteLine($"Name\t\tAge");
            //Console.WriteLine("=======================");

            //int max = 0;
            //for (int i = 0; i < count; i++)
            //{
            //    if (persons[i].Age > max)
            //    {
            //        max = persons[i].Age;
            //    }
            //}
            //foreach (Person person in persons)
            //{
            //    if (person.Age == max)
            //    {
            //        Console.WriteLine($"{person.Name}\t\t{person.Age}");
            //    }
            //}

            #endregion
        }
    }
}
