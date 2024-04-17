-- Crear base de datos
create database  WaltraceDatabase
use WaltraceDatabase

-- Tabla Empresas:
create table empresas (
	id_empresa int not null,
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
    id_trabajador int not null,
	id_empresa int not null, -- Clave foránea perteneciente a la tabla empresas
    nom_trabajador varchar(50) not null,
    rut_trabajador varchar(10) not null, -- Sin puntos, con guión
	cargo varchar(30) not null,
	fecha_inicio date not null,
	curriculum_url varchar(max) not null,
	foto varchar(max) not null,

    constraint pk_tra primary key (id_trabajador), -- Identificador
    constraint fk_empresa_contratante foreign key (id_empresa) references empresas(id_empresa) -- Conexión de tablas por medio de id de la empresa
);

-- Tabla barcos (pertenecientes a Walbusch SA):
create table barcos (
    id_barco int not null,
    id_empresa int not null, -- Clave foránea 
    nom_barco varchar(50) not null,
    foto varchar(max),
    ficha varchar(max),

	constraint pk_bar primary key (id_barco), -- Identificador
    constraint fk_barcos_empresas foreign key (id_empresa) references empresas(id_empresa),
    check (id_empresa = 1)  -- Solo la empresa 1 opera con barcos
);

-- Tabla Tripulación (Hecha para conectar la tabla trabajadores con la tabla barcos):
create table tripulacion (
    id_barco int,
    id_trabajador int,
    rol varchar(30),

    constraint pk_tripulacion primary key (id_barco, id_trabajador),
    constraint fk_tripulacion_barcos foreign key (id_barco) references barcos(id_barco),
    constraint fk_tripulacion_trabajadores foreign key (id_trabajador) references trabajadores(id_trabajador)
);

-- Consultas:
select * from empresas
select * from trabajadores

delete from empresas
delete from trabajadores

-- Inserción de datos:
insert into empresas (id_empresa, nom_empresa, rut_empresa, representante, direccion, telefono, año_const, documentacion, logo) 
values
(1, 'Empresa 1', '74689042-3', 'Juan Gabriel', 'Pasaje Los Colonos 208, Valparaiso', 56987654321, '2012-06-18', 'https://drive.google.com/drive/folders/1W7JaSxQ0TEG6kGMRF8w9FCSloYBuppAV', 'https://i.imgur.com/NThgvQp.jpeg'),
(2, 'Empresa 2', '81237463-2', 'Ana Rivera', 'Avenida Los Industriales 1560, Santiago', 56222334455, '2010-03-15', 'https://drive.google.com/drive/folders/1W7JaSxQ0TEG6kGMRF8w9FCSloYBuppAV', 'https://i.imgur.com/NThgvQp.jpeg')

insert into trabajadores (id_trabajador, id_empresa, nom_trabajador, rut_trabajador, cargo, fecha_inicio, curriculum_url, foto)
values
(1, 1, 'Juan Pérez', '12345678-9', 'Recursos Humanos', '2020-01-15', 'https://www.ejemplo-cv.com/juanperez', 'https://www.ejemplo-foto.com/juanperez.jpg')