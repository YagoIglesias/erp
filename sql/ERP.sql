-- --------------------------------------------------------
-- Hôte:                         127.0.0.1
-- Version du serveur:           10.3.34-MariaDB-1:10.3.34+maria~focal - mariadb.org binary distribution
-- SE du serveur:                debian-linux-gnu
-- HeidiSQL Version:             12.3.0.6589
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Listage de la structure de la base pour ERP
CREATE DATABASE IF NOT EXISTS `ERP` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `ERP`;

-- Listage de la structure de table ERP. t_client
CREATE TABLE IF NOT EXISTS `t_client` (
  `idClient` bigint(20) NOT NULL AUTO_INCREMENT,
  `cliName` varchar(50) NOT NULL,
  `cliLastName` varchar(50) NOT NULL,
  `cliCompanyName` varchar(50) NOT NULL,
  `cliAddress` varchar(50) NOT NULL,
  `cliCity` varchar(50) NOT NULL,
  `cliCounty` varchar(50) NOT NULL,
  `cliState` varchar(50) NOT NULL,
  `cliZip` int(11) NOT NULL,
  `cliPhone1` varchar(50) NOT NULL,
  `cliPhone2` varchar(50) NOT NULL,
  `cliEmail` varchar(50) NOT NULL,
  `cliWeb` varchar(50) NOT NULL,
  `cliUsserName` varchar(50) NOT NULL,
  `cliPassWord` varchar(50) NOT NULL,
  PRIMARY KEY (`idClient`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Les données exportées n'étaient pas sélectionnées.

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
