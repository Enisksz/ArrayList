using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add("Ayşe");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');


            //İçerisindeki verilere erişim
            foreach (var ürün in liste)
            {
                Console.WriteLine(ürün);
            }

            //AddRange
            string[] renkler = { "Kırmızı", "Sarı", "Yeşil" };
            List<int> sayilar = new List<int>() {1,8,7,54,3,5};
            liste.AddRange(renkler);
            liste.AddRange(sayilar);

            //Sort
            liste.Sort();

            //Binary Search
            Console.WriteLine(liste.BinarySearch(9));

            //Reverse
            liste.Reverse();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            //Clear
            liste.Clear();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
        }
    }
}
