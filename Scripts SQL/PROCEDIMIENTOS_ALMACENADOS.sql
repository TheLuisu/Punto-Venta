create proc SP_REGISTRARUSUARIO(
	@documento varchar(50),
	@nombreCompleto varchar(50),
	@correo varchar(50),
	@contraseña varchar(50),
	@idRol int,
	@estado bit,
	@idUsuarioResultado int output,
	@mensaje varchar(500) output
)
as
begin
	set @idUsuarioResultado = 0
	set @mensaje = ''

	if not exists (select * from USUARIO where documento = @documento)
	begin
		insert into USUARIO(documento, nombreCompleto, correo, contraseña, idRol, estado)
		values (@documento, @nombreCompleto, @correo, @contraseña, @idRol, @estado)

		set @idUsuarioResultado = SCOPE_IDENTITY()
	end
	else
		set @mensaje = 'No se puede repetir el documento para mas de un usuario'
end
go

declare @idusuariogenerado int
declare @mensaje varchar(500)

exec SP_REGISTRARUSUARIO '123', 'puebas', 'test@gmail.com', 'password', 2, 1, @idusuariogenerado output, @mensaje output

select 	@idusuariogenerado
select @mensaje
go


create proc SP_EDITARUSUARIO(
	@idUsuario int,
	@documento varchar(50),
	@nombreCompleto varchar(50),
	@correo varchar(50),
	@contraseña varchar(50),
	@idRol int,
	@estado bit,
	@Respuesta int output,
	@mensaje varchar(500) output
)
as
begin
	set @Respuesta = 0
	set @mensaje = ''

	if not exists (select * from USUARIO where documento = @documento and idUsuario != @idUsuario)
	begin
		update USUARIO set
		documento = @documento,
		nombreCompleto = @nombreCompleto,
		correo = @correo,
		contraseña = @contraseña, 
		idRol = @idRol, 
		estado =@estado
		where idUsuario = @idUsuario

		set @Respuesta = 1
	end
	else
		set @mensaje = 'No se puede repetir el documento para mas de un usuario'
end
go

/*
declare @respuesta bit
declare @mensaje varchar(500)

exec SP_EDITARUSUARIO 2,'123', 'puebas 2', 'test@gmail.com', 'password', 2, 1, @respuesta output, @mensaje output

select @respuesta
select @mensaje

select *from USUARIO;
go
*/
create proc SP_ELIMINARUSUARIO(
	@idUsuario int,
	@Respuesta int output,
	@mensaje varchar(500) output
)
as
begin
	set @Respuesta = 0
	set @mensaje = ''
	declare @pasoReglas bit = 1

	if exists (select * from COMPRA C
	inner join USUARIO u on u.idUsuario = C.idUsuario
	where u.idUsuario = @idUsuario
	)
	begin
		set @pasoReglas = 0
		set @Respuesta = 0
		set @mensaje = @mensaje + 'No se puede eliminar porque usuario se encuentra relacionado a una COMPRA\n'
	end

	if exists (select * from VENTA V
	inner join USUARIO u on u.idUsuario = V.idUsuario
	where u.idUsuario = @idUsuario
	)
	begin
		set @pasoReglas = 0
		set @Respuesta = 0
		set @mensaje = @mensaje + 'No se puede eliminar porque usuario se encuentra relacionado a una VENTA\n'
	end

	if(@pasoReglas = 1)
	begin
		delete from USUARIO where idUsuario = @idUsuario
		set @Respuesta = 1
	end
end
go

/*
declare @respuesta bit
declare @mensaje varchar(500)

exec SP_EDITARUSUARIO 2,'123', 'puebas 2', 'test@gmail.com', 'password', 2, 1, @respuesta output, @mensaje output

select @respuesta
select @mensaje

select *from USUARIO;
go*/

/*-------------------------------------*/

create proc SP_REGISTRARCATEGORIA(
	@descripcion varchar (50),
	@estado bit, 
	@Resultado int output,
	@mensaje varchar(500) output

)
as
begin
	set @Resultado = 0
	if not exists (select * from CATEGORIA where descripcion = @descripcion)
	begin
		insert into CATEGORIA(descripcion, estado)
		values (@descripcion, @estado)
		set @Resultado = SCOPE_IDENTITY()
	end
	else
		set @mensaje = 'No se puede repetir la descripcion de una categoria'
