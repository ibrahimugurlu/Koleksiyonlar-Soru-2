using System;
using System.Collections.Generic;
using System.Collections;
namespace Koleksiyonlar_Soru_2
{
    public static class Examples
    {
        public static void FoundNumber(this ArrayList param, ref ArrayList LowNumber)
        {
            for (int i = 0; i < 3; i++)
            {
                LowNumber.Add(param[i]);
            }
        }

     
        public static void Average(this ArrayList param)
        {
            int total = 0;
            
            foreach (int number in param)
            {
                total = total + number;
            }
            int average = total / param.Count;

            Console.WriteLine("Ortalama :" + average);
            Console.WriteLine("Toplam :" + total);


        }
        
    }

    class Program
    {
       
    

        public 
        static void Main(string[] args)
        {
            Console.WriteLine("Hoşgeldiniz!!");
            Console.WriteLine("20 Adet Sayı Giriniz");
            ArrayList numberList = new ArrayList();
            ArrayList lowNumber = new ArrayList();
            ArrayList highNumber = new ArrayList();


            for (int i = 0; i < 20; i++)
            {
                numberList.Add(int.Parse(Console.ReadLine()));
            }
                Console.WriteLine("**************************************");

            
            numberList.Sort();

            foreach (var item in numberList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("**************************************");
            
           numberList.FoundNumber(ref lowNumber);
           numberList.Reverse();
           numberList.FoundNumber(ref highNumber);

         
            Console.WriteLine("Küçük Array :.........");
            foreach (var item in lowNumber)
            {
                Console.WriteLine(item);
            }
            lowNumber.Average();
           

            Console.WriteLine("Büyük Array :..........");
            foreach (var item in highNumber)
            {
                Console.WriteLine(item);
            }
            highNumber.Average();

            

            Console.Read();
        }
    }
}
