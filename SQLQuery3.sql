CREATE TABLE users
(
	id INT PRIMARY KEY IDENTITY(1,1),
	username VARCHAR(MAX) NULL,
	password VARCHAR(MAX) NULL,
	adminrole BIT NULL,
	firstname VARCHAR(MAX) NULL,
	lastname VARCHAR(MAX) NULL,
	gender VARCHAR(MAX) NULL,
	birthdate DATE NULL,
	email VARCHAR(MAX) NULL,
	phone VARCHAR(MAX) NULL,
	address VARCHAR(MAX) NULL,
	date_reg DATE NULL,
)
SELECT * FROM users