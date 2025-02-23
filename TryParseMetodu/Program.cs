using System.Reflection.Metadata;

namespace TryParseMetodu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TryParse Metodu
            //TryParse, bir değeri belirli bir türdeki veriye dönüştürmeye çalışır ve dönüşüm başarılı olursa bu değeri döndürür.Eğer dönüşüm başarısız olursa, bir hata fırlatmaz, yalnızca false döner.Verinin string olması zorunludur.

            string numberString = "123"; // String türünde bir değer
            bool result = int.TryParse(numberString, out int number); // 'out' parametresi kullanılıyor

            /* Açıklama: Bu örnekte, int.TryParse metodunun ikinci parametresi out int number'dır.
        • numberString değeri "123" olarak verilir.
        • Eğer bu değer bir int türüne dönüştürülebilirse, out parametre olarak kullanılan number değişkeni bu dönüştürülen değeri alır.
        • Eğer dönüşüm başarılı olursa, TryParse metodu true döner ve number değişkeni 123 olarak atanır.
        • Eğer dönüşüm başarısız olursa, TryParse metodu false döner ve number değişkeni başlangıçta atanmış bir değer almaz(içeriği sıfırlanır, genellikle 0 olur).     
            */
            #endregion

            #region TryParse Metodu Ornekler

            //Girilen telefon numarasının dogru formatte olup olmadıgını kontrol etme
            Console.WriteLine("10 haneli Telefon numarası giriniz:");
            string bilgi = Console.ReadLine();

            if (bilgi.Length == 10)
            {
                long telno;
                if (long.TryParse(bilgi, out telno))
                {
                    Console.WriteLine("Tebrikler! 10 haneli telefon numarası girdiniz.");
                }
                else
                {
                    Console.WriteLine("10 karakter ama yanlış format");
                }
            }
            else
            {
                Console.WriteLine("10 haneli telefon numarası giriniz.");
            }
            #endregion
        }
    }
}
