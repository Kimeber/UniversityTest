CREATE TABLE [dbo].[Departament] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [Name]       NVARCHAR (50) NOT NULL,
    [DirectorId] INT           NULL,
    CONSTRAINT [PK_Departament] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Departament_Teacher] FOREIGN KEY ([DirectorId]) REFERENCES [dbo].[Teacher] ([Id])
);



