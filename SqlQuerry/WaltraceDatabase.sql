-- Crear base de datos
create database  WaltraceDatabase
use WaltraceDatabase

-- Tabla Empresas:
create table empresas (
	id_empresa int not null identity(1,1),
	nom_empresa varchar(50) not null,
	rut_empresa varchar(10) not null, -- Sin puntos, con guión
	representante varchar(50) not null, 
	direccion varchar(50) not null,
	telefono bigint not null,
	año_const date not null,
	logo varchar(max) not null,
	documentacion varchar(max) not null,

	constraint pk_emp primary key (id_empresa) -- Identificador
);

-- Tabla Trabajadores:
create table trabajadores (
	id_trabajador int not null identity(1,1),
	id_empresa int not null, -- Clave foránea perteneciente a la tabla empresas
	nom_trabajador varchar(50) not null,
	rut_trabajador varchar(10) not null, -- Sin puntos, con guión
	cargo varchar(30) not null,
	fecha_inicio date not null,
	curriculum_url varchar(max) not null,
	foto varchar(max) null, -- Opcional

	constraint pk_tra primary key (id_trabajador), -- Identificador
	constraint fk_empresa_contratante foreign key (id_empresa) references empresas(id_empresa) -- Conexión de tablas por medio de id de la empresa
);

-- Tabla Usuarios
create table usuarios (
	id_usuario int not null identity(1,1),
	usuario varchar(30) not null,
	contraseña varchar(30) not null,

	constraint pk_use primary key (id_usuario), -- Identificador
);

-- Consultas:
select * from empresas
select * from trabajadores
select * from usuarios

delete from empresas
delete from trabajadores
