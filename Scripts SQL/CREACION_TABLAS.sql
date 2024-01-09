create database sistema_venta;
go

use sistema_venta
go

CREATE TABLE ROL(
	idRol int primary key identity, 
    descripcion varchar(250),
    fechaRegistro datetime default getdate()
	);

CREATE TABLE PERMISO(
	idPermiso int primary key identity,
	idRol int references ROL(idRol),
    nombreMenu varchar(250),
    fechaRegistro datetime default getdate()
);


CREATE TABLE PROVEEDOR(
	idProveedor int primary key identity, 
    documento varchar(50),
    razonSocial varchar(50),
    correo varchar(50),
    telefono varchar(50),
    estado bit,
    fechaRegistro datetime default getdate()
);

CREATE TABLE CLIENTE(
	idCliente int primary key identity, 
    documento varchar(50),
    nombreCompleto varchar(50),
    correo varchar(50),
    telefono varchar(50),
    estado bit,
    fechaRegistro datetime default getdate()
);

CREATE TABLE USUARIO(
	idUsuario int primary key identity,
	idRol int references ROL(idRol),
    documento varchar(50),
    nombreCompleto varchar(50),
    correo varchar(50),
    contraseña varchar(50),
    estado bit,
    fechaRegistro datetime default getdate()
);

CREATE TABLE COMPRA(
	idCompra int primary key identity, 
    idUsuario int references USUARIO(idUsuario),
    idProveedor int references PROVEEDOR(idProveedor),
    tipoDocumento varchar(50),
    numDocumento varchar(50),
	montoTotal decimal(20,2),
    fechaRegistro datetime default getdate()
);

CREATE TABLE CATEGORIA(
	idCategoria int primary key identity, 
    descripcion VARCHAR(250),
	estado bit,
    fechaRegistro datetime default getdate()
);

CREATE TABLE PRODUCTO(
	idProducto int primary key identity, 
    codigo varchar(50),
    nombre varchar(50),
    descripcion varchar(50),
    idCategoria int references CATEGORIA(idCategoria),
    stock int not null default 0,
    precioCompra decimal(20,2) default 0,
    precioVenta decimal(20,2) default 0,
	estado bit,
    fechaRegistro datetime default getdate()
);


CREATE TABLE DETALLE_COMPRA(
	idDetalleCompra int primary key identity, 
    idCompra int references COMPRA(idCompra),
    idProducto int references PRODUCTO(idProducto),
    precioCompra decimal(20,2) default 0,
    precioVenta decimal(20,2) default 0,
    cantidad int,
	montoTotal decimal(20,2),
    fechaRegistro datetime default getdate()
);

CREATE TABLE VENTA(
	idVenta int primary key identity, 
    idUsuario int references USUARIO(idUsuario),
    tipoDocumento varchar(50),
    numDocumento varchar(50),
    documentoCliente varchar(50),
    nombreCliente varchar(100),
    montoPago decimal(20,2),
    montoCambio decimal(20,2),
    montoTotal decimal(20,2),
    fechaRegistro datetime default getdate()
);

CREATE TABLE DETALLE_VENTA(
	idDetalleVenta int primary key identity, 
    idVenta int references VENTA(idVenta),
    idProducto int references PRODUCTO(idProducto),
    precioVenta decimal(20,2),
    cantidad int,
	subTotal decimal(20,2),
    fechaRegistro datetime default getdate()
);
