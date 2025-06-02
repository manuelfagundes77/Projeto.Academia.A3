9CREATE DATABASE  IF NOT EXISTS `dbacademia` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `dbacademia`;
-- MySQL dump 10.13  Distrib 8.0.42, for Win64 (x86_64)
--
-- Host: localhost    Database: dbacademia
-- ------------------------------------------------------
-- Server version	8.0.42

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `exercicios`
--

DROP TABLE IF EXISTS `exercicios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `exercicios` (
  `ExercicioId` int NOT NULL AUTO_INCREMENT,
  `Nome` varchar(100) NOT NULL,
  `Serie` varchar(10) NOT NULL,
  `Repeticoes` varchar(10) NOT NULL,
  `SubTreinoId` int DEFAULT NULL,
  PRIMARY KEY (`ExercicioId`),
  KEY `SubTreinoId` (`SubTreinoId`),
  CONSTRAINT `exercicios_ibfk_2` FOREIGN KEY (`SubTreinoId`) REFERENCES `treinosub` (`SubTreinoId`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=50 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `funcionario`
--

DROP TABLE IF EXISTS `funcionario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `funcionario` (
  `FuncionarioId` int NOT NULL AUTO_INCREMENT,
  `Nome` varchar(100) NOT NULL,
  `Cargo` varchar(50) NOT NULL,
  `Login` varchar(50) NOT NULL,
  `Senha` varchar(255) NOT NULL,
  PRIMARY KEY (`FuncionarioId`),
  UNIQUE KEY `UQ_Funcionario_Login` (`Login`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `membros`
--

DROP TABLE IF EXISTS `membros`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `membros` (
  `AlunoId` int NOT NULL AUTO_INCREMENT,
  `Nome` varchar(100) NOT NULL,
  `CPF` char(11) NOT NULL,
  `Telefone` varchar(15) DEFAULT NULL,
  `Endereco` varchar(255) DEFAULT NULL,
  `DataCadastro` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`AlunoId`),
  UNIQUE KEY `CPF` (`CPF`)
) ENGINE=InnoDB AUTO_INCREMENT=68 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `pagamentos`
--

DROP TABLE IF EXISTS `pagamentos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pagamentos` (
  `PagamentoId` int NOT NULL AUTO_INCREMENT,
  `AlunoId` int NOT NULL,
  `Mes` varchar(7) NOT NULL,
  `Situacao` enum('Pendente','Pago') DEFAULT 'Pendente',
  `DataPagamento` datetime DEFAULT NULL,
  PRIMARY KEY (`PagamentoId`),
  UNIQUE KEY `AlunoId` (`AlunoId`,`Mes`),
  CONSTRAINT `pagamentos_ibfk_1` FOREIGN KEY (`AlunoId`) REFERENCES `membros` (`AlunoId`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=519 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `treinos`
--

DROP TABLE IF EXISTS `treinos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `treinos` (
  `TreinoId` int NOT NULL AUTO_INCREMENT,
  `AlunoId` int NOT NULL,
  `Tipo` varchar(50) NOT NULL,
  `Descricao` text NOT NULL,
  `Duracao` varchar(50) NOT NULL,
  `DataInicio` datetime NOT NULL,
  `FuncionarioId` int DEFAULT NULL,
  PRIMARY KEY (`TreinoId`),
  KEY `fk_aluno_treino` (`AlunoId`),
  KEY `fk_funcionario_treino` (`FuncionarioId`),
  CONSTRAINT `fk_aluno_treino` FOREIGN KEY (`AlunoId`) REFERENCES `membros` (`AlunoId`) ON DELETE CASCADE,
  CONSTRAINT `fk_funcionario_treino` FOREIGN KEY (`FuncionarioId`) REFERENCES `funcionario` (`FuncionarioId`) ON DELETE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=67 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `treinosub`
--

DROP TABLE IF EXISTS `treinosub`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `treinosub` (
  `SubTreinoId` int NOT NULL AUTO_INCREMENT,
  `TreinoId` int NOT NULL,
  `Nome` varchar(50) NOT NULL,
  PRIMARY KEY (`SubTreinoId`),
  KEY `TreinoId` (`TreinoId`),
  CONSTRAINT `treinosub_ibfk_1` FOREIGN KEY (`TreinoId`) REFERENCES `treinos` (`TreinoId`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=66 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-05-28  9:13:34
