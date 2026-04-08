--INSERTAR LECTOR
create or alter proc sp_Insertar_Lectores
	@Nom_Lector varchar(50),
	@Direc_Lector varchar(60),
	@Tel_Lector varchar(15),
	@Email_Lector varchar(40)
as
begin
	declare @id_Lector int

	select @id_Lector = @id_Lector from Lectores
	where Nom_Lector = @Nom_Lector

	if @id_Lector is not null
	begin
		update Lectores
		set Nom_Lector = @Nom_Lector,
			Direc_Lector = @Direc_Lector,
			Tel_Lector = @Tel_Lector,
			Email_Lector = @Email_Lector
		where id_Lector = @id_Lector
	end

	else
	begin
		insert into Lectores(Nom_Lector, Direc_Lector, Tel_Lector, Email_Lector, Estado) 
		values (@Nom_Lector, @Direc_Lector, @Tel_Lector, @Email_Lector, 1)
	end
end


--ELIMINAR 
create or alter proc sp_Eliminar_Lector
	@Nom_Lector varchar(30)
as
begin
	declare @id_Lector int

	select @id_Lector = id_Lector from Lectores
	where Nom_Lector = @Nom_Lector

	update Lectores
		set Estado = 0
		where id_Lector = @id_Lector;
end


--INSERTAR USUARIO
create or alter proc sp_Insertar_Usuarios
	@Nom_Usuario varchar(50),
	@Email varchar(40),
	@Telefono varchar(15),
	@Usuario varchar(30),
	@Clave varchar(12),
	@Rol varchar(20)
as
begin
	declare @id_Rol int,
			@id_Usuario int

	select @id_Rol = id_Rol from Roles
	where Nom_Rol = @Rol

	select @id_Usuario = @id_Usuario from Usuarios
	where Usuario = @Usuario

	if @id_Usuario is not null
	begin
		update Usuarios
		set Nom_Usuario = @Nom_Usuario,
			Email = @Email,
			Telefono = @Telefono,
			Clave = @Clave,
			id_Rol = @id_Rol
		where id_Usuario = @id_Usuario
	end

	else
	begin
		insert into Usuarios(Nom_Usuario, Email, Telefono, Usuario, Clave, id_Rol, Estado) 
		values
		(@Nom_Usuario, @Email, @Telefono, @Usuario, @Clave, @id_Rol, 1)
	end
end


--ELIMINAR 
create or alter proc sp_Eliminar_Usuario
	@Nom_Usuario varchar(30)
as
begin
	declare @id_Usuario int

	select @id_Usuario = id_Usuario from Usuarios
	where Nom_Usuario = @Nom_Usuario

	update Usuarios
		set Estado = 0
		where id_Usuario = @id_Usuario;
end


--INSERTAR LIBRO
create proc sp_Insertar_Libros
	@Titulo_Libro varchar(40),
	@Nom_Autor varchar(50),
	@Genero varchar(30),
	@Isbn varchar(20),
	@Cant_Paginas numeric(4),
	@Pasillo char(1),
	@Estanteria numeric(1),
	@id_Usuario int,
	@Stock numeric(5),
	@Fecha_Creacion date,
	@Estado bit output
as
begin
	declare @id_Autor int, @id_Ubicacion int, @id_Genero int

	select @id_Autor = id_Autor from Autores
	where Nom_Autor = @Nom_Autor

	if @id_Autor is null
	begin
		print 'El autor no existe.'
		set @Estado = 0
		return
	end


	select @id_Ubicacion = id_Ubicacion from Ubicacion
	where Pasillo = @Pasillo and Estanteria = @Estanteria
	
	if @id_Ubicacion is null
	begin
		print 'La ubicacion no existe.'
		set @Estado = 0
		return
	end


	select @id_Genero = id_Genero from Generos
	where Nom_Genero = @Genero

	if @Genero is null
	begin
		set @id_Genero = 1
	end

	insert into	Libros(Titulo_Libro, id_Genero, id_Autor, isbn, Cant_Paginas, id_Ubicacion, id_Usuario, Stock, Fecha_Creacion, Estado) 
	values
	(@Titulo_Libro, @id_Genero, @id_Autor, @Isbn, @Cant_Paginas, @id_Ubicacion, @id_Usuario, @Stock, @Fecha_Creacion, 1)

	set @Estado = 1
end


--ELIMINAR 
create proc sp_Eliminar_Libro
	@id_Libro int
as
begin
	update Libros
		set Estado = 0
		where id_Libro = @id_Libro;
end


--INSERTAR PRESTAMO
create or alter proc sp_Insertar_Prestamos
    @Fecha_Prestamo date,
    @Nom_Lector varchar(40),
    @Fecha_Entrega date,
    @id_Usuario int
