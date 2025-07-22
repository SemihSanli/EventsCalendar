# EventCalendar

## Proje Hakkında
EventCalendar, kullanıcıların etkinlik ve kategori yönetimi yapabildiği, etkinlikleri takvim üzerinde sürükle-bırak ile planlayabildiği modern bir web uygulamasıdır. Kullanıcılar etkinlik ekleyebilir, kategorilere renk atayabilir, etkinlikleri takvimde istediği tarihe taşıyabilir ve tüm verileri görsel olarak yönetebilir.

## Kullanılan Teknolojiler
- **ASP.NET MVC 5** (Backend ve View yönetimi)
- **Entity Framework** (ORM, Code First veri tabanı yönetimi)
- **SQL Server** (Veri tabanı)
- **jQuery** (Frontend etkileşimleri)
- **FullCalendar.js** (Takvim ve sürükle-bırak desteği)
- **Bootstrap 4** (Responsive ve modern arayüz)
- **AdminLTE** (Hazır yönetim paneli teması)

## Kurulum
1. **Projeyi klonlayın veya indirin.**
2. **Visual Studio ile açın.**
3. Gerekirse `packages.config` ile NuGet paketlerini yükleyin.
4. **Veri tabanını oluşturmak için:**
   - Migration'ları uygulayın: 
     - `Update-Database` (Package Manager Console üzerinden)
5. **Projeyi başlatın (F5 veya Ctrl+F5).**

## Kullanım Senaryoları
### 1. Kategori Yönetimi
- Kullanıcı yeni bir kategori ekleyebilir (isim ve renk seçimiyle).
- Kategoriler modern kart yapısında, kendi renklerinin koyu tonuyla listelenir.
- Kategoriler güncellenebilir veya silinebilir.

### 2. Etkinlik Yönetimi
- Kullanıcı yeni bir etkinlik ekleyebilir (başlık ve kategori seçerek).
- Eklenen etkinlikler, takvimde kategori rengine göre gösterilir.
- Etkinlikler takvimde sürüklenip başka bir tarihe taşınabilir.
- Etkinlikler güncellenebilir veya silinebilir.
- Tüm etkinlikler ay ay gruplandırılmış, kart yapısında ve renkli şekilde listelenir.

### 3. Takvim Üzerinde Sürükle-Bırak
- Sol paneldeki etkinlik kutucukları takvime sürüklenip bırakılabilir.
- Takvimdeki bir etkinlik başka bir tarihe taşındığında, veri tabanında tarihi güncellenir.

## Kullanıcı Akışı
1. **Kategori ekle:** Renk ve isim seçerek yeni kategori oluştur.
2. **Etkinlik ekle:** Başlık ve kategori seçerek yeni etkinlik oluştur.
3. **Etkinlikleri takvimde gör:** Tüm etkinlikler, kategori rengine göre takvimde gösterilir.
4. **Etkinliği sürükle-bırak:** Takvimde etkinliği başka bir tarihe taşı.
5. **Etkinlik ve kategori güncelle/sil:** Kartlar üzerindeki butonlarla işlemleri yap.
6. **Etkinlik ve kategori listelerini modern kart yapısında incele.**

## Geliştirme Adımları
- Entity ve migration yapısı oluşturuldu.
- Controller ve View'lar hazırlandı.
- FullCalendar ile takvim ve sürükle-bırak entegrasyonu sağlandı.
- Kategori ve etkinlikler için CRUD işlemleri eklendi.
- Modern ve renkli kart tasarımları uygulandı.
- Tüm işlemler backend ile tam entegre edildi.

## Katkı ve Geliştirme
- Projeyi fork'layıp pull request gönderebilirsiniz.
- Yeni özellik önerileri ve hata bildirimleri için issue açabilirsiniz.

---
**Hazırlayan:** [Senin Adın]  
**Tarih:** 2025 