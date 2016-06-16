-- phpMyAdmin SQL Dump
-- version 4.6.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Jun 16, 2016 at 12:11 PM
-- Server version: 5.6.30
-- PHP Version: 7.0.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `censordb`
--

-- --------------------------------------------------------

--
-- Table structure for table `censortable`
--

CREATE TABLE `censortable` (
  `censorID` int(11) NOT NULL,
  `fname` varchar(25) NOT NULL,
  `mname` varchar(25) NOT NULL,
  `lname` varchar(25) NOT NULL,
  `sex` varchar(25) NOT NULL,
  `maritalstatus` varchar(25) NOT NULL,
  `dob` date NOT NULL,
  `email` varchar(50) NOT NULL,
  `phonenumber` varchar(13) NOT NULL,
  `stateoforigin` varchar(25) NOT NULL,
  `nationality` varchar(50) NOT NULL,
  `employmentstatus` varchar(50) NOT NULL,
  `worksector` varchar(25) NOT NULL,
  `officeoffice` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `censortable`
--

INSERT INTO `censortable` (`censorID`, `fname`, `mname`, `lname`, `sex`, `maritalstatus`, `dob`, `email`, `phonenumber`, `stateoforigin`, `nationality`, `employmentstatus`, `worksector`, `officeoffice`) VALUES
(1, 'queen', 'bisola', 'daniels', 'female', '', '1989-06-20', '', '0', 'lagos', 'nigeria', '', 'private', 'sci, sabo, yabo, lagos.'),
(2, 'yetunde', 'christiana', 'abioye', 'female', '', '1994-06-01', '', '0', 'osun ', 'nigeria', '', 'government', 'air force primary school, kano.'),
(3, 'ayo', 'deji', 'abimbola', 'male', '', '1990-04-11', '', '0', 'oyo', 'nigeria', '', 'private', 'techpoint, ikeja.'),
(4, 'nancy', 'chioma', 'deji', 'FEMALE', 'married', '1995-06-15', 'nancychioma@gmail.com', '2147483647', 'Ogun', 'Nigeria', 'employed', 'PRIVATE', 'andella house'),
(5, 'jjsckjd', 'cvv', 'hfbv', 'MALE', 'single', '2016-06-15', 'acvfcd@yahoo.com', '08130452345', 'Ondo', 'Burundi', 'unemployed', 'GOVERNMENT', 'j,khk,lol');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `censortable`
--
ALTER TABLE `censortable`
  ADD PRIMARY KEY (`censorID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `censortable`
--
ALTER TABLE `censortable`
  MODIFY `censorID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
