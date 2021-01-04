create database bdsistema
go

use bdsistema
create table usuarios(
id_usuarios int identity(1,1) primary key not null,
usu_nome varchar(20) not null,
usu_senha varchar(512) not null
)
go

use bdsistema
create table fornecedores(
id_fornecedores int identity(1,1) primary key not null,
for_nome varchar(120) not null,
for_cnpj varchar(18) not null,
for_endereco varchar(200) not null,
for_ativo char(1) not null
)
go

use bdsistema
create table produtos(
id_produtos int identity(1,1) primary key not null,
id_fornecedores int not null,
pro_nome varchar(120) not null,
pro_quantidade numeric (10,3) not null
)
go

use bdsistema
alter table produtos
add constraint FK_fornecedores
foreign key (id_fornecedores)
references fornecedores (id_fornecedores);
go

/*
insert na tabela usuarios:
Usuário: admin
Senha: 123456
*/
use bdsistema
insert into usuarios(usu_nome,usu_senha) 
values('admin','123456'))
go

/*Não consegui fazer a busca pelo sistema usando criptografia na senha
values('admin',hashbytes('SHA2_512','123456'))

/*senha sa = 123456*/

select * from usuarios