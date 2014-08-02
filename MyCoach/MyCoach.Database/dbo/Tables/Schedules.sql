CREATE TABLE [dbo].[Schedules] (
    [Id]            INT      IDENTITY (1, 1) NOT NULL,
    [StartDateTime] DATETIME NOT NULL,
    [Duration]      INT      NOT NULL,
    [Coach_Id]      INT      NULL,
    CONSTRAINT [PK_dbo.Schedules] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.Schedules_dbo.Coaches_Coach_Id] FOREIGN KEY ([Coach_Id]) REFERENCES [dbo].[Coaches] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Coach_Id]
    ON [dbo].[Schedules]([Coach_Id] ASC);

