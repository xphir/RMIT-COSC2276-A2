create table Room
(
    RoomID nvarchar(10) not null,
    constraint PK_Room primary key (RoomID)
);

create table [User]
(
    UserID nvarchar(8) not null,
    Name nvarchar(max) not null,
    Email nvarchar(max) not null,
    constraint PK_User primary key (UserID)
);

create table Slot
(
    RoomID nvarchar(10) not null,
    StartTime datetime2 not null,
    StaffID nvarchar(8) not null,
    BookedInStudentID nvarchar(8) null,
    constraint PK_Slot primary key (RoomID, StartTime),
    constraint FK_Slot_Room foreign key (RoomID) references Room (RoomID),
    constraint FK_Slot_User_Staff foreign key (StaffID)
    references [User] (UserID),
    constraint FK_Slot_User_Student foreign key (BookedInStudentID)
    references [User] (UserID)
);
