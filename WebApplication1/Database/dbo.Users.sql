CREATE TABLE [dbo].[users] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [name]     NVARCHAR (50) NOT NULL,
    [password] VARCHAR (150) NOT NULL,
    [email]    NVARCHAR (50) NOT NULL,
    [role]     INT           NOT NULL,
	[address]  NVARCHAR(70)  NOT NULL,
	[phone]         NVARCHAR(15)	 NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

