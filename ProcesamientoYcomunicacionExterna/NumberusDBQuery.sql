select * from LogIn_Table

insert into LogIn_Table values ('root', 0101111, 0);

delete from LogIn_Table

drop table LogIn_Table

create table LogIn_Table
(
	_ROOT bit not null,
	Usuario varchar(50) not null,
	Contraseña varchar(max) not null,
	nombres varchar(50) not null,
	apellidos varchar(50) not null,
	primary key(Usuario)
);