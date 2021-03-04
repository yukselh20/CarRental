CREATE TABLE [dbo].[Users] (
    [UserId]   INT  NOT NULL,
    [FirstName] TEXT NOT NULL,
    [LastName] TEXT NOT NULL,
    [Email] TEXT not null,
    [Password] TEXT NOT NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC)
);
CREATE TABLE [dbo].[Customers] (
    [CustomerId]   INT  NOT NULL,
    [UserId] INT NOT NULL,
    [CompanyName] TEXT NOT NULL,
    PRIMARY KEY CLUSTERED ([CustomerId] ASC),
    FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([UserId])
);

CREATE TABLE [dbo].[Rentals] (
    [RentalId]   INT  NOT NULL,
    [CarId] Int NOT NULL,
    [CustomerId] Int NOT NULL,
    [RentalDate] INT NOT NULL,
    [ReturnDate] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([RentalId] ASC),
    FOREIGN KEY ([CarId]) REFERENCES [dbo].[Cars] ([CarId]),
    FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customers] ([CustomerId])
);