end
go

create proc SP_EDITARCATEGORIA(
	@idCategoria int,
	@estado bit, 
	@descripcion varchar (50),
	@Resultado bit output,
	@mensaje varchar(500) output

)
as
begin
	set @Resultado = 1
	if not exists (select * from CATEGORIA where descripcion = @descripcion)
		update CATEGORIA set
		descripcion = @descripcion,
		estado = @estado
		where idCategoria = @idCategoria
	else
		begin
			set @Resultado = 0
			set @mensaje = 'No se puede repetir la descripcion de una categoria'
		end
end
go

create proc SP_ELIMINARCATEGORIA(
	@idCategoria int,
	@Resultado bit output,
	@mensaje varchar(500) output

)
as
begin
	set @Resultado = 1
	if not exists (select * from CATEGORIA C
	inner join PRODUCTO p on p.idCategoria = c.idCategoria
	where C.idCategoria = @idCategoria
	)
	begin
		delete top(1) from CATEGORIA where idCategoria = @idCategoria
	end
	else
		begin
			set @Resultado = 0
			set @mensaje = 'No se puede eliminar la categoria'
		end
end
go

/*-------------------------------------*/

create proc SP_REGISTRARPRODUCTO(
	@codigo varchar (20),
	@nombre varchar (30),
	@descripcion varchar (30),
	@idCategoria int,
	@estado bit,
	@resultado bit output,
	@mensaje varchar (500) output
)
as
begin
	set @resultado = 0
	if not exists (select * from PRODUCTO where codigo = @codigo)
	begin
		insert into PRODUCTO(codigo, nombre, descripcion, idCategoria, estado)
		values (@codigo, @nombre, @descripcion, @idCategoria, @estado)
		set @resultado = SCOPE_IDENTITY()
		end
		else
		set @mensaje = 'Ya existe un producto con el mismo codigo'
	end
go

create proc SP_MODIFICARPRODUCTO(
	@idProducto int,
	@codigo varchar (20),
	@nombre varchar (30),
	@descripcion varchar (30),
	@idCategoria int,
	@estado bit,
	@resultado bit output,
	@mensaje varchar (500) output
)
as
begin
	set @resultado = 1
	if not exists (select * from PRODUCTO where codigo = @codigo and idProducto != @idProducto)
		update PRODUCTO set
		codigo = @codigo,
		nombre = @nombre,
		descripcion = @descripcion,
		idCategoria = idCategoria,
		estado = @estado
		where idProducto = @idProducto
		else 
		begin
			set @resultado = 0
			set @mensaje = 'Ya existe un producto con el mismo codigo'
		end
end
go

create proc SP_ELIMINARPRODUCTO(
	@idProducto int,
	@respuesta bit output,
	@mensaje varchar (500) output
)
as
begin
	set @respuesta = 0
	set @mensaje = ''
	declare @pasoReglas bit = 1

	if exists (select * from DETALLE_COMPRA dc
	inner join PRODUCTO p on p.idProducto = dc.idProducto
	where p.idProducto = @idProducto)
	begin
		set @pasoReglas = 0
		set @respuesta = 0
		set @mensaje = @mensaje + 'No se puede eliminar porque se encuentra relacionado con una COMPRA'
	end
	if exists (select * from DETALLE_VENTA dv
	inner join PRODUCTO p on p.idProducto = dv.idProducto
	where p.idProducto = @idProducto)
	begin
		set @pasoReglas = 0
		set @respuesta = 0
		set @mensaje = @mensaje + 'No se puede eliminar porque se encuentra relacionado con una VENTA'
	end
	if (@pasoReglas = 1)
	begin
		delete from PRODUCTO where idProducto = @idProducto
		set @respuesta = 1
	end
end
go

/*-------------------------------------*/

