using System.Reflection.PortableExecutable;

namespace _6_Is_As_Kullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region is Kullanımı
            //Bir nesnenin belirli bir türde olup olmadığını kontrol etmek için kullanılır.Çalışma zamanında gerçekleşir.Bu,türün doğruluğunu doğrulamak için kullanılır ve genellikle koşul ifadelerinde yer alır. is, nesnenin türünü kontrol eder ve sonucunda true veya false döner.

            //Kullanım:
            object obj = "Hello, world!";
            if (obj is Type)
            {
                // obj nesnesi Type türünde
            }

            //Ornek1:
            object obj2 = "Hello, world!";
            if (obj2 is string)
            {
                Console.WriteLine("The object is a string.");
            }
            else
            {
                Console.WriteLine("The object is not a string.");
            }
            // Açıklama: Burada obj nesnesinin türü string olup olmadığını kontrol ediyoruz.Eğer obj, string türündeyse, is ifadesi true döndürecektir.

            //is ile Dönüşüm (Pattern Matching)
            //C# 7.0 ve sonrasında is operatörü ile tür dönüşümü yapılabilir. Bu durumda, tür doğrulaması ve dönüşüm aynı anda yapılır.

            object obj3 = "Hello, world!";
            if (obj3 is string str)
            {
                Console.WriteLine($"The object is a string: {str}");
            }
            //Açıklama: Eğer obj bir string türündeyse, str adlı yeni bir değişken oluşturulur ve bu değişkene obj'nin değeri atanır. Yani tür kontrolü yapılır ve başarılıysa dönüşüm sağlanır.
            #endregion

            #region as Kullanımı
            //Bir nesneyi belirtilen türde dönüştürmek için kullanılır.Ancak, as dönüşüm başarısız olursa, null döner. as, dönüşüm sırasında hata fırlatmaz, bu yüzden tür dönüşümünde null kontrolü yapılması gerekir. `as` sadece referans ve nullable türler için çalışır.

            //Kullanım:
            Type variable = obj as Type;

            //Ornek1:
            object obj5 = "Hello, world!";
            string str2 = obj5 as string;
            if (str2 != null)
            {
                Console.WriteLine($"The object is a string: {str2}");
            }
            else
            {
                Console.WriteLine("The object is not a string.");
            }
            //Açıklama: Burada obj nesnesini string türüne dönüştürmeye çalışıyoruz. Eğer dönüşüm başarılı olursa, str değişkenine değeri atanır, aksi takdirde str null olur.

            //nullable turler
            object bilinmeyenSayi = 5;
            int? bilinenSayi = bilinmeyenSayi as int?;

            #endregion

            //Ne Zaman Kullanılmalı?
            //• is: Tür doğrulama yapmak ve sadece nesnenin türünü kontrol etmek istediğinizde kullanılır.
            //• as: Tür dönüşümünü güvenli bir şekilde yapmak ve dönüşüm başarısız olduğunda null dönerse işlemi kontrol etmek için kullanılır.
        }
    }
}
