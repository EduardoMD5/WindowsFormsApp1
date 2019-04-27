-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         10.3.12-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win64
-- HeidiSQL Versión:             9.4.0.5125
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Volcando estructura de base de datos para sistema_escolar
CREATE DATABASE IF NOT EXISTS `sistema_escolar` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `sistema_escolar`;

-- Volcando estructura para tabla sistema_escolar.alumnos
CREATE TABLE IF NOT EXISTS `alumnos` (
  `matricula` int(10) unsigned NOT NULL,
  `ap1` varchar(255) NOT NULL,
  `ap2` varchar(255) DEFAULT NULL,
  `nombre` varchar(255) NOT NULL,
  `fechadenacimento` date NOT NULL,
  `correo` varchar(255) NOT NULL,
  `telefono` int(10) unsigned DEFAULT NULL,
  UNIQUE KEY `matricula` (`matricula`),
  UNIQUE KEY `correo` (`correo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla sistema_escolar.alumnos: ~40 rows (aproximadamente)
/*!40000 ALTER TABLE `alumnos` DISABLE KEYS */;
INSERT IGNORE INTO `alumnos` (`matricula`, `ap1`, `ap2`, `nombre`, `fechadenacimento`, `correo`, `telefono`) VALUES
	(110000, 'HERNANDEZ', 'FERNANDEZ', 'JUANA', '1988-01-10', 'pepecas123@gmail.com', 662299089),
	(110001, 'SERNA', 'NAVARRO', 'LUNES', '1993-05-28', 'correo@servidor.com', 66211),
	(110002, 'SERNA', 'NAVARRO', 'MARTES', '1993-05-29', 'correomartes@servidor.com', 66211),
	(110003, 'SERNA', 'NAVARRO', 'MIERCOLES', '1993-05-17', 'correomiercoles@servidor.com', 66211),
	(110004, 'SERNA', 'NAVARRO', 'JUEVES', '1993-05-10', 'correojueves@servidor.com', 66211),
	(110005, 'SERNA', 'NAVARRO', 'VIERNES', '1993-05-08', 'correoviernes@gmail.com', 66211),
	(120001, 'RENTERIA', 'GALLEGOS', 'MOISES', '1996-03-03', 'mois1996mm@gmail.com', 95930),
	(120002, 'RENTERIA', 'GALLEGOS', 'JOEL', '1996-03-23', 'elmasloco@gmail.com', 695931),
	(120003, 'RENTERIA', 'DE', 'JESUS', '1995-03-23', 'elmenosloco@gmail.com', 932),
	(120004, 'RENTERIA', 'MAS', 'SIOSARE', '1994-03-23', 'elmedioloco@gmail.com', 695933),
	(120005, 'RENTERIA', 'MANGANITO', 'FULANITO', '1993-03-23', 'elmasdiabolico@gmail.com', 662),
	(123460, 'REYES', 'YEPIZ', 'MANUEL DAVID', '2017-09-11', 'chleros96@hotmail.com', 662187839),
	(123461, 'REYES', 'CABRERA', 'SANDRA LUZ', '1996-09-16', 'sandraluzyepix@hotmail.com', 662106249),
	(123462, 'REYES', 'MONGE', 'JESUS FRANCISCO', '1996-11-25', 'cleros96@hotmail.com', 662487069),
	(123463, 'REYES', 'PUENTE', 'ALEJANDRO', '1991-10-20', 'negro_20@hotmail.com', 662112990),
	(123464, 'REYES', 'ANDRADE', 'JOEL', '1995-05-17', 'joel_matrixvdr@hotmail.com', 662114164),
	(132145, 'MONGE', 'RAMOS', 'LEO', '1993-01-29', 'mariadb@practica.com', 661930329),
	(133598, 'MONGE', 'ALMADA', 'MARCELA', '1993-06-29', 'mariadb5@practica.com', 662193038),
	(133658, 'MONGE', 'RENTERIA', 'RAUL', '1993-09-29', 'mariadb2@practica.com', 662193331),
	(133660, 'MONGE', 'OZUNA', 'RAUL', '1993-07-28', 'mariadb3@practica.com', 662130332),
	(133661, 'MONGE', 'HERNANDEZ', 'MANUEL', '1993-05-29', 'mariadb4@practica.com', 662193033),
	(135489, 'MONGE', 'CUEN', 'MAX', '1993-03-01', 'mariadb1@practica.com', 621930330),
	(142342, 'GALVEZ', 'QUINTANA', 'MANUEL', '1885-12-14', 'manuel@correo.com', 662342342),
	(142343, 'GASTELUM', 'ARMENTA', 'DORA', '1887-05-01', 'dora@correo.com', 662342343),
	(142344, 'CANTU', 'DURAN', 'CARLOS', '1890-01-23', 'carlos@correo.com', 662342344),
	(142345, 'ALONSO', 'OTHON', 'ALFREDOS', '1879-05-26', 'alfredo@correo.com', 662342345),
	(150001, 'HERNANDEZ', 'ONTIVEROS', 'ISAI', '1992-10-08', 'papas123@gmail.com,', 662299085),
	(150002, 'HERNANDEZ', 'ONTIVEROS', 'GABRIEL', '1989-05-13', 'papas321@gmail.com', 662305787),
	(150003, 'HERNANDEZ', 'MARTINEZ', 'FRIDA', '1999-12-09', 'paps123@gmail.com', 662299798),
	(150004, 'HERNANDEZ', 'ESCOBAR', 'MISAEL', '1994-12-09', 'pepe123@gmail.com', 662290895),
	(423451, 'MARTINES', 'LOPEZ', 'DANIEL', '1886-05-03', 'daniel@correo.com', 662342345),
	(423452, 'Monge', 'Pepi', 'Raul', '1993-05-25', 'correo19@correo.com', 662285659),
	(423453, 'Monge', 'Ghia', 'Raul', '1993-05-25', 'correo20@correo.com', 662285660),
	(423454, 'Monge', 'Benq', 'Raul', '1993-05-25', 'correo34@correo.com', 662585660),
	(423455, 'Monge', 'Toshiba', 'Raul', '1993-05-25', 'correo64@correo.com', 662285661),
	(423456, 'Monge', 'Sony', 'Raul', '1993-05-25', 'correo78@correo.com', 662255662),
	(423457, 'Monge', 'Logitech', 'Raul', '1993-05-25', 'correo89@correo.com', 662258563),
	(423458, 'Monge', 'Honey', 'Raul', '1993-05-25', 'correo90@correo.com', 662258564),
	(423459, 'Monge', 'Hawei', 'Raul', '1993-05-25', 'correo100@correo.com', 622585665),
	(429451, 'Monge', 'Nu¤ez', 'Raul', '1993-05-25', 'correo18@correo.com', 662285658);
/*!40000 ALTER TABLE `alumnos` ENABLE KEYS */;

-- Volcando estructura para tabla sistema_escolar.carreras
CREATE TABLE IF NOT EXISTS `carreras` (
  `id_carrera` int(11) NOT NULL,
  `nombre` varchar(255) NOT NULL,
  `area` varchar(255) NOT NULL,
  UNIQUE KEY `id_materia` (`id_carrera`),
  UNIQUE KEY `id_carrera` (`id_carrera`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla sistema_escolar.carreras: ~8 rows (aproximadamente)
/*!40000 ALTER TABLE `carreras` DISABLE KEYS */;
INSERT IGNORE INTO `carreras` (`id_carrera`, `nombre`, `area`) VALUES
	(1, 'Ingenieria en Sistemas', 'ingenieria'),
	(2, 'Lic. gerontologia', 'LICENCIATURA'),
	(3, 'Lic. administracion de empresas', 'LICENCIATURA'),
	(4, 'Lic. educacion', 'LECENCIATURA'),
	(5, 'Lic. Comercio Internacional', 'LICENCIATURA'),
	(6, 'Contador Publico', 'LICENCIATURA'),
	(7, 'Ciencias de la Educacion', 'LICENCIATURA'),
	(8, 'Lic. Periodismo y Comunicacoin Social', 'LICENCIATURA');
/*!40000 ALTER TABLE `carreras` ENABLE KEYS */;

-- Volcando estructura para tabla sistema_escolar.clases
CREATE TABLE IF NOT EXISTS `clases` (
  `grupo` int(11) NOT NULL,
  `materia` int(11) NOT NULL,
  `maestro` int(10) unsigned NOT NULL,
  KEY `llavegrupo` (`grupo`),
  KEY `llavemateria` (`materia`),
  KEY `llavemestro` (`maestro`),
  CONSTRAINT `llavegrupo` FOREIGN KEY (`grupo`) REFERENCES `grupos` (`id_grupo`),
  CONSTRAINT `llavemateria` FOREIGN KEY (`materia`) REFERENCES `materias` (`id_materia`),
  CONSTRAINT `llavemestro` FOREIGN KEY (`maestro`) REFERENCES `maestros` (`matricula`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla sistema_escolar.clases: ~40 rows (aproximadamente)
/*!40000 ALTER TABLE `clases` DISABLE KEYS */;
INSERT IGNORE INTO `clases` (`grupo`, `materia`, `maestro`) VALUES
	(4441, 1011, 44441),
	(4442, 1012, 44442),
	(4443, 1013, 44443),
	(4444, 1014, 44444),
	(4445, 1020, 44445),
	(1011, 1006, 10001),
	(1011, 1007, 10002),
	(1011, 1008, 10003),
	(1011, 1009, 10004),
	(1011, 1010, 10001),
	(1011, 1011, 10002),
	(1011, 1012, 10003),
	(1011, 1013, 10004),
	(1011, 1014, 10005),
	(1054, 1006, 30005),
	(1054, 1004, 30004),
	(1054, 1057, 30003),
	(1054, 1012, 30002),
	(1054, 1059, 30001),
	(1054, 1014, 30000),
	(1011, 1060, 50000),
	(1012, 1005, 50001),
	(1013, 1059, 50002),
	(1014, 1022, 50003),
	(1015, 1012, 50004),
	(1015, 1006, 60000),
	(1015, 1057, 60001),
	(1015, 1033, 60002),
	(1015, 1053, 60003),
	(1015, 1059, 60004),
	(3032, 1057, 60001),
	(3032, 1033, 60002),
	(3032, 1053, 60003),
	(3032, 1059, 60004),
	(3032, 1006, 60000),
	(3035, 1006, 60000),
	(3035, 1057, 60001),
	(3035, 1033, 60002),
	(3035, 1053, 60003),
	(3035, 1059, 60004);
/*!40000 ALTER TABLE `clases` ENABLE KEYS */;

-- Volcando estructura para tabla sistema_escolar.grupos
CREATE TABLE IF NOT EXISTS `grupos` (
  `id_grupo` int(11) NOT NULL,
  `carrera` int(11) DEFAULT NULL,
  `nombre_corto` varchar(255) DEFAULT NULL,
  `semestre` enum('1','2','3','4','5','6','7','8','9') DEFAULT NULL,
  UNIQUE KEY `id_grupo` (`id_grupo`),
  UNIQUE KEY `id_grupo_2` (`id_grupo`),
  KEY `gancho` (`carrera`),
  CONSTRAINT `gancho` FOREIGN KEY (`carrera`) REFERENCES `carreras` (`id_carrera`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla sistema_escolar.grupos: ~25 rows (aproximadamente)
/*!40000 ALTER TABLE `grupos` DISABLE KEYS */;
INSERT IGNORE INTO `grupos` (`id_grupo`, `carrera`, `nombre_corto`, `semestre`) VALUES
	(1011, 1, 'x', '1'),
	(1012, 1, 'xy', '3'),
	(1013, 1, 'xyz', '5'),
	(1014, 1, 'xyzw', '8'),
	(1015, 1, 'xyzwv', '7'),
	(1020, 2, 'A', '1'),
	(1021, 2, 'B', '2'),
	(1022, 2, 'C', '3'),
	(1023, 2, 'D', '4'),
	(1024, 2, 'E', '5'),
	(1050, 5, 'A', '1'),
	(1051, 5, 'B', '2'),
	(1052, 5, 'C', '3'),
	(1053, 5, 'D', '4'),
	(1054, 5, 'D', '5'),
	(3031, 3, 'empresita', '1'),
	(3032, 3, 'empresitas', '3'),
	(3033, 3, 'empresas', '4'),
	(3034, 3, 'vagos', '5'),
	(3035, 3, 'esos vatos', '6'),
	(4441, 4, 'locos', '1'),
	(4442, 4, 'Prietos', '2'),
	(4443, 4, 'Cholos', '3'),
	(4444, 4, 'Divos', '4'),
	(4445, 4, 'Malias', '5');
/*!40000 ALTER TABLE `grupos` ENABLE KEYS */;

-- Volcando estructura para tabla sistema_escolar.grupo_alumnos
CREATE TABLE IF NOT EXISTS `grupo_alumnos` (
  `grupo` int(11) DEFAULT NULL,
  `alumno` int(10) unsigned NOT NULL,
  KEY `llavegrupoalumno` (`grupo`),
  KEY `llavealumnogrupo` (`alumno`),
  CONSTRAINT `llavealumnogrupo` FOREIGN KEY (`alumno`) REFERENCES `alumnos` (`matricula`),
  CONSTRAINT `llavegrupoalumno` FOREIGN KEY (`grupo`) REFERENCES `grupos` (`id_grupo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla sistema_escolar.grupo_alumnos: ~41 rows (aproximadamente)
/*!40000 ALTER TABLE `grupo_alumnos` DISABLE KEYS */;
INSERT IGNORE INTO `grupo_alumnos` (`grupo`, `alumno`) VALUES
	(1011, 110000),
	(1011, 110001),
	(1011, 110002),
	(1011, 110003),
	(1011, 110004),
	(1012, 120001),
	(1012, 120002),
	(1012, 120003),
	(1012, 120004),
	(1012, 120005),
	(1013, 123460),
	(1013, 123461),
	(1013, 123462),
	(1013, 123462),
	(1013, 123463),
	(1014, 132145),
	(1014, 133598),
	(1014, 133658),
	(1014, 133660),
	(1014, 133661),
	(3032, 150001),
	(3032, 150002),
	(3032, 150003),
	(3032, 150004),
	(3032, 423451),
	(4445, 135489),
	(4445, 142342),
	(4445, 142343),
	(4445, 142344),
	(4445, 142345),
	(1011, 429451),
	(1011, 423452),
	(1011, 423453),
	(1011, 423454),
	(1011, 423455),
	(1012, 423456),
	(1012, 423457),
	(1012, 423458),
	(1012, 423459),
	(1012, 110005),
	(1013, 123464);
/*!40000 ALTER TABLE `grupo_alumnos` ENABLE KEYS */;

-- Volcando estructura para tabla sistema_escolar.maestros
CREATE TABLE IF NOT EXISTS `maestros` (
  `matricula` int(10) unsigned NOT NULL,
  `ap1` varchar(255) NOT NULL,
  `ap2` varchar(255) DEFAULT NULL,
  `nombre` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `fecha_ingreso` date NOT NULL,
  UNIQUE KEY `matricula` (`matricula`),
  UNIQUE KEY `email` (`email`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla sistema_escolar.maestros: ~35 rows (aproximadamente)
/*!40000 ALTER TABLE `maestros` DISABLE KEYS */;
INSERT IGNORE INTO `maestros` (`matricula`, `ap1`, `ap2`, `nombre`, `email`, `fecha_ingreso`) VALUES
	(10001, 'HERNANDEZ', 'ONTIVEROS', 'GABRIEL', 'caca1@gmail.com', '2016-02-21'),
	(10002, 'MARTINEZ', 'VALDEZ', 'LUIS', 'luisito23@hotmail.com', '1992-12-12'),
	(10003, 'VALENTIN', 'GARCIA', 'JOSE', 'pepe-mon007@hotmail.com', '1992-06-05'),
	(10004, 'MORALES', 'MORALES', 'MARIANO', 'manomon@gmail.com', '1999-12-10'),
	(10005, 'MORALES', 'LUNA', 'ALONSO', 'aloalo02@gmail.com', '1998-05-04'),
	(10006, 'NU¤EZ', 'ROMANA', 'NORBER', 'nu¤ez@hotmail.com', '2017-10-14'),
	(22222, 'RENTER¡A', 'GALLEGOS', 'JOEL MOISES', 'mois1996@gmail.com', '2019-02-16'),
	(22224, 'RENTER¡A', 'ACEVEDO', 'MOISES', 'mois1995@gmail.com', '2017-02-16'),
	(22225, 'RENTER¡A', 'CASTA¤O', 'MARTIN', 'martin1999@gmail.com', '2016-02-16'),
	(22226, 'RENTER¡A', 'CATALU¤A', 'MARIO', 'mario@gmail.com', '2012-01-16'),
	(22228, 'RENTER¡A', 'TENESSE', 'WILLIAM', 'william1992@gmail.com', '2019-02-16'),
	(22229, 'RENTER¡A', 'QUIJADA', 'BARTOLOMEO', 'bartolomeo1991@gmail.com', '2019-02-16'),
	(30000, 'GARZA', NULL, 'LAURITA', 'porquey@nolaqueria.com', '2016-04-18'),
	(30001, 'LOYA', 'URBALEJO', 'JORGUE', 'reprobados@sinllorar.com', '2017-05-25'),
	(30002, 'LA', 'CUBANA', 'JUANA', 'bailacomo@lacubana.com', '2015-05-18'),
	(30003, 'SILVA', 'DE ALEGRIA', 'ALMA MARCELA', 'sinidea@alguna.com', '2014-05-25'),
	(30004, 'CANON', 'PRIETO', 'ELMA', 'elmacanon@prieto.com', '2019-02-16'),
	(30005, 'BASURITA', NULL, 'ELVA', 'elvasurita@jaja.com', '2019-02-16'),
	(44441, 'ALONSO', 'CANO', 'BRACAMONTE', 'alonso@gmail.com', '2015-02-05'),
	(44442, 'MANUEL', 'PERALTA', 'RAMIREZ', 'manuel@gmail.com', '2000-02-12'),
	(44443, 'MARIA', 'MARTINEZ', 'SAHAVEDRA', 'maria@gmail.com', '2006-02-20'),
	(44444, 'VALERIA', 'MARIN', 'TAUTIME', 'valeria@gmail.com', '2012-01-16'),
	(44445, 'DANIEL', 'GUSAINO', 'DANIEL', 'daniel@gmail.com', '2003-04-22'),
	(44446, 'DORA', 'GASTELUM', 'ARMENTA', 'dora@gmail.com', '2010-12-01'),
	(50000, 'NU¤EZ', 'ROMAN', 'NORBERTO', 'norberto_nu¤ez@hotmail.com', '2017-10-15'),
	(50001, 'VALDEZ', 'CAMPA', 'RAMON', 'ramon_valdez@hotmail.com', '2012-11-10'),
	(50002, 'ESCALANTE', 'RAMIREZ', 'TEODORO', 'teodoro@hotmail.com', '2015-06-17'),
	(50003, 'MARTINEZ', 'DE LA VARA', 'SHARON', 'sharon_delavara@hotmail.com', '2010-06-06'),
	(50004, 'MORALES', 'ACU¤A', 'VALERIA', 'valeria_morales@hotmail.com', '2016-02-08'),
	(50005, 'ROSALES', 'ZAZUETA', 'GISSEL', 'gissel_rosales@hotmail.com', '2018-11-28'),
	(60000, 'GALVEZ', 'LOPEZ', 'ALEJANDRO', 'yc_cetec@hotmail.com', '2012-02-01'),
	(60001, 'LOPEZ', 'MARTINEZ', 'ARON', 'luisito@hotmail.com', '2013-02-01'),
	(60002, 'MEDINA', 'RODRIGUEZ', 'MANUEL', 'alex83@hotmail.com', '2014-05-06'),
	(60003, 'MORENO', 'RENTERIA', 'JESUS', 'dana@hotmail.com', '2018-09-09'),
	(60004, 'RAMIREZ', 'GONZALEZ', 'JUAN', 'dani3@hotmail.com', '2015-06-02');
/*!40000 ALTER TABLE `maestros` ENABLE KEYS */;

-- Volcando estructura para tabla sistema_escolar.materias
CREATE TABLE IF NOT EXISTS `materias` (
  `id_materia` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_materia` varchar(255) NOT NULL,
  `id_carrera` int(11) DEFAULT NULL,
  `semestre_carrera` int(10) unsigned NOT NULL,
  UNIQUE KEY `id_materia` (`id_materia`),
  UNIQUE KEY `nombre_materia` (`nombre_materia`,`id_carrera`,`semestre_carrera`),
  KEY `llaveforanea` (`id_carrera`),
  CONSTRAINT `llaveforanea` FOREIGN KEY (`id_carrera`) REFERENCES `carreras` (`id_carrera`)
) ENGINE=InnoDB AUTO_INCREMENT=1066 DEFAULT CHARSET=latin1;

-- Volcando datos para la tabla sistema_escolar.materias: ~42 rows (aproximadamente)
/*!40000 ALTER TABLE `materias` DISABLE KEYS */;
INSERT IGNORE INTO `materias` (`id_materia`, `nombre_materia`, `id_carrera`, `semestre_carrera`) VALUES
	(1020, 'Administracion para informatica', 1, 1),
	(1025, 'Administraci¢n del Tiempo', 1, 1),
	(1031, 'Administraci¢n del Tiempo', 1, 5),
	(1051, 'Administraci¢n del Tiempo', 2, 3),
	(1057, 'Administraci¢n del Tiempo 2', 3, 5),
	(1004, 'Algebra Solar', 1, 3),
	(1022, 'calculito 1', 6, 4),
	(1023, 'calculitos2', 6, 6),
	(1024, 'calculitos3', 6, 5),
	(1013, 'Calculo', 7, 5),
	(1012, 'Civica', 4, 3),
	(1007, 'Colorear', 4, 1),
	(1015, 'Contabilidad 1', 7, 1),
	(1016, 'Contabilidad 2', 8, 2),
	(1017, 'Contabilidad 3', 7, 3),
	(1018, 'Contabilidad 4', 8, 4),
	(1019, 'Contabilidad 5', 6, 5),
	(1032, 'EDUCACIàN FISICA', 2, 2),
	(1052, 'EDUCACIàN FISICA', 2, 4),
	(1058, 'EDUCACIàN FISICA 2', 3, 5),
	(1006, 'Fisica', 4, 5),
	(1014, 'Fisica', 5, 3),
	(1033, 'FISICA DE LA EDUCACIàN', 3, 4),
	(1053, 'FISIDA DE LA EDUCACIàN', 2, 5),
	(1059, 'FISIDA DE LA EDUCACIàN 2', 4, 6),
	(1056, 'HERBOLOGIA IV', 1, 1),
	(1062, 'HERBOLOGIA V', 2, 3),
	(1065, 'HERBOLOGIA VI', 6, 5),
	(1061, 'HOMICIDIOS 2', 2, 4),
	(1064, 'HOMICIDIOS 3', 4, 7),
	(1035, 'Homicidios I', 4, 8),
	(1055, 'HOMICIDIOS I', 6, 2),
	(1011, 'Introducion a las Matematicas', 6, 1),
	(1021, 'numeritos discretos', 4, 3),
	(1009, 'Operaciones', 5, 1),
	(1010, 'Programacionsita', 1, 1),
	(1034, 'ROBOTICA', 1, 8),
	(1054, 'ROBOTICA', 2, 1),
	(1063, 'ROBOTICA 3', 4, 6),
	(1060, 'ROBOTICA2', 4, 3),
	(1005, 'Sistemas Fotovoltaicos', 1, 4),
	(1008, 'Sumas', 6, 2);
/*!40000 ALTER TABLE `materias` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