create proc SP_REGISTRARCLIENTE(
	@documento varchar(50),
	@nombreCompleto varchar(50),
	@correo varchar(50),
	@telefono varchar(50),
	@estado bit,
	@resultado int output,
	@mensaje varchar(500) output
)as
begin
	SET @resultado = 0
	DECLARE @idPersona INT 
	IF NOT EXISTS (SELECT * FROM CLIENTE WHERE documento = @documento)
	begin
		insert into CLIENTE(documento, nombreCompleto, correo, telefono, estado) values (
		@documento, @nombreCompleto, @correo, @telefono, @estado)

		set @resultado = SCOPE_IDENTITY()
	end
	else
		set @mensaje = 'El nombre de usuario ya existe'
end

go

create PROC sp_EDITARCLIENTE(
@idCliente int,
@documento varchar(50),
@nombreCompleto varchar(50),
@correo varchar(50),
@telefono varchar(50),
@estado bit,
@resultado bit output,
@mensaje varchar(500) output
)as
begin
	SET @resultado = 1
	DECLARE @idPersona INT 
	IF NOT EXISTS (SELECT * FROM CLIENTE WHERE documento = @documento and idCliente != @idCliente)
	begin
		update CLIENTE set
		documento = @documento,
		nombreCompleto = @nombreCompleto,
		correo = @correo,
		telefono = @telefono,
		estado = @estado
		where idCliente = @idCliente
	end
	else
	begin
		SET @resultado = 0
		set @mensaje = 'El nombre del cliente ya existe'
	end
end
go

/*-------------------------------------*/

create PROC sp_RegistrarProveedor(
@documento varchar(50),
@razonSocial varchar(50),
@correo varchar(50),
@telefono varchar(50),
@estado bit,
@resultado int output,
@mensaje varchar(500) output
)as
begin
	SET @resultado = 0
	DECLARE @IDPERSONA INT 
	IF NOT EXISTS (SELECT * FROM PROVEEDOR WHERE documento = @documento)
	begin
		insert into PROVEEDOR(documento,razonSocial,correo,telefono,estado) values (
		@documento,@razonSocial,@correo,@telefono,@estado)

		set @resultado = SCOPE_IDENTITY()
	end
	else
		set @mensaje = 'El numero de documento ya existe'
end

GO

create PROC sp_ModificarProveedor(
@idProveedor int,
@documento varchar(50),
@razonSocial varchar(50),
@correo varchar(50),
@telefono varchar(50),
@estado bit,
@resultado bit output,
@mensaje varchar(500) output
)as
begin
	SET @resultado = 1
	DECLARE @IDPERSONA INT 
	IF NOT EXISTS (SELECT * FROM PROVEEDOR WHERE documento = @documento and idProveedor != @idProveedor)
	begin
		update PROVEEDOR set
		documento = @documento,
		razonSocial = @razonSocial,
		correo = @correo,
		telefono = @telefono,
		estado = @estado
		where idProveedor = @idProveedor
	end
	else
	begin
		SET @resultado = 0
		set @mensaje = 'El numero de documento ya existe'
	end
end
go

create procedure sp_EliminarProveedor(
@idProveedor int,
@resultado bit output,
@mensaje varchar(500) output
)
as
begin
	SET @resultado = 1
	IF NOT EXISTS (
	 select *  from PROVEEDOR p
	 inner join COMPRA c on p.idProveedor = c.idProveedor
	 where p.idProveedor = @idProveedor
	)
	begin
	 delete top(1) from PROVEEDOR where idProveedor = @idProveedor
	end
	ELSE
	begin
		SET @resultado = 0
		set @mensaje = 'El proveedor se encuentara relacionado a una compra'
	end
end
go

/*-------------------------------------*/

CREATE TYPE [dbo].[EDetalle_Compra] AS TABLE(
	[idProducto] int NULL,
	[precioCompra] decimal(18,2) NULL,
	[precioVenta] decimal(18,2) NULL,
	[cantidad] int NULL,
	[montoTotal] decimal(18,2) NULL
)
GO

