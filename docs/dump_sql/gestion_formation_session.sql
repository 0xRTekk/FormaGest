-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: gestion_formation
-- ------------------------------------------------------
-- Server version	5.7.24

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `session`
--

DROP TABLE IF EXISTS `session`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `session` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `date` date NOT NULL,
  `hour_begin` varchar(50) NOT NULL,
  `hour_end` varchar(50) NOT NULL,
  `place` varchar(100) NOT NULL,
  `id_formation` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id_formation` (`id_formation`),
  CONSTRAINT `fk_session_formation1` FOREIGN KEY (`id_formation`) REFERENCES `formation` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `session`
--

LOCK TABLES `session` WRITE;
/*!40000 ALTER TABLE `session` DISABLE KEYS */;
INSERT INTO `session` VALUES (1,'2018-07-22','9','14','8 Jackson Drive',8),(2,'2018-05-30','9','17','8 Prairie Rose Plaza',8),(3,'2018-07-04','10','14','58046 Truax Road',6),(4,'2019-01-04','9','13','022 Hauk Terrace',5),(5,'2018-10-10','8','15','4 Eagan Place',4),(6,'2019-02-27','11','14','52451 Loeprich Hill',6),(7,'2018-10-27','8','15','53713 John Wall Crossing',2),(8,'2018-08-21','10','13','022 Gina Terrace',3),(9,'2018-06-23','10','16','55143 Pleasure Terrace',6),(10,'2018-11-04','10','15','6 Merrick Park',3),(11,'2018-08-12','8','17','1959 Monterey Center',2),(12,'2018-11-30','8','17','42436 Burning Wood Junction',4),(13,'2018-12-09','11','16','5444 Steensland Court',5),(14,'2018-09-05','10','16','904 David Street',9),(15,'2018-06-05','11','17','370 Schurz Road',8),(16,'2019-03-26','10','16','59426 Johnson Place',9),(17,'2018-09-30','11','16','850 Raven Lane',4),(18,'2018-07-31','8','16','5 Jay Center',7),(19,'2019-03-17','8','15','93 Briar Crest Road',6),(20,'2018-05-21','10','13','97746 Tennessee Terrace',6),(21,'2019-03-19','10','15','3549 Pankratz Trail',10),(22,'2018-07-28','8','16','87008 Hoard Hill',2),(23,'2018-08-05','8','17','004 Moose Lane',5),(24,'2018-06-03','11','15','4 Rutledge Point',7),(25,'2019-04-28','9','15','903 Cottonwood Road',5),(26,'2018-09-19','10','15','01 Red Cloud Plaza',3),(27,'2019-05-12','10','15','9 Jenna Hill',8),(28,'2019-03-21','9','17','023 Lukken Court',3),(29,'2018-07-17','11','15','121 Haas Point',5),(30,'2018-05-21','10','13','63934 Meadow Ridge Avenue',4);
/*!40000 ALTER TABLE `session` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-06-09 16:54:09
