namespace _7_GetType_typeOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region GetType
            //Çalışma zamanında (runtime) bir nesnenin tür bilgisini almak için kullanılır. Nesne gerektirir, çünkü çağrıldığında nesnenin türünü döndürür. Değişkenin tipini bize söyleyen metotdur. GetType() nesnenin gerçek tipini döndürür, yani türün tam adını sağlar.System.Type türünde bir değer döndürür.

            //Ornekler
            int number = 10;
            string text = "Hello";

            Type t1 = number.GetType();  // number değişkeninin türünü alır
            Type t2 = text.GetType();    // text değişkeninin türünü alır

            Console.WriteLine(t1); // Çıktı: System.Int32
            Console.WriteLine(t2); // Çıktı: System.String

            object birinciDegisken = 25;
            object ikinciDegisken = "HelloWorld";
            Console.WriteLine("Değişken birin tipi " + birinciDegisken.GetType());  // Çıktı: System.Int32
            Console.WriteLine("Değişken ikinin tipi " + ikinciDegisken.GetType());  // Çıktı: System.String
            #endregion

            #region typeOf
            //Derleme zamanında (compile-time) bir türün (type) bilgisini almak için kullanılır. Nesne gerektirmez, doğrudan bir tür adı ile çalışır. System.Type türünde bir değer döndürür.

            //Ornekler
            Type a = typeof(int);  // int türünün Type nesnesini alır
            Type b = typeof(string);  // string türünün Type nesnesini alır

            Console.WriteLine(a); // Çıktı: System.Int32
            Console.WriteLine(b); // Çıktı: System.String

            Console.WriteLine(typeof(List<int>)); //Çıktı: System.Collections.Generic.List`1[System.Int32]
            #endregion
        }
    }
}
