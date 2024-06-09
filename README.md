
# 🚀 Visual Basic .NET - MSSQL | Araç Satış/Kiralama Uygulaması
<p align="center">
  <picture>
	<img src="https://github.com/gurayalinn/arac/assets/99608413/0638c7ec-0aef-41a0-ab05-918e910abc63" width=66% height=auto alt="banner" />
</picture>
</p>

---

> **Note:** Bu proje, Visual Basic .NET ile SQLite/MSSQL veritabanı kullanarak araç satış ve kiralama işlemlerini gerçekleştiren otomasyon uygulamasıdır.

## ⚙️ Kurulum:

### 📝 Geliştirme Ortamı

> **Note:** Bu projeyi çalıştırmak için aşağıdaki yazılımların yüklü olması gerekmektedir.
- 📦 Visual Studio 2022 - [Download](https://visualstudio.microsoft.com/tr/downloads/)
- 📦 .Net 8.0 SDK - [Download](https://dotnet.microsoft.com/download/dotnet/8.0)
- 📦 Git - [Download](https://git-scm.com/downloads)
- 📦 SQLite - Projeye dahil
- 📦 Docker Desktop (Opsiyonel)
- 📦 MSSQL 2022 Server (Opsiyonel)
- 📦 SQL Server Management Studio 20 (Opsiyonel)

> **Not:** SQL Server Bağlantısı:

```vb
' SQL Server Connection
Dim connectionString As String = "Persist Security Info=False;User ID=sa;Password=!#1Password;Initial Catalog=arac;Server=127.0.0.1;Encrypt=False;"
```

```powershell
$ docker pull mcr.microsoft.com/mssql/server:2022-latest

$ docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=!#1Password" -p 1433:1433 --name mssql --hostname mssql -d mcr.microsoft.com/mssql/server:2022-latest
```

- SSMS - Login
- Server Type: Database Engine
- Server name: 127.0.0.1, 1433
- Authentication: SQL Server Authentication
- Login: sa
- Password: !#1Password
- Connection Security - Encryption: Optional

- 🌐 SQL Server [127.0.0.1:1433](http://127.0.0.1:1433) portunda çalışmaktadır.

> **Not:** SQLite Bağlantısı:

```vb
' SQLite Connection
Dim connectionString As String = "Data Source=C:\Users\%USERPROFILE%\arac\db.sqlite3;Version=3;"
```

```bash
$ mkdir C:\Users\%USERPROFILE%\arac
$ sqlite3 C:\Users\%USERPROFILE%\arac\db.sqlite3
```

### 📦 Projeyi İndirme

```bash
$ git clone https://github.com/gurayalinn/arac.git
$ cd arac
```

### 🚀 Proje gereksinimlerini yükleme ve çalıştırma

```powershell
$ dotnet restore

$ dotnet build

$ dotnet run

$ dotnet test

$ dotnet publish -c Release -o dist
```

### ⚡Projeyi Çalıştırma

📦 arac-x64.zip - [Download](https://github.com/gurayalinn/arac/releases/download/first/arac-x64.zip)

📦 .NET 8.0 - [Download](https://dotnet.microsoft.com/download/dotnet/8.0/)

- .NET 8.0 SDK yüklü olmalıdır.
- En az Windows 10 x64 işletim sistemi gereklidir.
- İndirilen dosyayı açın ve `arac.exe` dosyasını çalıştırın.
- Kullanıcı adı: `admin` ve şifre: `admin123` ile giriş yapabilirsiniz.

---

## 📃 LİSANS

<strong> &copy; 2024</strong> [APACHE-2.0](LICENSE)
