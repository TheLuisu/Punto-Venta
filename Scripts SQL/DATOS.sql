
select * from ROL;
insert into ROL(descripcion)
values ('ADMINISTRADOR');

insert into ROL(descripcion)
values ('EMPLEADO');

select * from USUARIO;

insert into USUARIO(documento, nombreCompleto, correo, contraseña, idRol, estado)
values ('admin', 'Luis Castillo', 'castillo@gmail.com', '0000', 1, 1);

insert into USUARIO(documento, nombreCompleto, correo, password, idRol, estado)
values ('EmpleadoLuisu', 'Luisu Angelo', 'luisu@gmail.com', 'tigres', 2, 1);

update USUARIO set documento = 'admin';


select * from ROL
go

select * from PERMISO
go

select * from USUARIO
go
delete from USUARIO
	where  idUsuario= 5
go

DBCC CHECKIDENT (USUARIO, RESEED, 0);
go

insert into USUARIO(documento, nombreCompleto, correo, password, idRol, estado)
values ('admin', 'Luis Castillo', 'castillo@gmail.com', '1234', 1, 1);
go

select * from CATEGORIA
go
delete from CATEGORIA
	where  idCategoria= 6

DBCC CHECKIDENT (CATEGORIA, RESEED, 0);
go

select * from PRODUCTO
go
delete from PRODUCTO
	where  idProducto= 7

DBCC CHECKIDENT (PRODUCTO, RESEED, 0);
go


select * from CLIENTE
go

DBCC CHECKIDENT (CLIENTE, RESEED, 0);
go

select * from COMPRA
go

delete from COMPRA
	where  idCompra= 1

DBCC CHECKIDENT (COMPRA, RESEED, 0);
go

select * from DETALLE_COMPRA
go

delete from DETALLE_COMPRA
	where  idDetalleCompra= 3

DBCC CHECKIDENT (DETALLE_COMPRA, RESEED, 0);
go

select * from DETALLE_VENTA
go

delete from DETALLE_VENTA
	where  idDetalleVenta= 1

DBCC CHECKIDENT (DETALLE_VENTA, RESEED, 0);
go

select * from PROVEEDOR
go

delete from PROVEEDOR
	where  idProveedor= 5

DBCC CHECKIDENT (PROVEEDOR, RESEED, 0);
go

select * from VENTA
go

delete from VENTA
	where  idVenta= 3

DBCC CHECKIDENT (VENTA, RESEED, 0);
go

insert into PERMISO (idRol, nombreMenu)
values (1, 'iconMenuInventario')

select * from PERMISO;

update PERMISO set nombreMenu = 'iconMenuUsuarios';

delete from PERMISO
	where  nombreMenu='iconMenuUsuarios'

DBCC CHECKIDENT (PERMISO, RESEED, 0);
go

insert into PERMISO(idRol, nombreMenu) values 
(1, 'iconMenuUsuarios'),
(1, 'iconMenuAdmin'),
(1, 'iconMenuVentas'),
(1, 'iconMenuCompras'),
(1, 'iconMenuClientes'),
(1, 'iconMenuProveedores'),
(1, 'iconMenuInventario'),
(1, 'iconMenuReportes'),
(1, 'iconMenuAcercaDe');
go

insert into PERMISO(idRol, nombreMenu) values 
(2, 'iconMenuVentas'),
(2, 'iconMenuCompras'),
(2, 'iconMenuClientes'),
(2, 'iconMenuProveedores'),
(2, 'iconMenuAcercaDe');
go


select p.idRol, p.nombreMenu from PERMISO p
inner join ROL r on r.idRol = p.idRol
inner join USUARIO u on u.idRol = r.idRol
where u.idUsuario = 1;

select u.idUsuario, u.documento, u.nombreCompleto, u.correo, u.password, u.estado, r.idRol, r.descripcion from usuario u
inner join ROL r on r.idRol = u.idRol;

update USUARIO set estado = 0 
where idUsuario = 2;
go

insert into CATEGORIA
	(descripcion, estado)
	values
		('Procesadores', 1),
		('Tarjeta Grafica', 1),
		('Memoria RAM', 1)
go

select * from CATEGORIA
select * from PRODUCTO
go

select idProducto, codigo, nombre, p.descripcion, c.idCategoria, c.descripcion[descripcionCategoria], stock, precioCompra, precioVenta, p.estado from PRODUCTO p
inner join CATEGORIA c on c.idCategoria = p.idCategoria
go

delete from PRODUCTO
	where  idProducto= 2

DBCC CHECKIDENT (PRODUCTO, RESEED, 0);
go

insert into PRODUCTO (codigo, nombre, descripcion, idCategoria, estado)
	values (101010, 'Tarjeta Grafica', 'EVGA', 2, 1)
go

select * from CLIENTE

select idCliente, documento, nombreCompleto, correo, telefono, estado from CLIENTE

select * from PROVEEDOR

insert into PROVEEDOR (documento, razonSocial, correo, telefono, estado)
	values (101010, 'AMD', 'amd.gmail.com', '812000000', 1)
go
