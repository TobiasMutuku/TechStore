CREATE TABLE [dbo].[Items]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [name] NVARCHAR(50) NOT NULL, 
    [price] INT NOT NULL, 
    [description] NVARCHAR(300) NOT NULL, 
    [image] NVARCHAR(300) NOT NULL
)
