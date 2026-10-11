-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2026. Okt 11. 21:39
-- Kiszolgáló verziója: 10.4.32-MariaDB
-- PHP verzió: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `uzenetkuldo`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `uzenet`
--

DROP TABLE IF EXISTS `uzenet`;
CREATE TABLE IF NOT EXISTS `uzenet` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Szoveg` text NOT NULL,
  `KüldesiIdo` datetime NOT NULL,
  `UzenetTipus` varchar(8) NOT NULL,
  `Telefon` varchar(16) NOT NULL,
  `Email` varchar(64) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `uzenet`
--

INSERT INTO `uzenet` (`Id`, `Szoveg`, `KüldesiIdo`, `UzenetTipus`, `Telefon`, `Email`) VALUES
(1, 'Módosított üzenet', '2025-10-11 16:26:40', 'SMS', '+36301234567', ''),
(2, 'Módosított üzenet', '2025-10-11 16:26:40', 'SMS', '+36301234567', ''),
(3, 'Módosított üzenet', '2025-10-11 16:26:40', 'SMS', '+36301234567', ''),
(4, 'Módosított üzenet', '2025-10-11 16:26:40', 'SMS', '+36301234567', ''),
(5, 'Módosított üzenet', '2025-10-11 16:26:40', 'SMS', '+36301234567', ''),
(6, 'Módosított üzenet', '2025-10-11 16:26:40', 'SMS', '+36301234567', ''),
(7, 'Módosított üzenet', '2025-10-11 16:26:40', 'SMS', '+36301234567', ''),
(8, 'Módosított üzenet', '2025-10-11 16:26:40', 'SMS', '+36301234567', ''),
(10, 'Módosított üzenet', '2025-10-11 16:26:40', 'SMS', '+36301234567', ''),
(11, 'Módosított üzenet', '2025-10-11 16:26:40', 'SMS', '+36301234567', ''),
(12, 'Kérem, ellenőrizze postafiókját! Sürgős küldeménye érkezett.', '2026-09-02 15:00:28', 'SMS', '+36305679841', ''),
(13, 'Adategyeztetés céljából kérjük, keresse fel honlapunkat: https://www.ceghonlap.hu', '2026-08-27 19:05:38', 'Email', '', 'ugyfelcim1@mail.hu'),
(14, 'Vigyázat, csalók!!!\r\nIsmeretlenek a cégünk nevével visszaélve bizalmas információk (jelszavak, szerződésadatok) megadását kérhetik öntől teefonon vagy emailben. Felhívjuk figyelmét, hogy ilyen információt senkitől sem kérünk, ezért ne dőljön be a csalóknak!', '2026-09-13 10:07:19', 'SMS', '+36205009301', ''),
(15, 'Vigyázat, csalók!!!\r\nIsmeretlenek a cégünk nevével visszaélve bizalmas információk (jelszavak, szerződésadatok) megadását kérhetik öntől teefonon vagy emailben. Felhívjuk figyelmét, hogy ilyen információt senkitől sem kérünk, ezért ne dőljön be a csalóknak!', '2026-09-13 10:07:19', 'Email', '', 'kiemeltugyfel@mail.com');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
