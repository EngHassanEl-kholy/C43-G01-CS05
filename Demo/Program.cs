﻿using System.Text;

namespace Demo
{
    class Program
    {
        #region Function Prototype and Calling
        //static void PrintShapes()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine("*_*");
        //    }

        //}
        //static void PrintShapes(int count, string shape)
        //{
        //    for (int i = 1; i <= count; i++)
        //    {
        //        Console.WriteLine($"{shape}");
        //    }

        //}
        #endregion

        #region Value Type Parameters
        //static void swap(ref int x,ref int y)
        //{

        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}
        //static void Increment(int num)
        //{
        //    num += 10;
        //}
        #endregion

        #region Reference Type Parameters
        //static int sum(int[] nums)
        //{
        //    int sum = 0;
        //    if (nums is not null)
        //    {
        //        for (int i = 0; i < nums.Length; i++)
        //        {
        //            sum += nums[i];
        //        }
        //    }
        //    return sum;
        //}
        //static void AddNewText(StringBuilder sb)
        //{
        //    sb.AppendLine(" New Text");
        //}
        //static void Change(ref int[] nums)
        //{
        //    nums = [ 10, 20,30,40];

        //}
        #endregion

        #region Passing By Out
        //static void SumMul(int x,int y,out int sum,out int mul)
        //{
        //    sum = x + y;
        //    mul = x * y;
        //}
        #endregion
        static void Main(string[] args)
        {
            #region Function Prototype and Calling
            // PrintShapes();   //Calling 
            //PrintShapes(count: 10, shape:"#_#");   //calling by name
            //PrintShapes(10, "#_#");                //caliing by order
            //string folderPath = @"E:\Route";
            #endregion

            #region Value Type Parameters
            //Try make swap using only 2 variables
            //int x = 5, y = 13;
            //x = x + y;//18
            //y = x - y;//5
            //x = x - y;//13
            //Console.WriteLine($"x = {x}");
            //Console.WriteLine($"y = {y}");
            // int A = 5, B = 10;
            //swap(ref A, ref B);    //pass by ref [input-output]
            // Increment(A);            //pass by value [input]
            // Console.WriteLine(A);

            #endregion

            #region Reference Type Parameters
            // int[] arr = { 1, 2, 3 };
            //sum(arr);
            //StringBuilder stringBuilder = new StringBuilder();
            //stringBuilder.Append("Hassan");
            //AddNewText(stringBuilder);
            //Console.WriteLine(stringBuilder);
            //Change(ref arr);
            //Console.WriteLine( arr[3]); //40
            #endregion

            #region Passing By Out
            //int A = 10, B = 12, Sum,Mul;
            //SumMul(A, B,out Sum,out Mul);

            #endregion


        }
    }
}
