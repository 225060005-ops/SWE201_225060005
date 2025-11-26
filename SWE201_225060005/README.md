# SWE201 - Film Projesi (Benim İlk Adımlarım!)

Merhaba! Bu projeyi, C# dersi kapsamında Nesne Yönelimli Programlamanın (OOP) temellerini öğrenmek için hazırladım. 
Projemin ana fikri, bir **Film** nesnesini kodda nasıl en düzgün şekilde modelleyebileceğimi göstermekti.

Bu projeyi yaparken, öğrendiğim temel kavramları bolca kullandım.

## Film Sınıfında Neler Yaptım?

`Film` sınıfı, bir filmin tüm bilgilerini düzenli ve kontrollü bir şekilde tutuyor. İşte benim uyguladığım bazı temel özellikler:

* **Güvenlik (Kapsülleme):** Filmin adı (`ad`), puanı (`puan`), yönetmeni ve süresi gibi verileri **private** olarak tanımladım. 
Bu sayede kimse bu verilere dışarıdan kafasına göre müdahale edemiyor. Erişim, yalnızca benim belirlediğim **Properties (Özellikler)** üzerinden yapılıyor.
* **Puan Kontrolü (Validation):** Özellikle `Puan` özelliğini tasarlarken bir güvenlik kapısı oluşturdum. 
Eğer puan 0.0'dan küçük veya 10.0'dan büyük girilirse, sistem uyarı veriyor ve puanı otomatik olarak 10.0'a sabitliyor. **Böylece veri bütünlüğünü sağladım.**
* **Başlangıç Fonksiyonları (Constructors):**
    * **Boş Kurucu:** Hiç bilgi girmeden bir film nesnesi oluşturmak için varsayılan değerler atayan bir boş kurucu yazdım.
    * **Parametreli Kurucu:** Tüm temel bilgileri (Ad, Puan, Yönetmen, Süre, Tür, Yıl, Dil) tek bir satırda alıp nesneyi anında başlatan bir kurucu fonksiyon oluşturdum.

## Eklediğim Fonksiyonellikler (Metotlar)

`Film` nesnemin sadece veri tutmasını istemedim, aynı zamanda bazı işlevleri de yerine getirmesini sağladım:

1.  **`PuanArtir(miktar)`:** Filmin puanını artırmak için yazdığım bir metot. (Bu metot bile, puanın 10.0'u geçmeyeceğini kontrol eden `Puan` özelliğini kullanıyor!)
2.  **`SureArttir(ekSure)`:** Filmin süresine ek dakika eklemek için basit bir metot.
3.  **`SuresiSaatDakika()`:** Bu benim en sevdiğim ekleme! Filmin toplam süresini (dakika) alıp, bunu daha okunabilir bir format olan **"X saat Y dakika"** şeklinde döndüren pratik bir metot geliştirdim.
4.  **`ToString()` Override:** Nesneyi ekrana yazdırdığımda tüm bilgilerin dağınık değil, tek ve düzenli bir satırda görünmesi için `ToString()` metodunu yeniden yazdım (override ettim).

## Proje Akışı

Projem, biri sınıf tanımını (Film), diğeri ise test kodlarını (`Main` fonksiyonu) içeren iki ana bölümden oluşuyor. **`Program.cs`** dosyasındaki `Main` fonksiyonunda:

* Farklı kurucular kullanarak film nesneleri oluşturdum.
* Bu nesneler üzerinde `PuanArtir` ve `SureArttir` gibi metotları test ettim.
* Özellikle kontrollü `Puan` özelliğimin nasıl çalıştığını göstermek için sınırdan büyük değerleri denedim.