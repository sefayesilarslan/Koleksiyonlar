using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class koleksiyon
    {

        public static void Main(string[] args)
        {

            // List<T> class
            //System.Collection.Generic
            // T-> object türündedir.

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(65);
            sayiListesi.Add(32);
            sayiListesi.Add(8);
            sayiListesi.Add(29);
            sayiListesi.Add(74);
            sayiListesi.Add(21);
            sayiListesi.Add(16);
            sayiListesi.Add(37);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("Yeşil");
            renkListesi.Add("Mavi");
            renkListesi.Add("Krımızı");
            renkListesi.Add("Siyah");
            renkListesi.Add("Gri");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Beyaz");


            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);



            // LİSTEDEN ELEMAN ÇIKARMA

            sayiListesi.Remove(8);
            renkListesi.Remove("Gri");

            sayiListesi.RemoveAt(1);
            renkListesi.RemoveAt(2);


            foreach (var sayi in renkListesi)
            {
                Console.WriteLine(sayi);
            }


            sayiListesi.ForEach(sayi => Console.WriteLine(sayi)); //Farklı bir foreach metodu
            
            if(sayiListesi.Contains(29)){
                Console.WriteLine("Liste İçerinde 29 Var");
            }

            // ELEMAN İLE İNDEXE ERİŞİM

            Console.WriteLine(renkListesi.BinarySearch("Siyah"));
            

            // DİZİYİ LİSTEYE ÇEVİRME

            string[] hayvanlar={"Kedi","köpek","Kuş"};

            List<string> hayvanlarListesi=new List<string>(hayvanlar);

            // LİSTEYİ NASIL TEMİZLERİZ ?

            hayvanlarListesi.Clear();


            // LİSTE İÇERİSİNDE NESNE TUTMA

            List<Kullanicilar> kullaniciListesi=new List<Kullanicilar>();

            Kullanicilar kullanici1= new Kullanicilar();
            kullanici1.Isim="Sefa";
            kullanici1.Soyisim="Yeşilarslan";
            kullanici1.Yas=24;


            Kullanicilar kullanici2= new Kullanicilar();
            kullanici2.Isim="Ahmet";
            kullanici2.Soyisim="Çalık";
            kullanici2.Yas=27;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanicilar> yeniListe=new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar(){
                Isim="Arslan",
                Soyisim="Yeşil",
                Yas=15
            });

            foreach (var kullanici in kullaniciListesi)
            {
             Console.WriteLine("Kullanici Ad = "    +kullanici.Isim);   
             Console.WriteLine("Kullanici Soyad = " +kullanici.Soyisim);   
             Console.WriteLine("Kullanici Yaş= "    +kullanici.Yas);   
            }

        }

        public class Kullanicilar{
            private string isim;
            private string soyisim;
            private int yas;

            public string Isim { get => isim; set => isim = value; }
            public string Soyisim { get => soyisim; set => soyisim = value; }
            public int Yas { get => yas; set => yas = value; }
        }
    }
}
