CREATE TABLE [dbo].[Student] (
    [Id]       INT             IDENTITY (1, 1) NOT NULL,
    [PersonId] INT             NOT NULL,
    [nReg]     INT             NOT NULL,
    [CourseID] INT             NOT NULL,
    [Grade]    DECIMAL (18, 2) NULL,
    CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Student_Person] FOREIGN KEY ([PersonId]) REFERENCES [dbo].[Person] ([Id])
);





