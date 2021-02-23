create database if not exists school;

use school;

drop table if exists classics;
create table classics (
    author varchar(128),
    title varchar(128),
    type varchar(16),
    year char(4),
    isbn char(13) not null
);

insert into classics values ('Mark Twain', 'The Adventures of Tom Sawyer','Fiction', 1876, 0923891),
                            ('Jane Austen', 'Pride and Prejudice', 'Fiction', 1811, 1209382890489),
                            ('Charles Darwin', 'The Origin of Species', 'Non-Fiction', 1856, 20902590),
                            ('Charles Dickens', 'The Old Curiosity Shop', 'Fiction', 1841, 0923801209),
                            ('William Shakespeare', 'Romeo and Juliet', 'Play', 1594, 21938940);

drop table if exists accounts;
create table accounts(
    number int(11) not null,
    balance float default null
);

insert into accounts values (12345, 1025.5),
                            (67980, 140);