create database LojinhaDoZe;
Use LojinhaDoZe;

create table Produtos(
CodigoProd int primary key auto_increment,
Nome varchar(40),
Descrição varchar(100),
Preço_un DECIMAL(8,2),
Quantidade_Estoque int
);

DROP TABLE Produtos;
select * from Produtos;
Select max(CodigoProd) from produtos; 