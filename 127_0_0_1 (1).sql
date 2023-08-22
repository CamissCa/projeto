-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Tempo de geração: 22-Ago-2023 às 01:27
-- Versão do servidor: 8.0.31
-- versão do PHP: 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `avastore`
--
DROP DATABASE IF EXISTS `avastore`;
CREATE DATABASE IF NOT EXISTS `avastore` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci;
USE `avastore`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `cadastrar`
--

DROP TABLE IF EXISTS `cadastrar`;
CREATE TABLE IF NOT EXISTS `cadastrar` (
  `nome` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `gmail` varchar(70) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `senha` varchar(8) NOT NULL,
  `id_perfil` varchar(12) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`gmail`),
  KEY `FK_perfil` (`id_perfil`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `cadastrar`
--

INSERT INTO `cadastrar` (`nome`, `gmail`, `senha`, `id_perfil`) VALUES
('pdspdo', 'ewqdwq', 'dwdwq', 'vendedor'),
('dwsdcs', 'ferwqfre', 'gtfreqwf', 'cliente'),
('1', '1', '1', 'cliente'),
('cami', 'aquilla', '1234', 'vendedor');

-- --------------------------------------------------------

--
-- Estrutura da tabela `perfil`
--

DROP TABLE IF EXISTS `perfil`;
CREATE TABLE IF NOT EXISTS `perfil` (
  `id_perfil` int NOT NULL AUTO_INCREMENT,
  `pefil` varchar(10) NOT NULL,
  PRIMARY KEY (`id_perfil`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `perfil`
--

INSERT INTO `perfil` (`id_perfil`, `pefil`) VALUES
(1, 'cliente'),
(2, 'vendedor');

-- --------------------------------------------------------

--
-- Estrutura da tabela `produto`
--

DROP TABLE IF EXISTS `produto`;
CREATE TABLE IF NOT EXISTS `produto` (
  `id_produto` int NOT NULL AUTO_INCREMENT,
  `nome_prod` varchar(100) NOT NULL,
  `descricao` varchar(300) NOT NULL,
  `preco` varchar(6) NOT NULL,
  `foto` varchar(400) NOT NULL,
  PRIMARY KEY (`id_produto`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `produto`
--

INSERT INTO `produto` (`id_produto`, `nome_prod`, `descricao`, `preco`, `foto`) VALUES
(2, 'dino', 'sdf', '12', '‪C:\\Users\\aluno\\Downloads\\dinon.png'),
(3, 'insira o nome de seu produto...', 'descreva o produto', '10', 'C:\\Users\\aluno\\Downloads\\dinon.png');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
