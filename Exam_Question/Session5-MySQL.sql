-- MySQL dump 10.13  Distrib 8.0.14, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: session5
-- ------------------------------------------------------
-- Server version	8.0.14

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `rocktypes`
--

DROP TABLE IF EXISTS `rocktypes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `rocktypes` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) COLLATE utf8_bin NOT NULL,
  `BackgroundColor` varchar(50) COLLATE utf8_bin NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rocktypes`
--

LOCK TABLES `rocktypes` WRITE;
/*!40000 ALTER TABLE `rocktypes` DISABLE KEYS */;
INSERT INTO `rocktypes` VALUES (1,'Argillite','#E52B50'),(2,'Breccia','#FFBF00'),(3,'Chalk','#9966CC'),(4,'Chert','#FBCEB1'),(5,'Coal','#7FFFD4'),(6,'Conglomerate','#007FFF'),(7,'Dolomite','#0095B6'),(8,'Limestone','#800020'),(9,'Marl','#DE3163'),(10,'Mudstone','#F7E7CE'),(11,'Sandstone','#7FFF00'),(12,'Shale','#C8A2C8'),(13,'Tufa','#BFFF00'),(14,'Wackestone','#FFFF00');
/*!40000 ALTER TABLE `rocktypes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `welllayers`
--

DROP TABLE IF EXISTS `welllayers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `welllayers` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `WellID` bigint(20) NOT NULL,
  `RockTypeID` bigint(20) NOT NULL,
  `StartPoint` bigint(20) NOT NULL,
  `EndPoint` bigint(20) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_WellLayers_RockTypes` (`RockTypeID`),
  KEY `FK_WellLayers_Wells` (`WellID`),
  CONSTRAINT `FK_WellLayers_RockTypes` FOREIGN KEY (`RockTypeID`) REFERENCES `rocktypes` (`ID`),
  CONSTRAINT `FK_WellLayers_Wells` FOREIGN KEY (`WellID`) REFERENCES `wells` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `welllayers`
--

LOCK TABLES `welllayers` WRITE;
/*!40000 ALTER TABLE `welllayers` DISABLE KEYS */;
INSERT INTO `welllayers` VALUES (1,1,10,0,800),(2,1,3,800,1430),(3,1,2,1430,1982),(4,1,11,1982,2648),(5,1,6,2648,3312),(6,1,7,3312,3839),(7,1,1,3839,4450),(8,2,9,0,755),(9,2,11,755,1523),(10,2,3,1523,2280),(11,2,6,2280,2916),(12,2,10,2916,3727),(13,2,1,3727,4230),(14,3,10,0,808),(15,3,5,808,1605),(16,3,1,1605,2129),(17,3,6,2129,2770),(18,3,9,2770,3738),(19,3,8,3738,4670),(20,3,4,4670,4830);
/*!40000 ALTER TABLE `welllayers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `wells`
--

DROP TABLE IF EXISTS `wells`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `wells` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `WellTypeID` bigint(20) NOT NULL,
  `WellName` varchar(50) COLLATE utf8_bin NOT NULL,
  `GasOilDepth` bigint(20) NOT NULL,
  `Capacity` bigint(20) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_Wells_WellTypes` (`WellTypeID`),
  CONSTRAINT `FK_Wells_WellTypes` FOREIGN KEY (`WellTypeID`) REFERENCES `welltypes` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `wells`
--

LOCK TABLES `wells` WRITE;
/*!40000 ALTER TABLE `wells` DISABLE KEYS */;
INSERT INTO `wells` VALUES (1,1,'Yolka #12 ',4500,980000000),(2,1,'Kazan  #12',4230,1080000000),(3,1,'Kazan  #13',4830,780000000);
/*!40000 ALTER TABLE `wells` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `welltypes`
--

DROP TABLE IF EXISTS `welltypes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `welltypes` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) COLLATE utf8_bin NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `welltypes`
--

LOCK TABLES `welltypes` WRITE;
/*!40000 ALTER TABLE `welltypes` DISABLE KEYS */;
INSERT INTO `welltypes` VALUES (1,'Well'),(2,'Section');
/*!40000 ALTER TABLE `welltypes` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-08-24 20:50:50
