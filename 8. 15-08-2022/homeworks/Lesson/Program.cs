using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 56;
            int num2 = 50;

            var a = Topla(20,40);
            Console.WriteLine(a);
            
            int result1 = num1+ num2;
            ShowResult(result1);

            int result2 = num1 * num2;
            ShowResult(result2);

            int result3 = num1 - num2;
            ShowResult(result3);

            ShowResult();


            Console.WriteLine(Kvadrat(10));
            Console.WriteLine(Kvadrat(15));
            Console.WriteLine(Kvadrat(45));


            Console.WriteLine(Pow(10,4));
            Console.WriteLine(Pow(5,3));
            Console.WriteLine(Pow(10, 3));


            int[] numbers = { 45, 100, 90, 44 };

            Console.WriteLine(FindBiggest(new int[]{ 45,10,32,88}));
            Console.WriteLine(FindBiggest(numbers));

        }

        static void ShowLetters()
        {
            Console.WriteLine("A");
            Console.WriteLine("B");
        }


        static void ShowResult(int result=0)
        {
            Console.WriteLine("=============================");
            Console.WriteLine("Proses bitdi!");
            Console.WriteLine("Netice: "+result);
            Console.WriteLine("==============================");
        }
      
        static int Topla(int num1,int num2,int num3=10)
        {
            var result = num1 + num2+num3;
            return result;
        }
        static int Topla(int num1, int num2)
        {
            var result = num1 + num2;
            //Console.WriteLine(result);
            return result;
        }

        static int Topla(double a, int b)
        {
            var result = a - b;
            //Console.WriteLine(result);
            return Convert.ToInt32(result);
        }

        static int Kvadrat(int num)
        {
            int result = num * num;
            return result;
        }

        static int Pow(int m,int n)
        {
            int result = 1;

            for (int i = 0; i < n; i++)
            {
                result *= m;
            }

            return result;
        }

        static int FindBiggest(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }
    }
}
