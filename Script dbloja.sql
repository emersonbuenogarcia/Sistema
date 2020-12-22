create database bdloja

create table usuarios(
id_usuarios int identity(1,1) primary key not null,
usu_nome varchar(20) not null,
usu_senha varchar(40) not null
)

create table fornecedores(
id_fornecedores int identity(1,1) primary key not null,
for_nome varchar(120) not null,
for_cnpj varchar(14) not null,
for_endereco varchar(200) not null,
for_ativo char(1) not null
)

create table produtos(
id_produtos int identity(1,1) primary key not null,
id_fornecedores int not null,
pro_nome varchar(120) not null,
pro_quantidade numeric (10,3) not null,
constraint fk_fornecedores foreign key (id_fornecedores) references fornecedores (id_fornecedores)
)

/*
insert na tabela usuarios
Usuário: Admin
Senha: 123456
*/
insert into usuarios(usu_nome,usu_senha) 
values('admin',hashbytes('md5','123456'))

/*senha sa = 123456


