CREATE DATABASE ParcialDb
GO
USE ParcialDb
GO

create table Evaluacion
(
	 IDEstudiante int primary key identity(1,1),
	 Estudiante varchar(50),
     Fecha Date,
	 valor float(3),
     logrado float(3),
     perdido float(3),
     pronostico int
)
