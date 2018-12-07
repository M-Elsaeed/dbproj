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
create table accounts(id integer PRIMARY KEY AUTO_INCREMENT )ENGINE=INNODB;
#/////////////////////////////////
 CREATE TABLE sub_accounts (
    id INTEGER PRIMARY KEY AUTO_INCREMENT,
    acc_name VARCHAR(50),
    description TINYTEXT,
    interest_rate DOUBLE,
    interest_interval INTEGER
)  ENGINE=INNODB;
#//////////////////////////////
create table currencies(
    id INTEGER primary KEY AUTO_INCREMENT ,
triple_code char(3),
exchange_rate double
)ENGINE=INNODB;
#/////////////////////////////////
CREATE TABLE issuers (
    id INTEGER AUTO_INCREMENT,
    issuerName VARCHAR(25),
    primary key(id)
)ENGINE=INNODB;
#//////////////////////////////////
create table ATMs(
    id INTEGER primary KEY AUTO_INCREMENT ,
address varchar (50),
balance double
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
CREATE TABLE departments (
    id INTEGER PRIMARY KEY AUTO_INCREMENT,
    d_name VARCHAR(50)
)  ENGINE=INNODB;
#/////////////////////////////////
CREATE TABLE customers (
    id INTEGER primary key,
    account_id INTEGER,
    constraint foreign key (id) references person(person_id) on update cascade on delete cascade,
    constraint foreign key (account_id) references accounts(id) on update cascade on delete cascade

)ENGINE=INNODB;
#/////////////////////////////////
create table roles (
    id INTEGER primary KEY AUTO_INCREMENT ,
r_name varchar(50) ,
dept_id integer,
constraint foreign key (dept_id) references departments(id) on update cascade on delete cascade
)ENGINE=INNODB;
#////////////////////////////////
CREATE TABLE employees (
    id INTEGER PRIMARY KEY,
    salary DOUBLE,
    role_id INTEGER,
    branch_SWIFT VARCHAR(50),
constraint foreign key (id) references person(person_id) on update cascade on delete cascade,
    CONSTRAINT FOREIGN KEY (role_id)
        REFERENCES roles (id)
        ON UPDATE CASCADE ON DELETE CASCADE,
    CONSTRAINT FOREIGN KEY (branch_SWIFT)
        REFERENCES branches (SWIFT)
        ON UPDATE CASCADE ON DELETE CASCADE
)  ENGINE=INNODB;
#/////////////////Revise////////////////
#/////////////////////////////////
CREATE TABLE accounts_sub_accounts (
    account_id INTEGER,
    subaccount_id INTEGER,
    currency_id INTEGER,
    balance double,
	primary key (account_id ,subaccount_id,currency_id),
    constraint foreign key (account_id) references accounts(id) on update cascade on delete cascade,
    constraint foreign key (subaccount_id) references sub_accounts(id) on update cascade on delete cascade,
    constraint foreign key (currency_id) references currencies(id) on update cascade on delete cascade
    
)ENGINE=INNODB;

#/////////////////////////////////
CREATE TABLE payroll (
    id INTEGER PRIMARY KEY AUTO_INCREMENT,
    employee_id INTEGER,
    payment_date DATE,
    bonuses DOUBLE,
    penalties DOUBLE,
    CONSTRAINT FOREIGN KEY (employee_id)
    REFERENCES employees (id)
    ON UPDATE CASCADE ON DELETE CASCADE
)  ENGINE=INNODB;

#////////////////////////////////
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
    constraint foreign key (from_subAccount) references sub_accounts(id) on update cascade on delete cascade,
    constraint foreign key (to_account) references accounts(id) on update cascade on delete cascade,
    constraint foreign key (to_subAccount) references sub_accounts(id) on update cascade on delete cascade
)ENGINE=INNODB;
#//////////////////////////////////
CREATE TABLE cards (
    cnumber VARCHAR(16) PRIMARY KEY,
    issuer_id INT,
    account_id INT,
    issue_date DATE,
    expirey_date DATE,
    daily_limit DOUBLE,
    ctype ENUM('debit', 'credit'),
    CVV VARCHAR(3),
    CONSTRAINT FOREIGN KEY (issuer_id)
        REFERENCES issuers (id)
        ON UPDATE CASCADE ON DELETE CASCADE,
    CONSTRAINT FOREIGN KEY (account_id)
        REFERENCES accounts (id)
        ON UPDATE CASCADE ON DELETE CASCADE
)  ENGINE=INNODB;
#//////////////////////////////////
CREATE TABLE customer_cards (
    account_id INTEGER ,
    cnumber VARCHAR(16),
    primary key(account_id,cnumber),
    constraint foreign key (account_id) references accounts(id) on update cascade on delete cascade,
    constraint foreign key (cnumber) references cards(cnumber) on update cascade on delete cascade
)ENGINE=INNODB;
#//////////////////////////////////
