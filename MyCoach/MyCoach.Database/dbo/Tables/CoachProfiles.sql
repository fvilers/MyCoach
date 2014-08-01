CREATE TABLE [dbo].[CoachProfiles] (
    [Id]        INT             IDENTITY (1, 1) NOT NULL,
    [FirstName] NVARCHAR (MAX)  NULL,
    [LastName]  NVARCHAR (MAX)  NULL,
    [Price]     DECIMAL (18, 2) NOT NULL,
    [Currency]  INT             NOT NULL,
    [Biography] NVARCHAR (MAX)  NULL,
    CONSTRAINT [PK_dbo.CoachProfiles] PRIMARY KEY CLUSTERED ([Id] ASC)
);

