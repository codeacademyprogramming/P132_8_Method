using System;

namespace homeworks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //===============================================
            //Task1
            //===============================================

            //Console.WriteLine("Metni daxil edin:");
            //string input = Console.ReadLine();

            //char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            //bool hasDigit = false;

            //for (int i = 0; i < input.Length; i++)
            //{
            //    for (int j = 0; j < digits.Length; j++)
            //    {
            //        if (input[i] == digits[j])
            //        {
            //            hasDigit = true;
            //            break;
            //        }
            //    }

            //    if (hasDigit)
            //        break;


            //}

            //if (hasDigit)
            //{
            //    Console.WriteLine("Reqem var");
            //}
            //else
            //{
            //    Console.WriteLine("Reqem yoxdur");
            //}



            //===============================================
            //Task2
            //===============================================

            //Version1
            //Console.WriteLine("1.ci ededi daxil et");
            //string num1Str = Console.ReadLine();
            //int num1 = Convert.ToInt32(num1Str);

            //Console.WriteLine("2.ci ededi daxil et");
            //string num2Str = Console.ReadLine();
            //int num2 = Convert.ToInt32(num2Str);

            //Console.WriteLine("3.ci ededi daxil et");
            //string num3Str = Console.ReadLine();
            //int num3 = Convert.ToInt32(num3Str);

            //Console.WriteLine("4.ci ededi daxil et");
            //string num4Str = Console.ReadLine();
            //int num4 = Convert.ToInt32(num4Str);

            //Console.WriteLine("5.ci ededi daxil et");
            //string num5Str = Console.ReadLine();
            //int num5 = Convert.ToInt32(num5Str);

            //int result = (num1 + num2 + num3 + num4 + num5) / 5;
            //Console.WriteLine("result="+result);

            //Version2
            //string numStr;
            //int num;
            //int sum=0;

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i+1}. ededi daxil edin:");
            //    numStr = Console.ReadLine();
            //    num = Convert.ToInt32(numStr);
            //    sum += num;
            //}

            //int result = sum / 5;
            //Console.WriteLine("result=" + result);


            //===============================================
            //Task3
            //===============================================

            //char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            //string username;

            //bool checkUsername = true;
            //do
            //{

            //    checkUsername = true;
            //    Console.WriteLine("Istifadeci adini daxil edin:");
            //    username = Console.ReadLine();

            //    if (username.Length < 4)
            //        checkUsername = false;
            //    else
            //    {
            //        for (int i = 0; i < digits.Length; i++)
            //        {
            //            if(username[0] == digits[i])
            //            {
            //                checkUsername = false;
            //                break;
            //            }
            //        }
            //    }



            //} while (!checkUsername);


            //===============================================
            //Task4
            //===============================================

            //Console.WriteLine("Adlarin sayini daxil edin");
            //string countStr = Console.ReadLine();
            //int count = Convert.ToInt32(countStr);

            //string[] names = new string[count];

            //for (int i = 0; i < count; i++)
            //{
            //    Console.WriteLine($"{i+1}. adi daxil edin");
            //    names[i] = Console.ReadLine();
            //}



            //===============================================
            //Task5
            //===============================================

            //string[] words = { "Abbas", "Azerbaycan", "Nbdulla" };

            //bool hasWanted = false;


            //for (int i = 0; i < words.Length; i++)
            //{
            //    if(words[i][0] != 'A' && words[i][0] != 'a')
            //    {
            //        hasWanted = true;
            //        break;
            //    }
            //}

            //if (hasWanted)
            //{
            //    Console.WriteLine("Butun sozler A ile baslamir");
            //}
            //else
            //{
            //    Console.WriteLine("Butun sozler A ile baslayir");
            //}



        }
    }
}
