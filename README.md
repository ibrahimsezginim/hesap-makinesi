# Hesap Makinesi Uygulaması

Bu proje, ASP.NET MVC Framework kullanılarak geliştirilmiş bir hesap makinesi uygulamasıdır. Kullanıcıların hesaplama yapmasına ve sonuçları kaydetmesine olanak tanır. Ayrıca, kullanıcıların giriş yapabilmesi, kayıt olabilmesi ve oturum açabilmesi için gerekli işlevselliği sağlar.

## Özellikler

- *Kullanıcı Girişi ve Kaydı*: Kullanıcılar, uygulamaya giriş yapabilir ve yeni hesap oluşturabilir.
- *Hesap Makinesi*: Kullanıcılar, iki sayı arasında çeşitli matematiksel işlemler gerçekleştirebilir (toplama, çıkarma, çarpma, bölme).
- *Sonuçların Kaydedilmesi*: Hesaplama sonuçları veritabanına kaydedilir ve kullanıcıya gösterilir.
- *Sonuçların Görüntülenmesi*: Kullanıcıların geçmiş hesaplama sonuçlarına erişim sağlanır.

## Yapı

Proje, aşağıdaki ana bileşenleri içerir:

### 1. Modeller

- *User*: Kullanıcı bilgilerini temsil eder. E-posta, şifre ve hesaplama sonuçlarını içerir.
- *Result*: Hesaplama sonuçlarını temsil eder. Sonuç ID'si, kullanıcı bilgileri, işlem türü, sayılar ve hesaplama sonucu içerir.
- *Calculator*: Hesap makinesi için gerekli verileri temsil eder. İlk sayı, işlem türü, ikinci sayı ve sonuç içerir.

### 2. Veritabanı Bağlantısı

- *MyDbContext*: Veritabanı bağlantısını ve ilgili tabloları temsil eder. Users ve Results tablosunu içerir.

### 3. Mevcut Kullanıcı

- *CurrentUser*: Mevcut kullanıcı bilgilerini depolar (e-posta ve kullanıcı ID'si).

### 4. Kontrolcüler

- *CalculatorController*: Hesap makinesi işlemlerini gerçekleştirir. Kullanıcının hesaplama yapabileceği bir form sunar ve hesaplama sonucunu veritabanına kaydeder.
- *AccountController*: Kullanıcı girişi, kaydı ve çıkışı işlemlerini gerçekleştirir. Giriş ve kayıt görünümleri sunar.

### 5. Görünümler

- *Login ve SignIn*: Kullanıcı girişi ve kayıt işlemleri için HTML formları içerir.
- *Calculator*: Hesap makinesi formunu içerir ve kullanıcıya hesaplama işlemi yapma imkanı sunar.

## Kurulum

1. *Proje Dosyalarını İndirin*: Proje dosyalarını yerel bilgisayarınıza indirin.

2. *Veritabanı Yapılandırması*: MyDbContext sınıfını kullanarak veritabanı yapılandırmasını yapın ve gerekli tabloları oluşturun.

3. *NuGet Paketlerini Yükleyin*: Gerekli NuGet paketlerini yüklemek için Visual Studio'da Package Manager Console kullanarak Update-Package komutunu çalıştırın.

4. *Uygulamayı Çalıştırın*: Visual Studio'da projeyi başlatın ve tarayıcıda http://localhost:xxxx adresine giderek uygulamayı test edin.

## Kullanım

1. *Kullanıcı Girişi ve Kaydı*: Login veya SignIn sayfalarına giderek kullanıcı girişi yapabilir veya yeni hesap oluşturabilirsiniz.

2. *Hesap Makinesi Kullanımı*: Calculator sayfasına gidin. İki sayı ve işlem türünü seçtikten sonra hesaplama yapabilirsiniz. Hesaplama sonucu anında gösterilir ve veritabanına kaydedilir.

3. *Sonuçların Görüntülenmesi*: Hesaplama sonuçları, veritabanında saklanır ve kullanıcıların geçmiş hesaplamalarına erişim sağlar.

---

Projeye öneri veya katkıda bulunmak isterseniz, [Linkedin](https://www.linkedin.com/in/ibrahimsezginim) profilimi ziyaret edebilir veya [e-posta](mailto:benibrahimsezgin@outlook.com) ile bana ulaşabilirsiniz.
