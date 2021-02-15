/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
USE [$(DatabaseName)]
GO

DECLARE @Count int



SELECT @Count = Count(*) FROM Departament

IF @Count > 0
BEGIN
    DELETE FROM [ClassStudent]
    DELETE FROM [Subject]
    DELETE FROM [Course]
    DELETE FROM [Teacher]
    DELETE FROM [Student]
    DELETE FROM [Person]
    DELETE FROM [Departament]

    DBCC CHECKIDENT ('[ClassStudent]', RESEED, 0);
    DBCC CHECKIDENT ('[Subject]', RESEED, 0);
    DBCC CHECKIDENT ('[Course]', RESEED, 0);
    DBCC CHECKIDENT ('[Teacher]', RESEED, 0);
    DBCC CHECKIDENT ('[Student]', RESEED, 0);
    DBCC CHECKIDENT ('[Person]', RESEED, 0);
    DBCC CHECKIDENT ('[Departament]', RESEED, 0);
END


------ ADD Departaments ------

    INSERT INTO Departament ([Name]) VALUES ('Computer Science Departament')
    INSERT INTO Departament ([Name]) VALUES ('Mechanic Departament')
    INSERT INTO Departament ([Name]) VALUES ('Mathmatical Departament')
    INSERT INTO Departament ([Name]) VALUES ('Biology Departament')

------ END ADD Departaments ------

------ ADD Courses ------

    INSERT INTO Course (Title, Credits, DepartamentId) VALUES ('Computer Science and Engineering', 180, 1)
    INSERT INTO Course (Title, Credits, DepartamentId) VALUES ('Big Data', 120, 1)
    INSERT INTO Course (Title, Credits, DepartamentId) VALUES ('Mechanical Engineering', 180, 2)
    INSERT INTO Course (Title, Credits, DepartamentId) VALUES ('Automation', 180, 2)
    INSERT INTO Course (Title, Credits, DepartamentId) VALUES ('Trigonometry', 120, 3)
    INSERT INTO Course (Title, Credits, DepartamentId) VALUES ('Biology', 180, 4)

------ END ADD Courses ------

------ ADD Persons ------

    INSERT INTO Person([Name], Birthday) VALUES ('John Doe', '1965-01-23') --1
    INSERT INTO Person([Name], Birthday) VALUES ('Carson Alexander', '1978-06-01')--2
    INSERT INTO Person([Name], Birthday) VALUES ('Arturo Anand', '1973-04-30')--3
    INSERT INTO Person([Name], Birthday) VALUES ('Gytis Barzdukas', '1984-07-25')--4
    INSERT INTO Person([Name], Birthday) VALUES ('Yan Li', '1988-05-13')--5
    INSERT INTO Person([Name], Birthday) VALUES ('Peggy Justice', '2000-05-06')--6
    INSERT INTO Person([Name], Birthday) VALUES ('Laura Norman', '2001-03-20')--7
    INSERT INTO Person([Name], Birthday) VALUES ('Mike Santo', '2002-07-21')--8
    INSERT INTO Person([Name], Birthday) VALUES ('Christopher Nolan', '2000-01-03')--9
    INSERT INTO Person([Name], Birthday) VALUES ('Samuel Jackson', '2004-03-29')--10
    INSERT INTO Person([Name], Birthday) VALUES ('Scarlett Johansson', '2003-08-08')--11
    INSERT INTO Person([Name], Birthday) VALUES ('Luke Skywalker', '2002-02-17')--12

------ END ADD Persons ------

------ ADD Teachers ------

    INSERT INTO Teacher(PersonId, Salary) VALUES (1,2000)
    INSERT INTO Teacher(PersonId, Salary) VALUES (2,1500)
    INSERT INTO Teacher(PersonId, Salary) VALUES (3,1800)
    INSERT INTO Teacher(PersonId, Salary) VALUES (4,1500)
    INSERT INTO Teacher(PersonId, Salary) VALUES (5,1400)

------ END ADD Teachers ------

------ ADD Students ------

    INSERT INTO Student (PersonId, nReg,CourseID) VALUES (6,12345,1)
    INSERT INTO Student (PersonId, nReg,CourseID) VALUES (7,21234,5)
    INSERT INTO Student (PersonId, nReg,CourseID) VALUES (8,12312,1)
    INSERT INTO Student (PersonId, nReg,CourseID) VALUES (9,34543,1)
    INSERT INTO Student (PersonId, nReg,CourseID) VALUES (10,57856,2)
    INSERT INTO Student (PersonId, nReg,CourseID) VALUES (11,23432,3)
    INSERT INTO Student (PersonId, nReg,CourseID) VALUES (12,91235,1)

