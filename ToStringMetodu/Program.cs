namespace ToStringMetodu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ToString Metodu
            //ToString, bir nesneyi string türüne dönüştürmek için kullanılır. Her türde, varsayılan olarak ToString() metodu vardır.

            bool deneme1 = true;
            Console.WriteLine(deneme1.ToString() + 2); //Çıktı: true2
            Console.WriteLine(22.ToString() + 2); //Çıktı: 222
            #endregion
        }
    }
}