CREATE PROCEDURE sp_RegistrarCompra(
@idUsuario int,
@idProveedor int,
@tipoDocumento varchar(500),
@numDocumento varchar(500),
@montoTotal decimal(18,2),
@detalleCompra [EDetalle_Compra] READONLY,
@resultado bit output,
@mensaje varchar(500) output
)
as
begin
	begin try
		declare @idcompra int = 0
		set @resultado = 1
		set @mensaje = ''

		begin transaction registro

		insert into COMPRA(idUsuario, idProveedor, tipoDocumento, numDocumento, montoTotal)
		values(@idUsuario, @idProveedor, @tipoDocumento, @numDocumento, @montoTotal)

		set @idcompra = SCOPE_IDENTITY()

		insert into DETALLE_COMPRA(idCompra, idProducto, precioCompra, precioVenta, cantidad, montoTotal)
		select @idcompra,idProducto, precioCompra, precioVenta, cantidad, montoTotal from @detalleCompra

		update p set p.stock = p.stock + dc.cantidad, 
		p.precioCompra = dc.precioCompra,
		p.precioVenta = dc.precioVenta
		from PRODUCTO p
		inner join @detalleCompra dc on dc.idProducto= p.idProducto

		commit transaction registro

	end try
	begin catch
		set @resultado = 0
		set @mensaje = ERROR_MESSAGE()
		rollback transaction registro
	end catch
end
GO

/*
select c.idCompra,
u.nombreCompleto,
pr.documento,pr.razonSocial,
c.tipoDocumento,c.numDocumento,c.montoTotal,convert(char(10), c.fechaRegistro, 103)[fechaRegistro]
from COMPRA c
inner join USUARIO u on u.idUsuario = c.idUsuario
inner join PROVEEDOR pr on pr.idProveedor = c.idProveedor
where c.numDocumento = '00001'
go
*/

/*-------------------------------------*/

CREATE TYPE [dbo].[EDetalle_Venta] AS TABLE(
	[idProducto] int NULL,
	[precioVenta] decimal(18,2) NULL,
	[cantidad] int NULL,
	[subTotal] decimal(18,2) NULL
)
GO

create procedure usp_RegistrarVenta(
@idUsuario int,
@tipoDocumento varchar(500),
@numDocumento varchar(500),
@documentoCliente varchar(500),
@nombreCliente varchar(500),
@montoPago decimal(18,2),
@montoCambio decimal(18,2),
@montoTotal decimal(18,2),
@detalleVenta [EDetalle_Venta] READONLY,                                      
@resultado bit output,
@mensaje varchar(500) output
)
as
begin
	begin try
		declare @idventa int = 0
		set @resultado = 1
		set @mensaje = ''

		begin  transaction registro

		insert into VENTA(idUsuario, tipoDocumento, numDocumento, documentoCliente, nombreCliente, montoPago, montoCambio, montoTotal)
		values(@idUsuario,@tipoDocumento,@numDocumento,@documentoCliente, @nombreCliente, @montoPago, @montoCambio, @montoTotal)

		set @idventa = SCOPE_IDENTITY()

		insert into DETALLE_VENTA(idVenta,idProducto,precioVenta,cantidad,subTotal)
		select @idventa,idProducto,precioVenta,cantidad,subTotal from @DetalleVenta

		commit transaction registro

	end try
	begin catch
		set @resultado = 0
		set @mensaje = ERROR_MESSAGE()
		rollback transaction registro
	end catch
end
go


/*-------------------------------------*/

create proc SP_REPORTEDIARIOVENTA(

 @fechainicio varchar(10),
 @fechafin varchar(10)
 )
 as
	begin
	SET DATEFORMAT dmy;  
		 select 
		 convert(char(10),v.fechaRegistro,103)[FechaRegistro],v.tipoDocumento,v.numDocumento,v.montoTotal,
		 u.nombreCompleto[UsuarioRegistro],
		 v.documentoCliente,v.nombreCliente,
		 p.codigo[CodigoProducto],p.nombre[NombreProducto],ca.descripcion[Categoria],dv.precioVenta,dv.cantidad,dv.subTotal
		from VENTA v
		inner join USUARIO u on u.idUsuario = v.idUsuario
		inner join DETALLE_VENTA dv on dv.idVenta = v.idVenta
		inner join PRODUCTO p on p.idProducto = dv.idProducto
		inner join CATEGORIA ca on ca.idCategoria = p.idCategoria
		where CONVERT(date, v.fechaRegistro) between @fechaInicio and @fechaFin
	end
go



