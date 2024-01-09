create table MOVIMIENTOS_CLIENTE(
	idMovCliente int primary key identity,
	idCliente int references USUARIO(idUsuario),
    nombreCompleto varchar(50),
	tipoMovimiento varchar(50),
    fechaRegistro datetime default getdate()
)
go
/*
select * from MOVIMIENTOS_CLIENTE
go*/

create trigger INSERT_CLIENTE
on CLIENTE
after insert
as
begin
	declare @idCliente int, @documento varchar(50), @nombreCompleto varchar(50), 
	@correo varchar(50), @telefono varchar(50), @estado bit, @fechaRegistro date;

	select @idCliente = I.idCliente from inserted as I;
	select @documento = I.documento from inserted as I;
	select @nombreCompleto = I.nombreCompleto from inserted as I;
	select @correo = I.correo from inserted as I;
	select @telefono = I.telefono from inserted as I;
	select @estado = I.estado from inserted as I;
	select @fechaRegistro = I.fechaRegistro from inserted as I;

	insert into MOVIMIENTOS_CLIENTE(idCliente, nombreCompleto, tipoMovimiento, fechaRegistro)
	values (@idCliente, @nombreCompleto, 'ALTA', GETDATE())
	end
go

create trigger UPDATE_CLIENTE
on CLIENTE
after update
as
begin
	declare @idCliente int, @documento varchar(50), @nombreCompleto varchar(50), 
	@correo varchar(50), @telefono varchar(50), @estado bit, @fechaRegistro date;

	select @idCliente = I.idCliente from inserted as I;
	select @documento = I.documento from inserted as I;
	select @nombreCompleto = I.nombreCompleto from inserted as I;
	select @correo = I.correo from inserted as I;
	select @telefono = I.telefono from inserted as I;
	select @estado = I.estado from inserted as I;
	select @fechaRegistro = I.fechaRegistro from inserted as I;

	insert into MOVIMIENTOS_CLIENTE(idCliente, nombreCompleto, tipoMovimiento, fechaRegistro)
	values (@idCliente, @nombreCompleto, 'ACTUALIZACION', GETDATE())
	end
go

create trigger DELETE_CLIENTE
on CLIENTE
after delete
as
begin
	declare @idCliente int, @nombreCompleto varchar(50), @fechaRegistro date;

	select @idCliente = I.idCliente from deleted as I;
	select @nombreCompleto = I.nombreCompleto from deleted as I;
	select @fechaRegistro = I.fechaRegistro from deleted as I;

	insert into MOVIMIENTOS_CLIENTE (idCliente, nombreCompleto, tipoMovimiento, fechaRegistro)
	values (@idCliente, @nombreCompleto, 'BAJA', GETDATE())
	end
go

/*-------------------------------------*/

create table MOVIMIENTOS_USUARIO(
	idMovUsuario int primary key identity,
	idUsuario int,
	idRol int,
	documento varchar(50),
    nombreCompleto varchar(50),
	correo varchar(50),
	password varchar(50),
	tipoMovimiento varchar(50),
    fechaRegistro datetime default getdate()
)
go

select * from MOVIMIENTOS_USUARIO
select * from USUARIO
select * from CLIENTE
go

create trigger INSERT_USUARIO
on USUARIO
after insert
as
begin
	declare @idUsuario int, @idRol int, @documento varchar(50), @nombreCompleto varchar(50), @correo varchar(50), @password varchar(50), @fechaRegistro date;

	select @idUsuario = I.idUsuario from inserted as I;
	select @idRol = I.idRol from inserted as I;
	select @documento = I.documento from inserted as I;
	select @nombreCompleto = I.nombreCompleto from inserted as I;
	select @correo = I.correo from inserted as I;
	select @password = I.password from inserted as I;
	select @fechaRegistro = I.fechaRegistro from inserted as I;

	insert into MOVIMIENTOS_USUARIO(
	idUsuario,
	idRol,
	documento,
    nombreCompleto,
	correo,
	password,
	tipoMovimiento,
    fechaRegistro)
	values (@idUsuario, @idRol, @documento, @nombreCompleto, @correo, @password,'ALTA', GETDATE())
	end
