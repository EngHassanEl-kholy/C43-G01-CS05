using System.Numerics;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment
{
    class Program
    {
        #region Q01
        //static void IncrementNumber(int number)
        //{
        //    number += 10;
        //}
        //static void IncrementNumber(ref int number)
        //{
        //    number += 20;
        //}
        #endregion

        #region Q02

        //static void AddHi(StringBuilder stringBuilder)
        //{
        //    stringBuilder.Append(" Hi");
        //}
        //static void AddHi(ref StringBuilder stringBuilder)
        //{
        //    stringBuilder = new StringBuilder("Hi");
        //}
        #endregion

        #region Q03
        //static void sumSub(int num01,int num02,out int sum,out int sub)
        //{
        //    sum=num01+num02;
        //    sub = num01 - num02;
        //}
        #endregion

        #region Q04
        //static int SumOfDigit(int Num)
        //{
        //    int sum = 0;
        //    while(Num!=0)
        //    {
        //        sum += Num % 10;
        //        Num /= 10;
        //    }
        //    return sum;
        //}
        #endregion

        #region Q05
        //static bool isPrime(int number)
        //{
        //    if (number < 2)
        //    {
        //        return false;
        //    }


        //    for (int i = 2; i <= Math.Sqrt(number); i++)
        //    {
        //        if (number % i == 0)
        //        {
        //            return false;
        //        }
        //    }

        //    return true;
        //}

        #endregion

        #region Q06
        //static void MinMaxArray(int[] arr, ref int min, ref int max)
        //{
        //    min = arr[0];
        //    max = arr[0];
        //    if (arr is not null)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            if (min > arr[i])
        //            {
        //                min = arr[i];
        //            }
        //            if (max < arr[i])
        //            {
        //                max = arr[i];
        //            }

        //        }
        //    }
        //}
        #endregion

        #region Q07
        //static int Getfactorial(int num)
        //{
        //    int factorial = 1;
        //    for(int i=1;i<=num;i++)
        //    {
        //        factorial = i * factorial;
        //    }
        //    return factorial;
        //}
        #endregion

        #region Q08
        //static void ChangeChar(ref string text,int index,char c)
        //{
        //   char[]arr=text.ToCharArray();
        //    arr[index] = c;
        //    text = new string(arr);
        //}
        #endregion
        static void Main(string[] args)
        {
            #region Q01
            //1-Explain the difference between passing (Value type parameters)
            //by value and by reference then write a suitable c# example.
            // int Num = 10;
            //IncrementNumber(Num);     //Pass By Value 
            //Console.WriteLine(Num);   // will print 10 because it passed by value
            //IncrementNumber(ref Num);   //pass by reference
            //Console.WriteLine(Num);     // will print 30
            #endregion

            #region Q02
            //2-Explain the difference between passing (Reference type parameters)
            //by value and by reference then write a suitable c# example.
            //StringBuilder stringBuilder = new StringBuilder("Hassan");
            //AddHi(stringBuilder); //pass by value = [address]
            //Console.WriteLine(stringBuilder);
            //will print "Hassan Hi" , it changed and same thing will display if it pass 
            //by ref in this example but if we change the StringBuilder in the
            //function will see the difference
            //AddHi(ref stringBuilder);                //pass by reference
            //Console.WriteLine(stringBuilder);        //will print Hi because it changed in the method (new object created)


            #endregion

            #region Q03
            //3-Write a c# Function that accept 4 parameters from user and
            //return result of summation and subtracting of two numbers
            //int Num01 = 10, Num02 = 5, Sum, Sub;
            //sumSub(Num01, Num02,out  Sum,out Sub);
            //Console.WriteLine($" {Num01} + {Num02} = {Sum}");
            //Console.WriteLine($" {Num01} - {Num02} = {Sub}");


            #endregion

            #region Q04
            //4-Write a program in C# Sharp to create a function to calculate
            //the sum of the individual digits of a given number.
            //Console.WriteLine(SumOfDigit(303));  //6
            #endregion

            #region Q05
            //5-Create a function named "IsPrime", which receives an integer number
            //and retuns true if it is prime, or false if it is not:

            #endregion

            #region Q06
            //6-Create a function named MinMaxArray, to return the minimum and maximum
            //values stored in an array, using reference parameters
            //int[] arr = [1, 2, 3, 4, 5];
            //int min = 0;
            //int max = 0;
            //MinMaxArray(arr, ref min, ref max);
            //Console.WriteLine(min);
            //Console.WriteLine(max);
            #endregion

            #region Q07
            //7-Create an iterative (non-recursive) function to calculate the factorial
            //of the number specified as parameter
            //Console.WriteLine(Getfactorial(5));
            #endregion

            #region Q08
            //8-	Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string,
            //replacing it with a different letter
            //string txt = "Route";
            //ChangeChar(ref txt, 0, 'M');
            //Console.WriteLine(txt);

            #endregion

        }
    }
}


