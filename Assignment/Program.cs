using System.Text;

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



        }
    }
}
