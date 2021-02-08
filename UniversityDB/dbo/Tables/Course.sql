CREATE TABLE [dbo].[Course] (
    [Id]            INT             IDENTITY (1, 1) NOT NULL,
    [Title]         NVARCHAR (50)   NOT NULL,
    [Credits]       DECIMAL (18, 2) NOT NULL,
    [DepartamentId] INT             NOT NULL,
    CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Course_Departament] FOREIGN KEY ([DepartamentId]) REFERENCES [dbo].[Departament] ([Id])
);

