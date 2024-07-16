-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 28-08-2023 a las 16:31:09
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
-- Base de datos: `clinica_medica_consulta_update`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `doctores`
--

DROP TABLE IF EXISTS `doctores`;
CREATE TABLE IF NOT EXISTS `doctores` (
  `nombre` varchar(40) NOT NULL,
  `especialidad` varchar(40) NOT NULL,
  PRIMARY KEY (`nombre`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `doctores`
--

INSERT INTO `doctores` (`nombre`, `especialidad`) VALUES
('Adrian Perez Villegas', 'Neugrologia'),
('Jose Pablo Alcantara', 'Farmacologia'),
('Gerardo Galvan Rojas', 'Cardiologia'),
('Erick Curiel Vivero', 'Cirugia general'),
('Hugo Avila Valencia', 'Cardiologia'),
('Edmundo Cosio De La Torre', 'Bioquimica'),
('Saul Cuenca Fuentes', 'Radiologia e imagen'),
('Luis Oscar Guardiola', 'Genetica'),
('Cesar Esperon Mancilla', 'Farmacologia'),
('Hector Onofre Sauceda', 'Pediatria'),
('Fermin Rodriguez De Anda', 'Microbiologia'),
('Luis Angel Torres', 'Reumatologia'),
('Hugo Ramos Neri', 'Infectologia'),
('Ramon Gerardo Quiñonez', 'Hematologia'),
('Juan Luis Arenas Escobedo', 'Biotecnologia'),
('Roberto Ramon Fuentes', 'Parasitologia'),
('Erasmo Ortiz Garza', 'Neurologia'),
('Felipe Romero Gonzalez', 'Pediatria'),
('Julio Morales Arriola', 'Medicina interna'),
('Cesar Arriaga Loredo', 'Cirugia del torax'),
('Angel Ramon Muñoz Salas', 'Salud publica'),
('Reynaldo Villaseñor Pineda', 'Medicina familiar');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `enfermeras`
--

DROP TABLE IF EXISTS `enfermeras`;
CREATE TABLE IF NOT EXISTS `enfermeras` (
  `nombres` varchar(40) NOT NULL,
  `numeroficha` varchar(40) NOT NULL,
  `curp` varchar(40) NOT NULL,
  `especialidad` varchar(40) NOT NULL,
  PRIMARY KEY (`nombres`),
  KEY `numeroficha` (`numeroficha`),
  KEY `curp` (`curp`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `enfermeras`
--

INSERT INTO `enfermeras` (`nombres`, `numeroficha`, `curp`, `especialidad`) VALUES
('Myriam Esquivel', '7304', '', 'Neurocirugía'),
('Josefina Contreras', '1435', '', 'Oftalmología'),
('Teresa Placio Cervantes', '7585', '', 'Neurología'),
('Elena Monroy Uribe', '1184', '', 'Oncología'),
('Luisa Velazquez De Anda', '5401', '', 'Ginecología'),
('Olga Lidia Villalpando', '1161', '', 'Genética'),
('Maria Gomez Gallardo Vazquez', '2444', '', 'Enfermedades infecciosas'),
('Martha Reyes Vilar', '5575', '', 'Pediatria'),
('Carmen Serrano Rios', '9088', '', 'Endocrinología y nutrición'),
('Mayela Sanz Pineda', '8455', '', 'Cirugía vascular'),
('Lilia Rivas Sanchez', '7060', '', 'Dermatología'),
('Isabel Dosal Rubio', '5964', '', 'Pediatria'),
('Teresa Zamora Reyes', '7357', '', 'Pediatria'),
('Elva Luna Valenzuela', '1272', '', 'Enfermedades respiratorias'),
('Guillermina Espinosa Villar', '4520', '', 'Geriatría'),
('Julieta Aguilar Rueda', '1844', '', 'Cardiologia'),
('Irene Abundis Mancilla', '9220', '', 'Oncología'),
('Irma Morales Heredia', '2817', '', 'Pediatria'),
('Martha Concepcion Gonzalez', '9171', '', 'Hematología'),
('Alicia Gallardo', '6015', '', 'Endocrinología y nutrición'),
('Lucia Fuentes', '8454', '', 'Ginecología'),
('Teresa Cordova', '5348', '', 'Cirugía cardiaca'),
('Lourdes Renata Avalos', '2974', '', 'Enfermedades del corazon'),
('Irene Gomez Blanco', '7262', '', 'Enfermedades del hígado (hepatología)'),
('Araceli Favela Garcia', '1737', '', 'Medicina interna'),
('Gabriela Rosales Ramirez', '1584', '', 'Geriatría'),
('Ana Julieta Noriega', '2167', '', 'Gastroenterología- digestivo'),
('Rebeca Gonzalez Ocampo', '9527', '', 'Anatomía patológica'),
('Magdalena Valdes Luna', '9474', '', 'Cirugia plastica'),
('Katherine Muñoz Ruiz', '9544', '', 'Neurología'),
('Angelica Montaño Prado', '2614', '', 'Dermatologia'),
('Yadira Pascual Sauceda', '4074', '', 'Cirugía maxilofacial'),
('Monica Delgado Salazar', '9592', '', 'Bioquimica'),
('Lilia Romero Mosqueda', '7911', '', 'Radiologia e imagen'),
('Rosalinda Aguirre Mercado', '4911', '', 'Cirugía maxilofacial'),
('Alicia Ruiz Herrera', '8278', '', 'Enfermedades del hígado (hepatología)'),
('Maria Del Rosario Gallegos', '7717', '', 'Cirugía de mama'),
('Judith Malagon Villegas', '4445', '', 'Cirugía plastica'),
('Araceli Fizola Dueñas', '1737', '', 'Cardiología'),
('Isabel Aranda Vazquez', '2241', '', 'Anatomía patológica');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `espeacialidades`
--

DROP TABLE IF EXISTS `espeacialidades`;
CREATE TABLE IF NOT EXISTS `espeacialidades` (
  `especialidad` varchar(48) NOT NULL,
  PRIMARY KEY (`especialidad`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `espeacialidades`
--

INSERT INTO `espeacialidades` (`especialidad`) VALUES
('alergologia'),
('anatomía patológica'),
('cardiología'),
('cirugía cardiaca'),
('cirugía de mama'),
('cirugía general'),
('cirugía maxilofacial'),
('cirugía plastica'),
('cirugía vascular'),
('dermatología'),
('endocrinología y nutrición'),
('enfermedades del hígado (hepatología)'),
('enfermedades infecciosas'),
('gastroenterología- digestivo'),
('genética'),
('geriatría'),
('ginecología'),
('hematología'),
('medicina interna'),
('nefrología'),
('neumologia'),
('neurocirugía'),
('neurología'),
('oftalmología'),
('oncología'),
('otorrinolaringologia'),
('pediatría'),
('proctología'),
('psiquiatría'),
('rehabilitación y m. deportiva'),
('reumatología'),
('traumatología'),
('urología');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `medicamentos`
--

DROP TABLE IF EXISTS `medicamentos`;
CREATE TABLE IF NOT EXISTS `medicamentos` (
  `idmedicamento` varchar(40) NOT NULL,
  `nombre` varchar(40) NOT NULL,
  `categoría` varchar(40) NOT NULL,
  `presentación` varchar(40) NOT NULL,
  `laboratorio` varchar(4) NOT NULL,
  `granaje` varchar(40) NOT NULL,
  PRIMARY KEY (`idmedicamento`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `medicamentos`
--

INSERT INTO `medicamentos` (`idmedicamento`, `nombre`, `categoría`, `presentación`, `laboratorio`, `granaje`) VALUES
('5774', 'Rantidina', 'Comprimido', 'Blister X 10', 'A', '150 mg'),
('7335', 'Omeprazol', 'Capsula', 'Blister X 10', 'A', '20 mg'),
('4861', 'Sucralfato', 'Liquido oral ', 'Frasco', 'B', '100 m'),
('9010', 'Atropina (clorhidrato)', 'Inyectable', 'Ampolla', 'B', '1 mg/ml'),
('4524', 'Metformina', 'Comprimido', 'Blister x 10', 'A', '850 mg'),
('1195', 'Repaglinida', 'Comprimido', 'Blister x 10', 'A', '1 mg'),
('4184', 'Heparina sodica', 'Inyectable', 'Vial 5ml', 'B', '5.000 UI/ml'),
('8740', 'Clopidogrel', 'Comprimido', 'Blister x 10', 'B', '75 mg'),
('5146', 'Digoxina', 'Comprimido', 'Blister X 10', 'C', '0,25 mg'),
('2792', 'Amiodarona (clorhidrato)', 'Inyectable', 'Ampolla 3ml', 'C', '50 mg/ml'),
('1166', 'Dopamina (clorhidrato)', 'Inyectable', 'Ampolla 5ml', 'D', '200 mg/5ml'),
('2428', 'Adrenalina', 'Inyectable', 'Ampolla 1ml', 'D', '1 mg/ml'),
('5857', 'Cobletasol', 'Crema/pomada', 'Tubo', 'B', '0.05%'),
('4527', 'Lodopovidona', 'Solucion jabonosa', 'Frasco', 'B', '7.5%'),
('4595', 'Metronidazo', 'Ovulo', 'Caja x 10', 'D', '500mg');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `paciente`
--

DROP TABLE IF EXISTS `paciente`;
CREATE TABLE IF NOT EXISTS `paciente` (
  `nombre` varchar(40) NOT NULL,
  `padecimiento` varchar(40) NOT NULL,
  `medico` varchar(40) DEFAULT NULL,
  PRIMARY KEY (`nombre`),
  KEY `apellidos` (`padecimiento`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `paciente`
--

INSERT INTO `paciente` (`nombre`, `padecimiento`, `medico`) VALUES
('Nora San Juan', 'Sindrome diarreico', 'Rafael Mercedes Orozco'),
('Miguel Domingo', 'Sindrome doloroso abdomial', 'Lourdes Garcia Barrera'),
('Marcelo Holgado', 'Hipertension', 'Judith Quintana Cuevas'),
('Jose Alvez Carranza', 'Adiccion', 'Erasmo Garcia Hernandez'),
('Angel Arcaya Miquelarena', 'Hepatitis A', 'Hugo Avila Valencia'),
('Edmundo Fombona Rienda', 'Cirrosis hepatica', 'Gerardo Salas Mercado'),
('Katherine Barnuevo Ahedo', 'Crisis asmaticas', 'Carolina Zarate Vazquez'),
('Maria Lucia Zambrano', 'Bronquitis aguda', 'Carmen Serrano Rios'),
('Sandra Linares', 'Apendicitis', 'Genaro Dominguez Villalpando'),
('Emiliano Mora', 'Gastritis', 'Roberto Tovar Espinoza'),
('Vicenta Robledo', 'Cancer de mama', 'Sandra Olivares Mora'),
('Benjamin Quiroga', 'Linfedema', 'Mayela Rojas Pulido'),
('Florencia Atienza', 'enfermedad', 'Martha Reyes Vilar'),
('Jose Miguel Gonzalo', 'Embolia pulmonar', 'Maria Gomez Gallardo Vazquez'),
('Vanessa de las Heras', 'Fallo respiratorio', 'Hector Onofre Sauceda'),
('Alexandra Almeida', 'Coma metabolico', 'Fermin Rodriguez De Anda'),
('Sarah Montero', 'Desordenes gastrointestinales', 'Cesar Esperon Mancilla'),
('Otilia Vasquez', 'Escarlatina', 'Luis Angel Torres'),
('Iker Mellado', 'Epoc', 'Alfonso Ramos Neri'),
('Jose Octavio Gimenez Garcia', 'Bronquitis', 'Luis Oscar Guardiola'),
('Armando Miguel Perez Salgado', 'Colitis', 'Carmen Serrano Rios'),
('Valeria Sanchez Garcia', 'Listeria', 'Judith Malagon Villegas'),
('Adrian Gutierrez', 'Tosferina', 'Araceli Fizola Dueñas'),
('Carla Gomez Uribe', 'Para cardiaco reanimado', 'Rosalinda Aguirre Mercado'),
('Jose Armando Vazquez', 'Vasoespasmo', 'Isabel Aranda Vazquez'),
('Carmen Aguirre', 'Hemofilia', 'Martha Concepcion Gonzalez'),
('Hector Rodriguez', 'Neumonia', 'Alicia Gallardo'),
('Alejandra Vera', 'Meningitis', 'Lucia Fuentes'),
('Federico Amador', 'Diabetes', 'Martha Reyes Vilar'),
('Carlos Macotela Romo', 'Infeccion Cronica', ''),
('Jaime Bacab', 'Asma', 'Teresa Cordova'),
('Alejandra Sifuentes Báez', 'Vasoespasmo', 'Mayela Sanz Pineda'),
('Martin Rubio', 'Tromboembolismo', 'Lilia Rivas Sanchez'),
('Héctor Garcia Sepulveda', 'Carcinoide', 'Julio Morales Arriola'),
('Oscar Gonzalez Urzua', 'Enfermedad coronaria', 'Cesar Arriaga Loredo'),
('Martha Garcia', 'Pacreatitis augda', 'Adrian Perez Villegas'),
('Rosa Valeria Gimenez', 'Eergencia hipertensiva', 'Angel Ramon Muñoz Salas'),
('Adrian Acosta', 'Coma dietetico', 'Araceli Favela Garcia'),
('Mariana Juarez Martinez', 'Sifilis', 'Reynaldo Villaseñor Pineda'),
('Pepe Alfredo Herrera', 'Tosferina', 'Juan Luis Arenas Escobedo'),
('Roberto Salgado Escarlata', 'Tormeta tiroidea', 'Roberto Ramon Fuentes'),
('Tomas Morales Aguilar', 'Coma metabolico', 'Luis Angel Torres'),
('Salvador Romero', 'Ultrafiltracion', 'Hugo Ramos Neri'),
('Ignacio Hernandez', 'Hemodalisis', 'Ramon Gerardo Quiñonez'),
('CJEGJIEXBZ', 'Crisis asmatica', 'Erasmo Ortiz Garza'),
('Sarahi Buenaventura', 'Cancer de mama', 'Ana Julieta Noriega'),
('Arturo Vargas Sierra', 'Infeccion respiratoria', 'Fermin Rodriguez De Anda'),
('Tomas Cuevas Orozco', 'Dorsopatia', NULL),
('Sergio Polanco Pascual', 'Sincope', 'Hector Onofre Sauceda'),
('Gustavo Santillanes', 'Apendicitis', 'Cesar Esperon Mancilla'),
('Alicia Reyes', 'Cancer', 'Saul Cuenca Fuentes'),
('Linda Olivia Rodriguez', 'Cirrosis', 'Luis Oscar Guardiola'),
('Alberto Lomeli Orozco', 'Hemorragia digestiva', 'Teresa Zamora Reyes'),
('Marcelino Olvera', 'Cancer de pulmon', 'Isabel Dosal Rubio'),
('Lorenza Perez Ortiz', 'Hidrocefalia', 'Lourdes Renata Avalos'),
('Teresa Contreras', 'Gastrinoma', 'Elva Luna Valenzuela'),
('Gerardo Rivas Garcia', 'Paperas', 'Gabriela Rosales Ramirez'),
('Ana Garcia Gallardo', 'Epoc', 'Irene Gomez Blanco'),
('Iker Ferrat Diaz', 'Clamida', 'Felipe Romero Gonzalez'),
('Teresa De La Garza', 'Infuenza', 'Edmundo Cosio De La Torre'),
('Tonatiuh Villa Acosta', 'Falta de saliva', 'Erick Curiel Vivero'),
('Aurora Mendez De La Torre', 'VIH', 'Hugo Avila Valencia'),
('Jose Ruiz Elgueta', 'Citomegalovirus', 'Jose Pablo Alcantara'),
('Edmundo Esper Rodriguez', 'Patologia del sueño', 'Gerardo Galvan Rojas'),
('Ruben Castillo Arteaga', 'Reflujo gastro-esofagico', 'Alicia Ruiz Herrera'),
('Eduardo Santander Rivera', 'Hipertension arterial', 'Maria Del Rosario Gallegos'),
('Carlos De La Torre', 'Diverticulo de Meckel', 'Katherine Muñoz Ruiz'),
('Jose De Jesus Ugarte', 'Aspiracion pulmonar', 'Angelica Montaño Prado'),
('Roman Garcia Vazquez', 'Embolia pulmonar', 'Rebeca Gonzalez Ocampo'),
('Antonio Cruz Saavedra', 'Vaciamento gastrico anormal', 'Magdalena Valdes Luna');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
