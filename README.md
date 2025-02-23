# C# Type Casting (Tip Dönüşümleri)
Bu repo, C# dilinde **tip dönüşümleri (type casting)** ile ilgili örnekleri içerir. Aşağıdaki farklı tip dönüşüm yöntemleri açıklanmış ve örneklerle gösterilmiştir:

- **Implicit (Örtük Dönüşüm)**
- **Explicit (Açık Dönüşüm)**
- **Convert Sınıfı Kullanımı**
- **Parse ve TryParse Metotları**
- **ToString Metodu**
  
## 📌 İçerik
1. Implicit ve Explicit Type Casting  
2. Convert Sınıfı ile Dönüşümler  
3. Parse ve TryParse Kullanımı  
4. ToString Metodu Kullanımı
5. is ve as Operatörleri
6. GetType() ve typeof Kullanımı
   
## 🖼️ Tip Dönüşümleri Özet Tablosu
Aşağıdaki tablo, C#'ta yaygın kullanılan tip dönüşümlerini özetlemektedir.

| Dönüşüm Türü | Kullanım Şekli | Örnek |
|-------------|---------------|------|
| **Implicit (Örtük Dönüşüm)** | Küçük tür → Büyük tür | `int x = 10; double y = x;` |
| **Explicit (Açık Dönüşüm)** | Büyük tür → Küçük tür (Cast Gerekir) | `double x = 10.5; int y = (int)x;` |
| **Convert Metodu** | Türü doğrudan çevirir | `int x = Convert.ToInt32("123");` |
| **Parse Metodu** | Sadece string'den ilgili türe çevirir | `int x = int.Parse("123");` |
| **TryParse Metodu** | Hata yönetimi içerir, boolean döndürür | `int.TryParse("123", out int x);` |

---

## 📂 Proje İçeriği
- `ImplicitExplicitCasting.cs` → Örtük ve açık dönüşüm örnekleri  
- `ConvertSinifi.cs` → Convert sınıfı ile dönüşüm örnekleri  
- `ParseMetodu.cs` → Parse Metodu ile örnekler
- `TryParseMetodu.cs` → TryParse Metodu ile örnekler
- `ToStringMetodu.cs` → ToString Metodu ile örnekler
- `Is_As_Kullanimi.cs` → is ve as kullanımı ile örnekler
- `GetType_typeOf.cs` → GetType Metodu ve typeOf ile örnekler  
