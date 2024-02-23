-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 23, 2024 at 04:54 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `trgovina_retro_rpa`
--

-- --------------------------------------------------------

--
-- Table structure for table `artikli`
--

CREATE TABLE `artikli` (
  `id` int(11) NOT NULL,
  `ime` varchar(255) DEFAULT NULL,
  `cena` decimal(10,2) DEFAULT NULL,
  `zaloga` int(11) DEFAULT NULL,
  `kategorija_id` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `artikli`
--

INSERT INTO `artikli` (`id`, `ime`, `cena`, `zaloga`, `kategorija_id`) VALUES
(1, 'PlayStation 3', 150.00, 1, 'konzola'),
(2, 'PlayStation DualShock 2', 39.99, 50, 'kotroler'),
(3, 'Xbox 360', 299.99, 20, 'konzole'),
(4, 'JLab Rewind', 49.99, 30, 'pripomocki'),
(5, 'PlayStation 5', 399.00, 15, 'konzola'),
(6, 'Logitech F310', 29.99, 25, 'kotroler'),
(8, 'Logitech G502', 40.00, 1, 'miska'),
(9, 'test', 69.00, 420, 'igra'),
(10, 'Asus NB', 999.00, 2, 'prenosnik');

-- --------------------------------------------------------

--
-- Table structure for table `uporabnik`
--

CREATE TABLE `uporabnik` (
  `id` int(11) NOT NULL,
  `uporabnisko_ime` varchar(255) DEFAULT NULL,
  `geslo` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `uporabnik`
--

INSERT INTO `uporabnik` (`id`, `uporabnisko_ime`, `geslo`) VALUES
(1, 'aljaz', 'aljaz'),
(2, 'nino', 'nino'),
(3, 'flisar', 'flisar'),
(4, 'peytro', 'aqua');

-- --------------------------------------------------------

--
-- Table structure for table `zapisi`
--

CREATE TABLE `zapisi` (
  `id` int(11) NOT NULL,
  `uporabnik` varchar(255) DEFAULT NULL,
  `cas_vpisa` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `zapisi`
--

INSERT INTO `zapisi` (`id`, `uporabnik`, `cas_vpisa`) VALUES
(1, 'aljaz', '2024-02-02 17:27:54'),
(2, 'flisar', '2024-02-02 17:27:54'),
(3, 'nino', '2024-02-02 17:27:54'),
(4, 'aljaz', '2024-02-02 17:43:22'),
(5, 'peytro', '2024-02-02 17:47:25'),
(6, 'peytro', '2024-02-02 17:48:09'),
(7, 'peytro', '2024-02-02 17:50:32'),
(8, 'aljaz', '2024-02-02 17:54:53'),
(9, 'nino', '2024-02-02 17:57:39');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `artikli`
--
ALTER TABLE `artikli`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `uporabnik`
--
ALTER TABLE `uporabnik`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `zapisi`
--
ALTER TABLE `zapisi`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `artikli`
--
ALTER TABLE `artikli`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `uporabnik`
--
ALTER TABLE `uporabnik`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `zapisi`
--
ALTER TABLE `zapisi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
