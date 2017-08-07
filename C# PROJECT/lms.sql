-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Aug 29, 2016 at 12:06 PM
-- Server version: 10.1.10-MariaDB
-- PHP Version: 5.5.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `lms`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `Id` varchar(50) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `Seq_pin` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`Id`, `Username`, `Password`, `Seq_pin`) VALUES
('1', 'Admin', '421', 'rice'),
('2', 'Admin1', '420', 'cricket');

-- --------------------------------------------------------

--
-- Table structure for table `book_details`
--

CREATE TABLE `book_details` (
  `Book_Id` varchar(50) NOT NULL,
  `Book_Name` varchar(50) NOT NULL,
  `Edition` varchar(5) NOT NULL,
  `Writer_Name` varchar(50) NOT NULL,
  `Shelf_No` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `book_details`
--

INSERT INTO `book_details` (`Book_Id`, `Book_Name`, `Edition`, `Writer_Name`, `Shelf_No`) VALUES
('g1', 'c#', '10th', 'karshof', '25'),
('h1', 'math3', '16th', 'kamal', '132'),
('h2', 'java', '7th', 'k.man', '128'),
('yooo7', 'pascle', '6th', 'taylor', '65');

-- --------------------------------------------------------

--
-- Table structure for table `borrow_history`
--

CREATE TABLE `borrow_history` (
  `User_Name` varchar(50) NOT NULL,
  `Book_Id` varchar(50) NOT NULL,
  `Borrow_date` varchar(50) NOT NULL,
  `Return_date` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `borrow_history`
--

INSERT INTO `borrow_history` (`User_Name`, `Book_Id`, `Borrow_date`, `Return_date`) VALUES
('user1', 'g1', '28/08/2016', '01/09/2016'),
('user2', 'g1', '28/08/2016', '02/09/2016');

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `ID` varchar(50) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Adress` varchar(100) NOT NULL,
  `Age` varchar(50) NOT NULL,
  `Salary` varchar(50) NOT NULL,
  `Joining_Date` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`ID`, `Name`, `Adress`, `Age`, `Salary`, `Joining_Date`) VALUES
('2', 'emp2', 'dhaka', '25', '15,800/-', '4th june 2015'),
('3', 'emp3', 'Dhaka', '24', '20,000/-', '2nd Mar 2012'),
('1', 'emp1', 'dhaka', '32', '18000/-', '10th mar 2016');

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE `supplier` (
  `Id` varchar(20) NOT NULL,
  `Name` varchar(80) NOT NULL,
  `Adress` varchar(50) NOT NULL,
  `Ammount` varchar(50) NOT NULL,
  `Paid` varchar(50) NOT NULL,
  `Date` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`Id`, `Name`, `Adress`, `Ammount`, `Paid`, `Date`) VALUES
('01', 'Khan printing and book store', 'purandhaka', '1000', '275,000/-', '4th july 2015');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `ID` int(10) NOT NULL,
  `Username` varchar(20) NOT NULL,
  `Password` varchar(20) NOT NULL,
  `Seq_pin` varchar(50) NOT NULL,
  `Address` varchar(100) NOT NULL,
  `Age` varchar(50) NOT NULL,
  `Gender` varchar(50) NOT NULL,
  `Mobile_no` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`ID`, `Username`, `Password`, `Seq_pin`, `Address`, `Age`, `Gender`, `Mobile_no`) VALUES
(1, 'user1', '2000', '2001', 'Dhaka', '21', 'Male', '0184-0052203'),
(2, 'user2', '1001', '444', 'hgjhg', '11', 'Male', '5555');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `book_details`
--
ALTER TABLE `book_details`
  ADD PRIMARY KEY (`Book_Id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
