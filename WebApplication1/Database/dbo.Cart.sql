CREATE TABLE [dbo].[Cart] (
    [Id]      INT IDENTITY (1, 1) NOT NULL,
    [item_id] INT NOT NULL,
    [user_id] INT NOT NULL,
	[bought]  INT NOT NULL DEFAULT 0,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