as
begin
    declare @id_Lector int

    select @id_Lector = id_Lector 
    from Lectores
    where Nom_Lector = @Nom_Lector

	if @id_Lector is null
    begin
        RAISERROR('El lector no existe', 16, 1)
        return
    end

    insert into Prestamos
    (Fecha_Prestamo, id_Lector, Fecha_Entrega, Fecha_devolucion, id_Usuario)
    values
    (@Fecha_Prestamo, @id_Lector, @Fecha_Entrega, NULL, @id_Usuario)

    select SCOPE_IDENTITY() as id_Prestamo
end


--ACTUALIZAR
create or alter proc sp_Actualizar_Estado_Prestamo
    @id_Prestamo int,
    @Fecha_devolucion date,
	@Estado varchar(15)
as
begin
    update Prestamos
    set 
        Fecha_devolucion = @Fecha_devolucion,
        Estado = @Estado
    where id_Prestamo = @id_Prestamo
end

DROP PROCEDURE IF EXISTS sp_Actualizar_Estado_Prestamo


--INSERTAR DETALLE_PRESTAMO
create proc sp_Insertar_Detalle_Prestamo
	@id_Prestamo int,
	@Nom_Libro varchar(40)
as
begin
	declare @id_Libro int

	select @id_Libro = id_Libro from Libros
	where Titulo_Libro = @Nom_Libro

	insert into Detalle_Prestamo(id_Prestamo, id_Libro) 
	values
	(@id_Prestamo, @id_Libro)
end


create or alter proc sp_Login_Usuarios
	@Usuario varchar(30),
	@Clave varchar(12),
	@Nom_Rol varchar(15)
as
begin
	set nocount on;
	
	if exists(
		select 1 from Usuarios u inner join Roles r
		on u.id_Rol = r.id_Rol
		where u.Usuario = @Usuario and U.Clave = @Clave 
		and r.Nom_Rol = @Nom_Rol and u.Estado = 1
	)
		select 1 as Reultado
	else
		select 0 as Resultado
end


--Reporte Prestamos
create or alter proc sp_Report_Prestamos
	@id_Prestamo int
as
begin
	set nocount on;

	select
		p.id_Prestamo as Ficha,
		p.Fecha_Entrega,
		p.Fecha_Devolucion,
		p.Estado,

		le.Nom_Lector	as Lector,
		u.Nom_Usuario as Usuario,

		l.Titulo_Libro as Libro,
		g.Nom_Genero as Genero,
		a.Nom_Autor as Autor

	from Prestamos p

	left join Lectores le 
		on p.id_Lector = le.id_Lector

	left join Usuarios u 
		on p.id_Usuario = u.id_Usuario

	left join Detalle_Prestamo dp 
		on p.id_Prestamo = dp.id_Prestamo

	left join Libros l 
		on dp.id_Libro = l.id_Libro

	left join Generos g
		on l.id_Genero = g.id_Genero

	left join Autores a 
		on l.id_Autor = a.id_Autor

	where p.id_Prestamo = @id_Prestamo
end


--Reporte Usuarios
create or alter proc sp_Report_Usuarios
as
begin
	select * from Usuarios
end

--Reporte Lectores
create or alter proc sp_Report_Lectores
as
begin
	select * from Lectores
end


--NO MOSTRAR IDS
create or alter proc sp_No_Ids
as
begin
	select
		l.id_Libro,
		l.Titulo_Libro,
		a.Nom_Autor,
		g.Nom_Genero,
		l.Cant_Paginas
	from libros l
	inner join Autores a on l.id_Autor = a.id_Autor
	inner join Generos g on l.id_Genero = g.id_Genero
end


--BUSCAR LIBROS
create or alter proc sp_Buscar
	@busqueda varchar(50)
as
begin
	select
		l.id_Libro,
		l.Titulo_Libro,
		a.Nom_Autor,
		g.Nom_Genero,
		l.Cant_Paginas
	from libros l
	inner join Autores a on l.id_Autor = a.id_Autor
	inner join Generos g on l.id_Genero = g.id_Genero
	where
		l.Titulo_Libro like '%' + @busqueda +'%'
		or a.Nom_Autor like '%' + @busqueda + '%'
end


create or alter proc sp_Listar_Prestamos
as
begin
	set nocount on;

	select 
		p.id_Prestamo,
		le.Nom_Lector as Lector,
		u.Nom_Usuario as Usuario,
		p.Fecha_Entrega,
		p.Fecha_devolucion,
		p.Estado
	from Prestamos p
	inner join Lectores le on p.id_Lector = le.id_Lector
	inner join Usuarios u on p.id_Usuario = u.id_Usuario
end


select * from Libros
select Nom_Rol from Roles

truncate table Prestamos
select * from Usuarios
select * from Lectores

ALTER TABLE Roles
DROP COLUMN Estado;

select * from Detalle_Prestamo