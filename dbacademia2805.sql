CREATE DATABASE  IF NOT EXISTS `dbacademia` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
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
-- Dumping data for table `exercicios`
--

LOCK TABLES `exercicios` WRITE;
/*!40000 ALTER TABLE `exercicios` DISABLE KEYS */;
INSERT INTO `exercicios` VALUES (15,'Crucifixo com Halteres','3','12',22),(22,'Supino Reto','3','6',29),(23,'Supino Inclinado','3','10',30),(24,'Crucifixo com Halteres','2','12',30),(25,'Crucifixo com Halteres','3','8',31),(26,'Crucifixo com Halteres','3','10',32),(27,'Supino Inclinado','3','10',33),(28,'Puxada Frontal','4','10',34),(29,'Tríceps Pulley','5','8',35),(30,'Tríceps Testa','4','12',36),(31,'Crucifixo com Halteres','4','10',37),(32,'Tríceps Pulley','5','8',38),(33,'Tríceps Testa','4','12',39),(34,'Crucifixo com Halteres','4','10',40),(35,'Supino Inclinado','3','12',41),(36,'Supino Inclinado','4','8',42),(37,'Tríceps Pulley','4','10',43),(38,'Supino Inclinado','4','10',44),(39,'Supino Inclinado','3','8',45),(40,'Tríceps Testa','5','12',46),(41,'Supino Inclinado','3','8',60),(42,'Supino Reto','4','8',60),(43,'Tríceps Testa','3','8',61),(44,'Crucifixo com Halteres','2','8',61),(45,'Tríceps Pulley','2','8',62),(46,'Remada Curvada','5','10',62),(47,'Supino Inclinado','2','8',63),(48,'Tríceps Testa','4','10',64),(49,'Tríceps Testa','4','10',65);
/*!40000 ALTER TABLE `exercicios` ENABLE KEYS */;
UNLOCK TABLES;

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
-- Dumping data for table `funcionario`
--

LOCK TABLES `funcionario` WRITE;
/*!40000 ALTER TABLE `funcionario` DISABLE KEYS */;
INSERT INTO `funcionario` VALUES (1,'João Silva','Professor','joao.silva','senha123'),(5,'Carlos','Gerente','carlos123','senha123'),(6,'Teste tela','Gerente','tela','123'),(7,'admin','Gerente','123','123'),(10,'manuel','Personal','ma','123'),(11,'admin','Gerente','ad','123'),(26,'João Manoel','Personal','joao@email.com','coxinha123');
/*!40000 ALTER TABLE `funcionario` ENABLE KEYS */;
UNLOCK TABLES;

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
-- Dumping data for table `membros`
--

LOCK TABLES `membros` WRITE;
/*!40000 ALTER TABLE `membros` DISABLE KEYS */;
INSERT INTO `membros` VALUES (2,'ttttt1','223232321','11111','22122121','2025-04-26 14:59:25'),(5,'b2 b2 b2','22222','12345566','kkkkkkkkkkkk','2025-04-26 19:54:01'),(7,'testeValidadornum','99999','11111','testeValidadornum','2025-04-27 09:41:58'),(8,'aaaaaaaaaaa','1','223','aaaaaaaa','2025-04-27 18:35:17'),(11,'k','11','4','dssddfsf','2025-04-29 12:51:11'),(12,'jjj','7','45454','jfjghg','2025-04-29 12:56:42'),(13,'bbbbbbbbbbbbb','777','322323','323322323','2025-04-29 13:09:26'),(14,'paga','2','23323432','asaaa','2025-04-29 14:25:08'),(15,'Manuel Fagundes','08926157458','11962955555','rua rua ruaa','2025-04-29 14:43:01'),(17,'caaaa3','3','32342432','fssfssfdfs','2025-04-29 20:58:09'),(19,'carlos miguel','10','43434334','aaaa','2025-05-12 14:12:48'),(67,'Otavio Paiva','70874639425','484848484','rua fulano de tal','2025-05-26 19:02:44');
/*!40000 ALTER TABLE `membros` ENABLE KEYS */;
UNLOCK TABLES;

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
-- Dumping data for table `pagamentos`
--

