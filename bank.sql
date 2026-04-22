
create table users(
	account_id int identity(000001,1) primary key,
	account_name Varchar(100) not null,
	username varchar(50) not null unique,
	password varchar(50) not null,
	email varchar(100) not null unique,
	balance DECIMAL(9,2) default 0.00,
    created DATETIME NOT NULL DEFAULT GETDATE()
	);

    use bank;

ALTER TABLE users
ADD created DATETIME   DEFAULT GETDATE();


CREATE TABLE TransactionHistory (
    TransactionID INT PRIMARY KEY IDENTITY(001,1),
    AccountID INT NOT NULL,
    TransactionType VARCHAR(20) NOT NULL,  
    Amount DECIMAL(18,2) NOT NULL,
    PreviousBalance DECIMAL(18,2) NOT NULL,
    NewBalance DECIMAL(18,2) NOT NULL,
    TransactionDate DATETIME NOT NULL DEFAULT GETDATE(),
    Description VARCHAR(255),         

    FOREIGN KEY (AccountID) REFERENCES users(account_id)
);


select * from users;
