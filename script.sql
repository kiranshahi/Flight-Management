/****** Object:  Database [FlightManagement]    Script Date: 10/4/2018 9:03:42 PM ******/
CREATE DATABASE [FlightManagement]  ;
GO
ALTER DATABASE [FlightManagement] SET COMPATIBILITY_LEVEL = 130
GO
ALTER DATABASE [FlightManagement] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [FlightManagement] SET ANSI_NULLS ON 
GO
ALTER DATABASE [FlightManagement] SET ANSI_PADDING ON 
GO
ALTER DATABASE [FlightManagement] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [FlightManagement] SET ARITHABORT ON 
GO
ALTER DATABASE [FlightManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FlightManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FlightManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FlightManagement] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [FlightManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FlightManagement] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [FlightManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FlightManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FlightManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FlightManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FlightManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FlightManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FlightManagement] SET  MULTI_USER 
GO
ALTER DATABASE [FlightManagement] SET QUERY_STORE = OFF
GO
/*** The scripts of database scoped configurations in Azure should be executed inside the target database connection. ***/
GO
-- ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
-- ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
-- ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
-- ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
/****** Object:  Table [dbo].[Cargo]    Script Date: 10/4/2018 9:03:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cargo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PlaneId] [int] NOT NULL,
	[CargoItem] [nvarchar](100) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 10/4/2018 9:03:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](100) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[Country] [nvarchar](50) NOT NULL,
	[Contact] [bigint] NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Plane]    Script Date: 10/4/2018 9:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Plane](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PlaneName] [nvarchar](50) NOT NULL,
	[PlaneType] [nvarchar](50) NOT NULL,
	[Capacity] [int] NOT NULL,
	[PassengerNumber] [int] NOT NULL,
 CONSTRAINT [PK_Plane] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlaneBook]    Script Date: 10/4/2018 9:03:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlaneBook](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BookedBy] [nvarchar](50) NOT NULL,
	[PlaneId] [int] NOT NULL,
	[CustomerId] [int] NULL,
	[CargoId] [int] NULL,
	[Departure] [datetime] NOT NULL,
	[Arrival] [datetime] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cargo] ON 

INSERT [dbo].[Cargo] ([Id], [PlaneId], [CargoItem]) VALUES (1, 1, N'Electronics')
INSERT [dbo].[Cargo] ([Id], [PlaneId], [CargoItem]) VALUES (2, 3, N'Mens')
INSERT [dbo].[Cargo] ([Id], [PlaneId], [CargoItem]) VALUES (3, 5, N'Womens')
INSERT [dbo].[Cargo] ([Id], [PlaneId], [CargoItem]) VALUES (4, 7, N'Kids')
SET IDENTITY_INSERT [dbo].[Cargo] OFF
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([Id], [Name], [Address], [City], [Country], [Contact], [Email]) VALUES (1, N'Klaus', N'Virginia', N'New Orleans', N'France', 3546456465, N'klaus@originals.com')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [City], [Country], [Contact], [Email]) VALUES (3, N'Elijah', N'Virginia', N'New Orleans', N'France', 789, N'elijah@gmail.com')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [City], [Country], [Contact], [Email]) VALUES (4, N'Rebekah', N'Virginia', N'New Orleans', N'France', 8779, N'rebekah@gmail.com')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [City], [Country], [Contact], [Email]) VALUES (5, N'Damon', N'Florida', N'Mystic Falls', N'USA', 654, N'damon@gmail.com')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [City], [Country], [Contact], [Email]) VALUES (6, N'Stefan', N'Florida', N'Mystic Falls', N'USA', 123, N'stefan@gmail.com')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [City], [Country], [Contact], [Email]) VALUES (7, N'Freya', N'Florida', N'Mystic Falls', N'USA', 657, N'freya@gmail.com')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [City], [Country], [Contact], [Email]) VALUES (8, N'Hope', N'Florida', N'Mystic Falls', N'USA', 987, N'hope@gmail.com')
SET IDENTITY_INSERT [dbo].[Customer] OFF
SET IDENTITY_INSERT [dbo].[Plane] ON 

INSERT [dbo].[Plane] ([Id], [PlaneName], [PlaneType], [Capacity], [PassengerNumber]) VALUES (1, N'A-001', N'Cargo', 1000, 50)
INSERT [dbo].[Plane] ([Id], [PlaneName], [PlaneType], [Capacity], [PassengerNumber]) VALUES (2, N'A-002', N'Passenger', 1500, 55)
INSERT [dbo].[Plane] ([Id], [PlaneName], [PlaneType], [Capacity], [PassengerNumber]) VALUES (3, N'A-003', N'Cargo', 2000, 60)
INSERT [dbo].[Plane] ([Id], [PlaneName], [PlaneType], [Capacity], [PassengerNumber]) VALUES (4, N'A-004', N'Passenger', 2500, 65)
INSERT [dbo].[Plane] ([Id], [PlaneName], [PlaneType], [Capacity], [PassengerNumber]) VALUES (5, N'A-005', N'Cargo', 3000, 70)
INSERT [dbo].[Plane] ([Id], [PlaneName], [PlaneType], [Capacity], [PassengerNumber]) VALUES (6, N'A-006', N'Passenger', 3100, 75)
INSERT [dbo].[Plane] ([Id], [PlaneName], [PlaneType], [Capacity], [PassengerNumber]) VALUES (7, N'A-007', N'Cargo', 3200, 76)
INSERT [dbo].[Plane] ([Id], [PlaneName], [PlaneType], [Capacity], [PassengerNumber]) VALUES (8, N'A-008', N'Passenger', 3300, 77)
SET IDENTITY_INSERT [dbo].[Plane] OFF
SET IDENTITY_INSERT [dbo].[PlaneBook] ON 

INSERT [dbo].[PlaneBook] ([Id], [BookedBy], [PlaneId], [CustomerId], [CargoId], [Departure], [Arrival]) VALUES (1, N'Kiran', 5, NULL, 2, CAST(N'2018-10-02T20:09:54.000' AS DateTime), NULL)
INSERT [dbo].[PlaneBook] ([Id], [BookedBy], [PlaneId], [CustomerId], [CargoId], [Departure], [Arrival]) VALUES (2, N'Amit', 2, 3, NULL, CAST(N'2018-10-02T20:09:54.000' AS DateTime), CAST(N'2018-10-02T20:09:54.000' AS DateTime))
INSERT [dbo].[PlaneBook] ([Id], [BookedBy], [PlaneId], [CustomerId], [CargoId], [Departure], [Arrival]) VALUES (3, N'Peter', 3, NULL, 3, CAST(N'2018-10-03T20:09:54.000' AS DateTime), NULL)
INSERT [dbo].[PlaneBook] ([Id], [BookedBy], [PlaneId], [CustomerId], [CargoId], [Departure], [Arrival]) VALUES (4, N'Tom', 6, 3, NULL, CAST(N'2018-10-03T20:09:54.000' AS DateTime), CAST(N'2018-10-02T20:09:54.923' AS DateTime))
INSERT [dbo].[PlaneBook] ([Id], [BookedBy], [PlaneId], [CustomerId], [CargoId], [Departure], [Arrival]) VALUES (5, N'a', 1, NULL, 3, CAST(N'2018-10-02T21:59:56.797' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[PlaneBook] OFF
ALTER DATABASE [FlightManagement] SET  READ_WRITE 
GO
