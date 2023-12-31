USE [master]
GO
/****** Object:  Database [StudentInfo]    Script Date: 7/18/2023 9:37:29 AM ******/
CREATE DATABASE [StudentInfo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StudentInfo', FILENAME = N'G:\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\StudentInfo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'StudentInfo_log', FILENAME = N'G:\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\StudentInfo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [StudentInfo] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StudentInfo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StudentInfo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StudentInfo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StudentInfo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StudentInfo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StudentInfo] SET ARITHABORT OFF 
GO
ALTER DATABASE [StudentInfo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StudentInfo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StudentInfo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StudentInfo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StudentInfo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StudentInfo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StudentInfo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StudentInfo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StudentInfo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StudentInfo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [StudentInfo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StudentInfo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StudentInfo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StudentInfo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StudentInfo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StudentInfo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StudentInfo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StudentInfo] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [StudentInfo] SET  MULTI_USER 
GO
ALTER DATABASE [StudentInfo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StudentInfo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StudentInfo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StudentInfo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [StudentInfo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [StudentInfo] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [StudentInfo] SET QUERY_STORE = OFF
GO
USE [StudentInfo]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 7/18/2023 9:37:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[Password] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 7/18/2023 9:37:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[AdminID] [nvarchar](10) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AdminID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Application]    Script Date: 7/18/2023 9:37:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Application](
	[AdminID] [nvarchar](10) NOT NULL,
	[StudentID] [nvarchar](8) NOT NULL,
	[ApplicationID] [nvarchar](8) NOT NULL,
	[Description] [nvarchar](100) NOT NULL,
	[CreateDate] [date] NULL,
	[ApproveDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[ApplicationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Class]    Script Date: 7/18/2023 9:37:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Class](
	[ClassID] [nvarchar](6) NOT NULL,
	[MajorID] [nvarchar](2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ClassID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Major]    Script Date: 7/18/2023 9:37:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Major](
	[MajorID] [nvarchar](2) NOT NULL,
	[MajorDesc] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MajorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 7/18/2023 9:37:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StudentID] [nvarchar](8) NOT NULL,
	[StudentName] [nvarchar](50) NOT NULL,
	[StudentAge] [int] NOT NULL,
	[StudentEmail] [nvarchar](50) NOT NULL,
	[MajorID] [nvarchar](2) NOT NULL,
	[ClassID] [nvarchar](6) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subject]    Script Date: 7/18/2023 9:37:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subject](
	[ClassID] [nvarchar](6) NOT NULL,
	[SubjectID] [nvarchar](6) NOT NULL,
	[Description] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SubjectID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

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

GO
ALTER TABLE [dbo].[Application]  WITH CHECK ADD FOREIGN KEY([AdminID])
REFERENCES [dbo].[Admin] ([AdminID])
GO
ALTER TABLE [dbo].[Application]  WITH CHECK ADD FOREIGN KEY([StudentID])
REFERENCES [dbo].[Student] ([StudentID])
GO
ALTER TABLE [dbo].[Class]  WITH CHECK ADD FOREIGN KEY([MajorID])
REFERENCES [dbo].[Major] ([MajorID])
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD FOREIGN KEY([ClassID])
REFERENCES [dbo].[Class] ([ClassID])
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD FOREIGN KEY([MajorID])
REFERENCES [dbo].[Major] ([MajorID])
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD FOREIGN KEY([StudentEmail])
REFERENCES [dbo].[Account] ([Email])
GO
ALTER TABLE [dbo].[Subject]  WITH CHECK ADD FOREIGN KEY([ClassID])
REFERENCES [dbo].[Class] ([ClassID])
GO
USE [master]
GO
ALTER DATABASE [StudentInfo] SET  READ_WRITE 
GO
