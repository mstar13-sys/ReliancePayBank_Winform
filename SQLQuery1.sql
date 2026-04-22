create database bank;
use bank;

CREATE TABLE users (
    id INT identity(1,1) PRIMARY KEY,
    username VARCHAR(100) unique NOT NULL,
    password VARCHAR(50) NOT NULL,
    email varchar(100) unique not null 
);


