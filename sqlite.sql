CREATE TABLE IF NOT EXISTS kullanicilar (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    username VARCHAR(30) NOT NULL,
    password VARCHAR(128) NOT NULL,
    email VARCHAR(254) NOT NULL,
    name VARCHAR(255) NOT NULL,
    surname VARCHAR(255) NOT NULL,
    role INT(1) DEFAULT 0,
    createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE IF NOT EXISTS musteriler (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    ad VARCHAR(55) NOT NULL,
    soyad VARCHAR(55) NOT NULL,
    tckn VARCHAR(11) NOT NULL,
    cinsiyet VARCHAR(10) NOT NULL,
    dogum DATE NOT NULL,
    telefon VARCHAR(11) NOT NULL,
    adres VARCHAR(255) NOT NULL,
    email VARCHAR(254) NOT NULL,
    tarih DATETIME DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE IF NOT EXISTS araclar (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    sahibi INT DEFAULT NULL,
    durum VARCHAR(10) NOT NULL,
    sinif VARCHAR(50) NOT NULL,
    marka VARCHAR(50) NOT NULL,
    model VARCHAR(50) NOT NULL,
    renk VARCHAR(50) NOT NULL,
    yil INT NOT NULL,
    km INT NOT NULL,
    plaka VARCHAR(20) NOT NULL,
    sasi VARCHAR(17) NOT NULL,
    kiralama_ucreti DECIMAL(10, 2) NOT NULL,
    satis_ucreti DECIMAL(10, 2) NOT NULL,
    kiralayan INT DEFAULT NULL,
    aciklama TEXT,
    gorsel TEXT DEFAULT NULL,
    createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (sahibi) REFERENCES musteriler(id)
);

CREATE TABLE IF NOT EXISTS kiralama (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    musteri_id INT NOT NULL,
    arac_id INT NOT NULL,
    kiralama_tarihi DATE NOT NULL,
    iade_tarihi DATE NOT NULL,
    ucret DECIMAL(10, 2) NOT NULL,
    odeme_turu VARCHAR(10) NOT NULL,
    createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (musteri_id) REFERENCES musteriler(id),
    FOREIGN KEY (arac_id) REFERENCES araclar(id)
);

CREATE TABLE IF NOT EXISTS satis (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    musteri_id INT NOT NULL,
    arac_id INT NOT NULL,
    satis_tarihi DATE NOT NULL,
    ucret DECIMAL(10, 2) NOT NULL,
    odeme_turu VARCHAR(10) NOT NULL,
    createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (musteri_id) REFERENCES musteriler(id),
    FOREIGN KEY (arac_id) REFERENCES araclar(id)
);


CREATE TABLE IF NOT EXISTS odemeler (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    islem_no VARCHAR(255) NOT NULL,
    kira_id INT DEFAULT 0,
    satis_id INT DEFAULT 0,
    odeme_durumu INT(1) DEFAULT 0,
    aciklama TEXT,
    odeme_tarihi DATE NOT NULL,
    FOREIGN KEY (kira_id) REFERENCES kiralama(id),
    FOREIGN KEY (satis_id) REFERENCES satis(id)
);

    INSERT INTO kullanicilar (username, password, email, name, surname, role)
    VALUES 
        ('admin', 'admin123', 'admin@arac.local', 'ADMIN', 'ACCOUNT', 1),
        ('guray', '123456', '222203578@ogr.uludag.edu.tr' , 'GURAY', 'ALIN', 0);

INSERT INTO musteriler (ad, soyad, tckn, cinsiyet, dogum, telefon, adres, email)
VALUES
	('GALERİ', 'SAHİBİ', '12345678901', 'ERKEK', '2000-01-01', '05551234567', 'BURSA', 'galeri@arac.local'),
    ('ÖRNEK', 'MÜŞTERİ', '12345678901', 'ERKEK', '2000-01-01', '05551234567', 'BURSA', 'musteri@arac.local');

INSERT INTO araclar (sahibi, durum, sinif, marka, model, renk, yil, km, plaka, sasi, kiralama_ucreti, satis_ucreti,kiralayan, aciklama, gorsel)
VALUES 
    (1, 'SATILIK', 'KAMYONET', 'FORD', 'RANGER', 'SIYAH', 2023, 12000, '16ABC16', '56789012345678901', 2000.00, 2200000.00,1 ,'Kasa boyası yenilendi.  - Debug','C:\Users\guray\source\repos\gorsel\arac\bin\Debug\net8.0-windows\win-x64\assets\img\car.png'),
    (1, 'KİRALIK', 'SUV', 'VOLVO', 'XC90', 'ŞAMPANYA', 2023, 9200, '16ABC16', '56789012345678902', 3000.00, 4200000.00,1 ,'Yedek anahtar kayıp. - Release','C:\Users\guray\source\repos\gorsel\arac\bin\Debug\net8.0-windows\win-x64\assets\img\car.png');



INSERT INTO kiralama (musteri_id, arac_id, kiralama_tarihi, iade_tarihi, ucret, odeme_turu)
VALUES
    (2, 2, '2024-01-01', '2024-02-01', 90000.00, 'NAKIT');

INSERT INTO satis (musteri_id, arac_id, satis_tarihi, ucret, odeme_turu)
VALUES
    (2, 1, '2024-01-01', 4200000.00, 'KREDI');

INSERT INTO odemeler (islem_no, kira_id, satis_id, odeme_durumu, aciklama, odeme_tarihi)
VALUES
    ('KIRALAMA-1', 1, 0, 1, 'Nakit ile ödendi.', '2024-02-01'),
    ('SATIS-1', 0, 1, 1, 'Kredi ile ödendi.', '2024-01-01');
