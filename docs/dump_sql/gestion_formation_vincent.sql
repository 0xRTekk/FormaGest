-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  ven. 10 mai 2019 à 07:44
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
CREATE DATABASE IF NOT EXISTS `gestion_formation` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `gestion_formation`;

-- --------------------------------------------------------

--
-- Structure de la table `candidater`
--

DROP TABLE IF EXISTS `candidater`;
CREATE TABLE IF NOT EXISTS `candidater` (
  `session_id` int(11) NOT NULL,
  `participant_id` int(11) NOT NULL,
  `est_inscrit` tinyint(4) NOT NULL,
  PRIMARY KEY (`session_id`,`participant_id`),
  KEY `fk_session_has_participant_participant1_idx` (`participant_id`),
  KEY `fk_session_has_participant_session1_idx` (`session_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `formation`
--

DROP TABLE IF EXISTS `formation`;
CREATE TABLE IF NOT EXISTS `formation` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `level` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `formation`
--

INSERT INTO `formation` (`id`, `name`, `level`) VALUES
(1, 'nisi', 3),
(2, 'leo.', 1),
(3, 'In', 1),
(4, 'netus', 3),
(5, 'urna', 2),
(6, 'ipsum.', 3),
(7, 'scelerisque', 3),
(8, 'velit', 1),
(9, 'amet', 3),
(10, 'egestas,', 3);

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
  `telephone` int(11) NOT NULL,
  `id_session` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `participant`
--

INSERT INTO `participant` (`id`, `name`, `first_name`, `email`, `telephone`, `id_session`) VALUES
(1, 'Reilly', 'Noel', '', 0, 7),
(2, 'Noble', 'Mercedes', '', 0, 14),
(3, 'Mckay', 'Brady', '', 0, 18),
(4, 'Holloway', 'Forrest', '', 0, 3),
(5, 'Marquez', 'Yoshio', '', 0, 11),
(6, 'Golden', 'Yvonne', '', 0, 12),
(7, 'Foreman', 'James', '', 0, 5),
(8, 'Irwin', 'Darryl', '', 0, 6),
(9, 'Dudley', 'Giacomo', '', 0, 14),
(10, 'Stanton', 'Laith', '', 0, 16),
(11, 'Goodman', 'Roanna', '', 0, 9),
(12, 'Hopper', 'Owen', '', 0, 2),
(13, 'Carney', 'Dahlia', '', 0, 1),
(14, 'Obrien', 'Harding', '', 0, 13),
(15, 'Head', 'Grace', '', 0, 5),
(16, 'Greer', 'Ivy', '', 0, 15),
(17, 'Knox', 'Zenaida', '', 0, 13),
(18, 'Sexton', 'Flavia', '', 0, 11),
(19, 'Moreno', 'Montana', '', 0, 14),
(20, 'Pate', 'Harper', '', 0, 12);

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
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `session`
--

INSERT INTO `session` (`id`, `date`, `hour_begin`, `hour_end`, `place`, `id_formation`) VALUES
(1, '2019-12-21', '12', '20', 'Leamington', 8),
(2, '2019-12-06', '8', '20', 'Paulatuk', 1),
(3, '2018-09-24', '11', '16', 'Cerchio', 6),
(4, '2019-03-16', '9', '15', 'Kelkheim', 7),
(5, '2018-12-15', '10', '19', 'Baltimore', 1),
(6, '2019-02-25', '10', '15', 'Lugnano in Teverina', 10),
(7, '2019-04-07', '10', '20', 'Rhisnes', 9),
(8, '2019-08-20', '11', '15', 'Newton Stewart', 5),
(9, '2018-11-07', '10', '14', 'Emmen', 8),
(10, '2019-10-30', '10', '15', 'Scarborough', 8),
(11, '2019-01-10', '11', '20', 'Penna in Teverina', 7),
(12, '2018-06-30', '10', '20', 'Campli', 6),
(13, '2018-12-06', '8', '17', 'Hérouville-Saint-Clair', 1),
(14, '2018-08-14', '11', '15', 'Cimolais', 4),
(15, '2018-11-08', '12', '14', 'Orai', 6),
(16, '2018-05-02', '12', '17', 'Hulst', 5),
(17, '2018-06-02', '9', '16', 'Clauzetto', 8),
(18, '2018-07-26', '9', '19', 'Santarém', 2),
(19, '2020-01-21', '8', '20', 'Cupar', 5),
(20, '2019-12-09', '10', '18', 'Warren', 5),
(21, '2019-10-19', '9', '17', 'Cádiz', 7),
(22, '2019-02-23', '11', '16', 'San Pablo', 10),
(23, '2019-03-23', '12', '20', 'Missoula', 7),
(24, '2018-07-23', '10', '19', 'Wetteren', 6),
(25, '2018-12-06', '9', '15', 'St. Thomas', 1),
(26, '2019-05-25', '10', '14', 'Tavigny', 9),
(27, '2019-09-06', '10', '18', 'Schagen', 6),
(28, '2018-10-30', '12', '14', 'Oberpullendorf', 3),
(29, '2019-06-30', '10', '20', 'Meerdonk', 8),
(30, '2019-12-02', '9', '20', 'Wisbech', 8);

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
(1, 'admin', 'admin', 'administrateur', NULL, 0, 0),
(2, 'gestio', 'gestio', 'gestionnaire', NULL, 0, 0),
(4, 'guest', 'guest', 'utilisateur', NULL, 0, 0);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `candidater`
--
ALTER TABLE `candidater`
  ADD CONSTRAINT `fk_inscrit_participant1` FOREIGN KEY (`participant_id`) REFERENCES `participant` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_inscrit_session1` FOREIGN KEY (`session_id`) REFERENCES `session` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
