# Library Management System

Bu proje, C# dilinde SOLID prensiplerine ve OOP (Object-Oriented Programming) kurallarına uygun olarak geliştirilmiş bir kütüphane yönetim sistemidir.

## Genel Bakış

Proje, kütüphane yönetimi için temel operasyonları içermektedir: üye ekleme, kitap ekleme, kitap ödünç alma, kitap iade etme, üye ve kitap listeleme gibi işlemleri içermektedir. Proje, SOLID prensiplerini takip ederek, genişletilebilir, bakımı kolay ve yeniden kullanılabilir bir yapı üzerine kurulmuştur.

## Kullanılan Prensipler

Projede aşağıdaki SOLID prensipleri ve OOP kuralları uygulanmıştır:

1. **Single Responsibility Principle (SRP):** Her sınıf ve metod yalnızca bir sorumluluğa sahiptir. Örneğin, `MemberManager` sınıfı sadece üye işlemleriyle ilgilenir.

2. **Open/Closed Principle (OCP):** Sınıflar, değişiklik yapmadan genişletilebilir olmalıdır. Yeni özellikler eklemek için mevcut kodu değiştirmemelisiniz. Örneğin, yeni bir ödünç alma stratejisi eklemek için `IBarrowStrategy` kullanılır.

3. **Liskov Substitution Principle (LSP):** Alt sınıflar, üst sınıfların yerine kullanılabilir olmalıdır. Örneğin, `IBarrowStrategy` interface'i, farklı ödünç alma stratejilerini temsil eden sınıflar tarafından uygulanır.

4. **Interface Segregation Principle (ISP):** Bir sınıfın ihtiyacı olmayan özelliklere bağlı olmamalıdır. Örneğin, `IBarrowStrategy` sadece ödünç alma işlemini tanımlar.

5. **Dependency Inversion Principle (DIP):** Üst seviye modüller, alt seviye modüllere bağlı olmamalıdır. Her ikisi de soyutlamalara bağlı olmalıdır. Örneğin, `LibraryManager` sınıfı, `IinMemoryMemberDal` ve `IinMemoryBookDal` gibi soyut veri erişim katmanlarına bağımlıdır.

## Proje Yapısı

Proje, aşağıdaki temel bileşenleri içermektedir:

- **Business Layer:** İş mantığı işlemlerini içeren sınıfları içerir. Örneğin, `LibraryManager`, `MemberManager`, ve `BookManager`.

- **Data Access Layer:** Veri erişim işlemlerini içeren sınıfları içerir. Örneğin, `InMemoryMemberDal` ve `InMemoryBookDal`.

- **Entities:** Temel nesne sınıflarını içerir. Örneğin, `Member` ve `Book`.

- **LibraryManagementSystem:** Sunum katmanı olarakta değerlendirilebilir. İsterleri test eden ekibin işini kolaylaştırmak için her olasılık ekrana basılmıştır. 

## Kurulum

Proje klonlandıktan sonra, Visual Studio veya başka bir C# geliştirme ortamında açabilir ve derleyebilirsiniz. LibraryManagementSystem klasörü içerisindeki Program.cs dosyasını çalıştırarak çıktıyı görebilirsiniz.
