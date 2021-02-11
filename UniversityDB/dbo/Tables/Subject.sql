CREATE TABLE [dbo].[Subject] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [CourseId]  INT           NOT NULL,
    [TeacherId] INT           NOT NULL,
    [Name]      NVARCHAR (50) CONSTRAINT [DF_Subject_Name] DEFAULT (N'Teste') NOT NULL,
    CONSTRAINT [PK_Class] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Subject_Course] FOREIGN KEY ([CourseId]) REFERENCES [dbo].[Course] ([Id]),
    CONSTRAINT [FK_Subject_Teacher] FOREIGN KEY ([TeacherId]) REFERENCES [dbo].[Teacher] ([Id])
);



