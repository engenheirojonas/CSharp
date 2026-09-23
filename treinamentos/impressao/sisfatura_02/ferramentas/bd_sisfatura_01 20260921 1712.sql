-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.5.5-10.4.32-MariaDB


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema bd_sistemafatura_01
--

CREATE DATABASE IF NOT EXISTS bd_sistemafatura_01;
USE bd_sistemafatura_01;

--
-- Definition of table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
CREATE TABLE `clientes` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  `nif` varchar(20) NOT NULL,
  `endereco` varchar(150) DEFAULT NULL,
  `telefone` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `nif` (`nif`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `clientes`
--

/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` (`id`,`nome`,`nif`,`endereco`,`telefone`) VALUES 
 (1,'jonas','50001','luvassa','999'),
 (2,'sambo','50002','zangoio','888');
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;


--
-- Definition of table `fatura_itens`
--

DROP TABLE IF EXISTS `fatura_itens`;
CREATE TABLE `fatura_itens` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `fatura_id` int(11) DEFAULT NULL,
  `produto_id` int(11) DEFAULT NULL,
  `quantidade` int(11) NOT NULL,
  `preco_unitario` decimal(10,2) NOT NULL,
  `subtotal` decimal(10,2) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fatura_id` (`fatura_id`),
  KEY `produto_id` (`produto_id`),
  CONSTRAINT `fatura_itens_ibfk_1` FOREIGN KEY (`fatura_id`) REFERENCES `faturas` (`id`) ON DELETE CASCADE,
  CONSTRAINT `fatura_itens_ibfk_2` FOREIGN KEY (`produto_id`) REFERENCES `produtos` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `fatura_itens`
--

/*!40000 ALTER TABLE `fatura_itens` DISABLE KEYS */;
INSERT INTO `fatura_itens` (`id`,`fatura_id`,`produto_id`,`quantidade`,`preco_unitario`,`subtotal`) VALUES 
 (1,5,1,3,'500.00','1500.00'),
 (2,5,2,2,'5000.00','10000.00'),
 (3,6,1,3,'2500.00','7500.00'),
 (4,6,1,3,'250.00','750.00'),
 (5,6,1,5,'100.00','500.00'),
 (6,7,1,3,'2500.00','7500.00'),
 (7,7,1,3,'250.00','750.00'),
 (8,7,1,5,'100.00','500.00');
/*!40000 ALTER TABLE `fatura_itens` ENABLE KEYS */;


--
-- Definition of table `faturas`
--

DROP TABLE IF EXISTS `faturas`;
CREATE TABLE `faturas` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `data_emissao` datetime DEFAULT current_timestamp(),
  `cliente_id` int(11) DEFAULT NULL,
  `total` decimal(10,2) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `cliente_id` (`cliente_id`),
  CONSTRAINT `faturas_ibfk_1` FOREIGN KEY (`cliente_id`) REFERENCES `clientes` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `faturas`
--

/*!40000 ALTER TABLE `faturas` DISABLE KEYS */;
INSERT INTO `faturas` (`id`,`data_emissao`,`cliente_id`,`total`) VALUES 
 (1,'2026-09-21 15:27:03',1,'1300.00'),
 (2,'2026-09-21 15:40:45',1,'3000.00'),
 (3,'2026-09-21 15:40:51',1,'3000.00'),
 (4,'2026-09-21 15:45:01',1,'2500.00'),
 (5,'2026-09-21 16:02:14',2,'11500.00'),
 (6,'2026-09-21 16:40:27',1,'8750.00'),
 (7,'2026-09-21 16:42:40',1,'8750.00');
/*!40000 ALTER TABLE `faturas` ENABLE KEYS */;


--
-- Definition of table `produtos`
--

DROP TABLE IF EXISTS `produtos`;
CREATE TABLE `produtos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `descricao` varchar(100) NOT NULL,
  `preco_unitario` decimal(10,2) NOT NULL,
  `stock` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `produtos`
--

/*!40000 ALTER TABLE `produtos` DISABLE KEYS */;
INSERT INTO `produtos` (`id`,`descricao`,`preco_unitario`,`stock`) VALUES 
 (1,'arroz','500.00',10),
 (2,'feijao','1000.00',7),
 (3,'batata','400.00',10);
/*!40000 ALTER TABLE `produtos` ENABLE KEYS */;




/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
