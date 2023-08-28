-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 28-08-2023 a las 16:32:05
-- Versión del servidor: 8.0.31
-- Versión de PHP: 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `libreria`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `autor`
--

DROP TABLE IF EXISTS `autor`;
CREATE TABLE IF NOT EXISTS `autor` (
  `idautor` varchar(28) DEFAULT NULL,
  `nombreautor` varchar(28) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `autor`
--

INSERT INTO `autor` (`idautor`, `nombreautor`) VALUES
('R84J', 'Gabriel Marquez'),
('4J1D', 'Julio Verne'),
('9I8D', 'Mary Shelley'),
('I93S', 'Sun Tzu'),
('D93J', 'Jose Emilio Pacheco'),
('45KL', 'Monica B. Brozon'),
('K4IA', 'Charles Perrault'),
('4Y5W', 'Bram Stoker');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `editorial`
--

DROP TABLE IF EXISTS `editorial`;
CREATE TABLE IF NOT EXISTS `editorial` (
  `ideditorial` varchar(28) DEFAULT NULL,
  `nombreeditorial` varchar(28) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `editorial`
--

INSERT INTO `editorial` (`ideditorial`, `nombreeditorial`) VALUES
('7583', 'Alianza'),
(' 84JU', 'Porrua'),
('24KS', 'Secretaria de Cultura'),
('F80J', 'Edimat'),
('AI56', 'Cantaro'),
('S5DA', 'Barco De Vapor'),
('46FH', 'La Oveja Negra'),
('A2R7', 'Constalbe & Robinson'),
('T5A1', 'Planeta'),
('X1W2', 'Sirio');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `libro`
--

DROP TABLE IF EXISTS `libro`;
CREATE TABLE IF NOT EXISTS `libro` (
  `idlibro` varchar(28) DEFAULT NULL,
  `titulo` varchar(28) DEFAULT NULL,
  `autor` varchar(28) DEFAULT NULL,
  `editorial` varchar(28) DEFAULT NULL,
  `ficha` varchar(28) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `libro`
--

INSERT INTO `libro` (`idlibro`, `titulo`, `autor`, `editorial`, `ficha`) VALUES
('4829', 'Amor en tiempos de colera', 'Gabriel Marquez', 'Penguin Random House', '6H'),
('2154', 'De la tierra a la luna', 'Julio Verne', 'Alianza', 'U6'),
('2746', 'Cien años de soledad', 'Gabriel Marquez', 'Planeta', 'X2'),
('9145', 'El relato de amor frances', 'Charles Perrault', 'Cantaro', 'D6'),
('8421', 'Las Batallas En el Desierto', 'Jose Emilio Pacheco', 'Secretaria de Cultura', 'S5'),
('4236', 'Dracula', 'Bram Stoker', 'Constable & Robinson', 'F7'),
('3566', 'Viaje al centro de la tierra', 'Julio Verne', 'Alianza', 'L9'),
('7942', 'Frankenstein', 'Mary Shelley', 'Edimat', 'J5'),
('5243', '¡Casi medio año!', 'Monica B. Brozon', 'Barco De Vapor', 'O1'),
('2403', 'El arte de la guerra', 'Sun Tzu', 'Sirio', 'V4');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
