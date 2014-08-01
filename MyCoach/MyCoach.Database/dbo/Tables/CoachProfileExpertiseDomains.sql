CREATE TABLE [dbo].[CoachProfileExpertiseDomains] (
    [CoachProfile_Id]    INT NOT NULL,
    [ExpertiseDomain_Id] INT NOT NULL,
    CONSTRAINT [PK_dbo.CoachProfileExpertiseDomains] PRIMARY KEY CLUSTERED ([CoachProfile_Id] ASC, [ExpertiseDomain_Id] ASC),
    CONSTRAINT [FK_dbo.CoachProfileExpertiseDomains_dbo.CoachProfiles_CoachProfile_Id] FOREIGN KEY ([CoachProfile_Id]) REFERENCES [dbo].[CoachProfiles] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.CoachProfileExpertiseDomains_dbo.ExpertiseDomains_ExpertiseDomain_Id] FOREIGN KEY ([ExpertiseDomain_Id]) REFERENCES [dbo].[ExpertiseDomains] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_ExpertiseDomain_Id]
    ON [dbo].[CoachProfileExpertiseDomains]([ExpertiseDomain_Id] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CoachProfile_Id]
    ON [dbo].[CoachProfileExpertiseDomains]([CoachProfile_Id] ASC);

