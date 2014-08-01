CREATE TABLE [dbo].[ExpertiseDomains] (
    [Id]   INT            IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (MAX) NULL,
    [Slug] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.ExpertiseDomains] PRIMARY KEY CLUSTERED ([Id] ASC)
);




GO


