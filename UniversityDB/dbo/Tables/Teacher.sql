CREATE TABLE [dbo].[Teacher] (
    [Id]       INT             IDENTITY (1, 1) NOT NULL,
    [PersonId] INT             NOT NULL,
    [Salary]   DECIMAL (18, 2) NULL,
    CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Teacher_Person] FOREIGN KEY ([PersonId]) REFERENCES [dbo].[Person] ([Id])
);

