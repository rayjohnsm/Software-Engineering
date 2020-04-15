-- phpMyAdmin SQL Dump
-- version 3.2.4
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Apr 15, 2020 at 11:49 pm
-- Server version: 5.5.54
-- PHP Version: 5.3.1

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `aiso`
--

-- --------------------------------------------------------

--
-- Table structure for table `aiso_codegen`
--

CREATE TABLE IF NOT EXISTS `aiso_codegen` (
  `code_id` int(9) NOT NULL AUTO_INCREMENT,
  `code_barcode` varchar(255) NOT NULL,
  `prod_id` int(9) NOT NULL,
  PRIMARY KEY (`code_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `aiso_codegen`
--

INSERT INTO `aiso_codegen` (`code_id`, `code_barcode`, `prod_id`) VALUES
(1, '1001', 1);

-- --------------------------------------------------------

--
-- Table structure for table `aiso_products`
--

CREATE TABLE IF NOT EXISTS `aiso_products` (
  `prod_code` int(9) NOT NULL AUTO_INCREMENT,
  `prod_barcode` int(9) NOT NULL,
  `prod_name` varchar(255) NOT NULL,
  `prod_color` varchar(255) NOT NULL,
  `prod_quantity` int(9) NOT NULL,
  `prod_size` varchar(255) NOT NULL,
  `prod_price` int(9) NOT NULL,
  `prod_whoAdded` int(9) NOT NULL,
  PRIMARY KEY (`prod_code`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `aiso_products`
--

INSERT INTO `aiso_products` (`prod_code`, `prod_barcode`, `prod_name`, `prod_color`, `prod_quantity`, `prod_size`, `prod_price`, `prod_whoAdded`) VALUES
(1, 1001, 'bag', 'blue', 100, 'large', 100, 151501);

-- --------------------------------------------------------

--
-- Table structure for table `aiso_users`
--

CREATE TABLE IF NOT EXISTS `aiso_users` (
  `user_id` int(11) NOT NULL AUTO_INCREMENT,
  `user_fname` varchar(255) NOT NULL,
  `user_lname` varchar(255) NOT NULL,
  `user_mname` varchar(255) NOT NULL,
  `user_bdate` varchar(255) NOT NULL,
  `user_role` varchar(255) NOT NULL,
  `user_passw` varchar(255) NOT NULL,
  `user_style` varchar(255) NOT NULL,
  `user_whoAdd` int(9) NOT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=151510 ;

--
-- Dumping data for table `aiso_users`
--

INSERT INTO `aiso_users` (`user_id`, `user_fname`, `user_lname`, `user_mname`, `user_bdate`, `user_role`, `user_passw`, `user_style`, `user_whoAdd`) VALUES
(151501, 'Ray John', 'Man-on', 'Juson', 'nov 27 1999', 'Administrator', 'admin', 'DevExpress Style', 151501),
(151502, 'maricar', 'juson', 'man-on', '30/01/1990', 'Administrator', 'Password', 'DevExpress Style', 151501),
(151506, 'Edward', 'Juson', 'Man-on', '12/12/2000', 'Encoder', 'Password', 'DevExpress Style', 151502),
(151509, 'Angel Rose', 'Juson', 'Man-on', '01/01/1999', 'Cashier', 'Password', 'DevExpress Style', 151501);

-- --------------------------------------------------------

--
-- Table structure for table `aiso_users_logs`
--

CREATE TABLE IF NOT EXISTS `aiso_users_logs` (
  `user_log_id` int(9) NOT NULL AUTO_INCREMENT,
  `user_id` int(9) NOT NULL,
  `user_log_inDate` varchar(255) NOT NULL,
  `user_log_outDate` varchar(255) NOT NULL,
  PRIMARY KEY (`user_log_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

--
-- Dumping data for table `aiso_users_logs`
--


/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
