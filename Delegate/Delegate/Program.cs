using System;
using System.Collections.Generic;

namespace Delegate
{
    public delegate bool Check(int number);
    public delegate void Print(string text);
    public delegate void Test();

    class Program
    {
        static void Main(string[] args)
        {
            #region Delegate

            //Console.WriteLine(GetSum(1, 2, 3, 4, 5, 6));
            //Console.WriteLine(GetSum2(1, 2, 3, 4, 5, 6));
            //Console.WriteLine(GetSum3(1, 2, 3, 4, 5, 6));

            //Console.WriteLine(GetSum(IsEven, 1, 2, 3, 4, 5, 6));
            //Console.WriteLine(GetSum(IsOdd, 1, 2, 3, 4, 5, 6));
            //Console.WriteLine(GetSum(MoreThanFive, 1, 2, 3, 4, 5, 6));
            //Console.WriteLine(GetSum(number => number > 5, 1, 2, 3, 4, 5, 6));
            //Console.WriteLine(GetSum(number => number % 2 == 0, 1, 2, 3, 4, 5, 6));
            //Console.WriteLine(GetSum(Test, 1, 2, 3, 4, 5, 6));

            //Print print2 = new Print(PrintAsUpper);
            //Print print = PrintAsUpper;
            //print("Hello");
            //print.Invoke("Hello");
            //print += PrintAsLower;
            //print += PrintFirstChar;
            //print("Bye");
            //print -= PrintAsLower;
            //print("P320");

            //print += (str) =>
            //{
            //    Console.WriteLine(str);
            //};
            //print -= (str) =>
            //{
            //    Console.WriteLine(str);
            //};
            //print("Hello");
            //Console.WriteLine(print);

            //Test test = () =>
            //{
            //    Console.WriteLine("Hello");
            //    Console.WriteLine("Bye");
            //};

            //test.Invoke();

            //Action action = () =>
            //{
            //    Console.WriteLine("Hello");
            //    Console.WriteLine("Bye");
            //};
            //action();

            //Check check = IsEven;
            //Predicate<int> predicate = IsEven;
            //Predicate<int> predicate2 = IsOdd;

            //Func<int, bool> func = IsEven;

            #endregion

            #region Practise

            Group g1 = new Group("P320");
            g1.AddToGroup(new Student("Orkhan Elyasov"));
            g1.AddToGroup(new Student("Parviz Asadov"));
            g1.AddToGroup(new Student("Orkhan Abdullayev"));
            //g1.ShowStudents();

            //var foundStudent = g1.FindById(3);
            //if (foundStudent == null)
            //{
            //    Console.WriteLine("Bele id-de student yoxdur");
            //}
            //else
            //{
            //    Console.WriteLine($"Mr. {foundStudent.Fullname}");
            //}

            //var foundStudent = g1.FindBy(x => x.Id == 1);
            //Console.WriteLine(foundStudent);
            //foundStudent = g1.FindBy(x => x.Fullname == "Orkhan Elyasov");
            //Console.WriteLine(foundStudent);
            //var foundStudent = g1.Students.FindAll(x => x.Fullname.StartsWith("Or"));
            //foreach (var item in foundStudent)
            //{
            //    Console.WriteLine(item);
            //}

            //var foundStudent = g1.FindBy(x => x.Fullname.Contains("aa"));
            //if (foundStudent == null)
            //{
            //    Console.WriteLine("Not found");
            //}
            //else
            //{
            //    Console.WriteLine(foundStudent);
            //}

            //var foundStudent = g1.Students.Exists(x => x.Fullname.StartsWith("Or") && x.Fullname.EndsWith("ov"));
            //Console.WriteLine(foundStudent);



            #endregion

            //Car.cs olsun, Model Marka Year Price property-leri saxlasin,
            //ancaq ctor-da set olsun.
            //AutoSalon.cs olsun ichinde List saxlasin private olsun.
            //AddCar,UpdateCar,RemoveCar,ShowItems methodlari olsun.
            //Elave olaraq FindBy methodu olsun delegate istifade edib
            //her bir property-sine gore (Model, Marka, Year, Price)
            //axtarish olsun.
        }

        #region Delegate

        static void PrintAsUpper(string text)
        {
            Console.WriteLine(text.ToUpper());
        }

        static void PrintAsLower(string text)
        {
            Console.WriteLine(text.ToLower());
        }

        static void PrintFirstChar(string text)
        {
            Console.WriteLine(text[0]);
        }

        //static bool Test()
        //{
        //    return true;
        //}

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

        static bool MoreThanFive(int number)
        {
            return number > 5;
        }

        //static int GetSum(Check check, params int[] numbers)
        //{
        //    int sum = 0;
        //    foreach (var item in numbers)
        //    {
        //        if (check(item))
        //        {
        //            sum += item;
        //        }
        //    }

        //    return sum;
        //}

        //static int GetSum(Predicate<int> check, params int[] numbers)
        //{
        //    int sum = 0;
        //    foreach (var item in numbers)
        //    {
        //        if (check(item))
        //        {
        //            sum += item;
        //        }
        //    }

        //    return sum;
        //}

        static int GetSum(Func<int, bool> check, params int[] numbers)
        {
            int sum = 0;
            foreach (var item in numbers)
            {
                if (check(item))
                {
                    sum += item;
                }
            }

            return sum;
        }

        //static int GetSum(params int[] numbers)
        //{
        //    int sum = 0;
        //    foreach (var item in numbers)
        //    {
        //        if (item % 2 == 0)
        //        {
        //            sum += item;
        //        }
        //    }

        //    return sum;
        //}

        //static int GetSum2(params int[] numbers)
        //{
        //    int sum = 0;
        //    foreach (var item in numbers)
        //    {
        //        if (item % 2 != 0)
        //        {
        //            sum += item;
        //        }
        //    }

        //    return sum;
        //}

        //static int GetSum3(params int[] numbers)
        //{
        //    int sum = 0;
        //    foreach (var item in numbers)
        //    {
        //        if (item > 3)
        //        {
        //            sum += item;
        //        }
        //    }

        //    return sum;
        //}

        #endregion
    }
}
