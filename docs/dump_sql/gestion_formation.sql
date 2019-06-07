-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  ven. 07 juin 2019 à 15:43
-- Version du serveur :  5.7.24
-- Version de PHP :  7.2.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `gestion_formation`
--

DELIMITER $$
--
-- Procédures
--
DROP PROCEDURE IF EXISTS `addInteresser`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `addInteresser` (IN `Pformation_id` INT, IN `Pparticipant_id` INT)  NO SQL
BEGIN
INSERT INTO interesser (formation_id, participant_id) 
VALUES (Pformation_id, Pparticipant_id);
END$$

DROP PROCEDURE IF EXISTS `addParticipantRtnId`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `addParticipantRtnId` (IN `Pname` VARCHAR(50), IN `Pfirst_name` VARCHAR(50), IN `Pemail` VARCHAR(255), IN `Ptelephone` BIGINT, OUT `PrtnId` INT)  BEGIN
INSERT INTO participant(name, first_name, email, telephone) VALUES (Pname, Pfirst_name, Pemail, Ptelephone);
SET PrtnId = LAST_INSERT_ID();
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `candidater`
--

DROP TABLE IF EXISTS `candidater`;
CREATE TABLE IF NOT EXISTS `candidater` (
  `session_id` int(11) NOT NULL,
  `participant_id` int(11) NOT NULL,
  `accepter` tinyint(1) NOT NULL,
  `motif_refus` text,
  KEY `session_id` (`session_id`),
  KEY `participant_id` (`participant_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `candidater`
--

INSERT INTO `candidater` (`session_id`, `participant_id`, `accepter`, `motif_refus`) VALUES
(30, 3, 1, NULL);

-- --------------------------------------------------------

--
-- Structure de la table `formation`
--

DROP TABLE IF EXISTS `formation`;
CREATE TABLE IF NOT EXISTS `formation` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `formation`
--

INSERT INTO `formation` (`id`, `name`) VALUES
(2, 'Games'),
(3, 'Jewelery'),
(4, 'Baby'),
(5, 'Outdoors'),
(6, 'Home'),
(7, 'Shoes'),
(8, 'Clothing'),
(9, 'Clothing'),
(10, 'Grocery');

-- --------------------------------------------------------

--
-- Structure de la table `incident`
--

DROP TABLE IF EXISTS `incident`;
CREATE TABLE IF NOT EXISTS `incident` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `libelle` varchar(255) NOT NULL,
  `description` text NOT NULL,
  `date_emission` datetime NOT NULL,
  `date_resolution` varchar(50) DEFAULT NULL,
  `niveau` int(11) NOT NULL,
  `etat` varchar(50) NOT NULL,
  `id_user` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id_user` (`id_user`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `incident`
--

INSERT INTO `incident` (`id`, `libelle`, `description`, `date_emission`, `date_resolution`, `niveau`, `etat`, `id_user`) VALUES
(1, 'Test', 'TEsTEss', '2019-03-29 00:00:00', NULL, 1, 'emis', 3),
(2, 'Test', 'TEsTEss', '2019-03-29 00:00:00', NULL, 1, 'emis', 3),
(3, 'Test2', '22222', '2019-03-29 00:00:00', NULL, 1, 'emis', 3),
(4, 'Test 3 ', '333333', '2019-03-29 00:00:00', NULL, 1, 'emis', 3),
(5, 'test 4 ', '444', '2019-03-29 00:00:00', NULL, 1, 'emis', 3),
(6, 'azeaz', 'eazeaze', '2019-03-29 11:59:20', NULL, 1, 'emis', 3);

-- --------------------------------------------------------

--
-- Structure de la table `interesser`
--

DROP TABLE IF EXISTS `interesser`;
CREATE TABLE IF NOT EXISTS `interesser` (
  `formation_id` int(11) NOT NULL,
  `participant_id` int(11) NOT NULL,
  KEY `id_formation` (`formation_id`),
  KEY `id_participant` (`participant_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `interesser`
--

INSERT INTO `interesser` (`formation_id`, `participant_id`) VALUES
(9, 21),
(3, 35),
(4, 3),
(8, 30),
(2, 32),
(8, 24),
(2, 46),
(7, 9),
(4, 33),
(6, 27),
(4, 17),
(10, 34),
(8, 26),
(3, 37),
(10, 43),
(8, 24),
(6, 8),
(6, 6),
(10, 16),
(4, 21),
(9, 14),
(10, 7),
(7, 37),
(3, 25),
(6, 14),
(9, 35),
(10, 31),
(10, 18),
(9, 44),
(2, 47),
(6, 38),
(6, 40),
(2, 15),
(3, 48),
(2, 22),
(4, 5),
(7, 21),
(6, 16),
(8, 41),
(10, 24),
(10, 24),
(10, 10),
(2, 64),
(3, 64);

-- --------------------------------------------------------

--
-- Structure de la table `participant`
--

DROP TABLE IF EXISTS `participant`;
CREATE TABLE IF NOT EXISTS `participant` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `first_name` varchar(50) NOT NULL,
  `email` varchar(255) NOT NULL,
  `telephone` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=65 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `participant`
--

INSERT INTO `participant` (`id`, `name`, `first_name`, `email`, `telephone`) VALUES
(1, 'Mingay', 'Hieronymus', 'hmingay0@ycombinator.com', '2147483647'),
(2, 'Sawkin', 'Matthaeus', 'msawkin1@dot.gov', '2147483647'),
(3, 'Offord', 'Cleon', 'cofford2@aboutads.info', '2147483647'),
(4, 'Popland', 'Jocko', 'jpopland3@google.ru', '1461551874'),
(5, 'Artois', 'Tandy', 'tartois4@discovery.com', '2147483647'),
(6, 'Whitsun', 'Wren', 'wwhitsun5@bloomberg.com', '2147483647'),
(7, 'Rumin', 'Selle', 'srumin6@cmu.edu', '2147483647'),
(8, 'Pontin', 'Sarena', 'spontin7@comcast.net', '2147483647'),
(9, 'Barr', 'Carver', 'cbarr8@who.int', '2147483647'),
(10, 'Garmans', 'Andy', 'agarmans9@cnet.com', '1322182899'),
(11, 'Greatbatch', 'Naoma', 'ngreatbatcha@eventbrite.com', '1831672185'),
(12, 'Duley', 'Adrianna', 'aduleyb@live.com', '2147483647'),
(13, 'Scahill', 'Garrett', 'gscahillc@delicious.com', '2147483647'),
(14, 'Ensley', 'Trevor', 'tensleyd@fotki.com', '2147483647'),
(15, 'Spradbery', 'Benedick', 'bspradberye@people.com.cn', '2147483647'),
(16, 'Brunnstein', 'Glennis', 'gbrunnsteinf@unesco.org', '2147483647'),
(17, 'Fiddyment', 'Nettie', 'nfiddymentg@census.gov', '2147483647'),
(18, 'Iacobucci', 'Curry', 'ciacobuccih@clickbank.net', '2147483647'),
(19, 'Matthis', 'Freeland', 'fmatthisi@usda.gov', '2147483647'),
(20, 'Fitzhenry', 'Godfree', 'gfitzhenryj@geocities.jp', '2147483647'),
(21, 'Lembrick', 'Mina', 'mlembrickk@epa.gov', '2147483647'),
(22, 'Neicho', 'Ailee', 'aneichol@live.com', '2147483647'),
(23, 'Morris', 'Frederique', 'fmorrism@wufoo.com', '2147483647'),
(24, 'Gage', 'Jany', 'jgagen@tinyurl.com', '2147483647'),
(25, 'Tidbold', 'Iolanthe', 'itidboldo@ow.ly', '1024079498'),
(26, 'Brougham', 'Devan', 'dbroughamp@ocn.ne.jp', '2147483647'),
(27, 'Diplock', 'Lorene', 'ldiplockq@cloudflare.com', '2147483647'),
(28, 'Perri', 'Tilda', 'tperrir@bing.com', '2147483647'),
(29, 'Sommer', 'Griffin', 'gsommers@mail.ru', '2147483647'),
(30, 'Fidelus', 'Joe', 'jfidelust@phpbb.com', '2147483647'),
(31, 'Hastie', 'Eugene', 'ehastieu@google.co.uk', '1757508676'),
(32, 'Sharvell', 'Bendix', 'bsharvellv@g.co', '2147483647'),
(33, 'Friend', 'Hertha', 'hfriendw@ocn.ne.jp', '2147483647'),
(34, 'Walas', 'Kurt', 'kwalasx@lycos.com', '2147483647'),
(35, 'Ivashnikov', 'Allys', 'aivashnikovy@dmoz.org', '2147483647'),
(36, 'Manns', 'Sam', 'smannsz@vkontakte.ru', '2147483647'),
(37, 'Brookfield', 'Whitaker', 'wbrookfield10@about.me', '2147483647'),
(38, 'Lovatt', 'Jacqueline', 'jlovatt11@hao123.com', '2147483647'),
(39, 'Randlesome', 'Tonye', 'trandlesome12@creativecommons.org', '2147483647'),
(40, 'Merrisson', 'Correna', 'cmerrisson13@answers.com', '2147483647'),
(41, 'Doohey', 'Annamarie', 'adoohey14@php.net', '2147483647'),
(42, 'Lenglet', 'Gwen', 'glenglet15@fc2.com', '2147483647'),
(43, 'Staunton', 'Jacqueline', 'jstaunton16@symantec.com', '1125394661'),
(44, 'Briddock', 'Chadd', 'cbriddock17@is.gd', '2147483647'),
(45, 'Gladding', 'Jodee', 'jgladding18@mediafire.com', '1088280430'),
(46, 'Bauldry', 'Sheppard', 'sbauldry19@free.fr', '2147483647'),
(47, 'Shackell', 'Marybelle', 'mshackell1a@prlog.org', '2147483647'),
(48, 'Moodey', 'Gwenette', 'gmoodey1b@ocn.ne.jp', '2147483647'),
(49, 'O\'Lynn', 'Andrew', 'aolynn1c@msn.com', '2147483647'),
(50, 'Sprigin', 'Kippy', 'ksprigin1d@indiegogo.com', '1727247636'),
(64, 'Sulpice', 'Réli', 'cqsd', '3216549870');

-- --------------------------------------------------------

--
-- Structure de la table `session`
--

DROP TABLE IF EXISTS `session`;
CREATE TABLE IF NOT EXISTS `session` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `date` date NOT NULL,
  `hour_begin` varchar(50) NOT NULL,
  `hour_end` varchar(50) NOT NULL,
  `place` varchar(100) NOT NULL,
  `id_formation` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id_formation` (`id_formation`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `session`
--

INSERT INTO `session` (`id`, `date`, `hour_begin`, `hour_end`, `place`, `id_formation`) VALUES
(1, '2018-07-22', '9', '14', '8 Jackson Drive', 8),
(2, '2018-05-30', '9', '17', '8 Prairie Rose Plaza', 8),
(3, '2018-07-04', '10', '14', '58046 Truax Road', 6),
(4, '2019-01-04', '9', '13', '022 Hauk Terrace', 5),
(5, '2018-10-10', '8', '15', '4 Eagan Place', 4),
(6, '2019-02-27', '11', '14', '52451 Loeprich Hill', 6),
(7, '2018-10-27', '8', '15', '53713 John Wall Crossing', 2),
(8, '2018-08-21', '10', '13', '022 Gina Terrace', 3),
(9, '2018-06-23', '10', '16', '55143 Pleasure Terrace', 6),
(10, '2018-11-04', '10', '15', '6 Merrick Park', 3),
(11, '2018-08-12', '8', '17', '1959 Monterey Center', 2),
(12, '2018-11-30', '8', '17', '42436 Burning Wood Junction', 4),
(13, '2018-12-09', '11', '16', '5444 Steensland Court', 5),
(14, '2018-09-05', '10', '16', '904 David Street', 9),
(15, '2018-06-05', '11', '17', '370 Schurz Road', 8),
(16, '2019-03-26', '10', '16', '59426 Johnson Place', 9),
(17, '2018-09-30', '11', '16', '850 Raven Lane', 4),
(18, '2018-07-31', '8', '16', '5 Jay Center', 7),
(19, '2019-03-17', '8', '15', '93 Briar Crest Road', 6),
(20, '2018-05-21', '10', '13', '97746 Tennessee Terrace', 6),
(21, '2019-03-19', '10', '15', '3549 Pankratz Trail', 10),
(22, '2018-07-28', '8', '16', '87008 Hoard Hill', 2),
(23, '2018-08-05', '8', '17', '004 Moose Lane', 5),
(24, '2018-06-03', '11', '15', '4 Rutledge Point', 7),
(25, '2019-04-28', '9', '15', '903 Cottonwood Road', 5),
(26, '2018-09-19', '10', '15', '01 Red Cloud Plaza', 3),
(27, '2019-05-12', '10', '15', '9 Jenna Hill', 8),
(28, '2019-03-21', '9', '17', '023 Lukken Court', 3),
(29, '2018-07-17', '11', '15', '121 Haas Point', 5),
(30, '2018-05-21', '10', '13', '63934 Meadow Ridge Avenue', 4);

-- --------------------------------------------------------

--
-- Structure de la table `user`
--

DROP TABLE IF EXISTS `user`;
CREATE TABLE IF NOT EXISTS `user` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `login` varchar(255) CHARACTER SET utf8 NOT NULL,
  `pass` varchar(255) CHARACTER SET utf8 NOT NULL,
  `role` enum('administrateur','gestionnaire','utilisateur','') CHARACTER SET utf8 NOT NULL DEFAULT 'utilisateur' COMMENT 'admin, gestionnaire, utilisateur',
  `heurePremiereCo` datetime DEFAULT NULL,
  `tentativeCo` int(11) NOT NULL DEFAULT '0',
  `demandeChangePass` tinyint(1) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `user`
--

INSERT INTO `user` (`id`, `login`, `pass`, `role`, `heurePremiereCo`, `tentativeCo`, `demandeChangePass`) VALUES
(1, 'admin', '88329B8692B8A8A26E0A9A37421B3BD644024CFBF20F928E37510B43B7684B07', 'administrateur', NULL, 0, 0),
(2, 'gestio', '164A48B61D83B559A94E28357D36CFD7497B3FEB0F6FE2565A29EC5178C8CDDC', 'gestionnaire', NULL, 0, 0),
(3, 'guest', 'F9529F8231BABB3DF48E2B4F02CF67CA37763761116ED1A7F79EB79DD61A2747', 'utilisateur', NULL, 0, 0),
(4, 'dev', '5994471ABB01112AFCC18159F6CC74B4F511B99806DA59B3CAF5A9C173CACFC5', 'administrateur', NULL, 0, 1);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `candidater`
--
ALTER TABLE `candidater`
  ADD CONSTRAINT `candidater_ibfk_1` FOREIGN KEY (`session_id`) REFERENCES `session` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `candidater_ibfk_2` FOREIGN KEY (`participant_id`) REFERENCES `participant` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `interesser`
--
ALTER TABLE `interesser`
  ADD CONSTRAINT `fk_interesser_formation` FOREIGN KEY (`formation_id`) REFERENCES `formation` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_interesser_participant` FOREIGN KEY (`participant_id`) REFERENCES `participant` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `session`
--
ALTER TABLE `session`
  ADD CONSTRAINT `fk_session_formation1` FOREIGN KEY (`id_formation`) REFERENCES `formation` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
