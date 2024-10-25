-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Sep 09, 2016 at 09:50 PM
-- Server version: 5.6.17
-- PHP Version: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `dbattendanceforcs`
--

-- --------------------------------------------------------

--
-- Table structure for table `id1`
--

CREATE TABLE IF NOT EXISTS `id1` (
  `id_no` varchar(45) DEFAULT NULL,
  `am_login` varchar(5) DEFAULT NULL,
  `am_logout` varchar(5) DEFAULT NULL,
  `pm_login` varchar(5) DEFAULT NULL,
  `pm_logout` varchar(5) DEFAULT NULL,
  `event_id` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `id1`
--

INSERT INTO `id1` (`id_no`, `am_login`, `am_logout`, `pm_login`, `pm_logout`, `event_id`) VALUES
('2050107', '1', '1', '0', '1', 'ID1'),
('2066418', '1', '1', '1', '1', 'ID1'),
('2065203', '1', '0', '0', '1', 'ID1'),
('2062684', '1', '0', '1', '0', 'ID1'),
('2063778', '0', '1', '1', '0', 'ID1'),
('2060495', '1', '0', '1', '0', 'ID1'),
('2063569', '1', '0', '0', '0', 'ID1'),
('2044250', '1', '1', '0', '0', 'ID1'),
('2062965', '0', '0', '1', '0', 'ID1'),
('2068306', '0', '0', '1', '0', 'ID1'),
('2049249', '0', '0', '0', '0', 'ID1'),
('2049228', '0', '0', '0', '1', 'ID1'),
('2048300', '0', '0', '0', '0', 'ID1'),
('2060718', '0', '1', '0', '0', 'ID1'),
('2066406', '0', '0', '0', '0', 'ID1'),
('2068295', '0', '0', '0', '0', 'ID1'),
('2034952', '0', '0', '0', '0', 'ID1'),
('2062528', '0', '0', '0', '0', 'ID1'),
('2060783', '0', '0', '0', '0', 'ID1'),
('2063700', '0', '1', '0', '0', 'ID1'),
('2063279', '0', '0', '0', '0', 'ID1'),
('2061010', '0', '0', '0', '0', 'ID1'),
('2050357', '0', '0', '0', '1', 'ID1'),
('2063686', '0', '0', '0', '0', 'ID1'),
('2028530', '0', '0', '0', '0', 'ID1'),
('2060833', '0', '0', '0', '0', 'ID1'),
('2062038', '0', '0', '0', '0', 'ID1'),
('2064333', '0', '0', '0', '0', 'ID1'),
('2063628', '0', '0', '0', '0', 'ID1'),
('2068112', '0', '0', '0', '0', 'ID1'),
('2060243', '0', '0', '0', '0', 'ID1'),
('2063023', '0', '0', '0', '0', 'ID1'),
('2068020', '0', '0', '0', '0', 'ID1'),
('2065816', '0', '0', '0', '0', 'ID1'),
('2067742', '0', '0', '0', '0', 'ID1'),
('2066283', '0', '0', '0', '0', 'ID1'),
('2048970', '0', '0', '0', '0', 'ID1'),
('2068182', '0', '0', '0', '0', 'ID1'),
('2066399', '0', '0', '0', '0', 'ID1'),
('2045538', '0', '0', '0', '0', 'ID1'),
('2066298', '0', '0', '0', '0', 'ID1'),
('2066158', '0', '0', '0', '0', 'ID1'),
('2047001', '0', '0', '0', '0', 'ID1'),
('2068120', '0', '0', '0', '0', 'ID1'),
('2066072', '0', '0', '0', '0', 'ID1'),
('2066445', '0', '0', '0', '0', 'ID1'),
('2065414', '0', '0', '0', '0', 'ID1'),
('2063597', '0', '0', '0', '0', 'ID1'),
('2067662', '0', '0', '0', '0', 'ID1'),
('2061640', '0', '0', '0', '0', 'ID1'),
('2065512', '0', '0', '0', '0', 'ID1'),
('2064032', '0', '0', '0', '0', 'ID1'),
('2060052', '0', '0', '0', '0', 'ID1'),
('2061099', '0', '0', '0', '0', 'ID1'),
('2064503', '0', '0', '0', '0', 'ID1'),
('2062984', '0', '0', '0', '0', 'ID1'),
('2062968', '0', '0', '0', '0', 'ID1'),
('2060962', '0', '0', '0', '0', 'ID1'),
('2063456', '0', '0', '0', '0', 'ID1'),
('2066665', '0', '0', '0', '0', 'ID1'),
('2066156', '0', '0', '0', '0', 'ID1'),
('2067611', '0', '0', '0', '0', 'ID1'),
('2064663', '0', '0', '0', '0', 'ID1'),
('2047243', '0', '0', '0', '0', 'ID1'),
('2068421', '0', '0', '0', '0', 'ID1'),
('2068160', '0', '0', '0', '0', 'ID1'),
('2064021', '0', '0', '0', '0', 'ID1'),
('2062655', '0', '0', '0', '0', 'ID1'),
('2067497', '0', '0', '0', '0', 'ID1'),
('2066633', '0', '0', '0', '0', 'ID1'),
('2061228', '0', '0', '0', '0', 'ID1'),
('2063324', '0', '0', '0', '0', 'ID1'),
('2068363', '0', '0', '0', '0', 'ID1'),
('2066481', '0', '0', '0', '0', 'ID1'),
('2047806', '0', '0', '0', '0', 'ID1'),
('2063895', '0', '0', '0', '0', 'ID1'),
('2062859', '0', '0', '0', '0', 'ID1'),
('2068212', '0', '0', '0', '0', 'ID1'),
('1002180', '0', '0', '0', '0', 'ID1'),
('2050875', '0', '0', '0', '0', 'ID1'),
('2067712', '0', '0', '0', '0', 'ID1'),
('2062654', '0', '0', '0', '0', 'ID1'),
('2050370', '0', '0', '0', '0', 'ID1'),
('2067669', '0', '0', '0', '0', 'ID1'),
('2049665', '0', '0', '0', '0', 'ID1'),
('1002146', '0', '0', '0', '0', 'ID1'),
('2068409', '0', '0', '0', '0', 'ID1'),
('2066113', '0', '0', '0', '0', 'ID1'),
('2039957', '0', '0', '0', '0', 'ID1'),
('2060908', '0', '0', '0', '0', 'ID1'),
('2062301', '0', '0', '0', '0', 'ID1'),
('2063427', '0', '0', '0', '0', 'ID1'),
('2066218', '0', '0', '0', '0', 'ID1'),
('2060706', '0', '0', '0', '0', 'ID1'),
('2047290', '0', '0', '0', '0', 'ID1'),
('2066042', '0', '0', '0', '0', 'ID1'),
('2065823', '0', '0', '0', '0', 'ID1'),
('2060741', '0', '0', '0', '0', 'ID1'),
('2067689', '0', '0', '0', '0', 'ID1'),
('2065376', '0', '0', '0', '0', 'ID1'),
('2067824', '0', '0', '0', '0', 'ID1'),
('2063122', '0', '0', '0', '0', 'ID1'),
('2063641', '0', '0', '0', '0', 'ID1'),
('2068143', '0', '0', '0', '0', 'ID1'),
('2064007', '0', '0', '0', '0', 'ID1'),
('2063877', '0', '0', '0', '0', 'ID1'),
('2060639', '0', '0', '0', '0', 'ID1'),
('2067663', '0', '0', '0', '0', 'ID1'),
('2049420', '0', '0', '0', '0', 'ID1'),
('2066465', '0', '0', '0', '0', 'ID1'),
('2068191', '0', '0', '0', '0', 'ID1'),
('2043822', '0', '0', '0', '0', 'ID1'),
('2064811', '0', '0', '0', '0', 'ID1'),
('2049308', '0', '0', '0', '0', 'ID1'),
('2062897', '0', '0', '0', '0', 'ID1'),
('2049399', '0', '0', '1', '0', 'ID1'),
('2049608', '0', '0', '0', '0', 'ID1'),
('2068229', '0', '0', '0', '0', 'ID1'),
('2065529', '0', '0', '0', '0', 'ID1'),
('2063098', '0', '0', '0', '0', 'ID1'),
('2060627', '0', '0', '0', '0', 'ID1'),
('2045934', '0', '0', '0', '0', 'ID1'),
('2050475', '0', '0', '0', '0', 'ID1'),
('2049359', '0', '0', '0', '0', 'ID1'),
('2065515', '0', '0', '0', '0', 'ID1'),
('2066395', '0', '0', '0', '0', 'ID1'),
('2068415', '0', '0', '0', '0', 'ID1'),
('2063341', '0', '0', '0', '0', 'ID1'),
('2065877', '0', '0', '0', '0', 'ID1'),
('2050292', '0', '0', '0', '0', 'ID1'),
('2062973', '0', '0', '0', '0', 'ID1'),
('2061100', '0', '0', '0', '0', 'ID1'),
('2067670', '0', '0', '0', '0', 'ID1'),
('2062892', '0', '0', '0', '0', 'ID1'),
('2066397', '0', '0', '0', '0', 'ID1'),
('2065708', '0', '0', '0', '0', 'ID1'),
('2066051', '0', '0', '0', '0', 'ID1'),
('2061282', '0', '0', '0', '0', 'ID1'),
('2060708', '0', '0', '0', '0', 'ID1'),
('2062090', '0', '0', '0', '0', 'ID1'),
('2060391', '0', '0', '0', '0', 'ID1'),
('2060853', '0', '0', '0', '0', 'ID1'),
('2050145', '0', '0', '0', '0', 'ID1'),
('2066624', '0', '0', '0', '0', 'ID1'),
('2050018', '0', '0', '0', '0', 'ID1'),
('2067802', '0', '0', '0', '0', 'ID1'),
('2062924', '0', '0', '0', '0', 'ID1'),
('2060586', '0', '0', '0', '0', 'ID1'),
('2050134', '0', '0', '0', '0', 'ID1'),
('2064561', '0', '0', '0', '0', 'ID1'),
('2061138', '0', '0', '0', '0', 'ID1'),
('2062513', '0', '0', '0', '0', 'ID1'),
('2062360', '0', '0', '0', '0', 'ID1'),
('2064009', '0', '0', '0', '0', 'ID1'),
('2067607', '0', '0', '0', '0', 'ID1'),
('2061000', '0', '0', '0', '0', 'ID1'),
('2065805', '0', '0', '0', '0', 'ID1'),
('2060231', '0', '0', '0', '0', 'ID1'),
('2068054', '0', '0', '0', '0', 'ID1'),
('2062895', '0', '0', '0', '0', 'ID1'),
('2064852', '0', '0', '0', '0', 'ID1'),
('2049491', '0', '0', '0', '0', 'ID1'),
('2067915', '0', '0', '0', '0', 'ID1'),
('2044228', '0', '0', '0', '0', 'ID1'),
('2067816', '0', '0', '0', '0', 'ID1'),
('2065959', '0', '0', '0', '0', 'ID1'),
('2065297', '0', '0', '0', '0', 'ID1'),
('2068088', '0', '0', '0', '0', 'ID1'),
('2068127', '0', '0', '0', '0', 'ID1'),
('2067758', '0', '0', '0', '0', 'ID1'),
('2065499', '0', '0', '0', '0', 'ID1'),
('2061246', '0', '0', '0', '0', 'ID1'),
('2062103', '0', '0', '0', '0', 'ID1'),
('2065927', '0', '0', '0', '0', 'ID1'),
('2065434', '0', '0', '0', '0', 'ID1'),
('2065476', '0', '0', '0', '0', 'ID1'),
('2067932', '0', '0', '0', '0', 'ID1'),
('2068094', '0', '0', '0', '0', 'ID1'),
('2067485', '0', '0', '0', '0', 'ID1'),
('2050479', '0', '0', '0', '0', 'ID1'),
('2067640', '0', '0', '0', '0', 'ID1'),
('2068161', '0', '0', '0', '0', 'ID1'),
('2067785', '0', '0', '0', '0', 'ID1'),
('2067616', '0', '0', '0', '0', 'ID1'),
('2060299', '0', '0', '0', '0', 'ID1'),
('2066513', '0', '0', '0', '0', 'ID1'),
('2049400', '0', '0', '0', '0', 'ID1'),
('2044960', '0', '0', '0', '0', 'ID1'),
('2060285', '0', '0', '0', '0', 'ID1'),
('2046562', '0', '0', '0', '0', 'ID1'),
('2050043', '0', '0', '0', '0', 'ID1'),
('2063171', '0', '0', '0', '0', 'ID1'),
('2065300', '0', '0', '0', '0', 'ID1'),
('2048243', '0', '0', '0', '0', 'ID1'),
('2066242', '0', '0', '0', '0', 'ID1'),
('2048099', '0', '0', '0', '0', 'ID1'),
('2050820', '0', '0', '0', '0', 'ID1');

-- --------------------------------------------------------

--
-- Table structure for table `id2`
--

CREATE TABLE IF NOT EXISTS `id2` (
  `id_no` varchar(45) DEFAULT NULL,
  `am_login` varchar(5) DEFAULT NULL,
  `am_logout` varchar(5) DEFAULT NULL,
  `pm_login` varchar(5) DEFAULT NULL,
  `pm_logout` varchar(5) DEFAULT NULL,
  `event_id` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `id2`
--

INSERT INTO `id2` (`id_no`, `am_login`, `am_logout`, `pm_login`, `pm_logout`, `event_id`) VALUES
('2050107', '0', '0', '0', '0', 'ID2'),
('2066418', '0', '0', '0', '0', 'ID2'),
('2065203', '0', '0', '0', '0', 'ID2'),
('2062684', '0', '0', '0', '0', 'ID2'),
('2063778', '0', '0', '0', '0', 'ID2'),
('2060495', '0', '0', '0', '0', 'ID2'),
('2063569', '0', '0', '0', '0', 'ID2'),
('2044250', '0', '0', '0', '0', 'ID2'),
('2062965', '0', '0', '0', '0', 'ID2'),
('2068306', '0', '0', '0', '0', 'ID2'),
('2049249', '0', '0', '0', '0', 'ID2'),
('2049228', '0', '0', '0', '0', 'ID2'),
('2048300', '0', '0', '0', '0', 'ID2'),
('2060718', '0', '0', '0', '0', 'ID2'),
('2066406', '0', '0', '0', '0', 'ID2'),
('2068295', '0', '0', '0', '0', 'ID2'),
('2034952', '0', '0', '0', '0', 'ID2'),
('2062528', '0', '0', '0', '0', 'ID2'),
('2060783', '0', '0', '0', '0', 'ID2'),
('2063700', '0', '0', '0', '0', 'ID2'),
('2063279', '0', '0', '0', '0', 'ID2'),
('2061010', '0', '0', '0', '0', 'ID2'),
('2050357', '0', '0', '0', '0', 'ID2'),
('2063686', '0', '0', '0', '0', 'ID2'),
('2028530', '0', '0', '0', '0', 'ID2'),
('2060833', '0', '0', '0', '0', 'ID2'),
('2062038', '0', '0', '0', '0', 'ID2'),
('2064333', '0', '0', '0', '0', 'ID2'),
('2063628', '0', '0', '0', '0', 'ID2'),
('2068112', '0', '0', '0', '0', 'ID2'),
('2060243', '0', '0', '0', '0', 'ID2'),
('2063023', '0', '0', '0', '0', 'ID2'),
('2068020', '0', '0', '0', '0', 'ID2'),
('2065816', '0', '0', '0', '0', 'ID2'),
('2067742', '0', '0', '0', '0', 'ID2'),
('2066283', '0', '0', '0', '0', 'ID2'),
('2048970', '0', '0', '0', '0', 'ID2'),
('2068182', '0', '0', '0', '0', 'ID2'),
('2066399', '0', '0', '0', '0', 'ID2'),
('2045538', '0', '0', '0', '0', 'ID2'),
('2066298', '0', '0', '0', '0', 'ID2'),
('2066158', '0', '0', '0', '0', 'ID2'),
('2047001', '0', '0', '0', '0', 'ID2'),
('2068120', '0', '0', '0', '0', 'ID2'),
('2066072', '0', '0', '0', '0', 'ID2'),
('2066445', '0', '0', '0', '0', 'ID2'),
('2065414', '0', '0', '0', '0', 'ID2'),
('2063597', '0', '0', '0', '0', 'ID2'),
('2067662', '0', '0', '0', '0', 'ID2'),
('2061640', '0', '0', '0', '0', 'ID2'),
('2065512', '0', '0', '0', '0', 'ID2'),
('2064032', '0', '0', '0', '0', 'ID2'),
('2060052', '0', '0', '0', '0', 'ID2'),
('2061099', '0', '0', '0', '0', 'ID2'),
('2064503', '0', '0', '0', '0', 'ID2'),
('2062984', '0', '0', '0', '0', 'ID2'),
('2062968', '0', '0', '0', '0', 'ID2'),
('2060962', '0', '0', '0', '0', 'ID2'),
('2063456', '0', '0', '0', '0', 'ID2'),
('2066665', '0', '0', '0', '0', 'ID2'),
('2066156', '0', '0', '0', '0', 'ID2'),
('2067611', '0', '0', '0', '0', 'ID2'),
('2064663', '0', '0', '0', '0', 'ID2'),
('2047243', '0', '0', '0', '0', 'ID2'),
('2068421', '0', '0', '0', '0', 'ID2'),
('2068160', '0', '0', '0', '0', 'ID2'),
('2064021', '0', '0', '0', '0', 'ID2'),
('2062655', '0', '0', '0', '0', 'ID2'),
('2067497', '0', '0', '0', '0', 'ID2'),
('2066633', '0', '0', '0', '0', 'ID2'),
('2061228', '0', '0', '0', '0', 'ID2'),
('2063324', '0', '0', '0', '0', 'ID2'),
('2068363', '0', '0', '0', '0', 'ID2'),
('2066481', '0', '0', '0', '0', 'ID2'),
('2047806', '0', '0', '0', '0', 'ID2'),
('2063895', '0', '0', '0', '0', 'ID2'),
('2062859', '0', '0', '0', '0', 'ID2'),
('2068212', '0', '0', '0', '0', 'ID2'),
('1002180', '0', '0', '0', '0', 'ID2'),
('2050875', '0', '0', '0', '0', 'ID2'),
('2067712', '0', '0', '0', '0', 'ID2'),
('2062654', '0', '0', '0', '0', 'ID2'),
('2050370', '0', '0', '0', '0', 'ID2'),
('2067669', '0', '0', '0', '0', 'ID2'),
('2049665', '0', '0', '0', '0', 'ID2'),
('1002146', '0', '0', '0', '0', 'ID2'),
('2068409', '0', '0', '0', '0', 'ID2'),
('2066113', '0', '0', '0', '0', 'ID2'),
('2039957', '0', '0', '0', '0', 'ID2'),
('2060908', '0', '0', '0', '0', 'ID2'),
('2062301', '0', '0', '0', '0', 'ID2'),
('2063427', '0', '0', '0', '0', 'ID2'),
('2066218', '0', '0', '0', '0', 'ID2'),
('2060706', '0', '0', '0', '0', 'ID2'),
('2047290', '0', '0', '0', '0', 'ID2'),
('2066042', '0', '0', '0', '0', 'ID2'),
('2065823', '0', '0', '0', '0', 'ID2'),
('2060741', '0', '0', '0', '0', 'ID2'),
('2067689', '0', '0', '0', '0', 'ID2'),
('2065376', '0', '0', '0', '0', 'ID2'),
('2067824', '0', '0', '0', '0', 'ID2'),
('2063122', '0', '0', '0', '0', 'ID2'),
('2063641', '0', '0', '0', '0', 'ID2'),
('2068143', '0', '0', '0', '0', 'ID2'),
('2064007', '0', '0', '0', '0', 'ID2'),
('2063877', '0', '0', '0', '0', 'ID2'),
('2060639', '0', '0', '0', '0', 'ID2'),
('2067663', '0', '0', '0', '0', 'ID2'),
('2049420', '0', '0', '0', '0', 'ID2'),
('2066465', '0', '0', '0', '0', 'ID2'),
('2068191', '0', '0', '0', '0', 'ID2'),
('2043822', '0', '0', '0', '0', 'ID2'),
('2064811', '0', '0', '0', '0', 'ID2'),
('2049308', '0', '0', '0', '0', 'ID2'),
('2062897', '0', '0', '0', '0', 'ID2'),
('2049399', '0', '0', '0', '0', 'ID2'),
('2049608', '0', '0', '0', '0', 'ID2'),
('2068229', '0', '0', '0', '0', 'ID2'),
('2065529', '0', '0', '0', '0', 'ID2'),
('2063098', '0', '0', '0', '0', 'ID2'),
('2060627', '0', '0', '0', '0', 'ID2'),
('2045934', '0', '0', '0', '0', 'ID2'),
('2050475', '0', '0', '0', '0', 'ID2'),
('2049359', '0', '0', '0', '0', 'ID2'),
('2065515', '0', '0', '0', '0', 'ID2'),
('2066395', '0', '0', '0', '0', 'ID2'),
('2068415', '0', '0', '0', '0', 'ID2'),
('2063341', '0', '0', '0', '0', 'ID2'),
('2065877', '0', '0', '0', '0', 'ID2'),
('2050292', '0', '0', '0', '0', 'ID2'),
('2062973', '0', '0', '0', '0', 'ID2'),
('2061100', '0', '0', '0', '0', 'ID2'),
('2067670', '0', '0', '0', '0', 'ID2'),
('2062892', '0', '0', '0', '0', 'ID2'),
('2066397', '0', '0', '0', '0', 'ID2'),
('2065708', '0', '0', '0', '0', 'ID2'),
('2066051', '0', '0', '0', '0', 'ID2'),
('2061282', '0', '0', '0', '0', 'ID2'),
('2060708', '0', '0', '0', '0', 'ID2'),
('2062090', '0', '0', '0', '0', 'ID2'),
('2060391', '0', '0', '0', '0', 'ID2'),
('2060853', '0', '0', '0', '0', 'ID2'),
('2050145', '0', '0', '0', '0', 'ID2'),
('2066624', '0', '0', '0', '0', 'ID2'),
('2050018', '0', '0', '0', '0', 'ID2'),
('2067802', '0', '0', '0', '0', 'ID2'),
('2062924', '0', '0', '0', '0', 'ID2'),
('2060586', '0', '0', '0', '0', 'ID2'),
('2050134', '0', '0', '0', '0', 'ID2'),
('2064561', '0', '0', '0', '0', 'ID2'),
('2061138', '0', '0', '0', '0', 'ID2'),
('2062513', '0', '0', '0', '0', 'ID2'),
('2062360', '0', '0', '0', '0', 'ID2'),
('2064009', '0', '0', '0', '0', 'ID2'),
('2067607', '0', '0', '0', '0', 'ID2'),
('2061000', '0', '0', '0', '0', 'ID2'),
('2065805', '0', '0', '0', '0', 'ID2'),
('2060231', '0', '0', '0', '0', 'ID2'),
('2068054', '0', '0', '0', '0', 'ID2'),
('2062895', '0', '0', '0', '0', 'ID2'),
('2064852', '0', '0', '0', '0', 'ID2'),
('2049491', '0', '0', '0', '0', 'ID2'),
('2067915', '0', '0', '0', '0', 'ID2'),
('2044228', '0', '0', '0', '0', 'ID2'),
('2067816', '0', '0', '0', '0', 'ID2'),
('2065959', '0', '0', '0', '0', 'ID2'),
('2065297', '0', '0', '0', '0', 'ID2'),
('2068088', '0', '0', '0', '0', 'ID2'),
('2068127', '0', '0', '0', '0', 'ID2'),
('2067758', '0', '0', '0', '0', 'ID2'),
('2065499', '0', '0', '0', '0', 'ID2'),
('2061246', '0', '0', '0', '0', 'ID2'),
('2062103', '0', '0', '0', '0', 'ID2'),
('2065927', '0', '0', '0', '0', 'ID2'),
('2065434', '0', '0', '0', '0', 'ID2'),
('2065476', '0', '0', '0', '0', 'ID2'),
('2067932', '0', '0', '0', '0', 'ID2'),
('2068094', '0', '0', '0', '0', 'ID2'),
('2067485', '0', '0', '0', '0', 'ID2'),
('2050479', '0', '0', '0', '0', 'ID2'),
('2067640', '0', '0', '0', '0', 'ID2'),
('2068161', '0', '0', '0', '0', 'ID2'),
('2067785', '0', '0', '0', '0', 'ID2'),
('2067616', '0', '0', '0', '0', 'ID2'),
('2060299', '0', '0', '0', '0', 'ID2'),
('2066513', '0', '0', '0', '0', 'ID2'),
('2049400', '0', '0', '0', '0', 'ID2'),
('2044960', '0', '0', '0', '0', 'ID2'),
('2060285', '0', '0', '0', '0', 'ID2'),
('2046562', '0', '0', '0', '0', 'ID2'),
('2050043', '0', '0', '0', '0', 'ID2'),
('2063171', '0', '0', '0', '0', 'ID2'),
('2065300', '0', '0', '0', '0', 'ID2'),
('2048243', '0', '0', '0', '0', 'ID2'),
('2066242', '0', '0', '0', '0', 'ID2'),
('2048099', '0', '0', '0', '0', 'ID2'),
('2050820', '0', '0', '0', '0', 'ID2');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_attendance_log`
--

CREATE TABLE IF NOT EXISTS `tbl_attendance_log` (
  `id_no` varchar(35) NOT NULL,
  `at_for` varchar(45) NOT NULL COMMENT 'Attendance For: Mode',
  `event_id` varchar(45) NOT NULL,
  `dt_log` varchar(45) NOT NULL,
  `tracecode` varchar(45) NOT NULL,
  UNIQUE KEY `tracecode` (`tracecode`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_attendance_log`
--

INSERT INTO `tbl_attendance_log` (`id_no`, `at_for`, `event_id`, `dt_log`, `tracecode`) VALUES
('2044250', 'am_login', 'ID1', '2016-09-10 03:08:54', 'ID12044250am_login'),
('2044250', 'am_logout', 'ID1', '2016-09-10 03:10:26', 'ID12044250am_logout'),
('2049228', 'pm_logout', 'ID1', '2016-09-10 03:14:17', 'ID12049228pm_logout'),
('2049399', 'pm_login', 'ID1', '2016-09-10 03:12:54', 'ID12049399pm_login'),
('2050107', 'am_login', 'ID1', '2016-09-10 03:08:05', 'ID12050107am_login'),
('2050107', 'am_logout', 'ID1', '2016-09-10 03:10:09', 'ID12050107am_logout'),
('2050107', 'pm_logout', 'ID1', '2016-09-10 03:14:07', 'ID12050107pm_logout'),
('2050357', 'pm_logout', 'ID1', '2016-09-10 03:14:26', 'ID12050357pm_logout'),
('2060495', 'am_login', 'ID1', '2016-09-10 03:08:38', 'ID12060495am_login'),
('2060495', 'pm_login', 'ID1', '2016-09-10 03:12:10', 'ID12060495pm_login'),
('2060718', 'am_logout', 'ID1', '2016-09-10 03:10:52', 'ID12060718am_logout'),
('2062684', 'am_login', 'ID1', '2016-09-10 03:08:26', 'ID12062684am_login'),
('2062684', 'pm_login', 'ID1', '2016-09-10 03:12:26', 'ID12062684pm_login'),
('2062965', 'pm_login', 'ID1', '2016-09-10 03:12:39', 'ID12062965pm_login'),
('2063569', 'am_login', 'ID1', '2016-09-10 03:08:45', 'ID12063569am_login'),
('2063700', 'am_logout', 'ID1', '2016-09-10 03:10:35', 'ID12063700am_logout'),
('2063778', 'am_logout', 'ID1', '2016-09-10 03:10:20', 'ID12063778am_logout'),
('2063778', 'pm_login', 'ID1', '2016-09-10 03:12:34', 'ID12063778pm_login'),
('2065203', 'am_login', 'ID1', '2016-09-10 03:08:18', 'ID12065203am_login'),
('2065203', 'pm_logout', 'ID1', '2016-09-10 03:14:58', 'ID12065203pm_logout'),
('2066418', 'am_login', 'ID1', '2016-09-10 03:08:11', 'ID12066418am_login'),
('2066418', 'am_logout', 'ID1', '2016-09-10 03:10:14', 'ID12066418am_logout'),
('2066418', 'pm_login', 'ID1', '2016-09-10 03:12:15', 'ID12066418pm_login'),
('2066418', 'pm_logout', 'ID1', '2016-09-10 03:14:41', 'ID12066418pm_logout'),
('2068306', 'pm_login', 'ID1', '2016-09-10 03:12:20', 'ID12068306pm_login');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_event`
--

CREATE TABLE IF NOT EXISTS `tbl_event` (
  `event_id` varchar(45) NOT NULL,
  `event_name` varchar(99) NOT NULL,
  `event_desc` text NOT NULL,
  `dt_event` varchar(45) NOT NULL,
  `event_status` varchar(45) NOT NULL,
  PRIMARY KEY (`event_id`),
  UNIQUE KEY `dt_event` (`dt_event`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_event`
--

INSERT INTO `tbl_event` (`event_id`, `event_name`, `event_desc`, `dt_event`, `event_status`) VALUES
('ID1', 'intrams day 1', '..', '9/10/2016', 'Active'),
('ID2', 'Intramurals Day 2', '. .', '9/11/2016', 'Active');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_studrec`
--

CREATE TABLE IF NOT EXISTS `tbl_studrec` (
  `id_no` varchar(45) NOT NULL,
  `lname` varchar(90) NOT NULL,
  `fname` varchar(90) NOT NULL,
  `mname` varchar(90) NOT NULL,
  `course_code` varchar(45) NOT NULL,
  `yr_lvl` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_studrec`
--

INSERT INTO `tbl_studrec` (`id_no`, `lname`, `fname`, `mname`, `course_code`, `yr_lvl`) VALUES
('2067669', 'ERFE', 'FRANZ LINDLEY', 'GALA', 'ACT', 1),
('2062103', 'Subalan', 'Geron', 'Soco', 'ACT', 1),
('2064663', 'Ching', 'Aljon John', 'Aguilar', 'ACT', 1),
('2065512', 'Caballero', 'Neil Renzo', 'Mabao', 'ACT', 1),
('2065529', 'Macalaguing', 'Larryfil', 'Romo', 'ACT', 1),
('2066158', 'Biñas', 'Eric John', 'Resurrection', 'ACT', 1),
('2066481', 'DANO', 'JOHN WILSON', 'NACALABAN', 'ACT', 1),
('1002146', 'ESTOQUE', 'ANGELA', 'FUDALAN', 'ACT', 2),
('2044228', 'ROMEA', 'ROBERT STEVEN', 'QUIBLAT', 'ACT', 2),
('2045538', 'BETE', 'RUBEN JOHN', 'MAANDIG', 'ACT', 2),
('2046562', 'VILLAHERMOSA', 'MELODY', 'ESCABUSA', 'ACT', 2),
('2047243', 'CIMAFRANCA', 'MARK', '', 'ACT', 2),
('2048300', 'AMISTA', 'MAXINE DOMINIQUE', 'LAUREL', 'ACT', 2),
('2048970', 'BATION', 'LOUIE JAY', 'PORNEA', 'ACT', 2),
('2050043', 'VIÑA', 'GERALD', 'SAGRADO', 'ACT', 2),
('2050107', 'ABALDE', 'ALJUNE', 'ROSKA', 'ACT', 2),
('2063023', 'Balatayo', 'Jane Ivy', 'L', 'ACT', 2),
('2063628', 'Balacuit', 'Luisito', 'Pahuyo', 'ACT', 2),
('2065203', 'Abellanosa', 'Jessie Ivy', 'Gallarde', 'ACT', 2),
('2068020', 'BAÑADOS', 'HOLDEM VON', 'BRACUSO', 'ACT', 1),
('2047290', 'GUDITO', 'FEBIE MAE', 'ODCHIGUE', 'ACT', 2),
('1002180', 'DOLIGOL', 'ALBERT', 'PALLUTO', 'BSCS', 4),
('2039957', 'GALARIDO', 'RONAGEN', 'LABIS', 'BSCS', 4),
('2049249', 'ALPEZ', 'BLESS CHARISSE MAE', 'LUCAGBO', 'BSCS', 4),
('2049491', 'REYES', 'KRISTOFFER', 'CAMPO', 'BSCS', 4),
('2050134', 'PARTOSA', 'DEOPRICELMAR', 'LOPEZ', 'BSCS', 4),
('2060243', 'Balane', 'Sharry Jean', 'Llobrera', 'BSCS', 4),
('2060908', 'Galua', 'James', 'Labor', 'BSCS', 4),
('2061246', 'Soliven', 'Amiel Bryan', 'Bacor', 'BSCS', 4),
('2066445', 'BRITANICO', 'DANDEVE', 'CASINILLO', 'BSCS', 4),
('2060627', 'Magasin', 'Gem Lorenz', 'Inot', 'BSIT', 1),
('2065927', 'TADULAN JR.', 'REY', 'ESTOCONING', 'BSIT', 1),
('2066665', 'CASTILLANES', 'MARY GRACE', 'PADRONES', 'BSIT', 1),
('2067485', 'TEMARIO', 'RONEL', 'VIAROS', 'BSIT', 1),
('2067607', 'QUIJOY', 'KEITH BRIAN', 'DULZURA', 'BSIT', 1),
('2067640', 'TOLO', 'RANDY', '', 'BSIT', 1),
('2067662', 'Buhawe', 'Judy Ann', 'Galgo', 'BSIT', 1),
('2067663', 'LAJOM', 'LEMUEL JOHN', 'MARTINEZ', 'BSIT', 1),
('2067689', 'Hassan', 'Jalanie', 'Macapodi', 'BSIT', 1),
('2067712', 'Ecaranum', 'Faith Mary', 'Salas', 'BSIT', 1),
('2067785', 'TORREJOS', 'REYNAN', 'LIMPIADO', 'BSIT', 1),
('2067816', 'SAA', 'DEYUEN RAY', 'OLARTE', 'BSIT', 1),
('2067824', 'JANOLINO', 'MICHAEL JAY', 'MURILLO', 'BSIT', 1),
('2067915', 'RICOHERMOSO', 'BONNIE', 'TIGBAS', 'BSIT', 1),
('2068054', 'RAMON', 'JONATHAN', 'PAGALING', 'BSIT', 1),
('2068088', 'SALVAN', 'JUNNEL JEROME', 'EMBERDA', 'BSIT', 1),
('2068120', 'BORJA', 'JASON', 'AMORA', 'BSIT', 1),
('2068191', 'LEGASPO', 'Mikhail Jan', 'Llanos', 'BSIT', 1),
('2068212', 'DESAMITO', 'Jerick', 'Sabo', 'BSIT', 1),
('2068229', 'MABI', 'Scott', 'Daniel', 'BSIT', 1),
('2068409', 'EVANGELISTA', 'Kenneth', 'Matabalan', 'BSIT', 1),
('2068415', 'MAUSISA', 'Miko', 'Biong', 'BSIT', 1),
('2068421', 'CINCHEZ', 'Mark Jason', 'Polestico', 'BSIT', 1),
('2062973', 'Monleon', 'Johannes Glyn', 'Dupa', 'BSIT', 2),
('2050145', 'OCTAVIANO', 'RICKY', 'LOPEZ', 'BSIT', 1),
('2062038', 'Bagnol', 'Jairus Riel', 'Arreza', 'BSIT', 1),
('2066218', 'GEMENTIZA', 'JANFEL', 'YAMUT', 'BSIT', 1),
('2045934', 'MAGBANUA', 'JEFFREY', 'ESCABAL', 'BSIT', 2),
('2060741', 'Halasan', 'Paul Christian', 'Marfa', 'BSIT', 2),
('2060783', 'Arañez', 'Rey Vincent', 'Compas', 'BSIT', 2),
('2063877', 'Ladra', 'Charlyn', 'Barvas', 'BSIT', 2),
('2043822', 'LLAMADO', 'MARK ANGELO', 'OPEÑNA', 'BSIT', 3),
('2050479', 'TILAR', 'MARJON', 'CAAYAO', 'BSIT', 1),
('2062528', 'Aranaydo', 'Franz Joeper', 'Paghasian', 'BSIT', 1),
('2063171', 'Ybalane', 'Kervey Kent', 'Polgar', 'BSIT', 1),
('2063686', 'Baculio', 'Lineil Anthony', 'Pacamalan', 'BSIT', 1),
('2064561', 'Pelderos', 'Jomarie', 'Lausa', 'BSIT', 1),
('2064852', 'Remulta', 'Jyrus Noel', 'Manalili', 'BSIT', 1),
('2065476', 'Tanato', 'Neil Christian', 'Arais', 'BSIT', 1),
('2065499', 'Sobradil', 'Michael John', 'Abao', 'BSIT', 1),
('2066051', 'Nale', 'James Timothy', 'D', 'BSIT', 1),
('2066395', 'MANTOC', 'MARY ROSE', 'SINTO', 'BSIT', 1),
('2066397', 'MOSLIMEN', 'AL RAJIE', 'HASSAN', 'BSIT', 1),
('2066399', 'BENITO', 'NIZAM', 'HASSAN', 'BSIT', 1),
('2066406', 'ANDAGAN', 'JULIE ANN', 'TABAMO', 'BSIT', 1),
('2066513', 'TUBAY', 'RASSEL JEAN', 'DAMIT', 'BSIT', 1),
('2066624', 'OPO', 'SHAINA YVONNE', 'GADIAN', 'BSIT', 1),
('2066633', 'DAHILAN', 'GREGG ROMMEL', 'SANTUA', 'BSIT', 1),
('2044250', 'ALCALA', 'PHILIP ANTHONY', 'YAMON', 'BSIT', 2),
('2047001', 'BOLIVAR', 'JOSE ROIE, JR.', 'BAGAS', 'BSIT', 2),
('2050292', 'MONEVA', 'ED ADDAMMES', 'OMAS-AS', 'BSIT', 2),
('2060052', 'Cabanos', 'Lloyd Lois', 'Cabatino', 'BSIT', 2),
('2060285', 'Vaguchay', 'Henrick Daryl', 'Pahunang', 'BSIT', 2),
('2060708', 'Nobelo', 'Bobby', 'Vecina', 'BSIT', 2),
('2061099', 'Cabaraban', 'Chester', 'Hora', 'BSIT', 2),
('2061228', 'Dalapag', 'Joylynn', 'Marban', 'BSIT', 2),
('2061282', 'Navas', 'Clarence Louie', 'Alulod', 'BSIT', 2),
('2062090', 'Nono', 'Woodford', 'Pellerin', 'BSIT', 2),
('2062301', 'Garces', 'Leoj Liandre', 'Quilaton', 'BSIT', 2),
('2062513', 'Pinili', 'Almer John', 'Magdadaro', 'BSIT', 2),
('2062654', 'Ediza', 'Justine Oliver', 'Toledo', 'BSIT', 2),
('2062924', 'Palapar', 'Jay', 'Pacunio', 'BSIT', 2),
('2062984', 'Cagampang', 'Richard', 'W', 'BSIT', 2),
('2063324', 'Dalondonan', 'Niño', 'Magallanes', 'BSIT', 2),
('2063341', 'Medrano', 'Ronnel', 'Belarte', 'BSIT', 2),
('2063597', 'Bual', 'Caryl Lyn', 'Caiña', 'BSIT', 2),
('2063895', 'Deki', 'Sittie Aikha', 'Casidar', 'BSIT', 2),
('2064007', 'Lacsento', 'Jozua Jireh', 'Barojabo', 'BSIT', 2),
('2064009', 'Pontillas', 'Kiddie June', 'Jacalan', 'BSIT', 2),
('2064333', 'Baja', 'Maria Zyrrah Lou', 'Bisto', 'BSIT', 2),
('2064503', 'Cabingas', 'Jomari Mar', 'Tilap', 'BSIT', 2),
('2064811', 'Lloren', 'Marl Joseph', 'Tabunan', 'BSIT', 2),
('2065297', 'Salmorin', 'Clarinda May', 'Oclarit', 'BSIT', 2),
('2065300', 'Ybañez', 'Sean Philippe', 'Dy', 'BSIT', 2),
('2065376', 'Ilongo', 'Jay Mark', 'Costelo', 'BSIT', 2),
('2065414', 'Bron', 'Verwin', 'Malanog', 'BSIT', 2),
('2065434', 'Tagubar', 'Kate Jhastine Claire', 'Oraiz', 'BSIT', 2),
('2065515', 'Manoga', 'Alnoor', 'Alonto', 'BSIT', 2),
('2065708', 'Nailes', 'Eduard Allan Kay', 'Dayaba', 'BSIT', 2),
('2065805', 'Radaza', 'Niño Chris', 'Flores', 'BSIT', 2),
('2065816', 'Barcelona', 'Leeann Jo', 'Atienza', 'BSIT', 2),
('2065823', 'Guno', 'Hazel Jean', 'Permias', 'BSIT', 2),
('2065877', 'MOLINA', 'PHILIP RAFAEL', 'CAJUTOR', 'BSIT', 2),
('2065959', 'SALAMAÑA', 'IRISH', 'LEPITEN', 'BSIT', 2),
('2066042', 'Gundaya', 'Rannel', 'Hamot', 'BSIT', 2),
('2066113', 'Fariola', 'Chrysler', 'Labado', 'BSIT', 2),
('2066156', 'Castillon', 'Tracy', 'Amil', 'BSIT', 2),
('2066242', 'ZOILON', 'AUREA MARIE', 'MACEDA', 'BSIT', 2),
('2066283', 'BASA', 'MARK KINNELL', 'ESMEDINA', 'BSIT', 2),
('2066298', 'BILO', 'HENRY', 'OBERT', 'BSIT', 2),
('2066418', 'ABARQUEZ', 'SIMEON JR.', 'GALGO', 'BSIT', 2),
('2066465', 'LAUDE', 'RIC HIGENBERT', 'CAILING', 'BSIT', 2),
('2028530', 'BACUS', 'RICHARD', 'DONATO', 'BSIT', 3),
('2044960', 'UY', 'KEN RYAN', 'MAAGAD', 'BSIT', 3),
('2048243', 'YECLA', 'MARJONE', 'PALAMINE', 'BSIT', 3),
('2049399', 'LUNA', 'ANDRO', 'LIM', 'BSIT', 3),
('2049400', 'UA-O', 'MARK GERALD', 'CULAJARA', 'BSIT', 3),
('2050018', 'OPON', 'JOHN LEIHNARD', 'MANZON', 'BSIT', 3),
('2050357', 'BACULIO', 'JUNE', 'ESTALLO', 'BSIT', 3),
('2050370', 'ENTERINA', 'ARNOLD', 'OLAPE', 'BSIT', 3),
('2050475', 'MALALAY', 'RYAN CHRISTOPHER', 'TORRECAMPO', 'BSIT', 3),
('2060231', 'Ragay Jr.', 'Joel', 'Gerodico', 'BSIT', 3),
('2060391', 'Noob', 'Kenneth Adrian', 'Jandayan', 'BSIT', 3),
('2060639', 'Lafuente', 'Rhenalyn Joy', 'Bacayana', 'BSIT', 3),
('2061000', 'Quisil', 'Jasper', 'Malolot', 'BSIT', 3),
('2061010', 'Bacu', 'Elvin', 'Estribor', 'BSIT', 3),
('2061138', 'Petalver', 'Alfie', 'Booc', 'BSIT', 3),
('2062360', 'Pontilar', 'Jonique Frances', 'Rule', 'BSIT', 3),
('2062655', 'Cuaresma', 'Bonnel', 'Echano', 'BSIT', 3),
('2062684', 'Abonitalla', 'Dee Rick Dave', 'Logronio', 'BSIT', 3),
('2062859', 'Dela Cruz', 'Harcy Joy', 'B', 'BSIT', 3),
('2062892', 'Moran', 'Cobi', 'Abejuela', 'BSIT', 3),
('2062895', 'Rapirap', 'Mary Jean', 'Almonte', 'BSIT', 3),
('2062897', 'Lumahang', 'Shaina', 'Saplot', 'BSIT', 3),
('2062965', 'Algabre Jr.', 'Victor', 'Bacayana', 'BSIT', 3),
('2062968', 'Cagol', 'Dc Ann', 'Cabanes', 'BSIT', 3),
('2063098', 'Madelo', 'Jelein Mae', 'Sajulan', 'BSIT', 3),
('2063122', 'Jarap', 'Arah Nova', 'Bartolaba', 'BSIT', 3),
('2063279', 'Baconguis', 'Troyiel', 'Serad', 'BSIT', 3),
('2063427', 'Gayloa', 'Gezelle Lloren', 'Lloren', 'BSIT', 3),
('2063456', 'Casas', 'Kenneth Michael', 'Londera', 'BSIT', 3),
('2063569', 'Agot', 'Micky', 'Gonzales', 'BSIT', 3),
('2063641', 'Jaso', 'Meara Zoe', 'Peritos', 'BSIT', 3),
('2063700', 'Arsenal', 'Lauren', 'Danuco', 'BSIT', 3),
('2063778', 'Abroqueña', 'Karr Louie', 'Pimenel', 'BSIT', 3),
('2064021', 'Cornepillo', 'Dionelle Krystian', 'Polley', 'BSIT', 3),
('2064032', 'Cabanducos', 'Prince Rey', 'Ayupan', 'BSIT', 3),
('2066072', 'Boter', 'Maxin', 'Soner', 'BSIT', 3),
('2034952', 'ANTIPAS', 'LIEZEL', 'BAGUHIN', 'BSIT', 4),
('2047806', 'DEJOS', 'ALFONSE OTHELO', 'CASIÑO', 'BSIT', 4),
('2048099', 'ZULITA', 'CLAIRE', 'MAGSALAY', 'BSIT', 4),
('2049228', 'AMBOY', 'KATHLEEN', 'OBSIOMA', 'BSIT', 4),
('2049308', 'LUCHIN', 'MARWIN', 'CAJILLA', 'BSIT', 4),
('2049359', 'MANGONDATO', 'ZAIDE', 'ADAYA', 'BSIT', 4),
('2049420', 'LAPUT', 'DIXIE MARIE', 'ABEJUELA', 'BSIT', 4),
('2049608', 'MABALACAD', 'MARK JAIME', 'GALLARDE', 'BSIT', 4),
('2049665', 'ESTAÑO', 'DANMER', 'PONGO', 'BSIT', 4),
('2050820', 'ZURITA', 'ROEL', 'OLAER', 'BSIT', 4),
('2050875', 'DULAY', 'FRANCIS RAFAEL', 'IGTOS', 'BSIT', 4),
('2060299', 'Torres', 'Keylynn Joy', 'Cabebe', 'BSIT', 4),
('2060495', 'Agan', 'Rocky', 'Mallari', 'BSIT', 4),
('2060586', 'Palasan', 'GarFunkel', 'Ouano', 'BSIT', 4),
('2060706', 'Glodove', 'Rotsen Jay', 'Camay', 'BSIT', 4),
('2060718', 'Amit', 'Janilla', 'Nambatac', 'BSIT', 4),
('2060833', 'Bagabaldo', 'Jemimah', '', 'BSIT', 4),
('2060853', 'Oba-ob', 'Wahlenlou', 'Cañeda', 'BSIT', 4),
('2060962', 'Cañas Jr.', 'Mario', 'Dagpin', 'BSIT', 4),
('2061100', 'Montejo', 'Jasmin Beatrice', 'Rugue', 'BSIT', 4),
('2061640', 'Buhia', 'Lea Jhanica', 'Mangcunsay', 'BSIT', 4),
('2067497', 'CUBILLAN', 'ROY JHON', 'ISRAEL', 'BSIT', 1),
('2067611', 'CATAYLO', 'JOEL JAY', 'ESCOBIDO', 'BSIT', 1),
('2067616', 'TORRES', 'JOHN RHEU', 'SAJULGA', 'BSIT', 1),
('2067670', 'MONTEMAYOR', 'JONNA', 'DUITES', 'BSIT', 1),
('2067742', 'BARTOLATA', 'LOUIE JOHN', 'SODER', 'BSIT', 1),
('2067802', 'PAGASPAS', 'DYANARA', 'VALCORZA', 'BSIT', 1),
('2067932', 'TANDUYAN', 'ANNESA', 'VILLASORDA', 'BSIT', 1),
('2068094', 'TARAN', 'ALEXANDER', 'BENDIJO', 'BSIT', 1),
('2068112', 'BALANDRA', 'MATTHEW AXEL', 'SISON', 'BSIT', 1),
('2068127', 'SANTILLAN', 'Grant CJ', 'Codoy', 'BSIT', 1),
('2068143', 'LACABA', 'Arsunel', 'Quitay', 'BSIT', 1),
('2068160', 'CONDE', 'Francis Art', 'Esmeralda', 'BSIT', 1),
('2068161', 'TORAYNO', 'James', 'Coca', 'BSIT', 1),
('2068182', 'BAUTISTA', 'Rommel', 'Gascon', 'BSIT', 1),
('2068295', 'Añora', 'Noel', 'Galupo', 'BSIT', 1),
('2068306', 'Aliñar', 'Daffny Jean', 'Morata', 'BSIT', 1),
('2068363', 'DAMPA', 'Mohammad-Nor', 'Diambrang', 'BSIT', 1),
('2067758', 'SILAO', 'RACHELLE', 'ABARICO', 'BSIT', 4);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_time_interv`
--

CREATE TABLE IF NOT EXISTS `tbl_time_interv` (
  `ti_id` varchar(45) NOT NULL,
  `li_AM_o` varchar(45) NOT NULL,
  `li_AM_c` varchar(45) NOT NULL,
  `lo_AM_o` varchar(45) NOT NULL,
  `lo_AM_c` varchar(45) NOT NULL,
  `li_PM_o` varchar(45) NOT NULL,
  `li_PM_c` varchar(45) NOT NULL,
  `lo_PM_o` varchar(45) NOT NULL,
  `lo_PM_c` varchar(45) NOT NULL,
  PRIMARY KEY (`ti_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_time_interv`
--

INSERT INTO `tbl_time_interv` (`ti_id`, `li_AM_o`, `li_AM_c`, `lo_AM_o`, `lo_AM_c`, `li_PM_o`, `li_PM_c`, `lo_PM_o`, `lo_PM_c`) VALUES
('TI101', '3:08:00', '3:09:00', '3:10:00', '3:11:00', '3:12:00', '3:13:00', '3:14:00', '3:15:00');

-- --------------------------------------------------------

--
-- Stand-in structure for view `v_id1`
--
CREATE TABLE IF NOT EXISTS `v_id1` (
`id_no` varchar(45)
,`full_name` varchar(272)
,`am_login` varchar(5)
,`am_logout` varchar(5)
,`pm_login` varchar(5)
,`pm_logout` varchar(5)
,`event_id` varchar(45)
,`event_name` varchar(99)
);
-- --------------------------------------------------------

--
-- Stand-in structure for view `v_id2`
--
CREATE TABLE IF NOT EXISTS `v_id2` (
`id_no` varchar(45)
,`full_name` varchar(272)
,`am_login` varchar(5)
,`am_logout` varchar(5)
,`pm_login` varchar(5)
,`pm_logout` varchar(5)
,`event_id` varchar(45)
,`event_name` varchar(99)
);
-- --------------------------------------------------------

--
-- Stand-in structure for view `v_studrec`
--
CREATE TABLE IF NOT EXISTS `v_studrec` (
`id_no` varchar(45)
,`full_name` varchar(272)
,`course_code` varchar(45)
,`yr_lvl` int(1)
);
-- --------------------------------------------------------

--
-- Structure for view `v_id1`
--
DROP TABLE IF EXISTS `v_id1`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_id1` AS select `id1`.`id_no` AS `id_no`,`v_studrec`.`full_name` AS `full_name`,`id1`.`am_login` AS `am_login`,`id1`.`am_logout` AS `am_logout`,`id1`.`pm_login` AS `pm_login`,`id1`.`pm_logout` AS `pm_logout`,`id1`.`event_id` AS `event_id`,`tbl_event`.`event_name` AS `event_name` from ((`id1` join `v_studrec`) join `tbl_event`) where ((`id1`.`id_no` = `v_studrec`.`id_no`) and (`id1`.`event_id` = `tbl_event`.`event_id`));

-- --------------------------------------------------------

--
-- Structure for view `v_id2`
--
DROP TABLE IF EXISTS `v_id2`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_id2` AS select `id2`.`id_no` AS `id_no`,`v_studrec`.`full_name` AS `full_name`,`id2`.`am_login` AS `am_login`,`id2`.`am_logout` AS `am_logout`,`id2`.`pm_login` AS `pm_login`,`id2`.`pm_logout` AS `pm_logout`,`id2`.`event_id` AS `event_id`,`tbl_event`.`event_name` AS `event_name` from ((`id2` join `v_studrec`) join `tbl_event`) where ((`id2`.`id_no` = `v_studrec`.`id_no`) and (`id2`.`event_id` = `tbl_event`.`event_id`));

-- --------------------------------------------------------

--
-- Structure for view `v_studrec`
--
DROP TABLE IF EXISTS `v_studrec`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_studrec` AS select `tbl_studrec`.`id_no` AS `id_no`,concat(`tbl_studrec`.`lname`,' ',`tbl_studrec`.`fname`,' ',`tbl_studrec`.`mname`) AS `full_name`,`tbl_studrec`.`course_code` AS `course_code`,`tbl_studrec`.`yr_lvl` AS `yr_lvl` from `tbl_studrec` order by concat(`tbl_studrec`.`lname`,' ',`tbl_studrec`.`fname`,' ',`tbl_studrec`.`mname`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
