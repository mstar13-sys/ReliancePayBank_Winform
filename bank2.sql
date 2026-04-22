DROP TABLE TransactionHistory;

-- Drop the parent table (users)
DROP TABLE users;

-- Recreate the parent table (users)
CREATE TABLE users(
	account_id INT IDENTITY(001,1) PRIMARY KEY,
	account_name VARCHAR(100) NOT NULL,
	username VARCHAR(50) NOT NULL UNIQUE,
	password VARCHAR(50) NOT NULL,
	email VARCHAR(100) NOT NULL UNIQUE,
	balance DECIMAL(9,2) DEFAULT 0.00,
 	created DATETIME NOT NULL DEFAULT GETDATE()
);

CREATE TABLE TransactionHistory (
    TransactionID INT PRIMARY KEY IDENTITY(1,1),
    AccountID INT NOT NULL,
    TransactionType VARCHAR(20) NOT NULL,  
    Amount DECIMAL(18,2) NOT NULL,
    PreviousBalance DECIMAL(18,2) NOT NULL,
    NewBalance DECIMAL(18,2) NOT NULL,
    TransactionDate DATETIME NOT NULL DEFAULT GETDATE(),
    Description VARCHAR(255),          
    
    FOREIGN KEY (AccountID) REFERENCES users(account_id) 
        ON DELETE CASCADE 
);