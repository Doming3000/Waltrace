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
	logo varchar(max) null, -- Opcional
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
delete from usuarios

-- Datos insertados de muestra en la base de datos, corresponden a trabajadores reales de la lista de currículums presente en la cuenta de Microsoft.
insert into trabajadores values
(1, 'Adolfo Bassaletti Cortés', '12696820-5', 'No especificado', '2010-01-01', 'https://1drv.ms/b/s!ArK2rh8W9rjhgVOwZ3RmQWjKKNiX?e=fA0BNZ', ''),
(1, 'Ana Maria Brito', '8382027-6', 'No especificado', '2010-01-01', 'https://1drv.ms/b/s!ArK2rh8W9rjhgRnb44jIlbQkwOrD?e=I7CqS6', '')

-- Datos insertados de ejemplo en la base de datos, no corresponde a información real y se recomienda modificar.
insert into empresas values
('Empresa 1 SA', '77777777-0', 'Walter buschmann Schirmer', 'Ruta 5 sur km 25 parcela 1 Puerto Montt', 56991880202, '2010-01-01', '', 'https://1drv.ms/f/s!ArK2rh8W9rjhgVWq94J76Qmzs00v?e=IApc7W'),
('Empresa 2 SA', '77777777-1', 'Walter buschmann Schirmer', 'Ruta 5 sur km 25 parcela 1 Puerto Montt', 56991880202, '2010-02-02', '', 'https://1drv.ms/f/s!ArK2rh8W9rjhgVYozG_TVFel3VvK?e=1VgauW'),
('Empresa 3 SA', '77777777-2', 'Walter buschmann Schirmer', 'Ruta 5 sur km 25 parcela 1 Puerto Montt', 56991880202, '2010-03-03', '', 'https://1drv.ms/f/s!ArK2rh8W9rjhgVduMeor2oKUnIu_?e=GN8T6o'),
('Empresa 4 SA', '77777777-3', 'Walter buschmann Schirmer', 'Ruta 5 sur km 25 parcela 1 Puerto Montt', 56991880202, '2010-04-04', '', 'https://1drv.ms/f/s!ArK2rh8W9rjhgViTTuMe9_3qabeU?e=XY40zg'),
('Empresa 5 SA', '77777777-4', 'Walter buschmann Schirmer', 'Ruta 5 sur km 25 parcela 1 Puerto Montt', 56991880202, '2010-05-05', '', 'https://1drv.ms/f/s!ArK2rh8W9rjhgVmBOx-MIMbF-5IA?e=TfFF5M'),
('Empresa 6 SA', '77777777-5', 'Walter buschmann Schirmer', 'Ruta 5 sur km 25 parcela 1 Puerto Montt', 56991880202, '2010-06-06', '', 'https://1drv.ms/f/s!ArK2rh8W9rjhgWFdeantNU-Z9F2C?e=lPjlU7'),
('Empresa 7 SA', '77777777-6', 'Walter buschmann Schirmer', 'Ruta 5 sur km 25 parcela 1 Puerto Montt', 56991880202, '2010-07-07', '', 'https://1drv.ms/f/s!ArK2rh8W9rjhgWLoUXFDidve0f3p?e=DeO7uD'),
('Empresa 8 SA', '77777777-7', 'Walter buschmann Schirmer', 'Ruta 5 sur km 25 parcela 1 Puerto Montt', 56991880202, '2010-08-08', '', 'https://1drv.ms/f/s!ArK2rh8W9rjhgWNyMw1tQ2gObaLP?e=8K9JS7'),
('Empresa 9 SA', '77777777-8', 'Walter buschmann Schirmer', 'Ruta 5 sur km 25 parcela 1 Puerto Montt', 56991880202, '2010-09-09', '', 'https://1drv.ms/f/s!ArK2rh8W9rjhgWRgPfiKhuXayTA3?e=8068dO'),
('Empresa 10 SA', '77777777-9', 'Walter buschmann Schirmer', 'Ruta 5 sur km 25 parcela 1 Puerto Montt', 56991880202, '2010-10-10', '', 'https://1drv.ms/f/s!ArK2rh8W9rjhgWX9iqwm2nZWJe6j?e=572K9N')
