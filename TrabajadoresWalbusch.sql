-- Crear base de datos
create database TrabajadoresWalbusch
use TrabajadoresWalbusch

-- Tabla Empresas:
create table empresas(
	id_empresa int not null,
	nom_empresa varchar(50) not null,
	rut_empresa varchar(10) not null, -- Sin puntos, con guión
	representante varchar(50) not null, 
	direccion varchar(50) not null,
	telefono bigint not null,
	año_const date not null,
	logo varchar(max) not null,
	documentacion varchar(max) not null,

	constraint pk_emp primary key (id_empresa)); -- Identificador

-- Tabla Trabajadores:
create table trabajadores(
    id_trabajador int not null,
	id_empresa int not null, -- Clave foránea perteneciente a la tabla empresas
    nom_trabajador varchar(50) not null,
    rut_trabajador varchar(10) not null, -- Sin puntos, con guión
	fecha_inicio date not null,
	curriculum_url varchar(max) not null,
	foto varchar(max) not null,

    constraint pk_tra primary key (id_trabajador), -- Identificador
    constraint fk_empresa_contratante foreign key (id_empresa) references empresas(id_empresa)); -- Conexión de tablas por medio de id de la empresa

-- Consultas:
select * from empresas
select * from trabajadores

delete from empresas

-- Inserción de datos ficticios:
insert into empresas (id_empresa, nom_empresa, rut_empresa, representante, direccion, telefono, año_const, documentacion, logo) 
values (1, 'Empresa 1', '74689042-3', 'Juan Gabriel', 'Pasaje Los Colonos 208, Valparaiso', 56987654321, '2012-06-18', 'https://drive.google.com/drive/folders/1W7JaSxQ0TEG6kGMRF8w9FCSloYBuppAV', 'https://i.imgur.com/NThgvQp.jpeg');

insert into empresas (id_empresa, nom_empresa, rut_empresa, representante, direccion, telefono, año_const, documentacion, logo) 
values (2, 'Empresa 2', '81237463-2', 'Ana Rivera', 'Avenida Los Industriales 1560, Santiago', 56222334455, '2010-03-15', 'https://drive.google.com/drive/folders/1W7JaSxQ0TEG6kGMRF8w9FCSloYBuppAV', 'https://i.imgur.com/NThgvQp.jpeg');

insert into empresas (id_empresa, nom_empresa, rut_empresa, representante, direccion, telefono, año_const, documentacion, logo) 
values (3, 'Empresa 3', '76894561-7', 'Luis Castillo', 'Calle Los Alerces 245, Valdivia', 56981234567, '1998-07-21', 'https://drive.google.com/drive/folders/1W7JaSxQ0TEG6kGMRF8w9FCSloYBuppAV', 'https://i.imgur.com/NThgvQp.jpeg');

insert into empresas (id_empresa, nom_empresa, rut_empresa, representante, direccion, telefono, año_const, documentacion, logo) 
values (4, 'Empresa 4', '65432109-0', 'Mariana Vidal', 'Avenida Siempre Viva 742, Punta Arenas', 56976543210, '2015-11-30', 'https://drive.google.com/drive/folders/1W7JaSxQ0TEG6kGMRF8w9FCSloYBuppAV', 'https://i.imgur.com/NThgvQp.jpeg');

insert into empresas (id_empresa, nom_empresa, rut_empresa, representante, direccion, telefono, año_const, documentacion, logo) 
values (5, 'Empresa 5', '98765432-K', 'Roberto Márquez', 'Pasaje Los Copihues 1234, Osorno', 5643219876, '2005-09-14', 'https://drive.google.com/drive/folders/1W7JaSxQ0TEG6kGMRF8w9FCSloYBuppAV', 'https://i.imgur.com/NThgvQp.jpeg');

insert into empresas (id_empresa, nom_empresa, rut_empresa, representante, direccion, telefono, año_const, documentacion, logo) 
values (6, 'Empresa 6', '87654321-5', 'Carla Martínez', 'Camino El Olivar 123, Rancagua', 5678912345, '2012-06-20', 'https://drive.google.com/drive/folders/1W7JaSxQ0TEG6kGMRF8w9FCSloYBuppAV', 'https://i.imgur.com/QZbaHpD.png');

insert into empresas (id_empresa, nom_empresa, rut_empresa, representante, direccion, telefono, año_const, documentacion, logo) 
values (7, 'Empresa 7', '12345678-9', 'Jorge González', 'Avenida Arturo Prat 789, Chiloé', 56912345678, '2001-12-05', 'https://drive.google.com/drive/folders/1W7JaSxQ0TEG6kGMRF8w9FCSloYBuppAV', 'https://i.imgur.com/QZbaHpD.png');

insert into empresas (id_empresa, nom_empresa, rut_empresa, representante, direccion, telefono, año_const, documentacion, logo) 
values (8, 'Empresa 8', '19283746-K', 'Monika Ríos', 'Paseo Bulnes 456, Coyhaique', 56987654321, '2018-08-15', 'https://drive.google.com/drive/folders/1W7JaSxQ0TEG6kGMRF8w9FCSloYBuppAV', 'https://i.imgur.com/QZbaHpD.png');

insert into empresas (id_empresa, nom_empresa, rut_empresa, representante, direccion, telefono, año_const, documentacion, logo) 
values (9, 'Empresa 9', '91827364-7', 'Carlos Navarro', 'Avenida Las Industrias 987, Punta Arenas', 56965432109, '2003-03-25', 'https://drive.google.com/drive/folders/1W7JaSxQ0TEG6kGMRF8w9FCSloYBuppAV', 'https://i.imgur.com/QZbaHpD.png');
