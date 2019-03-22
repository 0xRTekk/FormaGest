-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  ven. 22 mars 2019 à 10:20
-- Version du serveur :  5.7.19
-- Version de PHP :  5.6.31

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
  `id_session` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `participant`
--

INSERT INTO `participant` (`id`, `name`, `first_name`, `id_session`) VALUES
(1, 'Reilly', 'Noel', 7),
(2, 'Noble', 'Mercedes', 14),
(3, 'Mckay', 'Brady', 18),
(4, 'Holloway', 'Forrest', 3),
(5, 'Marquez', 'Yoshio', 11),
(6, 'Golden', 'Yvonne', 12),
(7, 'Foreman', 'James', 5),
(8, 'Irwin', 'Darryl', 6),
(9, 'Dudley', 'Giacomo', 14),
(10, 'Stanton', 'Laith', 16),
(11, 'Goodman', 'Roanna', 9),
(12, 'Hopper', 'Owen', 2),
(13, 'Carney', 'Dahlia', 1),
(14, 'Obrien', 'Harding', 13),
(15, 'Head', 'Grace', 5),
(16, 'Greer', 'Ivy', 15),
(17, 'Knox', 'Zenaida', 13),
(18, 'Sexton', 'Flavia', 11),
(19, 'Moreno', 'Montana', 14),
(20, 'Pate', 'Harper', 12);

-- --------------------------------------------------------

--
-- Structure de la table `session`
--

DROP TABLE IF EXISTS `session`;
CREATE TABLE IF NOT EXISTS `session` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `date_begin` varchar(50) NOT NULL,
  `date_end` varchar(50) NOT NULL,
  `place` varchar(100) NOT NULL,
  `id_formation` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `session`
--

INSERT INTO `session` (`id`, `date_begin`, `date_end`, `place`, `id_formation`) VALUES
(1, '25/03/2018', '11/05/2018', 'Ap #663-4720 Cras St.', 9),
(2, '05/04/2018', '14/06/2018', '1714 Urna. St.', 7),
(3, '04/04/2018', '07/06/2018', '5645 Eget, Rd.', 4),
(4, '16/03/2018', '02/06/2018', 'Ap #275-3559 Rhoncus. Rd.', 10),
(5, '13/03/2018', '25/06/2018', 'Ap #978-2878 Amet St.', 3),
(6, '29/03/2018', '12/06/2018', 'Ap #306-3347 Rutrum. Ave', 7),
(7, '01/04/2018', '16/05/2018', '3982 Eu Rd.', 1),
(8, '16/04/2018', '16/05/2018', '830-3091 Bibendum Avenue', 4),
(9, '26/03/2018', '17/06/2018', '7266 Pede. Rd.', 6),
(10, '16/03/2018', '22/05/2018', 'Ap #908-9454 Curae; Ave', 10),
(11, '18/04/2018', '12/06/2018', '1053 Quam St.', 1),
(12, '04/04/2018', '08/06/2018', 'Ap #170-8022 Tempor Rd.', 6),
(13, '03/04/2018', '30/06/2018', '761-2415 Mauris. Street', 8),
(14, '20/03/2018', '31/05/2018', '155-545 Duis Street', 8),
(15, '24/03/2018', '24/05/2018', 'P.O. Box 762, 8287 Eu Rd.', 2),
(16, '02/03/2018', '07/05/2018', '4725 Erat Av.', 8),
(17, '16/04/2018', '02/05/2018', 'P.O. Box 853, 3558 Enim. Road', 2),
(18, '25/04/2018', '31/05/2018', 'P.O. Box 181, 8458 Volutpat St.', 5),
(19, '31/03/2018', '13/05/2018', '832-9883 Luctus Av.', 1),
(20, '19/04/2018', '06/05/2018', 'Ap #989-2197 Nulla St.', 8);

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
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `user`
--

INSERT INTO `user` (`id`, `login`, `pass`, `role`, `heurePremiereCo`, `tentativeCo`, `demandeChangePass`) VALUES
(1, 'admin', 'admin', 'administrateur', NULL, 0, 0),
(2, 'gestio', 'gestio', 'gestionnaire', NULL, 0, 0),
(3, 'guest', 'guest', 'utilisateur', NULL, 0, 0);

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
