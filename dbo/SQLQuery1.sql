CREATE TABLE users
(
	UserID INT PRIMARY KEY IDENTITY(1,1),
	Username VARCHAR(50) UNIQUE NOT NULL ,
	Password VARCHAR(MAX) NULL,
	Firstname VARCHAR(MAX) NULL,
	Lastname VARCHAR(MAX) NULL,
	Gender VARCHAR(MAX) NULL,
	Birthdate DATE NULL,
	Email VARCHAR(MAX) NULL,
	Phone VARCHAR(MAX) NULL,
	Address VARCHAR(MAX) NULL,
	Role VARCHAR(MAX) DEFAULT 'user',
	CreatedAt DATE NULL
);

CREATE TABLE movies
(
MovieID INT PRIMARY KEY IDENTITY(1,1),
Title VARCHAR(MAX) NOT NULL,
Description VARCHAR(MAX) NOT NULL,
Genre VARCHAR(MAX) NOT NULL,
Duration INT, -- in minutes,
Rating VARCHAR(10) NULL,
ReleaseDate DATE NULL,
PosterPath VARCHAR(255) NULL,
CreatedAt DATE NULL
)

CREATE TABLE theaters (
    TheaterID INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(50) NOT NULL,
    RowsCount INT NOT NULL,
    SeatsPerRow INT NOT NULL
);

CREATE TABLE seats (
    SeatID INT PRIMARY KEY IDENTITY(1,1),
    TheaterID INT NOT NULL,
    RowLabel CHAR(1) NOT NULL,  -- A, B, C, D
    SeatNumber INT NOT NULL,    -- 1 to 10
    SeatCode AS (RowLabel + CAST(SeatNumber AS VARCHAR)) PERSISTED,
    FOREIGN KEY (TheaterID) REFERENCES Theaters(TheaterID)
);

CREATE TABLE showtimes (
    ShowtimeID INT PRIMARY KEY IDENTITY(1,1),
    MovieID INT NOT NULL,
    TheaterID INT NOT NULL,
    StartTime DATETIME NOT NULL,
    TotalSeats INT,
    AvailableSeats INT,
    FOREIGN KEY (MovieID) REFERENCES Movies(MovieID),
    FOREIGN KEY (TheaterID) REFERENCES Theaters(TheaterID)
);

CREATE TABLE tickets (
    TicketID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT NOT NULL,
    ShowtimeID INT NOT NULL,
    SeatCode VARCHAR(5) NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    BookingTime DATETIME NULL,
    Status VARCHAR(20) DEFAULT 'Reserved', -- Reserved, Cancelled
    CancelledTime DATETIME NULL,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (ShowtimeID) REFERENCES Showtimes(ShowtimeID)
);

CREATE TABLE payments (
    PaymentID INT PRIMARY KEY IDENTITY(1,1),
    TicketID INT NOT NULL,
    Amount INT NOT NULL,
    PaymentTime DATETIME NULL,
    Method VARCHAR(50), -- Credit card
    Status VARCHAR(20) DEFAULT 'Success', -- Success, Failed
    FOREIGN KEY (TicketID) REFERENCES Tickets(TicketID)
);


SELECT * from users;

SELECT * from movies;

SELECT * from theaters;


SELECT * from showtimes;

SELECT * from tickets;

SELECT * from payments;


DELETE FROM tickets 

DELETE from showtimes

DELETE from users where UserID=8

DELETE from movies where MovieID=9


SELECT COUNT(*) FROM movies

UPDATE movies SET PosterPath='Resources\infinitywar.jpg'

UPDATE showtimes SET Status = 'Cancelled' WHERE ShowtimeID = 1
UPDATE showtimes SET Status = 'Scheduled' WHERE ShowtimeID = 1

UPDATE showtimes SET Status = 'Scheduled' WHERE Status = 'Cancelled'

SELECT * FROM movies WHERE IsActive=1
UPDATE movies SET ReleaseDate = '2025-06-01' WHERE MovieID=10; 

SELECT movies.Title,showtimes.StartTime, showtimes.TotalSeats, 
showtimes.AvailableSeats,showtimes.Status as 'Premiere Status',movies.PosterPath
FROM showtimes 
INNER JOIN movies ON showtimes.MovieID = movies.MovieID
WHERE movies.IsActive =1


SELECT movies.Title, SUM(tickets.Price) AS TotalRevenue
FROM tickets
INNER JOIN showtimes ON tickets.ShowtimeID = showtimes.ShowtimeID
INNER JOIN movies ON showtimes.MovieID = movies.MovieID
WHERE tickets.Status = 'Reserved' AND movies.IsActive = 1
GROUP BY movies.Title
ORDER BY TotalRevenue DESC;

SELECT TOP 10 users.Username,movies.Title,tickets.BookingTime As 'Booking Date'
FROM tickets
INNER JOIN showtimes ON tickets.ShowtimeID = showtimes.ShowtimeID
INNER JOIN movies ON showtimes.MovieID = movies.MovieID
INNER JOIN users ON tickets.UserID = users.UserID
WHERE tickets.Status = 'Reserved' AND movies.IsActive = 1
ORDER BY tickets.BookingTime DESC;

