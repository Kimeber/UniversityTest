CREATE TABLE [dbo].[ClassStudent] (
    [Id]        INT             IDENTITY (1, 1) NOT NULL,
    [SubjectId] INT             NOT NULL,
    [StudentId] INT             NOT NULL,
    [Grade]     DECIMAL (18, 2) NULL,
    CONSTRAINT [PK_ClassStudent] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ClassStudent_Student] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Student] ([Id]),
    CONSTRAINT [FK_ClassStudent_Subject] FOREIGN KEY ([SubjectId]) REFERENCES [dbo].[Subject] ([Id])
);

