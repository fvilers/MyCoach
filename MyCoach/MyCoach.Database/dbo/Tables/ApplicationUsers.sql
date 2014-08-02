CREATE TABLE [dbo].[ApplicationUsers] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [UserName]      NVARCHAR (MAX) NULL,
    [Password]      NVARCHAR (MAX) NULL,
    [PasswordHash]  NVARCHAR (MAX) NULL,
    [SkypeId1]      NVARCHAR (MAX) NULL,
    [Discriminator] NVARCHAR (128) NULL,
    CONSTRAINT [PK_dbo.ApplicationUsers] PRIMARY KEY CLUSTERED ([Id] ASC)
);



