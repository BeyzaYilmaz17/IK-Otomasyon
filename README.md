# İK Otomasyon (N Katmanlı Mimari)

**İK Otomasyon**, bir kurumun İnsan Kaynakları süreçlerini (personel, departman, izin, performans, maaş, raporlama vb.) daha düzenli ve sürdürülebilir şekilde yönetmek amacıyla geliştirilmiş **C# WinForms** tabanlı bir masaüstü uygulamasıdır. Proje **N Katmanlı (Entities / DAL / BLL / UI)** mimari ile kurgulanmıştır. :contentReference[oaicite:1]{index=1}
yotube videosu / https://youtu.be/tYWtK0lMZyc?si=QuWY1eNXkFyjPTLc
---

## İçindekiler
- [Proje Özeti](#proje-özeti)
- [Mimari](#mimari)
- [Katmanlar ve Sorumlulukları](#katmanlar-ve-sorumlulukları)
- [Özellikler](#özellikler)
- [Kullanılan Teknolojiler](#kullanılan-teknolojiler)
- [Kurulum ve Çalıştırma](#kurulum-ve-çalıştırma)
- [Veritabanı ve Yapılandırma](#veritabanı-ve-yapılandırma)
- [Proje Yapısı](#proje-yapısı)
- [Geliştirme Notları](#geliştirme-notları)
- [Lisans](#lisans)

---

## Proje Özeti
Bu proje, insan kaynakları operasyonlarının tek bir uygulama üzerinden yürütülmesini hedefler. N katmanlı mimari sayesinde:
- Kod okunabilirliği artar,
- Bakım ve geliştirme kolaylaşır,
- UI ile veritabanı erişimi ayrıştırılır,
- İş kuralları (validasyon vb.) tek noktadan yönetilir.

---

## Mimari
Bu projede **N Katmanlı Mimari** kullanılmıştır:

- **Entities (Varlıklar):** Veriyi temsil eden sınıflar
- **DAL (Data Access Layer):** Veritabanı işlemleri (CRUD)
- **BLL (Business Logic Layer):** İş kuralları ve doğrulamalar
- **UI (User Interface):** WinForms arayüzü ve kullanıcı etkileşimi

Katmanlar arası bağımlılık mantığı:
`UI -> BLL -> DAL -> DB`  
`Entities` ise tüm katmanlar tarafından model olarak kullanılır.

---

## Katmanlar ve Sorumlulukları

### 1) IKotomasyonEntities
Veritabanı tablolarına karşılık gelen **Entity sınıfları** burada yer alır.  
Örnek mantık:
- Personel, Departman, İzin, Performans, Maaş gibi nesneler
- Sadece alanlar/properties + gerekirse basit constructor’lar

### 2) IKotomasyonDAL
Veritabanı erişim katmanı:
- Bağlantı (Connection)
- Sorgular
- CRUD operasyonları
- Repository/Helper yapıları (projeye göre)

> Not: Burada UI ile doğrudan SQL yazmak yerine DAL üzerinden erişim hedeflenmiştir.

### 3) IKotomasyonBLL
İş kuralları katmanı:
- Validasyon (örn. zorunlu alan kontrolü)
- Hesaplamalar (örn. performans puanı ortalaması gibi)
- UI’dan gelen talepleri DAL’e uygun şekilde yönlendirme

### 4) IKotomasyonUI
WinForms arayüzü:
- Formlar, ekranlar, DataGridView’ler, ComboBox’lar, Chart’lar
- Kullanıcı girişleri ve olaylar (button click, form load vb.)
- BLL çağrıları ile veri çekme/gösterme

---

## Özellikler
Projenin hedeflediği / kapsadığı tipik modüller:

- **Giriş / Yetkilendirme**
  - Yönetici / İK / Personel gibi rollere göre ekran yönlendirme (proje tasarımına göre)

- **Personel Yönetimi**
  - Personel listeleme / ekleme / güncelleme / silme
  - Filtreleme (departmana göre, duruma göre vb.)

- **Departman Yönetimi**
  - Departman ekleme / güncelleme
  - Departmana bağlı personel görüntüleme

- **İzin Yönetimi**
  - İzin talebi oluşturma
  - İzin onay/ret süreçleri (rol bazlı)

- **Performans**
  - Performans kayıtları görüntüleme
  - Puan/aktif-pasif kırılımı ve raporlama ekranları (Chart ile)

- **Maaş**
  - Maaş verileri yönetimi (projeye göre)

- **Raporlama**
  - Seçilen konuya göre rapor gridleri
  - Özet metrikler ve grafikler (örn. pasta grafik / dağılım)

> Bu maddeler, projedeki ekranlara göre geliştirilebilir/özelleştirilebilir.

---

## Kullanılan Teknolojiler
- **C# / .NET (WinForms)**
- **N Katmanlı Mimari (Entities - DAL - BLL - UI)**
- **Veritabanı:** MySQL (projede kullanılan yapıya göre)
- **UI bileşenleri:** DataGridView, ComboBox, Chart vb.

---

## Kurulum ve Çalıştırma

### Gereksinimler
- Visual Studio (Örn. 2022)
- .NET Framework / .NET sürümü (projeye göre)
- MySQL Server (veya projede kullanılan veritabanı)
- MySQL Connector / `MySql.Data` (NuGet paketleri)

### Adım adım çalıştırma
1. Depoyu klonla:
   ```bash
   git clone https://github.com/BeyzaYilmaz17/IK-Otomasyon.git
