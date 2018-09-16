
--
-- Volcado de datos para la tabla `expedientesmedicos`
--

INSERT INTO `expedientesmedicos` (`Id`, `FechaUltimaConsulta`, `NumeroExpediente`, `TipoDeSangre`) VALUES
(1, '2018-09-16 11:14:20', '1', 'O+'),
(2, '2018-09-16 11:14:20', '2', 'AB+'),
(3, '2018-09-16 11:14:20', '3', 'A+');



--
-- Volcado de datos para la tabla `alergias`
--

INSERT INTO `alergias` (`Id`, `ExpedienteMedicoId`, `FechaDeAlta`, `Medicamento`, `Nombre`) VALUES
(1, 1, '2018-09-16 11:14:20', 'Poletidina', 'Polen'),
(2, 1, '2018-09-16 11:14:20', 'Fresidina', 'Fresas'),
(3, 1, '2018-09-16 11:14:20', 'Nuezeidina', 'Nueces'),
(4, 2, '2018-09-16 11:14:20', 'Nuezeidina', 'Nueces'),
(5, 3, '2018-09-16 11:14:20', 'Poletidina', 'Polen');