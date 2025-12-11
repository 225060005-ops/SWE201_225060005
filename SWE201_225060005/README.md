# 🎬 SWE201 - Film Projesi

Bu proje, C# dersinde Nesne Yönelimli Programlama (OOP) temellerini pekiştirmek amacıyla geliştirdiğim basit ama öğretici bir çalışma.  
Amaç, bir **Film** nesnesini OOP prensiplerine uygun şekilde modellemek ve bu süreçte kapsülleme, kurucular, metotlar gibi kavramları uygulamaktı.

---

## 🎞 Film Sınıfında Yaptıklarım

### 🔒 Kapsülleme (Encapsulation)
Film adı, puanı, süresi ve yönetmeni gibi özellikleri **private** alanlarda tuttum.  
Bu verilere dışarıdan doğrudan erişim engelleniyor ve yalnızca Property'ler üzerinden kontrollü şekilde erişiliyor.

### ⭐ Puan Kontrolü (Validation)
`Puan` özelliği için bir doğrulama mekanizması ekledim.  
- Eğer girilen puan **0.0–10.0** aralığında değilse:
  - Sistem uyarı veriyor  
  - Puan otomatik olarak **10.0** yapılıyor  
Bu sayede veri bütünlüğü korunmuş oluyor.

### 🧱 Kurucular (Constructors)
Film sınıfında iki farklı kurucu tanımladım:
- **Boş Kurucu:** Varsayılan değerlerle bir film nesnesi oluşturur.
- **Parametreli Kurucu:** Tüm film bilgilerini tek seferde alarak nesneyi hazır hâle getirir.

---

## ⚙️ Eklediğim Metotlar

### 🎚 `PuanArtir(miktar)`
Filmin puanını artırır. Artış sonrasında puan 10’u geçemez çünkü kontrol yine `Puan` özelliği tarafından yapılır.

### ⏱ `SureArttir(ekSure)`
Film süresine ekstra dakika ekler.

### ⏳ `SuresiSaatDakika()`
Filmin süresini dakika cinsinden alır ve şu formatta geri döner:

📌 **“X saat Y dakika”**

### 📝 `ToString()` Override
Film nesnesi ekrana yazdırıldığında tüm bilgilerin düzenli bir şekilde görünmesi için `ToString()` metodunu yeniden tanımladım.

---

## 🚀 Proje Akışı

Proje iki ana kısımdan oluşuyor:

1. **Film.cs** – Film sınıfının tanımı
2. **Program.cs (Main)** – Film nesnelerinin test edildiği bölüm

Main içinde şunları yaptım:
- Farklı kurucularla film nesneleri oluşturdum.
- `PuanArtir` ve `SureArttir` metotlarını test ettim.
- Özellikle puan doğrulamasının çalıştığını göstermek için sınır dışı puan değerlerini denedim.

---

