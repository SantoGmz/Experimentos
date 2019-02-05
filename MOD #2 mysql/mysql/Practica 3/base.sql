-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 28-01-2019 a las 17:13:07
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
-- Base de datos: `base`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `humano`
--

CREATE TABLE `humano` (
  `cedula` int(11) NOT NULL,
  `nombre` varchar(20) COLLATE utf8_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `humano`
--

INSERT INTO `humano` (`cedula`, `nombre`) VALUES
(100782788, 'Daniel'),
(2147483647, 'Carlos');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_de_sangre`
--

CREATE TABLE `tipo_de_sangre` (
  `cedula` int(11) NOT NULL,
  `sangre` varchar(2) COLLATE utf8_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `tipo_de_sangre`
--

INSERT INTO `tipo_de_sangre` (`cedula`, `sangre`) VALUES
(100782788, 'O+'),
(2147483647, 'R+');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `humano`
--
ALTER TABLE `humano`
  ADD PRIMARY KEY (`cedula`);

--
-- Indices de la tabla `tipo_de_sangre`
--
ALTER TABLE `tipo_de_sangre`
  ADD KEY `sangre_del_humano` (`cedula`);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `tipo_de_sangre`
--
ALTER TABLE `tipo_de_sangre`
  ADD CONSTRAINT `sangre_del_humano` FOREIGN KEY (`cedula`) REFERENCES `humano` (`cedula`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