------ END ADD Students ------

------ ADD Subjects ------

    INSERT INTO [Subject] ([Name], CourseId, TeacherId, Credits) VALUES ('Introduction', 1, 1, 6)--1
    INSERT INTO [Subject] ([Name], CourseId, TeacherId, Credits) VALUES ('Microprocessors', 1, 1, 9)--2
    INSERT INTO [Subject] ([Name], CourseId, TeacherId, Credits) VALUES ('Programming', 1, 2, 9)--3
    INSERT INTO [Subject] ([Name], CourseId, TeacherId, Credits) VALUES ('Oriented Objects', 1, 2, 6)--4
    INSERT INTO [Subject] ([Name], CourseId, TeacherId, Credits) VALUES ('Math Analysis', 2, 3, 5)--5
    INSERT INTO [Subject] ([Name], CourseId, TeacherId, Credits) VALUES ('Accounting', 5, 3, 5)--6
    INSERT INTO [Subject] ([Name], CourseId, TeacherId, Credits) VALUES ('Finance', 5, 4, 5)--7
    INSERT INTO [Subject] ([Name], CourseId, TeacherId, Credits) VALUES ('Databases', 1, 4, 9)--8
    INSERT INTO [Subject] ([Name], CourseId, TeacherId, Credits) VALUES ('Algorithms', 1, 5, 6)--9

------ END ADD Subjects ------

------ ADD ClassStudent ------

    INSERT INTO ClassStudent(StudentId, SubjectId, Grade) VALUES (1, 1, 14)
    INSERT INTO ClassStudent(StudentId, SubjectId, Grade) VALUES (1, 2, 10)
    INSERT INTO ClassStudent(StudentId, SubjectId, Grade) VALUES (1, 3, 11)
    INSERT INTO ClassStudent(StudentId, SubjectId, Grade) VALUES (1, 4, 17)
    INSERT INTO ClassStudent(StudentId, SubjectId, Grade) VALUES (1, 8, 12)
    INSERT INTO ClassStudent(StudentId, SubjectId, Grade) VALUES (1, 9, 13)
    INSERT INTO ClassStudent(StudentId, SubjectId, Grade) VALUES (2, 6, 12)
    INSERT INTO ClassStudent(StudentId, SubjectId, Grade) VALUES (2, 7, 13)
    INSERT INTO ClassStudent(StudentId, SubjectId, Grade) VALUES (3, 1, 10)
    INSERT INTO ClassStudent(StudentId, SubjectId, Grade) VALUES (3, 2, 7)
    INSERT INTO ClassStudent(StudentId, SubjectId, Grade) VALUES (3, 3, 13)
    INSERT INTO ClassStudent(StudentId, SubjectId, Grade) VALUES (3, 4, 11)
    INSERT INTO ClassStudent(StudentId, SubjectId, Grade) VALUES (3, 8, 17)
    INSERT INTO ClassStudent(StudentId, SubjectId, Grade) VALUES (4, 1, 12)
    INSERT INTO ClassStudent(StudentId, SubjectId, Grade) VALUES (4, 2, 15)
    INSERT INTO ClassStudent(StudentId, SubjectId, Grade) VALUES (4, 3, 19)
    INSERT INTO ClassStudent(StudentId, SubjectId, Grade) VALUES (4, 4, 15)
    INSERT INTO ClassStudent(StudentId, SubjectId, Grade) VALUES (4, 8, 16)
    INSERT INTO ClassStudent(StudentId, SubjectId, Grade) VALUES (4, 9, 11)
    INSERT INTO ClassStudent(StudentId, SubjectId, Grade) VALUES (5, 5, 18)
    INSERT INTO ClassStudent(StudentId, SubjectId, Grade) VALUES (7, 1, 16)
    INSERT INTO ClassStudent(StudentId, SubjectId, Grade) VALUES (7, 2, 15)
    INSERT INTO ClassStudent(StudentId, SubjectId, Grade) VALUES (7, 4, 14)
    INSERT INTO ClassStudent(StudentId, SubjectId, Grade) VALUES (7, 8, 13)
    INSERT INTO ClassStudent(StudentId, SubjectId, Grade) VALUES (7, 9, 12)

------ END ClassStudent ------