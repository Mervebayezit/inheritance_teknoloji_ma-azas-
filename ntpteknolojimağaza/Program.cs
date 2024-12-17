using System;

namespace TeknolojiMagazasi
{
    public class Urun
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public decimal Fiyat { get; set; }
        public int Stok { get; set; }
        public string Kategori { get; set; }

        public Urun(string marka, string model, decimal fiyat, int stok, string kategori)
        {
            Marka = marka;
            Model = model;
            Fiyat = fiyat;
            Stok = stok;
            Kategori = kategori;
        }

        public virtual void BilgiYazdir()
        {
            Console.WriteLine("Marka: " +Marka);
            Console.WriteLine("Model: " +Model);
            Console.WriteLine("Fiyat: " +Fiyat);
            Console.WriteLine("Stok: " +Stok);
            Console.WriteLine("Kategori: " +Kategori);


        }
    }
    public class Telefon : Urun
    {
        public string IsletimSistemi { get; set; }
        public int KameraSayisi { get; set; }

        public Telefon( string marka,string model,decimal fiyat,int stok, string kategori,string isletimSistemi,int kameraSayisi)
        : base(marka, model, fiyat, stok, kategori)
        {
            IsletimSistemi = isletimSistemi;
            KameraSayisi = kameraSayisi;
        }

        public override void BilgiYazdir()
        {
            base.BilgiYazdir();
            Console.WriteLine("İşletim Sistemi: " + IsletimSistemi);
            Console.WriteLine("Kamera Sayısı: " +KameraSayisi);
        }
    }

    public class Bilgisayar : Urun
    {
        public string Islemci { get; set; }
        public int Ram { get; set; }
        public int Depolama { get; set; }
        public object GB { get; private set; }

        public Bilgisayar( string marka,string model,decimal fiyat,int stok,string kategori,string islemci, int ram, int depolama)
        : base(marka, model, fiyat, stok, kategori)   
        
        {
            Islemci = islemci;
            Ram = ram;
            Depolama = depolama;
        }

        public override void BilgiYazdir()
        {
            base.BilgiYazdir();
            Console.WriteLine("İşlemci: " +Islemci);
            Console.WriteLine("RAM: GB  " + Ram );
            Console.WriteLine("Depolama: GB  " +Depolama );
        }
    }

    public class Tablet : Urun
    {
        public string EkranBoyutu { get; set; }
        public bool KalemDestegi { get; set; }

        public Tablet(string marka,string model,decimal fiyat,int stok,string kategori,  string ekranBoyutu,bool kalemDestegi)
        : base(marka, model, fiyat, stok, kategori)
        {
            EkranBoyutu = ekranBoyutu;
            KalemDestegi = kalemDestegi;
        }

        public override void BilgiYazdir()
        {
            base.BilgiYazdir();
            Console.WriteLine("Ekran Boyutu: " +EkranBoyutu);
            Console.WriteLine("Kalem Desteği: " +KalemDestegi);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Telefon telefon = new Telefon ( "Apple", "iPhone 15",  54.999m, 50,"Telefon","iOS", 2 );
            
            Bilgisayar bilgisayar = new Bilgisayar(  " Dell","XPS 13", 105.999m, 30, "Bilgisayar","Intel i7", 32,512);
            
            Tablet tablet = new Tablet( "Samsung", "Galaxy Tab S7", 32.000m, 20,"Tablet","11 inç",  true );
            
            telefon.BilgiYazdir();
            bilgisayar.BilgiYazdir();
            tablet.BilgiYazdir();
        }
    }
}