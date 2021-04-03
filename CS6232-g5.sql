USE [master]
GO
/****** Object:  Database [CS6232-g5]    Script Date: 4/4/2021 6:11:50 AM ******/
CREATE DATABASE [CS6232-g5]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CS6232-g5', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\CS6232-g5.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CS6232-g5_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\CS6232-g5_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CS6232-g5] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CS6232-g5].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CS6232-g5] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CS6232-g5] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CS6232-g5] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CS6232-g5] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CS6232-g5] SET ARITHABORT OFF 
GO
ALTER DATABASE [CS6232-g5] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CS6232-g5] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CS6232-g5] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CS6232-g5] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CS6232-g5] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CS6232-g5] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CS6232-g5] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CS6232-g5] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CS6232-g5] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CS6232-g5] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CS6232-g5] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CS6232-g5] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CS6232-g5] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CS6232-g5] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CS6232-g5] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CS6232-g5] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CS6232-g5] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CS6232-g5] SET RECOVERY FULL 
GO
ALTER DATABASE [CS6232-g5] SET  MULTI_USER 
GO
ALTER DATABASE [CS6232-g5] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CS6232-g5] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CS6232-g5] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CS6232-g5] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CS6232-g5] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CS6232-g5] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'CS6232-g5', N'ON'
GO
ALTER DATABASE [CS6232-g5] SET QUERY_STORE = OFF
GO
USE [CS6232-g5]
GO
/****** Object:  Table [dbo].[Administrator]    Script Date: 4/4/2021 6:11:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administrator](
	[aid] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[iid] [int] NOT NULL,
 CONSTRAINT [PK_Administrator] PRIMARY KEY CLUSTERED 
(
	[aid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Appointment]    Script Date: 4/4/2021 6:11:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointment](
	[pid] [int] NOT NULL,
	[time] [datetime] NOT NULL,
	[did] [int] NOT NULL,
	[reason] [varchar](255) NOT NULL,
 CONSTRAINT [PK_Appointment] PRIMARY KEY CLUSTERED 
(
	[pid] ASC,
	[time] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 4/4/2021 6:11:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor](
	[did] [int] IDENTITY(1,1) NOT NULL,
	[iid] [int] NOT NULL,
 CONSTRAINT [PK_Doctor] PRIMARY KEY CLUSTERED 
(
	[did] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Individual]    Script Date: 4/4/2021 6:11:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Individual](
	[iid] [int] IDENTITY(1,1) NOT NULL,
	[lname] [varchar](50) NOT NULL,
	[fname] [varchar](50) NOT NULL,
	[dob] [date] NOT NULL,
	[streetAddress] [varchar](50) NOT NULL,
	[city] [varchar](50) NOT NULL,
	[state] [char](2) NOT NULL,
	[zip] [char](5) NOT NULL,
	[phone] [char](10) NOT NULL,
 CONSTRAINT [PK_Individual] PRIMARY KEY CLUSTERED 
(
	[iid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Individual] SET (LOCK_ESCALATION = DISABLE)
GO
/****** Object:  Table [dbo].[LabTests]    Script Date: 4/4/2021 6:11:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LabTests](
	[pid] [int] NOT NULL,
	[appointmentDate] [datetime] NOT NULL,
	[code] [int] NOT NULL,
	[dateTaken] [datetime] NOT NULL,
	[dateReturned] [datetime] NOT NULL,
	[result] [varchar](255) NULL,
	[normal] [tinyint] NULL,
 CONSTRAINT [PK_LabTests] PRIMARY KEY CLUSTERED 
(
	[pid] ASC,
	[appointmentDate] ASC,
	[code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 4/4/2021 6:11:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[username] [varchar](50) NOT NULL,
	[password] [varchar](255) NOT NULL,
	[privilege] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nurse]    Script Date: 4/4/2021 6:11:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nurse](
	[nid] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[iid] [int] NOT NULL,
 CONSTRAINT [PK_Nurse] PRIMARY KEY CLUSTERED 
(
	[nid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 4/4/2021 6:11:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[pid] [int] IDENTITY(1,1) NOT NULL,
	[iid] [int] NOT NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[pid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Specialty]    Script Date: 4/4/2021 6:11:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Specialty](
	[did] [int] NOT NULL,
	[specialty] [varchar](50) NOT NULL,
	[description] [varchar](255) NOT NULL,
 CONSTRAINT [PK_Specialty] PRIMARY KEY CLUSTERED 
(
	[did] ASC,
	[specialty] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Test]    Script Date: 4/4/2021 6:11:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Test](
	[code] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[description] [varchar](255) NOT NULL,
 CONSTRAINT [PK_Test] PRIMARY KEY CLUSTERED 
(
	[code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Visit]    Script Date: 4/4/2021 6:11:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Visit](
	[pid] [int] NOT NULL,
	[time] [datetime] NOT NULL,
	[nid] [int] NOT NULL,
	[weight] [numeric](5, 2) NOT NULL,
	[systolic] [int] NOT NULL,
	[diastolic] [int] NOT NULL,
	[temperature] [numeric](5, 2) NOT NULL,
	[pulse] [int] NOT NULL,
	[symptoms] [varchar](255) NOT NULL,
	[initialDiagnosis] [varchar](255) NOT NULL,
	[finalDiagnosis] [varchar](255) NULL,
 CONSTRAINT [PK_Visit] PRIMARY KEY CLUSTERED 
(
	[pid] ASC,
	[time] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Administrator] ON 

INSERT [dbo].[Administrator] ([aid], [username], [iid]) VALUES (1, N'Bruce', 3)
INSERT [dbo].[Administrator] ([aid], [username], [iid]) VALUES (2, N'John', 2)
SET IDENTITY_INSERT [dbo].[Administrator] OFF
GO
INSERT [dbo].[Appointment] ([pid], [time], [did], [reason]) VALUES (10, CAST(N'2020-04-11T13:30:00.000' AS DateTime), 2, N'injury')
INSERT [dbo].[Appointment] ([pid], [time], [did], [reason]) VALUES (10, CAST(N'2020-11-11T14:30:00.000' AS DateTime), 1, N'injury')
INSERT [dbo].[Appointment] ([pid], [time], [did], [reason]) VALUES (10, CAST(N'2021-04-18T10:34:00.000' AS DateTime), 1, N'sickness')
INSERT [dbo].[Appointment] ([pid], [time], [did], [reason]) VALUES (11, CAST(N'2020-05-04T15:30:00.000' AS DateTime), 2, N'sickness')
INSERT [dbo].[Appointment] ([pid], [time], [did], [reason]) VALUES (11, CAST(N'2020-12-04T10:30:00.000' AS DateTime), 1, N'injury')
INSERT [dbo].[Appointment] ([pid], [time], [did], [reason]) VALUES (11, CAST(N'2021-04-10T16:00:00.000' AS DateTime), 1, N'sickness')
INSERT [dbo].[Appointment] ([pid], [time], [did], [reason]) VALUES (12, CAST(N'2020-09-20T12:30:00.000' AS DateTime), 2, N'injury')
INSERT [dbo].[Appointment] ([pid], [time], [did], [reason]) VALUES (12, CAST(N'2020-10-01T13:30:00.000' AS DateTime), 1, N'sickness')
INSERT [dbo].[Appointment] ([pid], [time], [did], [reason]) VALUES (12, CAST(N'2021-04-07T09:45:00.000' AS DateTime), 2, N'sickness')
INSERT [dbo].[Appointment] ([pid], [time], [did], [reason]) VALUES (13, CAST(N'2020-12-12T13:30:00.000' AS DateTime), 1, N'sickness')
INSERT [dbo].[Appointment] ([pid], [time], [did], [reason]) VALUES (13, CAST(N'2021-05-01T11:00:00.000' AS DateTime), 2, N'injury')
GO
SET IDENTITY_INSERT [dbo].[Doctor] ON 

INSERT [dbo].[Doctor] ([did], [iid]) VALUES (1, 1002)
INSERT [dbo].[Doctor] ([did], [iid]) VALUES (2, 1003)
SET IDENTITY_INSERT [dbo].[Doctor] OFF
GO
SET IDENTITY_INSERT [dbo].[Individual] ON 

INSERT [dbo].[Individual] ([iid], [lname], [fname], [dob], [streetAddress], [city], [state], [zip], [phone]) VALUES (1, N'Doe', N'Jane', CAST(N'1980-04-04' AS Date), N'123 Main Street', N'New York City', N'NY', N'10012', N'8085551234')
INSERT [dbo].[Individual] ([iid], [lname], [fname], [dob], [streetAddress], [city], [state], [zip], [phone]) VALUES (2, N'Doe', N'John', CAST(N'1982-12-12' AS Date), N'321 Main Street', N'New York City', N'NY', N'10012', N'8085551235')
INSERT [dbo].[Individual] ([iid], [lname], [fname], [dob], [streetAddress], [city], [state], [zip], [phone]) VALUES (3, N'Wayne', N'Bruce', CAST(N'1961-12-12' AS Date), N'1 Wayne Manor', N'Gotham', N'NY', N'10000', N'8001234567')
INSERT [dbo].[Individual] ([iid], [lname], [fname], [dob], [streetAddress], [city], [state], [zip], [phone]) VALUES (4, N'Dirt', N'Joe', CAST(N'1979-12-12' AS Date), N'12 Rock Way', N'New Orleans', N'LA', N'70119', N'5558675309')
INSERT [dbo].[Individual] ([iid], [lname], [fname], [dob], [streetAddress], [city], [state], [zip], [phone]) VALUES (1002, N'Harkness', N'Agatha', CAST(N'1969-01-07' AS Date), N'555 Main Street', N'New York', N'NY', N'10012', N'8085551239')
INSERT [dbo].[Individual] ([iid], [lname], [fname], [dob], [streetAddress], [city], [state], [zip], [phone]) VALUES (1003, N'Zemo', N'Baron', CAST(N'1961-07-07' AS Date), N'9898 Wall Street', N'New York', N'NY', N'10011', N'8085559890')
INSERT [dbo].[Individual] ([iid], [lname], [fname], [dob], [streetAddress], [city], [state], [zip], [phone]) VALUES (1004, N'Dukes', N'Fred', CAST(N'1950-12-07' AS Date), N'1578 5th Avenue', N'New York', N'NY', N'10013', N'8085569765')
INSERT [dbo].[Individual] ([iid], [lname], [fname], [dob], [streetAddress], [city], [state], [zip], [phone]) VALUES (1005, N'Gibson', N'Ricky', CAST(N'1999-12-12' AS Date), N'156 12th Street', N'New York', N'NY', N'10001', N'8085566666')
INSERT [dbo].[Individual] ([iid], [lname], [fname], [dob], [streetAddress], [city], [state], [zip], [phone]) VALUES (1006, N'Dillon', N'Max', CAST(N'2000-12-09' AS Date), N'1219 Ocean Drive', N'New York', N'NY', N'10011', N'8085556565')
INSERT [dbo].[Individual] ([iid], [lname], [fname], [dob], [streetAddress], [city], [state], [zip], [phone]) VALUES (1007, N'LeBeau', N'Remy', CAST(N'2000-12-09' AS Date), N'1219 Ocean Drive', N'New Orleans', N'LA', N'70115', N'5045551234')
SET IDENTITY_INSERT [dbo].[Individual] OFF
GO
INSERT [dbo].[Login] ([username], [password], [privilege]) VALUES (N'Bruce', N'7B9eIwDXid1+n1Mf50j8ukGyxdTZDJir52f4ziP/jj0=', N'Admin')
INSERT [dbo].[Login] ([username], [password], [privilege]) VALUES (N'Jane', N'+2DYAkml91i8WROe09ESvoaFx+ongg3LG5mYn4HnhQA=', N'Nurse')
INSERT [dbo].[Login] ([username], [password], [privilege]) VALUES (N'Joe', N'qkDU9MCD7cEyeDJamiLKm4e+M24NiudPJX3y+HTGBbU=', N'Nurse')
INSERT [dbo].[Login] ([username], [password], [privilege]) VALUES (N'John', N'BZk5BetSRy+mkLM8z6/R0RWItvuPxnjRM+S/4Jti1kg=', N'Admin')
GO
SET IDENTITY_INSERT [dbo].[Nurse] ON 

INSERT [dbo].[Nurse] ([nid], [username], [iid]) VALUES (1, N'Jane', 1)
INSERT [dbo].[Nurse] ([nid], [username], [iid]) VALUES (2, N'Joe', 4)
SET IDENTITY_INSERT [dbo].[Nurse] OFF
GO
SET IDENTITY_INSERT [dbo].[Patient] ON 

INSERT [dbo].[Patient] ([pid], [iid]) VALUES (10, 1004)
INSERT [dbo].[Patient] ([pid], [iid]) VALUES (11, 1005)
INSERT [dbo].[Patient] ([pid], [iid]) VALUES (12, 1006)
INSERT [dbo].[Patient] ([pid], [iid]) VALUES (13, 1007)
SET IDENTITY_INSERT [dbo].[Patient] OFF
GO
INSERT [dbo].[Visit] ([pid], [time], [nid], [weight], [systolic], [diastolic], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis]) VALUES (10, CAST(N'2020-04-11T13:30:00.000' AS DateTime), 1, CAST(129.00 AS Numeric(5, 2)), 120, 80, CAST(98.60 AS Numeric(5, 2)), 65, N'Headache', N'Drank too much alcohol the day before', NULL)
INSERT [dbo].[Visit] ([pid], [time], [nid], [weight], [systolic], [diastolic], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis]) VALUES (10, CAST(N'2020-11-11T14:30:00.000' AS DateTime), 2, CAST(145.00 AS Numeric(5, 2)), 125, 85, CAST(98.60 AS Numeric(5, 2)), 66, N'Stomach Pains', N'Patient is pregnant', NULL)
INSERT [dbo].[Visit] ([pid], [time], [nid], [weight], [systolic], [diastolic], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis]) VALUES (11, CAST(N'2020-05-04T15:30:00.000' AS DateTime), 1, CAST(210.00 AS Numeric(5, 2)), 130, 85, CAST(98.50 AS Numeric(5, 2)), 73, N'Injured ankle', N'Tried to play basketball like an NBA star, completely failed.', NULL)
INSERT [dbo].[Visit] ([pid], [time], [nid], [weight], [systolic], [diastolic], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis]) VALUES (11, CAST(N'2020-12-04T10:30:00.000' AS DateTime), 1, CAST(210.00 AS Numeric(5, 2)), 125, 85, CAST(98.60 AS Numeric(5, 2)), 71, N'Headache', N'Patient thought jumping face first onto a trampoline was a good idea.', N'Patient is an idiot')
INSERT [dbo].[Visit] ([pid], [time], [nid], [weight], [systolic], [diastolic], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis]) VALUES (12, CAST(N'2020-09-20T12:30:00.000' AS DateTime), 2, CAST(175.00 AS Numeric(5, 2)), 140, 80, CAST(99.90 AS Numeric(5, 2)), 70, N'Fever', N'Possible flu', N'Patient has common cold.')
INSERT [dbo].[Visit] ([pid], [time], [nid], [weight], [systolic], [diastolic], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis]) VALUES (12, CAST(N'2020-10-01T13:30:00.000' AS DateTime), 2, CAST(175.00 AS Numeric(5, 2)), 140, 80, CAST(98.60 AS Numeric(5, 2)), 70, N'Vomiting', N'Possible food poisoning', N'Patient drank too much nyquil to fix a fever from last week.')
INSERT [dbo].[Visit] ([pid], [time], [nid], [weight], [systolic], [diastolic], [temperature], [pulse], [symptoms], [initialDiagnosis], [finalDiagnosis]) VALUES (13, CAST(N'2020-12-12T13:30:00.000' AS DateTime), 1, CAST(265.00 AS Numeric(5, 2)), 125, 85, CAST(98.60 AS Numeric(5, 2)), 80, N'Patient is interested in getting a face lift', N'Patient has been referred to another clinic for a follow-up', NULL)
GO
/****** Object:  Index [IX_Doctor]    Script Date: 4/4/2021 6:11:50 AM ******/
CREATE NONCLUSTERED INDEX [IX_Doctor] ON [dbo].[Doctor]
(
	[did] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Administrator]  WITH CHECK ADD  CONSTRAINT [FK_Administrator_Individual] FOREIGN KEY([iid])
