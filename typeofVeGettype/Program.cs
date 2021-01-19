using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace typeofVeGettype
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = "selam";
            Console.WriteLine(obj.GetType());

            //GetType kullanıldığı elemanın türünü verir
            //daha çok boxing işlemine tab tutulmuş elemanlar için kullanıır.
            insan ins = new insan();
            ins.isim = "Ali";
            ins.soyad = "veli";
            ins.yas = 25;

            ArrayList liste = new ArrayList();
            liste.Add("selam");
            liste.Add(12);
            liste.Add(ins);
            liste.Add(45.8);

            for (int i = 0; i < liste.Count; i++)
            {
                if (liste[i].GetType() == typeof(insan))
                {
                    insan ins2 = (insan)liste[i];//unboxing
                    Console.WriteLine(ins2.isim+" "+ins2.soyad+" "+ins2.yas);
                }
                else
                {
                    Console.WriteLine(liste[i]);
                }
            }
        }
    }
    class insan
    {
        public string isim { get; set; }
        public string soyad { get; set; }
        public int yas { get; set; }
    }
}
