CREATE TABLE Address
( 
    HouseNo varchar(50) primary key,
	StreetName varchar(50) not null,
	City varchar(50) not null,
	State varchar(50) not null,
	PinCode int not null
)

CREATE TABLE Users
(
	UserId BIGINT NOT NULL PRIMARY KEY, 
    LoginName VARCHAR(50) NOT NULL, 
    FirstName VARCHAR(50) NOT NULL, 
    LastName VARCHAR(50) NOT NULL, 
    HouseNo VARCHAR(50) references Address(HouseNo)
)

Create table Movie (MovieId bigint primary key, MovieName varchar(50) not null);

Create table Theatre (TheatreId int primary key, TheatreName varchar(50) not null);

Create table Screen (ScreenId int primary key, ScreenName varchar(50) not null, TheatreId int references Theatre(TheatreId) );

create table Show (ShowId int primary key, ShowTime Date not null, Cost Decimal not null, ScreenId int references Screen(ScreenId))

Create table Booking (BookingId bigint primary key, BookingDate DateTime not null, UserId bigint references Users(UserID), ShowId int references Show(ShowId));

Create table Ticket (TicketId bigint primary key, BookingId bigint references Booking(BookingID));

Create table Seat (RowId char not null, SeatId int not null, TicketId bigint references Ticket(TicketID), ScreenId int references Screen(ScreenId));


