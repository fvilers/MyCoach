CREATE TABLE [dbo].[Coaches] (
    [Id]        INT             NOT NULL,
    [Photo_Id]  INT             NULL,
    [FirstName] NVARCHAR (MAX)  NULL,
    [LastName]  NVARCHAR (MAX)  NULL,
    [Price]     DECIMAL (18, 2) NOT NULL,
    [Currency]  INT             NOT NULL,
    [Summary]   NVARCHAR (MAX)  NULL,
    [Biography] NVARCHAR (MAX)  NULL,
    [SkypeId]   NVARCHAR (MAX)  NULL,
    CONSTRAINT [PK_dbo.Coaches] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.Coaches_dbo.ApplicationUsers_Id] FOREIGN KEY ([Id]) REFERENCES [dbo].[ApplicationUsers] ([Id]),
    CONSTRAINT [FK_dbo.Coaches_dbo.Images_Photo_Id] FOREIGN KEY ([Photo_Id]) REFERENCES [dbo].[Images] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Photo_Id]
    ON [dbo].[Coaches]([Photo_Id] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Id]
    ON [dbo].[Coaches]([Id] ASC);

