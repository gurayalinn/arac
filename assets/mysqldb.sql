SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
SET CHARACTER_SET_CLIENT = "utf8mb4";
SET CHARACTER_SET_CONNECTION = "utf8mb4";
SET CHARACTER_SET_DATABASE = "utf8mb4";

CREATE DATABASE IF NOT EXISTS `arac` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE `arac`;

START TRANSACTION;
SET time_zone = "+00:00";

-- --------------------------------------------------------
--
-- Database: `arac`
--
-- --------------------------------------------------------
-- TABLES
-- --------------------------------------------------------


DROP TABLE IF EXISTS `kullanicilar`;
CREATE TABLE IF NOT EXISTS `kullanicilar` (
    `id` INT(11) NOT NULL AUTO_INCREMENT COMMENT 'Kullanıcı ID',
    `ad` VARCHAR(255) COLLATE utf8mb4_unicode_ci NOT NULL COMMENT 'Kullanıcı Adı',
    `email` VARCHAR(65) COLLATE utf8mb4_unicode_ci NOT NULL COMMENT 'Kullanıcı Email',
    `sifre` VARCHAR(255) COLLATE utf8mb4_unicode_ci NOT NULL COMMENT 'Kullanıcı Şifre',
    `tarih` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP COMMENT 'Kayıt Tarihi',
    PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4 COLLATE utf8mb4_unicode_ci;

DROP TABLE IF EXISTS `musteriler`;
CREATE TABLE IF NOT EXISTS `musteriler` (
    `id` INT(11) NOT NULL AUTO_INCREMENT COMMENT 'ID',
    `ad` VARCHAR(255) COLLATE utf8mb4_unicode_ci NOT NULL COMMENT 'Kullanıcı Adı',
    `soyad` VARCHAR(255) COLLATE utf8mb4_unicode_ci NOT NULL COMMENT 'Kullanıcı Soyadı',
    `tckn` VARCHAR(11) COLLATE utf8mb4_unicode_ci NOT NULL COMMENT 'Kullanıcı TC veya Pasaport ID',
    `cinsiyet` ENUM('ERKEK', 'KADIN', 'DIGER') NOT NULL COMMENT 'Kullanıcı Cinsiyet',
    `dogum` DATE NOT NULL COMMENT 'Kullanıcı Doğum Tarihi',
    `telefon` VARCHAR(11) COLLATE utf8mb4_unicode_ci NOT NULL COMMENT 'Kullanıcı Telefon',
    `adres` VARCHAR(255) COLLATE utf8mb4_unicode_ci NOT NULL COMMENT 'Kullanıcı Adres',
    `email` VARCHAR(65) COLLATE utf8mb4_unicode_ci NOT NULL COMMENT 'Kullanıcı Email',
    `tarih` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP COMMENT 'Kayıt Tarihi',
    PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4 COLLATE utf8mb4_unicode_ci;

DROP TABLE IF EXISTS `arac_sinif`;
CREATE TABLE IF NOT EXISTS `arac_sinif` (
    `id` INT(11) NOT NULL AUTO_INCREMENT COMMENT 'ID',
    `sinif` VARCHAR(50) NOT NULL COMMENT 'Araç Sınıfı',
    `aciklama` TEXT DEFAULT NULL COMMENT 'Araç Sınıfı Açıklama',
    PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4 COLLATE utf8mb4_unicode_ci;

DROP TABLE IF EXISTS `araclar`;
CREATE TABLE IF NOT EXISTS `araclar` (
    `id` INT(11) NOT NULL AUTO_INCREMENT COMMENT 'Araç ID',
    `durum` ENUM('KIRALIK', 'SATILIK', 'BAKIM' ,'SATILDI') NOT NULL COMMENT 'Araç Durumu',
    `sinif_id` INT NOT NULL COMMENT 'Araç Sınıfı ID',
    `marka` VARCHAR(50) NOT NULL COMMENT 'Araç Marka',
    `model` VARCHAR(50) NOT NULL COMMENT 'Araç Model',
    `renk` VARCHAR(50) NOT NULL COMMENT 'Araç Renk',
    `yil` INT(4) NOT NULL COMMENT 'Araç Yıl',
    `km` INT(11) NOT NULL COMMENT 'Araç Kilometre',
    `plaka` VARCHAR(20) NOT NULL COMMENT 'Araç Plaka',
    `sasi` VARCHAR(17) NOT NULL COMMENT 'Araç Şasi-Şase Numarası',
    `kiralama_ucreti` DECIMAL(10, 2) NOT NULL COMMENT 'Araç Kiralama Fiyatı',
    `satis_ucreti` DECIMAL(10, 2) NOT NULL COMMENT 'Araç Satış Fiyatı',
    `aciklama` TEXT DEFAULT NULL COMMENT 'Araç Açıklama',
    `tarih` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP COMMENT 'Araç Kayıt Tarihi',
    FOREIGN KEY (`sinif_id`) REFERENCES `arac_sinif`(`id`),
    PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4 COLLATE utf8mb4_unicode_ci;

DROP TABLE IF EXISTS `kiralama`;
CREATE TABLE IF NOT EXISTS `kiralama` (
    `id` INT(11) NOT NULL AUTO_INCREMENT COMMENT 'ID',
    `musteri_id` INT NOT NULL COMMENT 'Müşteri ID',
    `arac_id` INT NOT NULL COMMENT 'Araç ID',
    `kiralama_tarihi` DATE NOT NULL COMMENT 'Kiralama Tarihi',
    `iade_tarihi` DATE NOT NULL COMMENT 'İade Tarihi',
    `odeme_turu` ENUM('NAKİT', 'KREDİ') NOT NULL COMMENT 'Ödeme Türü',
    `ucret` DECIMAL(10, 2) NOT NULL COMMENT 'Toplam Ücret',
    FOREIGN KEY (`musteri_id`) REFERENCES `musteriler`(`id`),
    FOREIGN KEY (`arac_id`) REFERENCES `araclar`(`id`),
    PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4 COLLATE utf8mb4_unicode_ci;

DROP TABLE IF EXISTS `satis`;
CREATE TABLE IF NOT EXISTS `satis` (
    `id` INT(11) NOT NULL AUTO_INCREMENT COMMENT 'ID',
    `musteri_id` INT NOT NULL COMMENT 'Müşteri ID',
    `arac_id` INT NOT NULL COMMENT 'Araç ID',
    `satis_tarihi` DATE NOT NULL COMMENT 'Satış Tarihi',
    `ucret` DECIMAL(10, 2) NOT NULL COMMENT 'Toplam Ücret',
    `odeme_turu` ENUM('NAKİT', 'KREDİ') NOT NULL COMMENT 'Ödeme Türü',
    FOREIGN KEY (`musteri_id`) REFERENCES `musteriler`(`id`),
    FOREIGN KEY (`arac_id`) REFERENCES `araclar`(`id`),
    PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4 COLLATE utf8mb4_unicode_ci;

DROP TABLE IF EXISTS `odemeler`;
CREATE TABLE IF NOT EXISTS `odemeler` (
    `id` INT(11) NOT NULL AUTO_INCREMENT COMMENT 'ID',
    `islem_no` VARCHAR(55) NOT NULL COMMENT 'İşlem Numarası',
    `kira_id` INT DEFAULT NULL COMMENT 'Kira ID',
    `satis_id` INT DEFAULT NULL COMMENT 'Satış ID',
    `odeme_durumu` ENUM('TAMAMLANDI', 'BEKLIYOR', 'IPTAL') DEFAULT 'BEKLIYOR' COMMENT 'Ödeme Durumu',
    `aciklama` TEXT DEFAULT NULL COMMENT 'Ödeme Açıklama',
    `tarih` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP COMMENT 'İşlem Tarihi',
    FOREIGN KEY (`kira_id`) REFERENCES `kiralama`(`id`),
    FOREIGN KEY (`satis_id`) REFERENCES `satis`(`id`),
    PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4 COLLATE utf8mb4_unicode_ci;


-- Kullanicilar tablosu veri girisi
INSERT INTO kullanicilar (ad, email, sifre)
VALUES 
    ('Ahmet Yılmaz', 'ahmet@example.com', 'ahmet123'),
    ('Ayşe Demir', 'ayse@example.com', 'ayse456'),
    ('Mehmet Kaya', 'mehmet@example.com', 'mehmet789'),
    ('Fatma Öztürk', 'fatma@example.com', 'fatma321'),
    ('Mustafa Arslan', 'mustafa@example.com', 'mustafa654');

-- Musteriler tablosu veri girisi
INSERT INTO musteriler (ad, soyad, tckn, cinsiyet, dogum, telefon, adres, email)
VALUES 
    ('Ali', 'Yılmaz', '12345678901', 'ERKEK', '1980-05-15', '05551234567', 'Ankara', 'ali@example.com'),
    ('Zeynep', 'Demir', '23456789012', 'KADIN', '1992-10-25', '05557654321', 'İstanbul', 'zeynep@example.com'),
    ('Ahmet', 'Kaya', '34567890123', 'ERKEK', '1985-03-08', '05558974563', 'İzmir', 'ahmet@example.com'),
    ('Ayşe', 'Öztürk', '45678901234', 'KADIN', '1976-12-03', '05559876543', 'Bursa', 'ayse@example.com'),
    ('Mehmet', 'Arslan', '56789012345', 'ERKEK', '1990-07-20', '05556667788', 'Adana', 'mehmet@example.com');

-- Arac_sinif tablosu veri girisi
INSERT INTO arac_sinif (sinif, aciklama)
VALUES 
    ('Sedan', 'Geniş iç hacim, düşük yakıt tüketimi.'),
    ('Hatchback', 'Küçük ve pratik şehir aracı.'),
    ('SUV', 'Yüksek arazi performansı, geniş iç hacim.'),
    ('Minivan', 'Büyük aileler için ideal.'),
    ('Pick-up', 'Yük taşıma kapasitesi yüksek.');

-- Araclar tablosu veri girisi
INSERT INTO araclar (durum, sinif_id, marka, model, renk, yil, km, plaka, sasi, kiralama_ucreti, satis_ucreti, aciklama)
VALUES 
    ('KIRALIK', 1, 'Renault', 'Clio', 'Beyaz', 2019, 150000, '06ABC123', '12345678901234567', 400.00, 825000.00, 'Düşük yakıt tüketimi.'),
    ('SATILIK', 2, 'Fiat', 'Egea', 'Gri', 2020, 130000, '34DEF456', '23456789012345678', 0.00, 900000.00, 'Şehir içi kullanım için ideal.'),
    ('KIRALIK', 3, 'Hyundai', 'Tucson', 'Siyah', 2018, 180000, '35GHI789', '34567890123456789', 500.00, 1100000.00, 'Geniş iç hacim.'),
    ('KIRALIK', 4, 'Toyota', 'Auris', 'Kırmızı', 2017, 260000, '06JKL012', '45678901234567890', 500.00, 1300000.00, 'Pratik şehir aracı.'),
    ('SATILDI', 5, 'Ford', 'Ranger', 'Beyaz', 2023, 12000, '07MNO345', '56789012345678901', 0.00, 2200000.00, 'Yük taşıma kapasitesi yüksek.');

-- Kiralama tablosu veri girisi
INSERT INTO kiralama (musteri_id, arac_id, kiralama_tarihi, iade_tarihi, odeme_turu, ucret)
VALUES 
    (1, 1, '2023-05-01', '2023-05-10', 'NAKİT', 400.00),
    (2, 2, '2023-05-10', '2023-05-20', 'KREDİ', 400.00),
    (3, 3, '2023-05-20', '2023-05-30', 'NAKİT', 500.00),
    (4, 4, '2023-05-30', '2023-06-10', 'NAKİT', 500.00),
    (5, 5, '2023-06-10', '2023-06-20', 'KREDİ', 500.00);


-- Satis tablosu veri girisi
INSERT INTO satis (musteri_id, arac_id, satis_tarihi, ucret, odeme_turu)
VALUES 
    (1, 2, '2023-06-20', 900000.00, 'NAKİT'),
    (2, 3, '2023-06-25', 1100000.00, 'KREDİ'),
    (3, 4, '2023-07-01', 1300000.00, 'NAKİT'),
    (4, 1, '2023-07-05', 825000.00, 'NAKİT'),
    (5, 5, '2023-07-10', 2200000.00, 'KREDİ');


-- Odemeler tablosu veri girisi
INSERT INTO odemeler (islem_no, kira_id, satis_id, odeme_durumu, aciklama)
VALUES 
    ('KIR-2023-05-01', 1, NULL, 'TAMAMLANDI', 'Kiralama işlemi tamamlandı.'),
    ('KIR-2023-05-10', 2, NULL, 'BEKLIYOR', 'Kiralama işlemi bekliyor.'),
    ('KIR-2023-05-20', 3, NULL, 'IPTAL', 'Kiralama işlemi iptal edildi.'),
    ('KIR-2023-05-30', 4, NULL, 'TAMAMLANDI', 'Kiralama işlemi tamamlandı.'),
    ('SAT-2023-06-20', NULL, 1, 'TAMAMLANDI', 'Satış işlemi tamamlandı.'),
    ('SAT-2023-06-25', NULL, 2, 'BEKLIYOR', 'Satış işlemi bekliyor.'),
    ('SAT-2023-07-01', NULL, 3, 'IPTAL', 'Satış işlemi iptal edildi.'),
    ('SAT-2023-07-05', NULL, 4, 'TAMAMLANDI', 'Satış işlemi tamamlandı.'),
    ('KIR-2023-06-10', 5, NULL, 'BEKLIYOR', 'Kiralama işlemi bekliyor.'),
    ('SAT-2023-07-10', NULL, 5, 'TAMAMLANDI', 'Satış işlemi tamamlandı.');


COMMIT;