LOCK TABLES `pagamentos` WRITE;
/*!40000 ALTER TABLE `pagamentos` DISABLE KEYS */;
INSERT INTO `pagamentos` VALUES (2,13,'04/2025','Pago','2025-04-29 13:56:46'),(3,13,'05/2025','Pendente',NULL),(4,13,'06/2025','Pendente',NULL),(5,13,'07/2025','Pendente',NULL),(6,13,'08/2025','Pendente',NULL),(7,13,'09/2025','Pendente',NULL),(8,13,'10/2025','Pendente',NULL),(9,13,'11/2025','Pendente',NULL),(10,13,'12/2025','Pendente',NULL),(11,13,'01/2026','Pendente',NULL),(12,13,'02/2026','Pendente',NULL),(13,13,'03/2026','Pendente',NULL),(14,14,'04/2025','Pendente',NULL),(15,14,'05/2025','Pendente',NULL),(16,14,'06/2025','Pendente',NULL),(17,14,'07/2025','Pendente',NULL),(18,14,'08/2025','Pendente',NULL),(19,14,'09/2025','Pendente',NULL),(20,14,'10/2025','Pendente',NULL),(21,14,'11/2025','Pago','2025-04-29 15:05:16'),(22,14,'12/2025','Pago','2025-04-29 17:56:36'),(23,14,'01/2026','Pago','2025-04-29 14:59:51'),(24,14,'02/2026','Pendente',NULL),(25,14,'03/2026','Pendente',NULL),(26,15,'04/2025','Pago','2025-04-29 19:36:32'),(27,15,'05/2025','Pago','2025-04-30 19:20:13'),(28,15,'06/2025','Pago','2025-05-12 19:06:34'),(29,15,'07/2025','Pago','2025-05-12 19:17:34'),(30,15,'08/2025','Pago','2025-05-20 09:30:55'),(31,15,'09/2025','Pendente',NULL),(32,15,'10/2025','Pendente',NULL),(33,15,'11/2025','Pendente',NULL),(34,15,'12/2025','Pendente',NULL),(35,15,'01/2026','Pendente',NULL),(36,15,'02/2026','Pendente',NULL),(37,15,'03/2026','Pendente',NULL),(38,17,'04/2025','Pendente',NULL),(39,17,'05/2025','Pendente',NULL),(40,17,'06/2025','Pendente',NULL),(41,17,'07/2025','Pendente',NULL),(42,17,'08/2025','Pendente',NULL),(43,17,'09/2025','Pendente',NULL),(44,17,'10/2025','Pendente',NULL),(45,17,'11/2025','Pendente',NULL),(46,17,'12/2025','Pendente',NULL),(47,17,'01/2026','Pendente',NULL),(48,17,'02/2026','Pendente',NULL),(49,17,'03/2026','Pendente',NULL),(50,19,'05/2025','Pendente',NULL),(51,19,'06/2025','Pendente',NULL),(52,19,'07/2025','Pendente',NULL),(53,19,'08/2025','Pendente',NULL),(54,19,'09/2025','Pendente',NULL),(55,19,'10/2025','Pendente',NULL),(56,19,'11/2025','Pendente',NULL),(57,19,'12/2025','Pendente',NULL),(58,19,'01/2026','Pendente',NULL),(59,19,'02/2026','Pendente',NULL),(60,19,'03/2026','Pendente',NULL),(61,19,'04/2026','Pendente',NULL),(495,8,'05/2025','Pendente',NULL),(496,8,'06/2025','Pendente',NULL),(497,8,'07/2025','Pendente',NULL),(498,8,'08/2025','Pendente',NULL),(499,8,'09/2025','Pendente',NULL),(500,8,'10/2025','Pendente',NULL),(501,8,'11/2025','Pendente',NULL),(502,8,'12/2025','Pendente',NULL),(503,8,'01/2026','Pendente',NULL),(504,8,'02/2026','Pendente',NULL),(505,8,'03/2026','Pendente',NULL),(506,8,'04/2026','Pendente',NULL),(507,67,'05/2025','Pago','2025-05-26 19:03:58'),(508,67,'06/2025','Pendente',NULL),(509,67,'07/2025','Pendente',NULL),(510,67,'08/2025','Pendente',NULL),(511,67,'09/2025','Pendente',NULL),(512,67,'10/2025','Pendente',NULL),(513,67,'11/2025','Pendente',NULL),(514,67,'12/2025','Pendente',NULL),(515,67,'01/2026','Pendente',NULL),(516,67,'02/2026','Pendente',NULL),(517,67,'03/2026','Pendente',NULL),(518,67,'04/2026','Pendente',NULL);
/*!40000 ALTER TABLE `pagamentos` ENABLE KEYS */;
UNLOCK TABLES;

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
-- Dumping data for table `treinos`
--