REFERENCES [dbo].[Individual] ([iid])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Administrator] CHECK CONSTRAINT [FK_Administrator_Individual]
GO
ALTER TABLE [dbo].[Administrator]  WITH CHECK ADD  CONSTRAINT [FK_Administrator_Login] FOREIGN KEY([username])
REFERENCES [dbo].[Login] ([username])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Administrator] CHECK CONSTRAINT [FK_Administrator_Login]
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Doctor] FOREIGN KEY([did])
REFERENCES [dbo].[Doctor] ([did])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_Doctor]
GO
ALTER TABLE [dbo].[Appointment]  WITH NOCHECK ADD  CONSTRAINT [FK_Appointment_Patient] FOREIGN KEY([pid])
REFERENCES [dbo].[Patient] ([pid])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_Patient]
GO
ALTER TABLE [dbo].[Doctor]  WITH NOCHECK ADD  CONSTRAINT [FK_Doctor_Individual] FOREIGN KEY([iid])
REFERENCES [dbo].[Individual] ([iid])
GO
ALTER TABLE [dbo].[Doctor] CHECK CONSTRAINT [FK_Doctor_Individual]
GO
ALTER TABLE [dbo].[LabTests]  WITH CHECK ADD  CONSTRAINT [FK_LabTests_Test] FOREIGN KEY([code])
REFERENCES [dbo].[Test] ([code])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LabTests] CHECK CONSTRAINT [FK_LabTests_Test]
GO
ALTER TABLE [dbo].[LabTests]  WITH CHECK ADD  CONSTRAINT [FK_LabTests_Visit] FOREIGN KEY([pid], [appointmentDate])
REFERENCES [dbo].[Visit] ([pid], [time])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LabTests] CHECK CONSTRAINT [FK_LabTests_Visit]
GO
ALTER TABLE [dbo].[Nurse]  WITH CHECK ADD  CONSTRAINT [FK_Nurse_Individual] FOREIGN KEY([iid])
REFERENCES [dbo].[Individual] ([iid])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Nurse] CHECK CONSTRAINT [FK_Nurse_Individual]
GO
ALTER TABLE [dbo].[Nurse]  WITH CHECK ADD  CONSTRAINT [FK_Nurse_Login] FOREIGN KEY([username])
REFERENCES [dbo].[Login] ([username])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Nurse] CHECK CONSTRAINT [FK_Nurse_Login]
GO
ALTER TABLE [dbo].[Patient]  WITH NOCHECK ADD  CONSTRAINT [FK_Patient_Individual] FOREIGN KEY([iid])
REFERENCES [dbo].[Individual] ([iid])
GO
ALTER TABLE [dbo].[Patient] NOCHECK CONSTRAINT [FK_Patient_Individual]
GO
ALTER TABLE [dbo].[Specialty]  WITH CHECK ADD  CONSTRAINT [FK_Specialty_Doctor] FOREIGN KEY([did])
REFERENCES [dbo].[Doctor] ([did])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Specialty] CHECK CONSTRAINT [FK_Specialty_Doctor]
GO
ALTER TABLE [dbo].[Visit]  WITH CHECK ADD  CONSTRAINT [FK_Visit_Appointment] FOREIGN KEY([pid], [time])
REFERENCES [dbo].[Appointment] ([pid], [time])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Visit] CHECK CONSTRAINT [FK_Visit_Appointment]
GO
ALTER TABLE [dbo].[Visit]  WITH CHECK ADD  CONSTRAINT [FK_Visit_Nurse] FOREIGN KEY([nid])
REFERENCES [dbo].[Nurse] ([nid])
GO
ALTER TABLE [dbo].[Visit] CHECK CONSTRAINT [FK_Visit_Nurse]
GO
USE [master]
GO
ALTER DATABASE [CS6232-g5] SET  READ_WRITE 
GO
