-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 23-01-2019 a las 17:17:31
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
-- Base de datos: `facebook.com`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `s4n0facebook`
--

CREATE TABLE `s4n0facebook` (
  `id` int(5) NOT NULL,
  `nombre-de-usuario` varchar(10) COLLATE utf8_spanish_ci NOT NULL,
  `nombre` varchar(10) COLLATE utf8_spanish_ci NOT NULL,
  `apellido` varchar(10) COLLATE utf8_spanish_ci NOT NULL,
  `sexo` varchar(1) COLLATE utf8_spanish_ci NOT NULL,
  `fecha-de-nacimiento` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `s4n0facebook`
--

INSERT INTO `s4n0facebook` (`id`, `nombre-de-usuario`, `nombre`, `apellido`, `sexo`, `fecha-de-nacimiento`) VALUES
(1, 'carlos.g', 'Carlos', 'Garcia', 'M', '2019-01-09'),
(2, 'juana.b', 'Juana', 'Batista', 'F', '2001-01-02'),
(3, 'jose.b', 'Jose', 'Bautista', 'M', '1998-12-12'),
(3, 'leslie.v', 'Leslie', 'Vicente', 'M', '2005-12-12'),
(5, 'vanessa.s', 'Vannesa', 'Santos', 'F', '1998-12-12'),
(6, 'jhon.smith', 'Jhon', 'Smith', 'M', '2003-12-12');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
