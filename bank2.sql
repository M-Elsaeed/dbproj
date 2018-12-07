drop database BANK;
create database BANK;
use BANK;
#//////////////////////////////
CREATE TABLE person (
    person_id INTEGER AUTO_INCREMENT  ,
    person_name VARCHAR(50),
    birth_date DATE,
    address VARCHAR(250),
    city VARCHAR(50),
    phone_number VARCHAR(15),
    email VARCHAR(25),
    primary key  (person_id)
)ENGINE=INNODB;
#//////////////////////////////
CREATE TABLE customers (
    id INTEGER primary key,
    account_id INTEGER,
    constraint foreign key (id) references person(person_id) on update cascade on delete cascade,
    constraint foreign key (account_id) references accounts(id) on update cascade on delete cascade

)ENGINE=INNODB;
#/////////////////////////////////
CREATE TABLE employees (
    id INTEGER PRIMARY KEY,
    salary DOUBLE,
    role_id INTEGER,
    branch_SWIFT VARCHAR(50),
    CONSTRAINT FOREIGN KEY (id)
        REFERENCES person (person_id)
        ON UPDATE CASCADE ON DELETE CASCADE,
    CONSTRAINT FOREIGN KEY (role_id)
        REFERENCES role (id)
        ON UPDATE CASCADE ON DELETE CASCADE,
    CONSTRAINT FOREIGN KEY (branch_SWIFT)
        REFERENCES branches (SWIFT)
        ON UPDATE CASCADE ON DELETE CASCADE
)  ENGINE=INNODB;
#/////////////////Revise////////////////
create table accounts(id integer PRIMARY KEY AUTO_INCREMENT )ENGINE=INNODB;
#/////////////////////////////////
CREATE TABLE accounts_sub_accounts (
    account_id INTEGER,
    sub_accounts_id INTEGER,
    currency_id INTEGER,
    balance double,
	primary key (account_id ,sub_accounts_id,currency_id),
    constraint foreign key (account_id) references accounts(id) on update cascade on delete cascade,
    constraint foreign key (sub_account_id) references sub_accounts(id) on update cascade on delete cascade,
    constraint foreign key (currency_id) references currencies(id) on update cascade on delete cascade
    
)ENGINE=INNODB;
#/////////////////////////////////
 CREATE TABLE sub_accounts (
    id INTEGER PRIMARY KEY AUTO_INCREMENT,
    acc_name VARCHAR(50),
    description TINYTEXT,
    interest_rate DOUBLE,
    interest_interval INTEGER
)  ENGINE=INNODB;
#/////////////////////////////////
CREATE TABLE payroll (
    id INTEGER PRIMARY KEY AUTO_INCREMENT,
    employee_id INTEGER,
    payment_date DATE,
    amount DOUBLE ,
    bonuses DOUBLE,
    penalties DOUBLE,
    constraint foreign key (employee_id) references person(person_id) on update cascade on delete cascade,
    constraint foreign key (amount) references employees(salary) on update cascade on delete cascade
)ENGINE=INNODB;
#/////////////////////////////////
create table currencies(
    id INTEGER primary KEY AUTO_INCREMENT ,
triple_code char(3),
exchange_rate double
)ENGINE=INNODB;
#////////////////////////////////
create table roles (
    id INTEGER primary KEY AUTO_INCREMENT ,
r_name varchar(50) ,
dept_id integer,
constraint foreign key (dept_id) references department(id) on update cascade on delete cascade
)ENGINE=INNODB;
#////////////////////////////////
create table departments(
    id INTEGER primary KEY AUTO_INCREMENT ,
d_name varchar(50)
)ENGINE=INNODB;
#/////////////////////////////////
create table transactions
(
    id INTEGER primary KEY AUTO_INCREMENT ,
from_account integer,
from_subAccount integer,
to_account integer,
to_subAccount integer,
amount double,
t_time datetime,
	constraint foreign key (from_account) references accounts(id) on update cascade on delete cascade,
    constraint foreign key (from_sub_account) references sub_accounts(id) on update cascade on delete cascade,
    constraint foreign key (to_account) references accounts(id) on update cascade on delete cascade,
    constraint foreign key (to_sub_account) references sub_accounts(id) on update cascade on delete cascade
)ENGINE=INNODB;
#//////////////////////////////////
create table branches (
SWIFT varchar(11) primary key  ,
b_name varchar(50) ,
phone_number varchar(15),
postal_code varchar(5),
address varchar (50),
city varchar(10),
opening date
)ENGINE=INNODB;
#///////////////////////////////////
create table ATMs(
    id INTEGER primary KEY AUTO_INCREMENT ,
address varchar (50),
balance double
)ENGINE=INNODB;
#//////////////////////////////////
CREATE TABLE customer_cards (
    account_id INTEGER ,
    cnumber VARCHAR(16),
    primary key(account_id,cnumber),
    constraint foreign key (account_id) references accounts(id) on update cascade on delete cascade,
    constraint foreign key (cnumber) references cards(cnumber) on update cascade on delete cascade
)ENGINE=INNODB;
#//////////////////////////////////
create table cards(
cnumber varchar(16) primary key  ,
issuer_id varchar(25),
account_id int,
issue_date date,
expirey_date date,
daily_limit double,
ctype enum('debit','credit'),
CVV varchar(3),
constraint foreign key (account_id) references accounts(id) on update cascade on delete cascade,
    constraint foreign key (issuer_id) references issuers(id) on update cascade on delete cascade
)ENGINE=INNODB;
#//////////////////////////////////
CREATE TABLE issuers (
    id INTEGER PRIMARY KEY AUTO_INCREMENT,
    issuerName VARCHAR(25)
)ENGINE=INNODB;
#//////////////////////////////////