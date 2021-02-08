CREATE TABLE [dbo].[Student] (
    [Id]       INT NOT NULL,
    [PersonId] INT NOT NULL,
    [nReg]     INT NOT NULL,
    CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Student_Person] FOREIGN KEY ([PersonId]) REFERENCES [dbo].[Person] ([Id])
);

