create database if not exists highland_coffees;

use highland_coffees;

drop table if exists expressco;
create table expressco(
    id smallint primary key auto_increment,
    name nvarchar(150),
    image BLOB not null
);

insert into expressco (name, image) values ('Asset Vanilla Latte', load_file('D:/Documents/HK2/SQLFILES/Highland/Asset Vanilla Latte.jpg')),
                                           ('Coffee Americano', load_file('D:/Documents/HK2/SQLFILES/Highland/Coffee Americano.jpg')),
                                           ('Coffee Latte', load_file('D:/Documents/HK2/SQLFILES/Highland/Coffee Latte.jpg')),
                                           ('Hazelnut Macchiatob', load_file('D:/Documents/HK2/SQLFILES/Highland/Hazelnut Macchiatob.jpg')),
                                           ('Mocha', load_file('D:/Documents/HK2/SQLFILES/Highland/Mocha.jpg')),
                                           ('Ristretto Bianco', load_file('D:/Documents/HK2/SQLFILES/Highland/Ristretto Bianco.jpg')),
                                           ('Skinny Flavored Latte', load_file('D:/Documents/HK2/SQLFILES/Highland/Skinny Flavored Latte.jpg'));


