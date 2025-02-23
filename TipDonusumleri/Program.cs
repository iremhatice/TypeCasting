namespace TipDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1-Bilinçsiz Tip Dönüşümü - ImplictConversion

            //1-Bilinçsiz Tip Dönüşümü (Implict Conversion)
            //Düşük kapasiteli bir değişkeni yüksek kapasiteli bir değişken herhangi işlem gerektirmeden atayabilirsiniz.

            short degisken1 = 23456;
            int degisken2 = degisken1;
            Console.WriteLine("Shor Değişkeni: {0}, Int Değişkeni: {1}", degisken1, degisken2);

            #endregion

            #region 2-Bilinçli Tip Dönüşümü - ExplictConversion

            //2-Bilinçli Tip Dönüşümü (Explict Conversion)
            //Bilinçli tür dönüşümü genellikle derleyicinin izin vermediği durumlarda kullanılır. Büyük değişkeni küçük değişkene döndürdüğümüz zaman .NET veri kaybı olma olasılığından dolayı buna izin vermez.

            int degisken3 = 234562341;
            short degisken4 = (short)degisken3;
            Console.WriteLine("Short Değişkeni: {0}, Int Değişkeni: {1}", degisken4, degisken3);
            #endregion
        }
    }
}
