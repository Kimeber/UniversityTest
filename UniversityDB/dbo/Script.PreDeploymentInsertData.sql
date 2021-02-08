/*
 Pre-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be executed before the build script.	
 Use SQLCMD syntax to include a file in the pre-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the pre-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
INSERT INTO [dbo].[Departament]([Name],[DirectorId]) VALUES('Computer Science Departament', null)
INSERT INTO [dbo].[Departament]([Name],[DirectorId]) VALUES('Mechanic Departament', null)
INSERT INTO [dbo].[Departament]([Name],[DirectorId]) VALUES('Eletronical Departament', null)
INSERT INTO [dbo].[Departament]([Name],[DirectorId]) VALUES('Biology Departament', null)
INSERT INTO [dbo].[Departament]([Name],[DirectorId]) VALUES('Chemistry Departament', null)
INSERT INTO [dbo].[Course]([Title],[Credits],[DepartamentId]) VALUES('Computer Science and Engineering', 180.0, 1)
INSERT INTO [dbo].Person ([Name],[Birthday]) VALUES ('John DOe', '1990-01-01')
INSERT INTO [dbo].[Teacher] ([PersonId],[Salary]) VALUES (1,2000)