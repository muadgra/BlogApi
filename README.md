# BlogApi Kullanımı


<h4>Tanıtım</h4>
  <p>
    MSSQL veritabanı kullanarak oluşturduğum API'de, Entity Framework yardımıyla "Code First" yaklaşımında bulundum.
    Olabildiğince basit hazırlamak için, Paylaşım ve Yorumların uzunlukları gibi parametreleri kontrol etmedim.
    Hazırladığım Web API'de ilk kullanıcıları eklerken kolaylık sağlaması adına Index sayfasında "Kullanıcı Ekleme" kısmı bulunmaktadır.
    Postman uygulaması yardımıyla GET ve POST metotları kontrol edilmiştir.
    İsteklerde JSON formatı kullanılmıştır.
  </p>
<h4> Blog Paylaşımı Ekleme </h4>


![post](https://user-images.githubusercontent.com/44258022/134241423-7ec44e90-62de-4074-9f7b-f7cd2b00a491.png)

<h4> Blog Paylaşımlarına Yorum Ekleme </h4>

Paylaşım ekleme ile neredeyse aynı şekilde işler. Değişen kısım, action isminin "PaylasimEkle" yerine "YorumEkle" olmasıdır.

<h4> Tüm Blog Paylaşımlarını Çekme </h4>

./api/HomeApi/PaylasimlariCek endpointi kullanılır. Sonuç aşağıdakai gibi olur.

![get](https://user-images.githubusercontent.com/44258022/134241970-7dabafb3-280f-4ac5-9f9b-6002eddf308d.png)

<h4> Id ile Blog Paylaşımı Çekme </h4>

x yerine id konulduğunda döndürülür.
./api/HomeApi/PaylasimGetir/?id=x

![getpaylasim](https://user-images.githubusercontent.com/44258022/134242649-89b642ef-5dbb-4ea7-aa77-75d50a2b8a02.png)
