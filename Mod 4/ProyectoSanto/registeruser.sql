-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 06-03-2019 a las 16:18:20
-- Versión del servidor: 10.1.37-MariaDB
-- Versión de PHP: 7.2.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `registeruser`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `formulario`
--

CREATE TABLE `formulario` (
  `ID` int(100) NOT NULL,
  `Nombre` text COLLATE utf8_spanish_ci NOT NULL,
  `Apellido` text COLLATE utf8_spanish_ci NOT NULL,
  `fechan` date NOT NULL,
  `Correo` varchar(50) COLLATE utf8_spanish_ci NOT NULL,
  `Usuario` text COLLATE utf8_spanish_ci NOT NULL,
  `passwd` text COLLATE utf8_spanish_ci NOT NULL,
  `Genero` text COLLATE utf8_spanish_ci NOT NULL,
  `Pais` text COLLATE utf8_spanish_ci NOT NULL,
  `Estado` text COLLATE utf8_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `formulario`
--

INSERT INTO `formulario` (`ID`, `Nombre`, `Apellido`, `fechan`, `Correo`, `Usuario`, `passwd`, `Genero`, `Pais`, `Estado`) VALUES
(1, 'Santo', 'Gmz', '1999-09-11', 'mr.sansan777@gmail.com', 'S4N70', '123456', 'M', 'Republica Dominina', 'Jaja'),
(2, 'asd', 'asd', '0000-00-00', '6/3/19 11:10:39 a. m.', 'asd', 'asd', '1', '0', 'True'),
(3, 'd', '', '0000-00-00', '6/3/19 11:12:59 a. m.', '', '', '-1', '-1', 'False'),
(4, 'Santo', 'Gmz', '0000-00-00', '6/3/19 11:15:05 a. m.', 's4n70', '123', '1', '1', 'True'),
(5, 'Santo', 'Gmz', '0000-00-00', '6/3/19 11:15:05 a. m.', 's4n70', '123', '1', '1', 'True');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `formulario`
--
ALTER TABLE `formulario`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `formulario`
--
ALTER TABLE `formulario`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
