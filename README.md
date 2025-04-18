# 👋 Merhaba, eğitmenliğini Murat Yücedağ hocamın sağladığı  ve youtube üzerinde yayınladığı Traversal serisini tamamladım. Aşağıda sizlere projemden bahsedeceğim


# 💾Projemde Kullandığım Teknolojiler

## 🪫 Projemi dinamik bir hale getirmek için Asp.Net Core (.Net Core Framework) kullandım
## 🪫 Anlaşılır,olası bir sorunla karşılaşıldığı zaman, zaman kaybeden sorunun kaynağına ulaşmak için kısacası kontrol altına alabilmek için SOLID Prensiplerine uymaya çalıştım
## 🪫 Tasarım kısımlarının bulunduğu UI Sayfalarını PartialView yapısını kullanarak parçalara bölüp daha düzenli ve kontrol edilebilir bir yapı oluşturdum
## 🪫 N Katmanlı mimari ve  MVC yapısını kullandım, böylece uygulamanın katmanlarını birbirinden ayırarak daha sürdürülebilir bir yapı oluşturdum
## 🪫 Entity Framework CodeFirst yapısını kullanarak projem ile veri tabanı(MSSQL)'in haberleşmesini sağladım
## 🪫 Okuma ve yazma işlemlerini birbirinden ayırmak için CQRS Design Pattern Kullandım
## 🪫 Belirli alanları veri tabanından çekmek için DTO(Data-Transfer-Object) yapısını kullandım
## 🪫 Entity İle DTO Arasında dönüşümü otomatikleştirmek için Mapping yapısını kullandım. Bu işlemi otomatik yapmak için ise AutoMapper kullandım.
## 🪫 İstemci ve sunucu arasında anlık olarak veri aktarımı sağlamak için SignalR Kullandım.
## 🪫Authentication Ve authorization yapısını kullanarak kullanıcıların giriş yapmadan admin ve kullanıcı panellerine  ve izinleri olmayan sayfalara  erişim sağlamamalarına engel olmaya çalıştım.
## 
## 💊 Tam olarak 7 Adet katman üzerinde çalıştım. Bunlar;
### 🔹 Presentation Layer (Sunum Katmanı) : Kullanıcıya sunulan arayüzü barındırır
### 🔹 Business Logic Layer (İş Mantığı Katmanı) : Uygulamanın kurallarını ve iş mantığını barındırır
### 🔹 Data Access Layer (Veri Erişim Katmanı) : Veri tabanı ile uygulama arasında bağlantı kurmayı sağlayan katmandır
### 🔹 Entity Layer (Varlık Katmanı) : Codefirst yaklaşımını barındıran ve verilen saklandığı bir katmandır.
### 🔹 Projede örnek olarak çalışmak adına API Katmanı'nı  : İstemci ve sunucu arasında köprü kurarak farklı platformlar arası veri alışverişini sağlar. Peki ben API Katmanını neden kullandım?
#### Anlık olarak siteye giriş yapan kullanıcıların  bulunduğu ülkeleri anlık olarak dinamik bir yapıya sahip grafik üzerinde gösterdim
### 🔹 API Consume Katmanı: Bu katmanda ise API'yi tükettim.

# NOT : Proje'nin front end kısmında değiştirilmesi, back-end kısmında ise eklenilmesi gereken yerler olabilir. Zaman geçtikçe proje güncellenebilir.

# 🔗Projede 3 Farklı Alan Bize Eşlik Eder

# 🖇Admin Paneli : Rolü Admin olan kullanıcılar sayfaya erişim sağlayarak; rotalar,yorumlar,üyeler,mesajlar,rehberler ve duyurular gibi alanlar üzerinde CRUD(Create, Read,Update,Delete) işlemlerini yapabilir
# 🖇Kullanıcı/Üye Paneli : Rolü Kullanıcı olanların sayfaya erişim sağlayarak; Rezervasyonlarını(Aktif-Geçmiş-Onay Bekleyen), Profil düzenleme gibi sayfalara erişim sağlayabilir
# 🖇Vitrin Paneli : Rol gerekmeksizin herkesin Traversal Seyahat/Rezervasyon sitesine erişim sağlayıp rotalar,rehberler,iletişim bilgileri gibi verileri görüntüleyebilir