LOCK TABLES `treinos` WRITE;
/*!40000 ALTER TABLE `treinos` DISABLE KEYS */;
INSERT INTO `treinos` VALUES (24,14,'Físico geral','bbb','30/04/2025','2025-04-30 09:53:54',NULL),(25,14,'Emagrecimento','aaaa','30/04/2025','2025-04-30 00:00:00',NULL),(28,14,'Emagrecimento','teste3','30/04/2025','2025-04-30 10:25:27',NULL),(29,14,'Físico geral','teste3','30/04/2025','2025-04-30 10:36:07',NULL),(31,14,'Emagrecimento','aa','09/05/2025','2025-04-30 18:56:37',NULL),(34,15,'Condicionamento','treino membro id???','06/06/2025','2025-05-01 09:42:58',NULL),(35,15,'Físico geral','vem o id func','22/05/2025','2025-05-01 09:56:14',11),(36,15,'Hipertrofia','treino 1','01/05/2025','2025-05-01 10:56:44',10),(37,15,'Hipertrofia','treino2','21/05/2025','2025-05-01 00:00:00',10),(38,15,'Força','treino3','29/05/2025','2025-04-30 11:28:42',10),(39,14,'Força','ttttt','15/05/2025','2025-04-27 11:47:15',10),(40,8,'Musculação','Treino de força','2025','2025-05-12 18:32:12',1),(41,8,'Musculação','Treino de força','2025','2025-05-12 18:37:40',1),(42,8,'Musculação','Treino de força','2025','2025-05-12 19:49:13',1),(43,8,'Musculação','Teste SUBTREINO','2025','2025-05-13 13:21:38',1),(44,8,'Musculação','Treino de força','2025','2025-05-13 13:21:39',1),(45,8,'Musculação','Teste SUBTREINO','2025','2025-05-13 14:59:08',1),(46,8,'Musculação','Treino de força','2025','2025-05-13 14:59:08',1),(47,8,'Musculação','Teste SUBTREINO','2025','2025-05-13 16:32:33',1),(48,8,'Musculação','Treino de força','2025','2025-05-13 16:32:34',1),(49,8,'Musculação','Teste SUBTREINO','2025','2025-05-13 16:48:13',1),(50,8,'Musculação','Treino de força','2025','2025-05-13 16:48:13',1),(51,8,'Musculação','Teste 5SUBTREINO','2025','2025-05-13 16:59:03',1),(52,8,'Musculação','Teste 5SUBTREINO','2025','2025-05-13 17:02:08',1),(53,8,'Musculação','Teste 5SUBTREINO','2025','2025-05-13 19:13:36',1),(54,8,'Musculação','Treino de força','2025','2025-05-13 19:13:36',1),(55,8,'Musculação','Teste 5SUBTREINO','2025','2025-05-13 20:13:36',1),(56,8,'Musculação','Treino de força','2025','2025-05-13 20:13:37',1),(57,8,'Musculação','Teste 5SUBTREINO','2025','2025-05-15 13:20:31',1),(58,8,'Musculação','Treino de força','2025','2025-05-15 13:20:31',1),(59,8,'Musculação','Treino de força','2025','2025-05-15 16:57:28',1),(60,8,'Musculação','Teste 5SUBTREINO','2025','2025-05-15 16:57:28',1),(61,8,'Musculação','Treino de força','2025','2025-05-20 10:35:12',1),(62,8,'Musculação','Teste 5SUBTREINO','2025','2025-05-20 10:35:12',1),(63,8,'Musculação','Treino de força','2025','2025-05-20 10:35:25',1),(64,8,'Musculação','Teste 5SUBTREINO','2025','2025-05-20 10:35:25',1),(65,67,'Força','treino 1','15/07/2025','2025-05-26 19:10:29',11),(66,67,'Força','treino Para o FRANGO','17/06/2025','2025-05-26 19:28:59',26);
/*!40000 ALTER TABLE `treinos` ENABLE KEYS */;
UNLOCK TABLES;

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

--
-- Dumping data for table `treinosub`
--

LOCK TABLES `treinosub` WRITE;
/*!40000 ALTER TABLE `treinosub` DISABLE KEYS */;
INSERT INTO `treinosub` VALUES (1,24,'A - Peito'),(3,24,'C - Costas'),(4,25,'A - Peito'),(5,25,'B - Pernas'),(13,28,'A - Peito'),(14,28,'B - Pernas'),(15,28,'C - Costas'),(16,29,'A - Peito'),(17,29,'B - Pernas'),(18,29,'C - Costas'),(22,31,'A - Peito'),(29,34,'A - Peito'),(30,34,'B - Pernas'),(31,34,'C - Costas'),(32,35,'A - Peito'),(33,35,'B - Pernas'),(34,35,'C - Costas'),(35,36,'A - Peito'),(36,36,'B - Pernas'),(37,36,'C - Costas'),(38,37,'A - Peito'),(39,37,'B - Pernas'),(40,37,'C - Costas'),(41,38,'A - Peito'),(42,38,'B - Pernas'),(43,38,'C - Costas'),(44,39,'A - Peito'),(45,39,'B - Pernas'),(46,39,'C - Costas'),(47,42,'A - Peito'),(48,43,'A - Peito'),(49,45,'A - Peito'),(50,47,'A - Peito'),(51,49,'A - Peito'),(52,51,'A - Peito'),(53,52,'A - Peito'),(54,53,'A - Peito'),(55,55,'A - Peito'),(56,57,'A - Peito'),(57,60,'A - Peito'),(58,62,'A - Peito'),(59,64,'A - Peito'),(60,65,'A - Peito'),(61,65,'B - Pernas'),(62,65,'C - Costas'),(63,66,'A - Peito'),(64,66,'B - Pernas'),(65,66,'C - Costas');
/*!40000 ALTER TABLE `treinosub` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-05-28  9:08:50
