CREATE DATABASE ProductsCSharp;

USE ProductsCSharp;

CREATE TABLE produtos (
    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(50) NOT NULL,
    preco DECIMAL(10,2) NOT NULL
);

CREATE TABLE almoxarifados (
    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(50) NOT NULL
);

CREATE TABLE saldos (
    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    produto_id INT NOT NULL,
    almoxarifado_id INT NOT NULL,
    quantidade INT NOT NULL,
    FOREIGN KEY (produto_id) REFERENCES produtos(id),
    FOREIGN KEY (almoxarifado_id) REFERENCES almoxarifados(id)
);

select * from saldos;
