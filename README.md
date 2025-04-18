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

# Projede 3 Farklı Alan Bize Eşlik Eder

# Admin Paneli : Rolü Admin olan kullanıcılar sayfaya erişim sağlayarak; rotalar,yorumlar,üyeler,mesajlar,rehberler ve duyurular gibi alanlar üzerinde CRUD(Create, Read,Update,Delete) işlemlerini yapabilir
# Kullanıcı/Üye Paneli : Rolü Kullanıcı olanların sayfaya erişim sağlayarak; Rezervasyonlarını(Aktif-Geçmiş-Onay Bekleyen), Profil düzenleme gibi sayfalara erişim sağlayabilir
# Vitrin Paneli : Rol gerekmeksizin herkesin Traversal Seyahat/Rezervasyon sitesine erişim sağlayıp rotalar,rehberler,iletişim bilgileri gibi verileri görüntüleyebilir

# 🧑🏻‍💻 Admin Paneli

# Admin rolündeki kullanıcı, aşağıdaki resimlerde bulunan alanlardaki her şey üzerinde değişiklik yapabilir. Bunlar;
