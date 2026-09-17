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
-- Create schema bd_sistemastock_02
--

CREATE DATABASE IF NOT EXISTS bd_sistemastock_02;
USE bd_sistemastock_02;

--
-- Definition of table `categorias`
--

DROP TABLE IF EXISTS `categorias`;
CREATE TABLE `categorias` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  `descricao` text DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `categorias`
--

/*!40000 ALTER TABLE `categorias` DISABLE KEYS */;
INSERT INTO `categorias` (`id`,`nome`,`descricao`) VALUES 
 (1,'Mercearia e Alimentos','Tudo'),
 (2,'Higiene Pessoal e Cosmética','Tudo'),
 (3,'Limpeza e Cuidados com a Casa','Tudo');
/*!40000 ALTER TABLE `categorias` ENABLE KEYS */;


--
-- Definition of table `fornecedores`
--

DROP TABLE IF EXISTS `fornecedores`;
CREATE TABLE `fornecedores` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(150) NOT NULL,
  `contacto` varchar(20) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `endereco` text DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `fornecedores`
--

/*!40000 ALTER TABLE `fornecedores` DISABLE KEYS */;
INSERT INTO `fornecedores` (`id`,`nome`,`contacto`,`email`,`endereco`) VALUES 
 (1,'Ango','9999','ango@','Uneca'),
 (2,'Cabo','8888','cabo@','cabassango'),
 (3,'super','1111','super@','zona C');
/*!40000 ALTER TABLE `fornecedores` ENABLE KEYS */;


--
-- Definition of table `movimentacoes`
--

DROP TABLE IF EXISTS `movimentacoes`;
CREATE TABLE `movimentacoes` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `produto_id` int(11) NOT NULL,
  `tipo` enum('ENTRADA','SAÍDA') NOT NULL,
  `quantidade` int(11) NOT NULL,
  `data_movimentacao` datetime DEFAULT current_timestamp(),
  `motivo` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `produto_id` (`produto_id`),
  CONSTRAINT `movimentacoes_ibfk_1` FOREIGN KEY (`produto_id`) REFERENCES `produtos` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `movimentacoes`
--

/*!40000 ALTER TABLE `movimentacoes` DISABLE KEYS */;
INSERT INTO `movimentacoes` (`id`,`produto_id`,`tipo`,`quantidade`,`data_movimentacao`,`motivo`) VALUES 
 (1,2,'',20,'2026-09-16 16:47:21','rea'),
 (2,2,'SAÍDA',20,'2026-09-16 16:48:49','uso'),
 (3,2,'SAÍDA',30,'2026-09-16 16:49:29','uso'),
 (4,2,'SAÍDA',66,'2026-09-16 17:08:22','uso'),
 (5,2,'SAÍDA',10,'2026-09-16 17:09:03','y'),
 (6,2,'',6,'2026-09-16 17:10:38','rea'),
 (7,2,'SAÍDA',24,'2026-09-16 17:13:03','uso'),
 (8,2,'SAÍDA',11,'2026-09-16 17:13:55','uspo'),
 (9,2,'ENTRADA',10,'2026-09-16 17:33:54','REA');
/*!40000 ALTER TABLE `movimentacoes` ENABLE KEYS */;


--
-- Definition of trigger `trg_atualiza_stock`
--

DROP TRIGGER /*!50030 IF EXISTS */ `trg_atualiza_stock`;

DELIMITER $$

CREATE DEFINER = `root`@`localhost` TRIGGER `trg_atualiza_stock` AFTER INSERT ON `movimentacoes` FOR EACH ROW BEGIN
    IF NEW.tipo = 'ENTRADA' THEN
        UPDATE Produtos 
        SET quantidade_atual = quantidade_atual + NEW.quantidade
        WHERE id = NEW.produto_id;
    ELSEIF NEW.tipo = 'SAÍDA' THEN
        UPDATE Produtos 
        SET quantidade_atual = quantidade_atual - NEW.quantidade
        WHERE id = NEW.produto_id;
    END IF;
END $$

DELIMITER ;

--
-- Definition of table `produtos`
--

DROP TABLE IF EXISTS `produtos`;
CREATE TABLE `produtos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `codigo_barras` varchar(50) DEFAULT NULL,
  `nome` varchar(150) NOT NULL,
  `preco_compra` decimal(10,2) NOT NULL,
  `preco_venda` decimal(10,2) NOT NULL,
  `quantidade_atual` int(11) DEFAULT 0,
  `quantidade_minima` int(11) DEFAULT 5,
  `categoria_id` int(11) DEFAULT NULL,
  `fornecedor_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `codigo_barras` (`codigo_barras`),
  KEY `categoria_id` (`categoria_id`),
  KEY `fornecedor_id` (`fornecedor_id`),
  CONSTRAINT `produtos_ibfk_1` FOREIGN KEY (`categoria_id`) REFERENCES `categorias` (`id`) ON DELETE SET NULL,
  CONSTRAINT `produtos_ibfk_2` FOREIGN KEY (`fornecedor_id`) REFERENCES `fornecedores` (`id`) ON DELETE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `produtos`
--

/*!40000 ALTER TABLE `produtos` DISABLE KEYS */;
INSERT INTO `produtos` (`id`,`codigo_barras`,`nome`,`preco_compra`,`preco_venda`,`quantidade_atual`,`quantidade_minima`,`categoria_id`,`fornecedor_id`) VALUES 
 (2,'222','Arroz','2000.00','3500.00',60,5,1,1),
 (4,'333','Feijão','2000.00','3500.00',10,5,2,2),
 (5,'778','Papel Higiénico','2000.00','3500.00',10,5,3,3);
/*!40000 ALTER TABLE `produtos` ENABLE KEYS */;




/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
