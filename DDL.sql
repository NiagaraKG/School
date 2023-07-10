CREATE TABLE Student (
	StudentID NUMBER(10) PRIMARY KEY
	,YearStart NUMBER(4) NOT NULL
	,YearEnd NUMBER(4)
	);

CREATE TABLE Teacher (
	TeacherID NUMBER(10) PRIMARY KEY
	,IsCurrent NUMBER(1) NOT NULL CONSTRAINT check_IsCurrent CHECK (
		IsCurrent BETWEEN 0
			AND 1
		) DISABLE
	);

CREATE TABLE Person (
	PersonID NUMBER(10) PRIMARY KEY
	,FirstName VARCHAR2(255) NOT NULL
	,LastName VARCHAR2(255) NOT NULL
	,Gender CHAR(1) NOT NULL
	,DateOfBirth DATE
	);

CREATE TABLE Class (
	ClassID NUMBER(10) PRIMARY KEY
	,TeacherID NUMBER(10) NOT NULL
	,ClassName VARCHAR2(255) NOT NULL
	,YearOffered NUMBER(4) NOT NULL
	,TermOffered NUMBER(1) NOT NULL CONSTRAINT check_TermOffered CHECK (
		TermOffered BETWEEN 1
			AND 2
		) DISABLE
	,CONSTRAINT FK_Class_teacherID FOREIGN KEY (TeacherID) REFERENCES Teacher(TeacherID)
	);

CREATE TABLE Room (
	RoomID NUMBER(10) PRIMARY KEY
	,RoomNum NUMBER(4) NOT NULL
	,Floor NUMBER(2) NOT NULL
	,Building VARCHAR2(64) NOT NULL
	);

CREATE TABLE ClassStudent (
	ClassID NUMBER(10) NOT NULL
	,StudentID NUMBER(10) NOT NULL
	,FinalGrade NUMBER(1) CONSTRAINT check_FinalGrade CHECK (
		FinalGrade BETWEEN 2
			AND 6
		) DISABLE
	,CONSTRAINT PK_ClassStudent PRIMARY KEY (
		ClassID
		,StudentID
		)
	,CONSTRAINT FK_ClassStudent_classID FOREIGN KEY (ClassID) REFERENCES Class(ClassID)
	,CONSTRAINT FK_ClassStudent_studentID FOREIGN KEY (StudentID) REFERENCES Student(StudentID)
	);

CREATE TABLE Schedule (
	ClassID NUMBER(10) NOT NULL
	,RoomID NUMBER(10) NOT NULL
	,FromTS VARCHAR2(16) NOT NULL
	,ToTS VARCHAR2(16) NOT NULL
	,CONSTRAINT PK_Schedule PRIMARY KEY (
		ClassID
		,RoomID
		,FromTS
		)
	,CONSTRAINT FK_Schedule_classID FOREIGN KEY (ClassID) REFERENCES Class(ClassID)
	,CONSTRAINT FK_Schedule_roomID FOREIGN KEY (RoomID) REFERENCES Room(RoomID)
	);