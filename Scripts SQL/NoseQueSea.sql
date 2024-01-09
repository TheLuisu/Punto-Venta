use sistema_venta

select * from USUARIO

delete USUARIO
	where idUsuario = 3;
go

DBCC CHECKIDENT (USUARIO, RESEED, 0);
go

select * from CATEGORIA
select * from CLIENTE
select * from COMPRA
select * from DETALLE_COMPRA
select * from DETALLE_VENTA
select * from MOVIMIENTOS_CLIENTE
select * from MOVIMIENTOS_USUARIO
select * from PERMISO
select * from PRODUCTO
select * from PROVEEDOR
select * from ROL
select * from USUARIO
select * from VENTA