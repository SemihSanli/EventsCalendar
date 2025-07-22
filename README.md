# 📅 EventCalendar - Modern Etkinlik Takvimi Uygulaması

---

## 📌 Proje Hakkında

**EventCalendar**, kullanıcıların etkinlik ve kategori yönetimi yapabildiği, etkinlikleri takvim üzerinde 🎯 *sürükle-bırak* ile planlayabildiği modern bir web uygulamasıdır.  
📝 Kullanıcılar etkinlik ekleyebilir, kategorilere renk atayabilir, etkinlikleri takvimde istediği tarihe taşıyabilir ve tüm verileri **görsel** olarak yönetebilir.

---

## ⚙️ Kullanılan Teknolojiler

| Teknoloji        | Açıklama                                  |
|------------------|--------------------------------------------|
| 🔧 ASP.NET MVC 5 | Backend ve View yönetimi                  |
| 🛠️ Entity Framework | ORM, Code First veri tabanı yönetimi    |
| 🗄️ SQL Server     | Veritabanı yönetimi                       |
| 💡 jQuery         | Frontend etkileşimleri                    |
| 📆 FullCalendar.js | Takvim & sürükle-bırak özelliği          |
| 🎨 Bootstrap 4    | Responsive ve modern UI tasarımı         |
| 🧱 AdminLTE       | Hazır yönetim paneli teması              |

---





## 🧪 Kullanım Senaryoları

### 🎨 1. Kategori Yönetimi
- ➕ Yeni kategori eklenebilir (isim + renk seçimi).
- 🧱 Kart yapısında, kategori renginin koyu tonu ile gösterilir.
- ✏️ Kategoriler güncellenebilir, 🗑️ silinebilir.

### 🗓️ 2. Etkinlik Yönetimi
- ➕ Yeni etkinlik eklenebilir (başlık + kategori seçimi).
- 🌈 Etkinlikler, kategori rengine göre takvimde gösterilir.
- 🔄 Etkinlikler takvimde tarih değiştirerek taşınabilir.
- ✏️ Güncelleme ve 🗑️ silme işlemleri desteklenir.
- 📦 Etkinlikler ay bazında, kartlarla listelenir.

### 🖱️ 3. Takvim Üzerinde Sürükle-Bırak
- 🎯 Sol paneldeki etkinlik kutuları takvime sürüklenebilir.
- 📝 Takvimdeki etkinlik başka bir tarihe taşındığında, veritabanında otomatik güncellenir.

---

## 👤 Kullanıcı Akışı

1. 🎨 **Kategori Ekle:** Renk ve isim belirleyerek yeni kategori oluştur.
2. ➕ **Etkinlik Ekle:** Başlık + kategori seçimi ile etkinlik oluştur.
3. 📆 **Etkinlikleri Takvimde Gör:** Kategorilere göre renklendirilmiş şekilde.
4. 🚚 **Sürükle-Bırak:** Takvimde tarih değiştir.
5. ✏️ **Güncelle/Sil:** Kartlar üzerinden işlemler yapılabilir.
6. 🧱 **Modern Kart Listeleme:** Tüm veriler şık kartlar halinde.

---

## 🛠️ Geliştirme Aşamaları

- ✅ Entity ve Migration yapısı oluşturuldu.
- ✅ Controller ve View’lar tanımlandı.
- ✅ FullCalendar ile takvim ve drag-drop sistemi entegre edildi.
- ✅ Kategori ve Etkinlik CRUD işlemleri tamamlandı.
- ✅ Kart bazlı modern tasarımlar geliştirildi.
- ✅ Backend ile tam senkron çalışma sağlandı.

---



> 💡 Bu proje, görsel yönetim ve kullanıcı dostu arayüz ile etkinlik planlamasını kolaylaştırmak için tasarlandı.
