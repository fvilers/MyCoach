CREATE TABLE [dbo].[ExpertiseDomains] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [Name]            NVARCHAR (MAX) NULL,
    [Slug]            NVARCHAR (MAX) NULL,
    [CoachProfile_Id] INT            NULL,
    CONSTRAINT [PK_dbo.ExpertiseDomains] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.ExpertiseDomains_dbo.CoachProfiles_CoachProfile_Id] FOREIGN KEY ([CoachProfile_Id]) REFERENCES [dbo].[CoachProfiles] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_CoachProfile_Id]
    ON [dbo].[ExpertiseDomains]([CoachProfile_Id] ASC);

