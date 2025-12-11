# SWE201 – Film Sınıfı Projesi

Bu proje, C# dersinde öğrenilen Nesne Yönelimli Programlama (OOP) kavramlarını uygulamalı bir örnek üzerinden pekiştirmek amacıyla geliştirilmiştir. Oluşturulan yapı, bir **Film** nesnesinin gerçek hayattaki özelliklerini yazılım ortamında doğru, güvenli ve yönetilebilir bir biçimde temsil etmeyi hedefler.

---

## 1. Projenin Amacı

Projenin temel hedefi; OOP’nin dört ana prensibi olan **kapsülleme**, **soyutlama**, **kurucularla nesne oluşturma**, **metotlarla davranış kazandırma** gibi kavramları tek bir sınıf üzerinde toplu olarak uygulamaktır.

Film sınıfı; film adı, puanı, yönetmeni, süresi, türü, dili ve yılı gibi özellikleri temsil eden, bunun yanında bu özellikler üzerinde işlem yapmaya izin veren yapılar içerir.

---

## 2. Kullanılan OOP Kavramları

### **Kapsülleme (Encapsulation)**
Film sınıfının temel bilgileri (*ad, puan, yönetmen, süre*) doğrudan dışarıdan erişilemeyecek şekilde saklanır.  
Bu bilgilere erişim yalnızca **Property**’ler üzerinden sağlanır. Bu sayede veri güvenliği korunur ve dışarıdan kontrolsüz değişiklik yapılması engellenir.

---

### **Veri Doğrulama (Validation) - Puan Kontrolü**
Puan özelliği, sınıfa eklenen en önemli güvenlik mekanizmasıdır.  
Girilen puan sadece **0.0 ile 10.0** arasında olabilir.

- 10’dan büyük değerlerde puan otomatik olarak **10** yapılır.
- 0’dan küçük değerlerde puan otomatik olarak **0** yapılır.
- Uygunsuz bir giriş olduğunda kullanıcı bilgilendirilir.

Bu özellik, veri bütünlüğü sağlamak için tasarlanmıştır.

---

### **Kurucular (Constructors)**

Sınıf içinde iki farklı kurucu (constructor) bulunmaktadır:

1. **Boş Kurucu:**  
   Nesne hiçbir bilgi verilmeden oluşturulduğunda varsayılan değerler atanır.

2. **Parametreli Kurucu:**  
   Filmle ilgili tüm bilgileri tek seferde alarak nesneyi oluşturur.  
   Bu yöntem, kullanım kolaylığı sağlar ve tekrar eden kod ihtiyacını ortadan kaldırır.

---

### **Davranış Metotları**

Film nesnesine belirli işlevler kazandırmak için çeşitli metotlar tanımlanmıştır:

- **PuanArtir(miktar):**  
  Filmin puanını artıran bir metot.  
  Artış işlemi, yine puan doğrulama kurallarına uygun şekilde gerçekleştirilir.

- **SureArttir(ekSure):**  
  Film süresine belirtilen dakika kadar ekleme yapar.

- **SuresiSaatDakika():**  
  Film süresini daha okunabilir bir formata çevirir:  
  *“X saat Y dakika”*

- **ToString() Override:**  
  Film nesnesi ekrana yazdırıldığında tüm bilgilerin düzenli ve tek satırda görünmesini sağlar.

---

## 3. Programın Çalışma Mantığı

**Program.cs** içinde Film sınıfının farklı şekillerde nasıl kullanılabileceği gösterilmiştir:

- Varsayılan kurucu ile nesne oluşturma.
- Parametreli kurucu ile tüm bilgileri tek adımda girme.
- Puan artırma, süre artırma gibi metotların test edilmesi.
- Yönetmen değiştirme örneği.
- LINQ kullanarak film listesinden belirli özelliklere göre filtreleme yapılması.
- Puan doğrulama mekanizmasının sınanması (10’dan büyük puan girilmesi).

Tüm nesneler, `ToString()` metodu sayesinde ekranda düzenli ve anlaşılır biçimde görüntülenir.

---

## 4. Projenin Kazanımları

Bu proje ile:

- OOP’nin temelleri gerçek bir örnek üzerinde uygulanmış,
- Property kullanımı ve veri doğrulama mantığı geliştirilmiş,
- Kurucuların avantajları görülmüş,
- Listeler ve LINQ ile basit sorgulamalar yapılmış,
- Sınıfa ait davranışların nasıl tanımlandığı öğrenilmiştir.

Sınıf yapısı hem okunabilir hem genişletilebilir olacak şekilde tasarlanmıştır.  
İstenildiğinde yeni özellik veya metot eklemek oldukça kolaydır.

---

## 5. Sonuç

Bu çalışma, OOP prensiplerini hem teorik hem pratik açıdan anlamayı kolaylaştıran sade ama işlevsel bir örnek sunar.  
Bir film nesnesinin gerçek hayattaki özelliklerinin yazılım ortamında nasıl temsil edilebileceği başarılı şekilde gösterilmiştir.

---

