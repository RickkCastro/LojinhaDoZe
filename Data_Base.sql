create database LojinhaDoZe;

create table Produtos(
CodigoProd int primary key auto_increment,
Nome varchar(40),
Descrição varchar(100),
Preço_un int,
Quantidade_Estoque int
);

select * from Produtos;