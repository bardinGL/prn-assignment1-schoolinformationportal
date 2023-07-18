USE StudentInfo
GO

CREATE TABLE Account (
Password nvarchar (50) NOT NULL,
Email nvarchar (50) NOT NULL,
PRIMARY KEY (Email),
)

CREATE TABLE Admin (
AdminID nvarchar (10) NOT NULL,
Email nvarchar (50) NOT NULL,
PRIMARY KEY (AdminID),
)

CREATE TABLE Major (
MajorID nvarchar (2) NOT NULL,
MajorDesc nvarchar (50) NOT NULL,
PRIMARY KEY (MajorID)
)

CREATE TABLE Class (
ClassID nvarchar(6) NOT NULL,
MajorID nvarchar (2) NOT NULL,
PRIMARY KEY (ClassID),
FOREIGN KEY (MajorID) REFERENCES Major(MajorID),
)

CREATE TABLE Student (
StudentID nvarchar (8) NOT NULL,
StudentName nvarchar (50) NOT NULL,
StudentAge int NOT NULL,
StudentEmail nvarchar (50) NOT NULL,
MajorID nvarchar (2) NOT NULL,
ClassID nvarchar (6) NOT NULL,
PRIMARY KEY (StudentID),
FOREIGN KEY (StudentEmail) REFERENCES Account(Email),
FOREIGN KEY (MajorID) REFERENCES Major(MajorID),
FOREIGN KEY (ClassID) REFERENCES Class(ClassID),
)


CREATE TABLE Subject (
ClassID nvarchar(6) NOT NULL,
SubjectID nvarchar (6) NOT NULL,
Description nvarchar (100) NOT NULL,
PRIMARY KEY (SubjectID),
FOREIGN KEY (ClassID) REFERENCES Class(ClassID),
)

CREATE TABLE Application(
AdminID nvarchar (10) NOT NULL,
StudentID nvarchar (8) NOT NULL,
ApplicationID nvarchar(8) NOT NULL,
Description nvarchar (100) NOT NULL,
CreateDate date NULL,
ApproveDate date NULL,
PRIMARY KEY (ApplicationID),
FOREIGN KEY (StudentID) REFERENCES Student(StudentID),
FOREIGN KEY (AdminID) REFERENCES Admin(AdminID),
)

INSERT [Account] Values ('Hao', 'SENHH000001@gmail.com')
INSERT [Account] Values ('Nghia', 'SENTN000002@gmail.com')
INSERT [Account] Values ('Minh', 'SENNM000003@gmail.com')
INSERT [Account] Values ('Khanh', 'SETNK000004@gmail.com')
INSERT [Account] Values ('Tien', 'SETNT000005@gmail.com')

INSERT [ADMIN] Values ('adminTAT', 'adminTAT@gmail.com')
INSERT [ADMIN] Values ('adminNNTP', 'adminNNTP@gmail.com')

INSERT [Major] Values ('SE', 'Software Engineer')

INSERT [Class] Values ('SE0001', 'SE')
INSERT [Class] Values ('SE0002', 'SE')

INSERT [Student] Values ('SE000001', 'Nguyen Hung Hao', '20', 'SENHH000001@gmail.com', 'SE', 'SE0001')
INSERT [Student] Values ('SE000002', 'Nguyen Trong Nghia', '20', 'SENTN000002@gmail.com', 'SE', 'SE0001')
INSERT [Student] Values ('SE000003', 'Nguyen Nhat Minh', '21', 'SENNM000003@gmail.com', 'SE', 'SE0002')
INSERT [Student] Values ('SE000004', 'Tran Nhat Khanh', '20', 'SETNK000004@gmail.com', 'SE', 'SE0002')
INSERT [Student] Values ('SE000005', 'Tran Nhat Tien', '20', 'SETNT000005@gmail.com', 'SE', 'SE0002')

INSERT [Subject] Values ('SE0001', 'SWR302', 'Software Requirements')
INSERT [Subject] Values ('SE0001', 'SWT301', 'Software Testing')
INSERT [Subject] Values ('SE0001', 'SWP391', 'Software Development Project')
INSERT [Subject] Values ('SE0001', 'PRN211', 'Basic Cross Platform Application Programming With NET')
INSERT [Subject] Values ('SE0002', 'JPD123', 'Elementary Japanese 1-A1.2')
INSERT [Subject] Values ('SE0002', 'MAS291', 'Probability & statistics')
INSERT [Subject] Values ('SE0002', 'PRJ301', 'Java Web application development')
INSERT [Subject] Values ('SE0002', 'IOT102', 'Internet of Things')

INSERT [Application] Values ('adminTAT', 'SE000001', 'App00001', 'Class transfer application', '', '')
INSERT [Application] Values ('adminTAT', 'SE000002', 'App00002', 'Application for Deferment of military service', '', '')
INSERT [Application] Values ('adminNNTP', 'SE000005', 'App00003', 'Application for Exemption from Attendance', '', '')