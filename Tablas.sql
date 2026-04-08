create database Sistema_Gestion_Biblioteca

create table Usuarios(
id_Usuario int primary key identity(1,1),
Nom_Usuario varchar(50),
Email varchar(40),
Telefono varchar(15),
Usuario varchar(30),
Clave varchar(12),
id_Rol int,
Estado bit default 1
) drop table Usuarios


create table Roles(
id_Rol int primary key identity(1,1),
Nom_Rol varchar(50)
) drop table Roles


create table Libros(
id_Libro int primary key identity(1,1),
Titulo_Libro varchar(40),
id_Genero varchar(30),
id_Autor int,
Isbn varchar(20),
Cant_Paginas numeric(4),
id_Ubicacion int,
id_Usuario int,
Stock numeric(5),
Fecha_Creacion date,
Estado bit default 1
) drop table Libros


create table Autores(
id_Autor int primary key identity(1,1),
Nom_Autor varchar(50),
Pais varchar(25),
Email varchar(40)
) drop table Autores


create table Generos(
id_Genero int primary key identity(1,1),
Nom_Genero varchar(30),
Descripcion varchar(150)
) drop table Generos


create table Lectores(
id_Lector int primary key identity(1,1),
Nom_Lector varchar(50),
Direc_Lector varchar(60),
Tel_Lector varchar(15),
Email_Lector varchar(40),
Estado bit default 1
) drop table Lectores


create table Ubicacion(
id_Ubicacion int primary key identity(1,1),
Pasillo char(2),
Estanteria numeric(2)
) drop table Ubicacion


create table Prestamos(
id_Prestamo int primary key identity(1,1),
Fecha_Prestamo date,
id_Lector int,
Fecha_Entrega date,
Fecha_devolucion date,
id_Usuario int,
Estado char(15) default 'Pendiente'
) drop table Prestamos


create table Detalle_Prestamo(
id_Detalle int primary key identity(1,1),
id_Prestamo int,
id_Libro int
) drop table Detalle_Prestamo