go

create trigger UPDATE_USUARIO
on USUARIO
after update
as
begin
	declare @idUsuario int, @idRol int, @documento varchar(50), @nombreCompleto varchar(50), @correo varchar(50), @password varchar(50), @fechaRegistro date;

	select @idUsuario = I.idUsuario from inserted as I;
	select @idRol = I.idRol from inserted as I;
	select @documento = I.documento from inserted as I;
	select @nombreCompleto = I.nombreCompleto from inserted as I;
	select @correo = I.correo from inserted as I;
	select @password = I.password from inserted as I;
	select @fechaRegistro = I.fechaRegistro from inserted as I;

	insert into MOVIMIENTOS_USUARIO(
	idUsuario,
	idRol,
	documento,
    nombreCompleto,
	correo,
	password,
	tipoMovimiento,
    fechaRegistro)
	values (@idUsuario, @idRol, @documento, @nombreCompleto, @correo, @password,'ACTUALIZACION', GETDATE())
	end
go

create trigger DELETE_USUARIO
on USUARIO
after delete
as
begin
	declare @idUsuario int, @idRol int, @documento varchar(50), @nombreCompleto varchar(50), 
	@correo varchar(50), @password varchar(50), @fechaRegistro date;

	select @idUsuario = I.idUsuario from deleted as I;
	select @idRol = I.idRol from deleted as I;
	select @documento = I.documento from deleted as I;
	select @nombreCompleto = I.nombreCompleto from deleted as I;
	select @correo = I.correo from deleted as I;
	select @password = I.password from deleted as I;
	select @fechaRegistro = I.fechaRegistro from deleted as I;

	insert into MOVIMIENTOS_USUARIO(
	idUsuario,
	idRol,
	documento,
    nombreCompleto,
	correo,
	password,
	tipoMovimiento,
    fechaRegistro)
	values (@idUsuario, @idRol, @documento, @nombreCompleto, @correo, @password,'BAJA', GETDATE())
	end
go

/*-------------------------------------*/

select u.idUsuario, u.nombreCompleto, 
v.idVenta, v.nombreCliente, p.nombre, dv.cantidad
from USUARIO u
inner join VENTA v on v.idUsuario = u.idUsuario
inner join DETALLE_VENTA dv on v.idVenta = dv.idVenta
inner join PRODUCTO p on p.idProducto = dv.idProducto
where u.idUsuario = 1
go


select * from USUARIO
delete from USUARIO
	where idUsuario = 5
go

create view VENTAS_USUARIO
as
	select u.documento[NombreUsuario], u.nombreCompleto, v.idVenta, v.nombreCliente, p.nombre, dv.cantidad
	from USUARIO u
	inner join VENTA v on v.idUsuario = u.idUsuario
	inner join DETALLE_VENTA dv on v.idVenta = dv.idVenta
	inner join PRODUCTO p on p.idProducto = dv.idProducto
go

select * from VENTAS_USUARIO
go

create view COMPRAS_USUARIO
as
	select u.documento[NombreUsuario], u.nombreCompleto, c.idCompra, p.descripcion, p.nombre, dc.cantidad
	from USUARIO u
	inner join COMPRA c on c.idUsuario = u.idUsuario
	inner join DETALLE_COMPRA dc on c.idCompra = dc.idCompra
	inner join PRODUCTO p on p.idProducto = dc.idProducto
go

select * from COMPRAS_USUARIO
go

create view PRODUCTOS_CAT
as
	select ca.descripcion[categoria], pr.codigo, pr.nombre, pr.descripcion[marca], pr.stock
	from CATEGORIA ca
	inner join PRODUCTO pr on pr.idCategoria = ca.idCategoria
