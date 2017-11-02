using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("cümle giriniz:");
            //string cumle = Console.ReadLine();
            //string[] kelime = cumle.Split(new[] { ' ' });
            //int kelimesayisi = 0;
            //for (int i = 0; i <  kelime.Length; i++)
            //{
            //    if (cumle[i] == ' ' || cumle[i] == '.')
            //        kelimesayisi++;
            //}
            //Console.WriteLine("Kelime Sayısı = {0}", kelimesayisi);

            Console.Write("Cümle Giriniz: ");
            string cumle = Console.ReadLine();
            int kelimesayisi = 0, harfsayisi = 0;
            for (int i = 0; i < cumle.Length; i++)
            {


                if (cumle[i] == ' ' || cumle[i] == '.')
                kelimesayisi++;
                else
                harfsayisi++;
        }
        Console.WriteLine("Kelime Sayısı = { 0 }\nHarf Sayısı = { 1 }", kelimesayisi, harfsayisi);
        Console.ReadKey();
        }
    }
}
