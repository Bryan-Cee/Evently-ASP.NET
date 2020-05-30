CREATE TABLE [dbo].[Event]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [EventName] VARCHAR(50) NOT NULL, 
    [EventDescription] VARCHAR(140) NOT NULL, 
    [EventDate] DATETIME NOT NULL
)
