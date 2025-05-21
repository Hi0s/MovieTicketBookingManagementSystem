SELECT * FROM users
INSERT INTO users (username, password,role) VALUES ('admin', '12345678','admin')



DELETE FROM users Where username ='admin'

SELECT * FROM users WHERE username = "khanh"


DBCC CHECKIDENT ('users', RESEED, 0);