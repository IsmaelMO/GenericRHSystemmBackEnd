# GenericRHSystemmBackEnd

La base de datos asociada en la aplicación se puede crear bajo los siguientes comandos SQL:
CREATE DATABASE AppDB
USE AppDB
create table Usuario(
	id int not null identity primary key,
	email varchar(80) not null,
	user varchar(7) not null,
	password varchar(10) not null,
	status bit not null,
	gender varchar(10) not null,
	creationDate datetime default CURRENT_TIMESTAMP   not null 
);
