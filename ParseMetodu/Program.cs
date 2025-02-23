namespace ParseMetodu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Parse Metodu
            //Parse, bir veriyi belirli bir türdeki veriye dönüştürmeye çalışır. Eğer dönüşüm başarılı olmazsa, bir hata fırlatır(örneğin, FormatException). Sadece string bir girdiyi hedef veri tipine dönüştürebilir. Parse metodu Convert sınıfına göre daha hızlı çalışır.

            string numberString = "123";

            int result1 = int.Parse(numberString);
            double result2 = double.Parse(numberString);
            // bool result3 = bool.Parse(numberString); //Boolean.Parse() metodu yalnızca "True" veya "False" (büyük/küçük harf duyarsız olarak) string değerlerini kabul eder. "123" gibi bir string, geçerli bir Boolean değeri olmadığından hata alırız.
            #endregion

            #region Parse Metodu Ornekler

            string parseSayi = "20.5";
            double parseDouble1 = double.Parse(parseSayi); //string parseSayi degerini double tipine parse etti.
            Console.WriteLine(parseDouble1);

            int parseSayi1 = int.Parse(parseSayi);
            Console.WriteLine(parseSayi1);

            bool parseBool1 = bool.Parse("true");
            Console.WriteLine(parseBool1);

            object obj1 = "123";
            int int1 = Convert.ToInt32(obj1);
            int int2 = int.Parse(obj1.ToString());

            //Kullanicidan Adınızı: , Yaşınız: , 'Siz robot musunuz: true - false'

            Console.WriteLine("Adınız: ");
            string adi = Console.ReadLine();

            Console.WriteLine("Yaşınız: ");
            int yasi = int.Parse(Console.ReadLine());

            Console.WriteLine("Robot musunuz? True-False");
            bool robotMu = bool.Parse(Console.ReadLine());

            Console.WriteLine($"Adım: {adi} Yaşım: {yasi} Robot mu: {robotMu}");

            string birincisayi = "1100";
            string ikincisayi = "34";
            string üçüncüsayi = "122,0";
            string dorduncusayi = "12212312";
            Console.WriteLine(int.Parse(birincisayi));
            Console.WriteLine(byte.Parse(ikincisayi));
            Console.WriteLine(double.Parse(üçüncüsayi));
            Console.WriteLine(long.Parse(dorduncusayi));

            int sayi = int.Parse("14");
            Console.WriteLine($"Parse Sayi : {sayi}");

            // Metinsel olarak saklanan 3 adet sayinin toplamini sayisal bir degiskende saklayarak ekrana yazdiriniz.
            string sayi1 = "1";
            string sayi2 = "2";
            string sayi3 = "3";

            int yeniSayi1 = int.Parse(sayi1);
            int yeniSayi2 = int.Parse(sayi2);
            int yeniSayi3 = int.Parse(sayi3);

            int toplam = yeniSayi1 + yeniSayi2 + yeniSayi3;
            Console.WriteLine(toplam);
            #endregion

            #region Sayi Karsilastirma Ornegi

            // Kullaniciya iki sayi soyleyip bu sayilardan ilki buyukmu sorusuna karsilik true veya false cevabini alarak Yalan soyleme durumunu ekrana yazdiriniz.
            
            int sayi6 = 5, sayi7 = 10;
            Console.WriteLine($"[{sayi6},{sayi7}]\n1. Sayi buyukmu? [true/false]");

            bool cevap = bool.Parse(Console.ReadLine());
            bool karsilastirma = sayi6 > sayi7;
            bool sonuc = !(karsilastirma == cevap);

            Console.WriteLine($"yalan söyleme durumu: {sonuc}");
            #endregion

            #region Mesafe Hesaplama Ornegi
            // Bir kisi yol mesafesini ve hizini belirtiyor buna gore ne kadar surede varmak istedigi yere varir.

            Console.WriteLine("Yol mesafesini girin(km)");
            double mesafe = double.Parse(Console.ReadLine());

            Console.WriteLine("Hızınızı girin(km/saat)");
            double hiz = double.Parse(Console.ReadLine());

            double sure = mesafe / hiz;
            Console.WriteLine($"varış süresi:{sure}saat");
            #endregion
        }
    }
}
