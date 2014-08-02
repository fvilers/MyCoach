CREATE TABLE [dbo].[Images] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [Content]     VARBINARY (MAX) NULL,
    [ContentType] NVARCHAR (MAX)  NULL,
    CONSTRAINT [PK_dbo.Images] PRIMARY KEY CLUSTERED ([Id] ASC)
);

