-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 16-08-2023 a las 16:10:07
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
-- Base de datos: `universidad_upt`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `alumno`
--

DROP TABLE IF EXISTS `alumno`;
CREATE TABLE IF NOT EXISTS `alumno` (
  `nombre` varchar(40) NOT NULL,
  `matricula` varchar(40) NOT NULL,
  `fecha` varchar(40) NOT NULL,
  `correo` varchar(40) NOT NULL,
  `numerotelefono` varchar(40) NOT NULL,
  PRIMARY KEY (`nombre`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `alumno`
--

INSERT INTO `alumno` (`nombre`, `matricula`, `fecha`, `correo`, `numerotelefono`) VALUES
('Adrián Britos Castaño', '2004349541', '05/31/00', '', '(09)727-54-687'),
('Alberto M. G. Arellanes', '2035074957', '05/15/2000', '', '(64)983-05-624'),
('Aldo Feliope Espinoza Berumen', '4011220210', '12/10/02', '', '17(70)447-37948'),
('Alejandro Puig', '9683622034', '12/31/02', '', '(79)445-45-512'),
('Alessandra Reyna Cantu', '5581012682', '04/30/99', '', '8(9915)940-69-94376'),
('Alfonso Navarro Escalante', '2426063404', '05/02/01', '', '2(6136)362-63-88133'),
('Ana Cristina Galan Del Rio', '4845117215', '12/30/04', '', '5(68)894-82-24120'),
('Ana Elena Ortiz', '2046313068', '02/17/02', '', '791(7389)857-69393'),
('Angel Servantes Miquelarena', '9605260785', '07/18/1992', '', '(0198)808-35-265'),
('Arturo Morales Posadas', '4033883756', '06/20/02', '', '2(34)009-35102'),
('Bruno Olvera', '8311292788', '07/01/99', '', '12(70)829-80489'),
('Carlos A. P. Escobedo', '9248741297', '01/11/1983', '', '(4610)417-97-771'),
('Carlos Hernan Villa Beltran', '1787088320', '10/04/96', '', '07(03)541-38316'),
('Efrain Garza Ramos', '8777812288', '11/19/02', '', '0(085)994-03327'),
('Emma Espinosa', '4007460544', '10/01/02', '', '(8492)613-15-960'),
('Erick Gerardo Cordero', '4200920098', '12/08/02', '', '829(51)329-25-59819'),
('Gabriela Roman Guardiola', '1206809879', '09/06/04', '', '1(4189)943-42-07927'),
('Gerardo Reyes', '4628583215', '05/07/98', '', '9(2683)049-02191'),
('Guillermo Romet Tamayo', '4410855776', '10/26/98', '', '(82)325-35-166'),
('Guillermo Sanz Teran', '1943451827', '04/08/01', '', '988(07)521-21771'),
('Hector Alfredo Barragan', '8688381930', '11/21/02', '', '25(02)341-51055'),
('Hugo Hidalgo Peñaloza', '4751081889', '12/19/04', '', '859(0100)993-0250648'),
('Ignacio Rivas Del Rio', '8927260090', '05/20/01', '', '4(35)084-43838'),
('Irene Teresa Oliva Medina', '2018982230', '08/20/04', '', '88(531)448-22012'),
('Irineo Suarez Lopez', '4576504626', '09/15/97', '', '(7407)290-43-252'),
('Jorge Alonso Alcocer', '9223508451', '26/10/96', '', '(38)356-75-501'),
('Jorge Rivas Ayala', '8670686990', '10/03/02', '', '0(1128)395-90009'),
('Joseph Roberto Leon', '5669812938', '09/24/05', '', '69(549)227-41606'),
('Katherine Arias Jimenez', '5593785758', '05/02/06', '', '34(32)380-54582'),
('Laura Aranda Molina', '1095297540', '11/04/96', '', '2(24)513-52678'),
('Leticia Mercado Quiroz', '8511376680', '11/04/96', '', '499(3026)659-03252'),
('Lourdes Valencia Bermudez Buendia', '9381322408', '06/19/98', '', '3(4029)631-68942'),
('Luis D. M Torres', '1080261717', '03/30/06', '', '(0895)852-60-662'),
('Magdalena Concepcion Ramires Cruz', '6223664743', '11/05/96', '', '046(72)513-97147'),
('Margarita Espinoza Vazquez', '4549229882', '11/30/99', '', '(23)897-16-493'),
('Maria Dolores Verduzco Espinoza', '2449820851', '08/15/01', '', '445(5672)259-75988'),
('Mariana Guadalupe Guardiola', '4234768335', '04/16/00', '', '856(01)634-38509'),
('Martha Roman Fuente', '2370066070', '12/12/81', '', '(212)310-90-184'),
('Miguel Espinoza Valencia', '8897200805', '01/16/02', '', '24(9178)420-89829'),
('Natalia Curiel Torres', '9551859041', '09/03/92', '', '(60)318-40-370'),
('Olga Castañon', '1844682296', '08/12/99', '', '059(069)562-94085'),
('Olga Peralta Rubio', '6210989184', '05/22/06', '', '35(39)254-32138'),
('Pablo Francisco Delgado Rojas', '6079837936', '06/21/01', '', '5(13)294-44958'),
('Patricia Elena Castañon', '2662674794', '07/30/03', '', '(4050)620-26-135'),
('Rafael Alonso Navarro Escobedo', '8064410998', '11/24/02', '', '583(81)567-86401'),
('Raquel Lorenza Gonzales Avendaño', '4188853462', '01/29/06', '', '34(5890)749-90354'),
('Raul De La Fuente', '8344479698', '12/19/04', '', '(377)687-53-748'),
('Rocio Cuevas', '2730364685', '09/10/98', '', '1(885)063-09451'),
('Rosalina Arriola Guerrero', '9725283946', '02/12/04', '', '1(84)046-55266'),
('Roslinda C. G. Vidal', '4442725333', '02/12/1985', '', '(001)529-39-411'),
('Ruben Alfonoso Padilla Quintana', '4140295958', '04/16/00', '', '747(81)263-19-43991'),
('Ruben Araujo', '8362030824', '01/29/01', '', '2(369)773-20169'),
('Ruben Heriberto Gomez Alvarez', '8007153210', '12/14/99', '', '9(670)494-41231'),
('Samuel Alberto Funes Bermudez', '9205262886', '01/16/98', '', '59(47)106-50518'),
('Sandra Tapia', '4547042866', '12/08/80', '', '(7499)633-42-632'),
('Segio Montero', '2158375936', '03/06/00', '', '(4198)581-35-220'),
('Teresa Peralta Garcia Dueñas', '9757467550', '06/21/01', '', '44(22)464-78743'),
('Victor Hugo Blanchet Cisneros', '5686494402', '12/19/98', '', '5(971)249-69835'),
('Victora A. R. Zarain', '1204036028', '09/22/07', '', '(8815)979-21-719'),
('Xavier Bousculet Rodriguez', '4720184422', '09/15/00', '', '5(7682)750-8885166');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cuatrimestre`
--

DROP TABLE IF EXISTS `cuatrimestre`;
CREATE TABLE IF NOT EXISTS `cuatrimestre` (
  `numero` varchar(10) NOT NULL,
  `nombre` varchar(10) NOT NULL,
  PRIMARY KEY (`nombre`),
  KEY `numero` (`numero`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `cuatrimestre`
--

INSERT INTO `cuatrimestre` (`numero`, `nombre`) VALUES
('1', 'Primero'),
('2', 'Segundo'),
('3', 'Tercero'),
('4', 'Cuarto'),
('5', 'Quinto'),
('6', 'Sexto'),
('7', 'Septimo'),
('8', 'Octavo'),
('9', 'Noveno');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `docentes`
--

DROP TABLE IF EXISTS `docentes`;
CREATE TABLE IF NOT EXISTS `docentes` (
  `nombre` varchar(40) NOT NULL,
  `gradoacademico` varchar(40) NOT NULL,
  PRIMARY KEY (`nombre`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `docentes`
--

INSERT INTO `docentes` (`nombre`, `gradoacademico`) VALUES
('Antonio Madero', 'Doctorado'),
('Edmundo Cosio Mendoza', 'Magister'),
('Elena Teran Dueñas', 'Licenciatura'),
('Emma Libertad De Anda', 'Magistrado'),
('Esteban Montor Zuñiga', 'Magister'),
('Gullermina Reyes Aviles', 'Doctorado'),
('Irma Flores', 'Licenciatura'),
('Javier Antonio Padilla Mendoza', 'Magistrado'),
('Jose Felipe Arriola Gutierrez', 'Bachiller'),
('Katia Elena Ponce Lavalle', 'Bachiller'),
('Lilia Fuentes Rangel', 'Licenciatura'),
('Lilia Maldonado Arteaga', 'Licenciatura'),
('Linda Estela Pinto Mosqueda', 'Licenciatura'),
('Lourdes Amelia Elizondo', 'Magistrado'),
('Luis Abarca Iturralde', 'Bachiler'),
('Luis Agustin Velazquez Sanchez', 'Bachiler'),
('Magdalena Carrillo', 'Bachillerato'),
('Mercedes Parra Marin', 'Licenciatura'),
('Misael Federico Tovar', 'Magistrado'),
('Moises Medina Santillan', 'Doctorado'),
('Nahum Morfin Mendoza', 'Bachillerato'),
('Nestor Quiñonez Magon', 'Licenciatura'),
('Octavio Herrera', 'Magistrado'),
('Olivia Espinosa Mendoza', 'Doctorado'),
('Pablo Fermin Aguilar', 'Doctorado'),
('Rafael Favela Melendez', ''),
('Rocio Padilla Cuevas', ''),
('Rodolfo Covarubias Robles', ''),
('Valeria Coria Salas', ''),
('Ximena Santamaria Preciado', '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `grupos`
--

DROP TABLE IF EXISTS `grupos`;
CREATE TABLE IF NOT EXISTS `grupos` (
  `nombre` varchar(40) NOT NULL,
  `tutor` varchar(40) NOT NULL,
  `cuatrimestre` varchar(40) NOT NULL,
  `truno` varchar(40) NOT NULL,
  PRIMARY KEY (`nombre`),
  KEY `tutor` (`tutor`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `grupos`
--

INSERT INTO `grupos` (`nombre`, `tutor`, `cuatrimestre`, `truno`) VALUES
('Angel Genaro Reyes Vela', 'Luisa Sepulveda', 'Segundo', 'Matutino'),
('Angelica Estrada', 'Luisa Alcantara', 'Segundo', 'Vespertino'),
('Carlos Pascual Narro', 'Gustavo Ortiz Salazar', 'Primero', 'Vespertino'),
('Cesar Leonardo Madero Santos', 'Gloria Ortega Morales', 'Primero', 'Matutino'),
('Lourdes Esperanza Buendia', 'Romeo Santillanes', 'Tercero', 'Matutino'),
('Lourdes Renata Velasquez Arenas', 'Gerardo Valencia Aviña', 'Cuarto', 'Matutino'),
('Marcelo Rodriguez Montes de Oca', 'Federico Ulises Rodriguez', 'Quinto', 'Vespertino'),
('Maria Aguilar', 'Ramses Ingacio Sanz Rodriguez', 'Sexto', 'Vespertino'),
('Osvaldo Mosquera', 'Iris Eperanza Randovan Gomez', 'Quinto', 'Matutino'),
('Rafael Morales Curiel', 'Octavio Ulises Tapia', 'Tercero', 'Vespertino'),
('Raquel Ortiz', 'Ingacio Escarlata', 'Cuarto', 'Vespertino'),
('Salvador Aguirre', 'Rodrigo San Martin', 'Septimo', 'Matutino'),
('Tomas Echenique', 'Rosa Oviedo', 'Octavo', 'Vespertino'),
('Victoria Puig', 'Katia Ruiz', 'Sexto', 'Vespertino'),
('Yoselyn Rubio', 'Oscar De La Fuente', 'Noveno', 'Matutino');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `inscripcion`
--

DROP TABLE IF EXISTS `inscripcion`;
CREATE TABLE IF NOT EXISTS `inscripcion` (
  `folio` varchar(40) NOT NULL,
  `matricula` varchar(40) NOT NULL,
  `grado` varchar(40) NOT NULL,
  `grupo` varchar(40) NOT NULL,
  `tutor` varchar(40) NOT NULL,
  PRIMARY KEY (`matricula`),
  KEY `folio_2` (`folio`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `inscripcion`
--

INSERT INTO `inscripcion` (`folio`, `matricula`, `grado`, `grupo`, `tutor`) VALUES
('4663', '1787088320', '', '1110IA', 'Andrea Garcia Padilla'),
('2715', '1943451827', '', '1120IA', 'Leticia Garcia Narro'),
('9635', '2018982230', '', '1120IA', 'Teresa Gallardo Elizondo'),
('4108', '2035074957', '', '1110IS', 'Jose Alberto Bosques Falcon'),
('9930', '4007460544', '', '1120IS', 'Jose Arturo Ramos'),
('8681', '4845117215', '', '2210NI', 'Sayra Leon'),
('2412', '8311292788', '', '2220NI', ''),
('2470', '8927260090', '', '3310TM', 'Gabriela Cantu'),
('4002', '9605260785', '', '3320TM', 'Abreu Gomez Curiel'),
('8192', '9683622034', '', '3310IF', 'Yoselyn Ortuñez Ocampos');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `turno`
--

DROP TABLE IF EXISTS `turno`;
CREATE TABLE IF NOT EXISTS `turno` (
  `abreviacion` varchar(10) NOT NULL,
  `descripcion` varchar(10) NOT NULL,
  PRIMARY KEY (`abreviacion`),
  KEY `descripcion` (`descripcion`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `turno`
--

INSERT INTO `turno` (`abreviacion`, `descripcion`) VALUES
('Mat', 'Matutino'),
('Noc', 'Nocturno'),
('Ves', 'Vespertino');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tutor`
--

DROP TABLE IF EXISTS `tutor`;
CREATE TABLE IF NOT EXISTS `tutor` (
  `maestro` varchar(40) NOT NULL,
  `grupo` varchar(40) NOT NULL,
  PRIMARY KEY (`maestro`),
  KEY `grupo` (`grupo`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tutor`
--

INSERT INTO `tutor` (`maestro`, `grupo`) VALUES
('Kevin Martinez Villalpando', '1110IA'),
('Yaneth Miranda Castillo', '1120IA'),
('Jose Alberto Bosques Falcon', '1110IS'),
('Araceli Sarahi Vizcarra Salgado', '1120IS'),
('Yoselyn Ortuñez Ocampos', '2210NI'),
('Ivan Lomeli', '2220NI'),
('Sayra Leon', '3310TM'),
('Abreu Gomez Curiel', '3320TM'),
('Andrea Garcia Padilla', '3310IF'),
('Lilia Rivas Espinola', '3310IF'),
('Jose Arturo Ramos', '1410IA'),
('Leticia Garcia Narro', '1410IA'),
('Marcelo Campillo', '2410IS'),
('Gabriela Cantu', '2420IS'),
('Teresa Gallardo Elizondo', '3410NI');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