# 🧑🏻‍💻 Admin Paneli

# Admin rolündeki kullanıcı, aşağıdaki resimlerde bulunan alanlardaki her şey üzerinde değişiklik yapabilir. Bunlar;

# 📍Dashboard
## Admin, şirketin durumu ile ilgili tüm istatistikleri buradan görüntüleyebilir
![Image Alt](https://github.com/SemihSanli/TraversalCore/blob/a6dfce3aa583cd1130f6c1baa0d3fcd62f1b0ac9/ScreenShots/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-18%20162735.png)
# 📍Tur Rotaları
## Admin aktif olan tur rotalarını görüntüleyip gerekli CRUD işlemlerini burada yapabilir
![ImageAlt](https://github.com/SemihSanli/TraversalCore/blob/a6dfce3aa583cd1130f6c1baa0d3fcd62f1b0ac9/ScreenShots/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-16%20180912.png)
![ImageAlt](https://github.com/SemihSanli/TraversalCore/blob/a6dfce3aa583cd1130f6c1baa0d3fcd62f1b0ac9/ScreenShots/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-18%20155612.png)
![ImageAlt](https://github.com/SemihSanli/TraversalCore/blob/a6dfce3aa583cd1130f6c1baa0d3fcd62f1b0ac9/ScreenShots/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-18%20155628.png)

# 📍Rehber Listesi
## Admin tüm rehberleri burada görüntüleyip; Aktif-Pasif durumunu değiştirebilir, güncelleyebilir ve yeni rehber eklemesi yapabilir
![ImageAlt](https://github.com/SemihSanli/TraversalCore/blob/a6dfce3aa583cd1130f6c1baa0d3fcd62f1b0ac9/ScreenShots/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-16%20180942.png)
![ImageAlt](https://github.com/SemihSanli/TraversalCore/blob/a6dfce3aa583cd1130f6c1baa0d3fcd62f1b0ac9/ScreenShots/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-18%20161042.png)

# 📍Raporlar
## Admin şirketin durumu ile ilgili PDF Raporu oluşturabilir
![ImageAlt](https://github.com/SemihSanli/TraversalCore/blob/a6dfce3aa583cd1130f6c1baa0d3fcd62f1b0ac9/ScreenShots/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-16%20180949.png)


# 📍Mail Gönderme Sayfası
## Admin buradan kullanıcılara mail gönderimi yapabilir
![ImageAlt](https://github.com/SemihSanli/TraversalCore/blob/a6dfce3aa583cd1130f6c1baa0d3fcd62f1b0ac9/ScreenShots/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-16%20181000.png)

# 📍Rol Listesi
## Admin buraya rol eklemesi-silmesi ve güncellemesi yapabilir
![ImageAlt](https://github.com/SemihSanli/TraversalCore/blob/a6dfce3aa583cd1130f6c1baa0d3fcd62f1b0ac9/ScreenShots/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-16%20181008.png)
![ImageAlt](https://github.com/SemihSanli/TraversalCore/blob/a6dfce3aa583cd1130f6c1baa0d3fcd62f1b0ac9/ScreenShots/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-18%20162420.png)
![ImageAlt](https://github.com/SemihSanli/TraversalCore/blob/a6dfce3aa583cd1130f6c1baa0d3fcd62f1b0ac9/ScreenShots/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-18%20162719.png)

# 📍Rol İşlemleri
## Admin sistemi kullanan kullanıcıların üzerinde rol işlemleri gerçekleştirebilir
![ImageAlt](https://github.com/SemihSanli/TraversalCore/blob/a6dfce3aa583cd1130f6c1baa0d3fcd62f1b0ac9/ScreenShots/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-18%20162716.png)

# 👨🏻‍🔬Kullanıcı Paneli
##  Login paneli üzerinden giriş yapmış olan kullanıcı, aşağıdaki resimlerde bulunan tüm bölgeleri görüntüleyebilir

# 💎 Dashboard
## Kullanıcı profil bilgilerini,profil ayarlarını, aktif olan tur rehberlerini burada görüntüleyebilir.
![ImageAlt](https://github.com/SemihSanli/TraversalCore/blob/a6dfce3aa583cd1130f6c1baa0d3fcd62f1b0ac9/ScreenShots/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-18%20120156.png)

# 💎 Son Rotalar
## Kullanıcı Admin'in eklediği son tur rotalarını burada görüntüler
![ImageAlt](https://github.com/SemihSanli/TraversalCore/blob/d4d7b1d8e5b478f03e30e621060eba6f6f82e405/ScreenShots/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-18%20120208.png)

# 💎 Profilim
## Kullanıcı Profil bilgilerini görüntüleyip, isterse güncelleyebilir
![ImageAlt](https://github.com/SemihSanli/TraversalCore/blob/d4d7b1d8e5b478f03e30e621060eba6f6f82e405/ScreenShots/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-18%20120216.png)

# 💎 Akitf-Geçmiş-Onay Bekleyen Rezervasyonlarım-Yeni Rezervasyon 
## Kullanıcı bu sayfalarda rezervasyonları ile ilgili bilgileri görüntüleyip dilerse yeni rezervasyon yapabilir
![ImageAlt](https://github.com/SemihSanli/TraversalCore/blob/d4d7b1d8e5b478f03e30e621060eba6f6f82e405/ScreenShots/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-18%20120221.png)
![ImageAlt](https://github.com/SemihSanli/TraversalCore/blob/d4d7b1d8e5b478f03e30e621060eba6f6f82e405/ScreenShots/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-18%20120259.png)
![ImageAlt](https://github.com/SemihSanli/TraversalCore/blob/d4d7b1d8e5b478f03e30e621060eba6f6f82e405/ScreenShots/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-18%20120304.png)
![ImageAlt](https://github.com/SemihSanli/TraversalCore/blob/d4d7b1d8e5b478f03e30e621060eba6f6f82e405/ScreenShots/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-18%20120310.png)

# 🪟 Vitrin Paneli
![ImageAlt](https://github.com/SemihSanli/TraversalCore/blob/d4d7b1d8e5b478f03e30e621060eba6f6f82e405/ScreenShots/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-18%20120320.png)
# 💎 Misafirler aktif tur rotalarını buradan görüntüleyip. Üzerlerine tıklayarak tur ile ilgili bilgi alabilir
![ImageAlt](https://github.com/SemihSanli/TraversalCore/blob/d4d7b1d8e5b478f03e30e621060eba6f6f82e405/ScreenShots/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-18%20120330.png)
![ImageAlt](https://github.com/SemihSanli/TraversalCore/blob/d4d7b1d8e5b478f03e30e621060eba6f6f82e405/ScreenShots/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-18%20120336.png)
![ImageAlt](https://github.com/SemihSanli/TraversalCore/blob/d4d7b1d8e5b478f03e30e621060eba6f6f82e405/ScreenShots/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-18%20120342.png)
![ImageAlt](https://github.com/SemihSanli/TraversalCore/blob/d4d7b1d8e5b478f03e30e621060eba6f6f82e405/ScreenShots/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-18%20120347.png)
![ImageAlt](https://github.com/SemihSanli/TraversalCore/blob/d4d7b1d8e5b478f03e30e621060eba6f6f82e405/ScreenShots/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-18%20120416.png)
![ImageAlt](https://github.com/SemihSanli/TraversalCore/blob/d4d7b1d8e5b478f03e30e621060eba6f6f82e405/ScreenShots/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202025-04-18%20120426.png)
