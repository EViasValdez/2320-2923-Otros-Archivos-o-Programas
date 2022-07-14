-- phpMyAdmin SQL Dump
-- version 5.1.1
-- http://www.phpmyadmin.net
--
-- Servidor: localhost
-- Tiempo de generación: 22-06-2020 a las 14:19:38
-- Versión del servidor: 5.5.24-log
-- Versión de PHP: 5.4.3

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `primaria benito_juarez`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `alumno`
--

CREATE TABLE IF NOT EXISTS `alumno` (
  `matricula` int(5) NOT NULL,
  `nombre` text NOT NULL,
  `apellido_paterno` text NOT NULL,
  `apellido_materno` text NOT NULL,
  `edad` int(2) NOT NULL,
  PRIMARY KEY (`matricula`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `alumno`
--

INSERT INTO `alumno` (`matricula`, `nombre`, `apellido_paterno`, `apellido_materno`, `edad`) VALUES
(1001, 'Jose Miguel', 'Bayo', 'Zarza', 8),
(1114, 'Ismael', 'Roman', 'Ureña', 7),
(1640, 'Baldomero', 'Collado', '', 6),
(1665, 'Jorge', 'Gimenez', 'Palermo', 8),
(1988, 'Raul', 'Palencia', 'Tapia', 6),
(2078, 'Josue', 'Prado', '', 9),
(2225, 'Lídia', 'Toledo', '', 10),
(2280, 'Carmen', 'Mariño', 'Magdaleno', 8),
(2349, 'Reynaldo', 'Aguirre', 'Valdez', 6),
(2580, 'Laura', 'Escalante', '', 7),
(2851, 'Manuela', '', 'Manzano', 8),
(3711, 'Fernanda', '', 'Monzon', 8),
(3813, 'Jorge', 'Rodriguez', 'Zavala', 8),
(3999, 'Hilario', '', 'Ceballos', 7),
(4095, 'Maria', 'Antonia', 'Galdeano', 6),
(4101, 'David', 'Herraiz', 'Vila', 8),
(4224, 'Martha Angelica', 'Sanchez', 'Duran', 9),
(4291, 'Gabriel', 'Romero', 'Clavero', 9),
(4448, 'Aya', 'Alves', '', 10),
(4702, 'Juan', 'Fernando', 'Torres', 6),
(4739, 'Jesus', 'Antonio', 'Herrera', 7),
(4964, 'Victor Tomas', 'Caño', 'Pitarch', 6),
(5044, 'Vicente', 'Antunez', '', 8),
(5322, 'Lídia', 'Carranza', '', 8),
(5499, 'Alfonsa', 'Angeles', 'Linares', 8),
(5500, 'Laura Luisa', 'Torres', 'Allende', 8),
(5811, 'Juan Andres', 'Rodrigo', 'Baez', 10),
(6091, 'Manuel', 'Moraga', 'Guirao', 7),
(6387, 'Ana Maria', 'Dinojosa', 'Barragan', 6),
(6470, 'Luis', 'Centeno', 'Benito', 9),
(6677, 'Gloria', 'Gutierrez', 'Infante', 9),
(6699, 'Rayan', '', 'Cañadas', 8),
(7311, 'Azucena', 'Cantu', '', 7),
(7312, 'Maitane', 'Portela', '', 6),
(7620, 'Roman', '', 'Figueroa', 9),
(8008, 'Pedro', 'Saturnino', 'Villaverde', 9),
(8160, 'Mariano', '', 'Jurado', 8),
(8305, 'Angelina', '', 'Yague', 7),
(9190, 'Laura', 'Flores', 'Acevedo', 8),
(9368, 'Jose', 'Javier', 'De La Rosa', 9),
(9388, 'Carlos', 'Osorio', '', 6),
(9486, 'Estrella', '', 'Rincon', 8),
(9749, 'Joaquin', 'Puente', '', 6),
(9966, 'Eliseo', '', 'Riquelme', 8),
(12345, 'Marisol', 'Altamira', '', 6),
(23455, 'Ximena', 'Montes', 'Sandoval', 8),
(47757, 'Horacio', 'Vazquez', '', 6),
(54025, 'Andrea', 'Ortiz', 'Perez', 9),
(63574, 'Javier', 'Martinez', 'Escobedo', 8),
(78245, 'Ignacio Esquivel', 'Sanchez', 'Villareal', 7);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `grados`
--

CREATE TABLE IF NOT EXISTS `grados` (
  `nombre` text NOT NULL,
  `turno` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `grados`
--

INSERT INTO `grados` (`nombre`, `turno`) VALUES
('Pimero A', 'Matutino'),
('Primero B', 'Vespertino'),
('Segundo A', 'Matutino'),
('Segundo B', 'Vespertino'),
('Tercero A', 'Matutino'),
('Tercero B', 'Vespertino');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `grupos`
--

CREATE TABLE IF NOT EXISTS `grupos` (
  `nombre` text NOT NULL,
  `grado` text NOT NULL,
  `turno` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `laboratorios`
--

CREATE TABLE IF NOT EXISTS `laboratorios` (
  `aula` text NOT NULL,
  `materia` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `laboratorios`
--

INSERT INTO `laboratorios` (`aula`, `materia`) VALUES
('1', 'Español'),
('1', 'Matematicas'),
('2', 'Ciencias naturales'),
('2', 'Quimica'),
('3', 'Computacion'),
('3', 'Historia'),
('4', 'Ingles'),
('4', 'Geografia');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `maestros`
--

CREATE TABLE IF NOT EXISTS `maestros` (
  `nombre` text NOT NULL,
  `apellidos` text NOT NULL,
  `telefono` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `maestros`
--

INSERT INTO `maestros` (`nombre`, `apellidos`, `telefono`) VALUES
('Jose Luis', 'Morera Cuevas', 0),
('Nadia', 'Alcaraz', 0),
('Alicia', 'Aguirre', 0),
('Valeria', 'Suarez', 0),
('Ramón Romero', 'Benítez', 0),
('Joan Tapia', 'Bermúdez		', 0),
('Alejandro', 'García', 0),
('Julio', 'José Ignacio', 0),
('María Isabel', 'Morillo Crespo', 0),
('María León', 'Domínguez', 0),
('Diego', 'González Marín', 0),
('Laura', 'Suarez Ibáñez', 0),
('Mercedes', 'Domenech González', 0),
('Mercedes', 'García Orozco', 0),
('Daniel', 'Falcón ', 0),
('Samara', 'Gallardo', 0),
('Valentina', 'Palomino', 0),
('Paulina', 'Palma', 0),
('Oihane', 'Machado', 0),
('Jana', 'Tejedo', 0),
('Delfina', 'Arias', 0),
('Isidro', 'Calle', 0),
('Iker', 'Talavera', 0),
('Raúl', 'Fuentes', 0),
('Judith', 'Vargas', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `materias`
--

CREATE TABLE IF NOT EXISTS `materias` (
  `nombre` text NOT NULL,
  `clave` text NOT NULL,
  `horas_asigandas` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `materias`
--

INSERT INTO `materias` (`nombre`, `clave`, `horas_asigandas`) VALUES
('Español', '6372', 8),
('Matematicas', '6237', 8),
('Ciencias naturales', '8254', 5),
('Quimica', '5135', 0),
('Computacion', '4168', 5),
('Ingles', '1646', 8),
('Geografia', '5437', 4),
('Historia', '2126', 4);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
