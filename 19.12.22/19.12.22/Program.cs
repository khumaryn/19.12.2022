using System;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

namespace _19._12._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("metni daxil et");
            string[] fullnames = { "Hikmet Abbasov", "Tofiq Qulamov", "Nermin Memmedov" };
            var names = add(fullnames);
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);

            }
            //string str = "names";//?
            //var ad = boyukherf(str);
            //for (int i = 0; i < ad.Length; i++)
            //{
            //    Console.WriteLine(names[i]);

            //}

        }
        static bool boyukherf(string str)
        {
            if (!Char.IsUpper(str[0]))
            {
                return false;
            }
            for (int i = 0; i < str.Length; i++)
            {
               if (!Char.IsLower(str[i]))
                    return false;
            }
            return true;
            
        }
         
        static void Add(int[]arr,int value)
        {//Parameter olaraq integer array variable-ı (reference) və bir integer value qəbul edən və
         //həmin integer value-nu integer array-ə yəni element kimi əlavə edən metod.

            int[] newArr = new int[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            newArr[newArr.Length - 1] = value;
            arr=newArr  ;
        }
        static  add (string[] fullnames)
        {// Gonderilmis fullname arrayinden yeni bir names arrayi duzeldib geri qaytaran metod.
            string[]  arr = new string[fullnames.Length];
            for (int i = 0; i < fullnames.Length; i++)
            {
                arr[i] = fullnames[i].Substring(0, fullnames[i].IndexOf(' '));
            }
            return arr;//(?)

          

        }

        

    }
}    