DELETE FROM users where UserID = 1;

DELETE FROM movies where MovieID = 3;

SELECT COUNT(*) FROM users WHERE Username = 'admin';

DBCC CHECKIDENT ('users', RESEED, 0); --reset ID count

DBCC CHECKIDENT ('movies', RESEED, 0)

DBCC CHECKIDENT ('theaters', RESEED, 0)

DBCC CHECKIDENT ('tickets', RESEED, 0)

DBCC CHECKIDENT ('showtimes',RESEED, 0)

INSERT INTO Users (Username, Password,Role) VALUES ('admin', '12345678','admin') -- create admin account

UPDATE users SET Role ='admin' WHERE UserID = 1; -- make user with ID 1 an admin

DROP TABLE IF EXISTS users, movies, theaters, seats, showtimes, tickets, payments;

INSERT INTO theaters (Name, RowsCount, SeatsPerRow) VALUES
('Theater 1', 4, 10),
('Theater 2', 4, 10),
('Theater 3', 4, 10);

INSERT INTO seats (TheaterID, RowLabel, SeatNumber) VALUES
('1', 'A', 1),
('1', 'A', 2),
('1', 'A', 3),
('1', 'A', 4),
('1', 'A', 5),
('1', 'A', 6),
('1', 'A', 7),
('1', 'A', 8),
('1', 'A', 9),
('1', 'A', 10),
('1', 'B', 1),
('1', 'B', 2),
('1', 'B', 3),
('1', 'B', 4),
('1', 'B', 5),
('1', 'B', 6),
('1', 'B', 7),
('1', 'B', 8),
('1', 'B', 9),
('1', 'B', 10),
('1', 'C', 1),
('1', 'C', 2),
('1', 'C', 3),
('1', 'C', 4),
('1', 'C', 5),
('1', 'C', 6),
('1', 'C', 7),
('1', 'C', 8),
('1', 'C', 9),
('1', 'C', 10),
('1', 'D', 1),
('1', 'D', 2),
('1', 'D', 3),
('1', 'D', 4),
('1', 'D', 5),
('1', 'D', 6),
('1', 'D', 7),
('1', 'D', 8),
('1', 'D', 9),
('1', 'D', 10),
('2', 'A', 1),
('2', 'A', 2),
('2', 'A', 3),
('2', 'A', 4),
('2', 'A', 5),
('2', 'A', 6),
('2', 'A', 7),
('2', 'A', 8),
('2', 'A', 9),
('2', 'A', 10),
('2', 'B', 1),
('2', 'B', 2),
('2', 'B', 3),
('2', 'B', 4),
('2', 'B', 5),
('2', 'B', 6),
('2', 'B', 7),
('2', 'B', 8),
('2', 'B', 9),
('2', 'B', 10),
('2', 'C', 1),
('2', 'C', 2),
('2', 'C', 3),
('2', 'C', 4),
('2', 'C', 5),
('2', 'C', 6),
('2', 'C', 7),
('2', 'C', 8),
('2', 'C', 9),
('2', 'C', 10),
('2', 'D', 1),
('2', 'D', 2),
('2', 'D', 3),
('2', 'D', 4),
('2', 'D', 5),
('2', 'D', 6),
('2', 'D', 7),
('2', 'D', 8),
('2', 'D', 9),
('2', 'D', 10),
('3', 'A', 1),
('3', 'A', 2),
('3', 'A', 3),
('3', 'A', 4),
('3', 'A', 5),
('3', 'A', 6),
('3', 'A', 7),
('3', 'A', 8),
('3', 'A', 9),
('3', 'A', 10),
('3', 'B', 1),
('3', 'B', 2),
('3', 'B', 3),
('3', 'B', 4),
('3', 'B', 5),
('3', 'B', 6),
('3', 'B', 7),
('3', 'B', 8),
('3', 'B', 9),
('3', 'B', 10),
('3', 'C', 1),
('3', 'C', 2),
('3', 'C', 3),
('3', 'C', 4),
('3', 'C', 5),
('3', 'C', 6),
('3', 'C', 7),
('3', 'C', 8),
('3', 'C', 9),
('3', 'C', 10),
('3', 'D', 1),
('3', 'D', 2),
('3', 'D', 3),
('3', 'D', 4),
('3', 'D', 5),
('3', 'D', 6),
('3', 'D', 7),
('3', 'D', 8),
('3', 'D', 9),
('3', 'D', 10);


ALTER TABLE Users ADD IsActive BIT DEFAULT 1;
UPDATE Users SET IsActive = 1;

ALTER TABLE Movies ADD IsActive BIT DEFAULT 1;

UPDATE Movies SET IsActive = 1;

ALTER TABLE Theaters ADD IsActive BIT DEFAULT 1;
UPDATE Theaters SET IsActive = 1;

ALTER TABLE Showtimes ADD Status VARCHAR(20) DEFAULT 'Scheduled';



