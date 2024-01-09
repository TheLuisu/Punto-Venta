create database pruebasPIA;
go

use pruebasPIA
go

create table ROL (
	idRol int primary key identity,
	descripcion varchar (250),
	fechaRegistro datetime default getdate()
)
go

create table PERMISO(
	idPermiso int primary key identity,
	idRol int references ROL(idRol),
    nombreMenu varchar(250),
    fechaRegistro datetime default getdate()
)
go

create table USUARIO(
	idUsuario int primary key identity,
	idRol int references ROL(idRol),
    documento varchar(50),
    nombreCompleto varchar(50),
    correo varchar(50),
    contraseña varchar(50),
    estado bit,
    fechaRegistro datetime default getdate()
)
go

insert into ROL(descripcion)
values ('ADMINISTRADOR');
go

insert into ROL(descripcion)
values ('EMPLEADO');
go

insert into USUARIO(documento, nombreCompleto, correo, contraseña, idRol, estado)
values ('admin', 'Luis Castillo', 'castillo@gmail.com', '1234', 1, 1)
go

insert into USUARIO(documento, nombreCompleto, correo, contraseña, idRol, estado)
values ('JesusT', 'Jesus Tenorio', 'tenorio@gmail.com', 'jesus123', 2, 1)
go

insert into USUARIO(documento, nombreCompleto, correo, contraseña, idRol, estado)
values ('TeresaM', 'Teresa Mendoza', 'mendoza@gmail.com', 'teresa123', 2, 1)
go

update USUARIO
	set documento = 'Maria'
	where idUsuario = 3
go

update USUARIO
	set documento = 'Marco'
	where idUsuario = 2
go


delete from USUARIO
	where  idUsuario = 2
go

delete from AUDITORIA_USUARIO
	where  idAuditoria = 1
go

select * from ROL
select * from PERMISO
select * from USUARIO
select * from MOVIMIENTOS_USUARIO
go


DBCC CHECKIDENT (USUARIO, RESEED, 0);
go

DBCC CHECKIDENT (MOVIMIENTOS_USUARIO, RESEED, 0);
go


create table MOVIMIENTOS_USUARIO(
	idAuditoria int primary key identity,
	idUsuario int references USUARIO(idUsuario),
    nombreCompleto varchar(50),
	tipoMovimiento varchar(50),
    fechaRegistro datetime default getdate()
)
go

create trigger INSERT_USUARIO
on USUARIO
after insert
as
begin
	declare @idUsuario int, @idRol int, @documento varchar(50), @nombreCompleto varchar(50), @correo varchar(50), @contraseña varchar(50), @estado bit, @fechaRegistro date;

	select @idUsuario = I.idUsuario from inserted as I;
	select @idRol = I.idRol from inserted as I;
	select @documento = I.documento from inserted as I;
	select @nombreCompleto = I.nombreCompleto from inserted as I;
	select @correo = I.correo from inserted as I;
	select @contraseña = I.contraseña from inserted as I;
	select @estado = I.estado from inserted as I;
	select @fechaRegistro = I.fechaRegistro from inserted as I;

	insert into MOVIMIENTOS_USUARIO (idUsuario, nombreCompleto, tipoMovimiento, fechaRegistro)
	values (@idUsuario, @nombreCompleto, 'ALTA', GETDATE())
	end
go

create trigger UPDATE_USUARIO
on USUARIO
after update
as
begin
	declare @idUsuario int, @idRol int, @documento varchar(50), @nombreCompleto varchar(50), @correo varchar(50), @contraseña varchar(50), @estado bit, @fechaRegistro date;

	select @idUsuario = I.idUsuario from inserted as I;
	select @idRol = I.idRol from inserted as I;
	select @documento = I.documento from inserted as I;
	select @nombreCompleto = I.nombreCompleto from inserted as I;
	select @correo = I.correo from inserted as I;
	select @contraseña = I.contraseña from inserted as I;
	select @estado = I.estado from inserted as I;
	select @fechaRegistro = I.fechaRegistro from inserted as I;

	insert into MOVIMIENTOS_USUARIO (idUsuario, nombreCompleto, tipoMovimiento, fechaRegistro)
	values (@idUsuario, @nombreCompleto, 'ACTUALIZACION', GETDATE())
	end
go

create trigger DELETE_USUARIO
on USUARIO
after delete
as
begin
	declare @idUsuario int, @nombreCompleto varchar(50), @fechaRegistro date;

	select @idUsuario = I.idUsuario from deleted as I;
	select @nombreCompleto = I.nombreCompleto from deleted as I;
	select @fechaRegistro = I.fechaRegistro from deleted as I;

	insert into MOVIMIENTOS_USUARIO (idUsuario, nombreCompleto, tipoMovimiento, fechaRegistro)
	values (@idUsuario, @nombreCompleto, 'BAJA', GETDATE())
	end
go