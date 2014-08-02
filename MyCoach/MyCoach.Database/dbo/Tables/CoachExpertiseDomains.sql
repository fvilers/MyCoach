CREATE TABLE [dbo].[CoachExpertiseDomains] (
    [Coach_Id]           INT NOT NULL,
    [ExpertiseDomain_Id] INT NOT NULL,
    CONSTRAINT [PK_dbo.CoachExpertiseDomains] PRIMARY KEY CLUSTERED ([Coach_Id] ASC, [ExpertiseDomain_Id] ASC),
    CONSTRAINT [FK_dbo.CoachExpertiseDomains_dbo.Coaches_Coach_Id] FOREIGN KEY ([Coach_Id]) REFERENCES [dbo].[Coaches] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.CoachExpertiseDomains_dbo.ExpertiseDomains_ExpertiseDomain_Id] FOREIGN KEY ([ExpertiseDomain_Id]) REFERENCES [dbo].[ExpertiseDomains] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_ExpertiseDomain_Id]
    ON [dbo].[CoachExpertiseDomains]([ExpertiseDomain_Id] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Coach_Id]
    ON [dbo].[CoachExpertiseDomains]([Coach_Id] ASC);