go

select * from PRODUCTOS_CAT
go

/*--------------------*/

create procedure crearTablaTemporal
as
	begin
		create table ##REPORTE1(
		id int identity (1,1),
		fechaRegistro date,
		tipoDocumento varchar(50),
		numDocumento varchar(50),
		montoTotal decimal(18,2),
		nombreCompleto varchar(50),
		documentoCliente varchar(50),
		nombreCliente varchar(50),
		codigo varchar(50),
		nombre varchar(50),
		descripcion varchar(50),
		precioVenta decimal(18,2),
		cantidad int,
		subTotal decimal(18,2)
		);
	end
go

exec crearTablaTemporal
go

create procedure borrarTablaTemporal
as
	begin
		drop table ##REPORTE1
	end
go

exec borrarTablaTemporal
go

create proc consultarReporte
as
begin
	select * from ##REPORTE1
	end
go

exec consultarReporte
go

/*--------------------*/

create proc SP_REPORTEDIARIOVENTAS
as
	begin
		set nocount on;
		declare @fechaRegistro date
		declare @tipoDocumento varchar(50)
		declare @numDocumento varchar(50)
		declare @montoTotal decimal(18,2)
		declare @nombreCompleto varchar(50)
		declare @documentoCliente varchar(50)
		declare @nombreCliente varchar(50)
		declare @codigo varchar(50)
		declare @nombre varchar(50)
		declare @descripcion varchar(50)
		declare @precioVenta decimal(18,2)
		declare @cantidad int
		declare @subTotal decimal(18,2)
		declare @fechaInicio varchar(10)
		declare @fechaFin varchar(10)


		declare VENTAS_CURSOR scroll cursor for 
			select v.fechaRegistro, v.tipoDocumento, v.numDocumento, v.montoTotal,
			u.nombreCompleto,
			v.documentoCliente, v.nombreCliente,
			p.codigo, p.nombre,
			ca.descripcion, dv.precioVenta, dv.cantidad, dv.subTotal
			from VENTA v
			inner join USUARIO u on u.idUsuario = v.idUsuario
			inner join DETALLE_VENTA dv on dv.idVenta = v.idVenta
			inner join PRODUCTO p on p.idProducto = dv.idProducto
			inner join CATEGORIA ca on ca.idCategoria = p.idCategoria
			where CONVERT(date, v.fechaRegistro) between '23/05/2022' and '25/05/2022'

		open VENTAS_CURSOR

		exec borrarTablaTemporal
		exec crearTablaTemporal

			fetch next from VENTAS_CURSOR
				into @fechaRegistro, @tipoDocumento, @numDocumento, @montoTotal, @nombreCompleto, @documentoCliente, @nombreCliente,
				@codigo, @nombre, @descripcion, @precioVenta, @cantidad, @subTotal
			while @@FETCH_STATUS=0
		begin
			insert into ##REPORTE1 (fechaRegistro, tipoDocumento,numDocumento, montoTotal, nombreCompleto, documentoCliente, 
						nombreCliente, codigo, nombre, descripcion, precioVenta, cantidad, subTotal)
			values (@fechaRegistro, @tipoDocumento, @numDocumento, @montoTotal, @nombreCompleto, @documentoCliente, @nombreCliente,
					@codigo, @nombre, @descripcion, @precioVenta, @cantidad, @subTotal)
			fetch next from VENTAS_CURSOR
				into @fechaRegistro, @tipoDocumento, @numDocumento, @montoTotal, @nombreCompleto, @documentoCliente, @nombreCliente,
					@codigo, @nombre, @descripcion, @precioVenta, @cantidad, @subTotal
		end

		exec consultarReporte
		close VENTAS_CURSOR
		deallocate VENTAS_CURSOR
	end
go

exec SP_REPORTEDIARIOVENTAS 
go