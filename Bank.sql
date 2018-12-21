drop database BANK;
create database BANK;
use BANK;
CREATE TABLE person (
    national_id INTEGER AUTO_INCREMENT,
    person_name VARCHAR(50),
    birth_date DATE,
    address VARCHAR(250),
    city VARCHAR(50),
    phone_number VARCHAR(15),
    email VARCHAR(25),
    PRIMARY KEY (national_id)
)  ENGINE=INNODB;
CREATE TABLE sub_accounts (
    id INTEGER PRIMARY KEY AUTO_INCREMENT,
    acc_name VARCHAR(50),
    description TINYTEXT,
    interest_rate DOUBLE,
    interest_interval INTEGER
)  ENGINE=INNODB;
CREATE TABLE currencies (
    id INTEGER PRIMARY KEY AUTO_INCREMENT,
    triple_code CHAR(3),
    exchange_rate DOUBLE
)  ENGINE=INNODB;
CREATE TABLE issuers (
    id INTEGER AUTO_INCREMENT,
    issuerName VARCHAR(25),
    PRIMARY KEY (id)
)  ENGINE=INNODB;
CREATE TABLE ATMs (
    id INTEGER PRIMARY KEY AUTO_INCREMENT,
    address VARCHAR(50),
    balance DOUBLE
)  ENGINE=INNODB;
CREATE TABLE branches (
    SWIFT VARCHAR(11) PRIMARY KEY,
    b_name VARCHAR(50),
    phone_number VARCHAR(15),
    postal_code VARCHAR(5),
    address VARCHAR(50),
    city VARCHAR(10),
    opening DATE
)  ENGINE=INNODB;
CREATE TABLE departments (
    id INTEGER PRIMARY KEY AUTO_INCREMENT,
    d_name VARCHAR(50)
)  ENGINE=INNODB;
CREATE TABLE department_branch (
    branch_swift VARCHAR(11),
    dept_id INTEGER,
    CONSTRAINT FOREIGN KEY (dept_id)
        REFERENCES departments (id)
        ON UPDATE CASCADE ON DELETE CASCADE,
    CONSTRAINT FOREIGN KEY (branch_SWIFT)
        REFERENCES branches (SWIFT)
        ON UPDATE CASCADE ON DELETE CASCADE
)  ENGINE=INNODB;
CREATE TABLE customers (
	id int,
    account_id INTEGER PRIMARY KEY AUTO_INCREMENT,
    CONSTRAINT FOREIGN KEY (id)
        REFERENCES person (national_id)
        ON UPDATE CASCADE ON DELETE CASCADE
)  ENGINE=INNODB;
CREATE TABLE roles (
    id INTEGER PRIMARY KEY AUTO_INCREMENT,
    r_name VARCHAR(50),
    dept_id INTEGER,
    CONSTRAINT FOREIGN KEY (dept_id)
        REFERENCES departments (id)
        ON UPDATE CASCADE ON DELETE CASCADE
)  ENGINE=INNODB;
CREATE TABLE employees (
    id INTEGER PRIMARY KEY,
    salary DOUBLE,
    role_id INTEGER,
    username varchar(45) UNIQUE,
	user_password varchar(45),
    CONSTRAINT FOREIGN KEY (id)
        REFERENCES person (national_id)
        ON UPDATE CASCADE ON DELETE CASCADE,
    CONSTRAINT FOREIGN KEY (role_id)
        REFERENCES roles (id)
        ON UPDATE CASCADE ON DELETE CASCADE
)  ENGINE=INNODB;
CREATE TABLE accounts_sub_accounts (
    account_id INTEGER,
    subaccount_id INTEGER AUTO_INCREMENT,
    currency_id INTEGER,
    balance DOUBLE,
    PRIMARY KEY (account_id , subaccount_id , currency_id),
    CONSTRAINT FOREIGN KEY (account_id)
        REFERENCES customers (account_id)
        ON UPDATE CASCADE ON DELETE CASCADE,
    CONSTRAINT FOREIGN KEY (subaccount_id)
        REFERENCES sub_accounts (id)
        ON UPDATE CASCADE ON DELETE CASCADE,
    CONSTRAINT FOREIGN KEY (currency_id)
        REFERENCES currencies (id)
        ON UPDATE CASCADE ON DELETE CASCADE
)  ENGINE=INNODB;
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
CREATE TABLE transactions (
    id INTEGER PRIMARY KEY AUTO_INCREMENT,
    from_account INTEGER,
    from_subAccount INTEGER,
    to_account INTEGER,
    to_subAccount INTEGER,
    amount DOUBLE,
    t_time DATETIME,
    CONSTRAINT FOREIGN KEY (from_account)
        REFERENCES accounts_sub_accounts (account_id)
        ON UPDATE CASCADE ON DELETE CASCADE,
    CONSTRAINT FOREIGN KEY (to_account)
        REFERENCES accounts_sub_accounts (account_id)
        ON UPDATE CASCADE ON DELETE CASCADE,
    CONSTRAINT FOREIGN KEY (from_subAccount)
        REFERENCES accounts_sub_accounts (subaccount_id)
        ON UPDATE CASCADE ON DELETE CASCADE,
    CONSTRAINT FOREIGN KEY (to_subAccount)
        REFERENCES accounts_sub_accounts (subaccount_id)
        ON UPDATE CASCADE ON DELETE CASCADE
)  ENGINE=INNODB;
CREATE TABLE atm_transaction (
    atm_id INT,
    transaction_id INT,
    CONSTRAINT FOREIGN KEY (atm_id)
        REFERENCES atms (id)
        ON UPDATE CASCADE ON DELETE CASCADE,
    CONSTRAINT FOREIGN KEY (transaction_id)
        REFERENCES transactions (id)
        ON UPDATE CASCADE ON DELETE CASCADE
)  ENGINE=INNODB;
CREATE TABLE branch_transaction (
    branch_swift VARCHAR(11),
    transaction_id INT,
    CONSTRAINT FOREIGN KEY (branch_swift)
        REFERENCES branches (swift)
        ON UPDATE CASCADE ON DELETE CASCADE,
    CONSTRAINT FOREIGN KEY (transaction_id)
        REFERENCES transactions (id)
        ON UPDATE CASCADE ON DELETE CASCADE
)  ENGINE=INNODB;
CREATE TABLE customer_cards (
    cnumber VARCHAR(16) PRIMARY KEY,
    account_id INTEGER,
    issuer_id INT,
    issue_date DATE,
    expirey_date DATE,
    daily_limit DOUBLE,
    ctype ENUM('debit', 'credit'),
    CVV VARCHAR(3),
    CONSTRAINT FOREIGN KEY (issuer_id)
        REFERENCES issuers (id)
        ON UPDATE CASCADE ON DELETE CASCADE,
    CONSTRAINT FOREIGN KEY (account_id)
        REFERENCES customers (account_id)
        ON UPDATE CASCADE ON DELETE CASCADE
)  ENGINE=INNODB; 

#///////////////////////////////////////