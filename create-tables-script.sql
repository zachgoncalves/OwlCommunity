CREATE TABLE owl_members (
    [ID]        INT           NOT NULL,
    [Full_Name] VARCHAR (255) NOT NULL,
    [Birthdate] DATE          NOT NULL, 
    CONSTRAINT [PK_owl_members] PRIMARY KEY ([ID])
);
CREATE TABLE students
(
	[ID] INT NOT NULL,
    [Major] VARCHAR(255) NOT NULL, 
    [GPA] NUMERIC NOT NULL,
	CONSTRAINT [PK_student] PRIMARY KEY ([ID])
);
CREATE TABLE undergraduate_students 
(
	[ID] INT NOT NULL,
	[Tuition] DECIMAL NOT NULL,
	[Credits] INT NOT NULL,
	[Year] VARCHAR(255),
	CONSTRAINT [PK_undergraduate_student] PRIMARY KEY ([ID])
);
CREATE TABLE graduate_students
(
	[ID] INT NOT NULL,
	[Stipend] DECIMAL NOT NULL,
	[Degree_Program] VARCHAR(255) NOT NULL,
	CONSTRAINT [PK_graduate_student] PRIMARY KEY ([ID])
);
CREATE TABLE faculty 
(
	[ID] INT NOT NULL,
	[Department] VARCHAR(255) NOT NULL,
	[Rank] VARCHAR(255) NOT NULL,
	CONSTRAINT [PK_faculty] PRIMARY KEY ([ID])
);
CREATE TABLE faculty_chair 
(
	[ID] INT NOT NULL,
	[Stipend] DECIMAL NOT NULL,
	CONSTRAINT [PK_faculty_chair] PRIMARY KEY ([ID])
);