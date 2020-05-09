using System;
namespace Test {

    class Araba{
        static int no=0;
        string marka = "",yekit_turu="",renk="",viste_turu="";
        string model;
        int yil;

       public Araba(string marka, string yekit_turu, string renk, string viste_turu,string model,int yil) {
            this.marka = marka;
            this.yekit_turu = yekit_turu;
            this.renk = renk;
            this.viste_turu = viste_turu;
            this.model = model;
            this.yil = yil;
        }

        public void renkdegistirme(string renk) {
            this.renk = renk;
        }
        public void Renk()
        {
            Console.WriteLine(this.renk);
        }

        public void goster()
        {
            Console.WriteLine(" marka:" + this.marka+ " yekit_turu:" + this.yekit_turu+" renk:"+this.renk+ " viste_turu:"+this.viste_turu+ " model:"+this.model+" yil:"+this.model);
        }

        ~Araba() {
            ++no;
            Console.WriteLine(no+".araba nesnesini oluştu");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string[] marka = { "BMW", "VOlVO", "TOYOTA", "MAZDA", "AUDİ", "CHEVROLET", "SCİON", "MERCEDES-BENZ", "Jeep", "ACURA" }, viste_turu= {"360","180","380","120","240"};
            string[] yekit_turu = { "GAZ", "benzin", "solar" }, renk = { "Kırmızı", "sari", "yasil", "Mavi" };
            string[] model = {"nakliyat","taşmacılık","servis","uzun araç","yarışma araç"};
            int[] yil= {2013,2014,2015,2107,2016,2019,2018,2020};
            Araba[] araba = new Araba[10];
            for (int i = 0; i < araba.Length; i++) { 
                araba[i] = new Araba(marka[rnd.Next(0,marka.Length)], yekit_turu[rnd.Next(0, yekit_turu.Length)], renk[rnd.Next(0, renk.Length)], viste_turu[rnd.Next(0, viste_turu.Length)], model[rnd.Next(0, model.Length)], yil[rnd.Next(0, yil.Length)]);
                araba[i].goster();
            }
      

        }
    }

}
