namespace ConvertSinifi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Convert Sınıfı
            //Bir veri tipinde değişkeni bir veri tipine cevirmek için ihtiyacımız olan yardımcı sınıftır (helper class).

            string deger = "123";
            int cevrimisBir = Convert.ToInt32(deger); //string deger int tipine cevrildi.

            byte cevrilmisIki = Convert.ToByte(deger); //string deger byte tipine cevrildi.

            short cevrilmisUc = Convert.ToInt16(deger); //string deger short tipine cevrildi.

            long cevrilmisDort = Convert.ToInt64(deger); //string deger long tipine cevrildi.

            float cevrilmisBes = Convert.ToSingle(deger); //string deger float tipine cevrildi.

            double deger2 = 10.5;
            int cevirIki = Convert.ToInt32(deger2);  //double deger2 int tipine cevrildi.
            Console.WriteLine(cevirIki);
            #endregion

            #region Convert Sınıfı Ornekler

            string str = "123";
            int number = Convert.ToInt32(str);
            Console.WriteLine(number);

            bool str1 = false;
            int bool1 = Convert.ToInt32(str1);

            int karakter1 = 64;
            char integer1 = Convert.ToChar(karakter1);

            double double1 = 13.99;
            int sayi1 = Convert.ToInt32(double1);
            #endregion

            #region Zam Yapma Ornegi
            // Kullanicidan marka,model,fiyat alarak fiyata ne kadar zam yapmak istedigini sorunuz ve zam oranina gore ekrana marka model ve yeni fiyatla yazdiriniz.

            Console.Write("Marka giriniz: ");  // Kullaniciya cikti veriyoruz
            string marka = Console.ReadLine(); // Kullanicinin girdigi degeri aliyoruz(string)

            Console.Write("Model giriniz: ");  // Cikti gosteriyoruz
            string model = Console.ReadLine(); // Model icin girilen veriyi aliyoruz

            Console.Write("Fiyat giriniz: ");  // Fiyati girmesi icin cikti gosteriyoruz
            string fiyatGirdisi = Console.ReadLine(); // Metinsel olark fiyat bilgini cekiyoruz

            decimal fiyat = Convert.ToDecimal(fiyatGirdisi); // Metinsel olarak girilen fiyati sayisal degere donusturuyoruz

            Console.Write("Ne kadar zam yapmak istersiniz: "); // Zam oranini girmesi icin cikti veriyoruz
            string zamOrani = Console.ReadLine(); // Kullanicinin girdigi metinsel orani alip getiriyor 
            decimal uygulananZamOrani = Convert.ToDecimal(zamOrani); // Metinsel zam oranini sayisala ceviriyor
            decimal yeniFiyat = (1 + uygulananZamOrani) * fiyat; // Fiyata zam oranini uygulayarak yeni bir fiyat olusturuyoruz.   
            Console.WriteLine($"{marka} {model} ' in yeni fiyati: {yeniFiyat}' dir."); // Toplanan tum bilgilere gore ekrana rapor mahiyetinde cikti veriyoruz.
            #endregion
        }
    }
}
