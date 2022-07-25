CREATE TABLE [dbo].[UserTb]
(
	[UserNo] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserName] NCHAR(10) NULL, 
    [Age] INT NULL, 
    [Address] NCHAR(10) NULL, 
    [ContactNumber] VARCHAR(50) NULL, 
    [Status] NCHAR(10)  DEFAULT ('Processing') NULL, 
    [Role] NCHAR(10) NULL, 
    [Email] VARCHAR(50) NULL, 
    [Password] VARCHAR(50) NULL
)