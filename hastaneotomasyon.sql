-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 12, 2023 at 03:48 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hastaneotomasyon`
--

-- --------------------------------------------------------

--
-- Table structure for table `bolumler`
--

CREATE TABLE `bolumler` (
  `bolum_id` int(11) NOT NULL,
  `bolum_adi` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `bolumler`
--

INSERT INTO `bolumler` (`bolum_id`, `bolum_adi`) VALUES
(1, 'KBB'),
(2, 'Göz Hastalıkları'),
(3, 'Dahiliye'),
(6, 'acil');

-- --------------------------------------------------------

--
-- Table structure for table `doktorlar`
--

CREATE TABLE `doktorlar` (
  `doktor_id` int(11) NOT NULL,
  `doktor_adi` varchar(200) NOT NULL,
  `doktor_sifre` varchar(200) NOT NULL,
  `bolum_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `doktorlar`
--

INSERT INTO `doktorlar` (`doktor_id`, `doktor_adi`, `doktor_sifre`, `bolum_id`) VALUES
(3, 'Dr. Ali Gözbakan', '1234', 2),
(5, 'Ord. Dr. Bora Engin', '12345', 1),
(6, 'ord.dr. bertu kızhastası', '123', 3),
(7, 'dr.Serkan Telci', '123', 6),
(8, 'dr.can ', '123', 3),
(9, 'dr. ali göttengiren', '123', 3),
(10, 'Ord.Prf.Dr Sıla Tompaktepe', '123', 2);

-- --------------------------------------------------------

--
-- Table structure for table `randevu_kayitlari`
--

CREATE TABLE `randevu_kayitlari` (
  `randevu_id` int(11) NOT NULL,
  `hasta_tc` varchar(250) NOT NULL,
  `hasta_adi` varchar(250) NOT NULL,
  `bolum_id` int(11) NOT NULL,
  `doktor_id` int(11) NOT NULL,
  `randevu_tarih` datetime NOT NULL,
  `status` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `randevu_kayitlari`
--

INSERT INTO `randevu_kayitlari` (`randevu_id`, `hasta_tc`, `hasta_adi`, `bolum_id`, `doktor_id`, `randevu_tarih`, `status`) VALUES
(1, '1', 'q', 1, 1, '2023-04-22 15:34:34', 0),
(2, '11111', 'ahmet yesevi', 1, 5, '2023-04-22 16:56:50', 0),
(3, '111111111', 'ahmet mehmet', 2, 3, '2023-04-22 17:00:18', 0),
(4, '2423454643', 'ali veli', 3, 4, '2023-04-22 21:12:07', 0),
(5, '253416457621354', 'BAHAR ASLAN', 3, 6, '2023-04-23 09:02:47', 0),
(6, '366275273725', 'ahmet ahmet', 6, 7, '2023-04-25 02:17:16', 0),
(7, '623236452764', 'veli ali', 2, 3, '2023-04-25 02:27:00', 0),
(8, '36465735', 'ytdftyyft', 3, 9, '2023-04-25 03:46:51', 0),
(9, '234234234', 'melek', 2, 3, '2023-04-28 02:59:32', 0),
(10, '2314312431412', 'vvvvvvv', 3, 6, '2023-05-15 15:15:35', 0),
(11, '367634654', 'bora engin', 2, 10, '2023-05-19 08:24:17', 0),
(12, '4324363', 'ssssssssss', 1, 5, '2023-05-26 21:42:48', 1),
(13, '32234234124', 'jjjjjjjjj', 1, 5, '2023-05-26 22:01:40', 1),
(14, '32234234124', 'jhkhkjhklhk', 1, 5, '2023-05-26 22:01:49', 1),
(15, '32234234124', 'şşşşşşşşşşşş', 1, 5, '2023-05-26 22:02:05', 1),
(16, '214234123', '242432', 1, 5, '2023-06-05 05:18:00', 1),
(17, '1123242342', 'yasin', 3, 6, '2023-06-08 22:34:07', 1),
(18, '12341234132', 'kadirr', 1, 5, '2023-06-08 18:15:15', 1),
(19, '3243534534', 'serkan telci', 1, 5, '2023-06-08 18:25:51', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bolumler`
--
ALTER TABLE `bolumler`
  ADD PRIMARY KEY (`bolum_id`);

--
-- Indexes for table `doktorlar`
--
ALTER TABLE `doktorlar`
  ADD PRIMARY KEY (`doktor_id`);

--
-- Indexes for table `randevu_kayitlari`
--
ALTER TABLE `randevu_kayitlari`
  ADD PRIMARY KEY (`randevu_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bolumler`
--
ALTER TABLE `bolumler`
  MODIFY `bolum_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `doktorlar`
--
ALTER TABLE `doktorlar`
  MODIFY `doktor_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `randevu_kayitlari`
--
ALTER TABLE `randevu_kayitlari`
  MODIFY `randevu_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
