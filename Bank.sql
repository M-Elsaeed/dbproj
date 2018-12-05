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
);
#//////////////////////////////
CREATE TABLE customers (
    id INTEGER primary key  REFERENCES person.person_id,
    account_id INTEGER REFERENCES accounts.id

);
#/////////////////////////////////
CREATE TABLE employees (
    id INTEGER PRIMARY KEY,
    salary DOUBLE,
    role_id INTEGER REFERENCES role.id,
    branch_SWIFT VARCHAR(50) REFERENCES branches.SWIFT,
    FOREIGN KEY (id)
        REFERENCES person.person_id
);
#/////////////////Revise////////////////
create table accounts(id integer PRIMARY KEY AUTO_INCREMENT );
#/////////////////////////////////
CREATE TABLE accounts_sub_accounts (
    account_id INTEGER REFERENCES accounts.id,
    sub_accounts_id INTEGER REFERENCES sub_accounts.id,
    currency_id INTEGER REFERENCES currencies.id,
    primary key (account_id ,sub_accounts_id,currency_id)
);
#/////////////////////////////////
 CREATE TABLE sub_accounts (
    id INTEGER primary KEY AUTO_INCREMENT ,
    acc_name varchar(50),
    description TINYTEXT,
    interest_rate DOUBLE,
    interest_interval INTEGER,
    balance double
);
#/////////////////////////////////
create table payroll(
    id INTEGER primary KEY AUTO_INCREMENT ,
employee_id INTEGER REFERENCES person.person_id,
payment_date date,
amount double references employees.salary,
bonuses double,
penalties double
#,net double AS (amounut+bounses-panalties)
);
#/////////////////////////////////
create table currencies(
    id INTEGER primary KEY AUTO_INCREMENT ,
triple_code char(3),
exchange_rate double
);
#////////////////////////////////
create table roles (
    id INTEGER primary KEY AUTO_INCREMENT ,
r_name varchar(50) ,
dept_id integer references department.id
);
#////////////////////////////////
create table departments(
    id INTEGER primary KEY AUTO_INCREMENT ,
d_name varchar(50)
);
#/////////////////////////////////
create table transactions
(
    id INTEGER primary KEY AUTO_INCREMENT ,
from_account integer references accounts.id,
from_subAccount integer references sub_accounts.id,
to_account integer references accounts.id,
to_subAccount integer references sub_accounts.id,
amount double,
t_time datetime
);
#//////////////////////////////////
create table branches (
SWIFT varchar(11) primary key  ,
b_name varchar(50) ,
phone_number varchar(15),
postal_code varchar(5),
address varchar (50),
city varchar(10),
opening date
);
#///////////////////////////////////
create table ATMs(
    id INTEGER primary KEY AUTO_INCREMENT ,
address varchar (50),
balance double
);
#//////////////////////////////////
CREATE TABLE customer_cards (
    account_id INTEGER REFERENCES accounts.id,
    cnumber VARCHAR(16) REFERENCES cards.cnumber,
    primary key(account_id,cnumber)
);
#//////////////////////////////////
create table cards(
cnumber varchar(16) primary key  ,
issuerId varchar(25) references issuers.id,
account_id int references accounts.id,
issue_date date,
expirey_date date,
daily_limit double,
ctype enum('debit','credit'),
CVV varchar(3)
);
#//////////////////////////////////
CREATE TABLE issuers (
    id INTEGER PRIMARY KEY AUTO_INCREMENT,
    issuerName VARCHAR(25)
);
#//////////////////////////////////