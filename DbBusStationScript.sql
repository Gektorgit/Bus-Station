USE [master]
GO
/****** Object:  Database [BusStation]    Script Date: 19.10.2016 18:38:19 ******/
CREATE DATABASE [BusStation]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BusStation', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\BusStation.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BusStation_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\BusStation_log.ldf' , SIZE = 1040KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BusStation] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BusStation].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BusStation] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BusStation] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BusStation] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BusStation] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BusStation] SET ARITHABORT OFF 
GO
ALTER DATABASE [BusStation] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BusStation] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [BusStation] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BusStation] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BusStation] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BusStation] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BusStation] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BusStation] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BusStation] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BusStation] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BusStation] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BusStation] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BusStation] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BusStation] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BusStation] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BusStation] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BusStation] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BusStation] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BusStation] SET RECOVERY FULL 
GO
ALTER DATABASE [BusStation] SET  MULTI_USER 
GO
ALTER DATABASE [BusStation] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BusStation] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BusStation] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BusStation] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'BusStation', N'ON'
GO
USE [BusStation]
GO
/****** Object:  Table [dbo].[Buses]    Script Date: 19.10.2016 18:38:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Buses](
	[BusId] [int] IDENTITY(1,1) NOT NULL,
	[BusName] [varchar](100) NOT NULL,
	[CountSeats] [int] NOT NULL,
	[Information] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cities]    Script Date: 19.10.2016 18:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cities](
	[CityId] [int] IDENTITY(1,1) NOT NULL,
	[CityName] [varchar](100) NOT NULL,
	[Information] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Discounts]    Script Date: 19.10.2016 18:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Discounts](
	[DiscountId] [int] IDENTITY(1,1) NOT NULL,
	[DiscountName] [varchar](100) NOT NULL,
	[Size] [money] NOT NULL,
	[Information] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DiscountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Flights]    Script Date: 19.10.2016 18:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Flights](
	[FlightId] [int] IDENTITY(1,1) NOT NULL,
	[FlightNumber] [varchar](20) NOT NULL,
	[CityIdStart] [int] NOT NULL,
	[CityIdEnd] [int] NOT NULL,
	[DepartureDate] [date] NOT NULL,
	[DepartureTime] [time](7) NOT NULL,
	[ArrivalDate] [date] NOT NULL,
	[ArrivaTime] [time](7) NOT NULL,
	[BusId] [int] NOT NULL,
	[Price] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[FlightId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 19.10.2016 18:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Seats]    Script Date: 19.10.2016 18:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seats](
	[SeatId] [int] IDENTITY(1,1) NOT NULL,
	[BusId] [int] NOT NULL,
	[NumberSeat] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SeatId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tickets]    Script Date: 19.10.2016 18:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tickets](
	[TicketId] [int] IDENTITY(1,1) NOT NULL,
	[ReleaseDate] [date] NOT NULL,
	[FlightId] [int] NOT NULL,
	[SeatId] [int] NOT NULL,
	[DiscountId] [int] NOT NULL,
	[Sold] [bit] NULL,
	[Reserve] [bit] NULL,
	[Canceled] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[TicketId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserInRoles]    Script Date: 19.10.2016 18:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserInRoles](
	[UserInRoleId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[RoleId] [int] NOT NULL,
	[HireDate] [datetime] NOT NULL,
 CONSTRAINT [PK_UserInRoles] PRIMARY KEY CLUSTERED 
(
	[UserInRoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 19.10.2016 18:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](128) NOT NULL,
	[UserPassword] [nvarchar](128) NOT NULL,
	[FirstName] [nvarchar](128) NULL,
	[LastName] [nvarchar](128) NULL,
	[DateBirthday] [datetime] NOT NULL,
	[Telephon] [nvarchar](10) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Buses] ON 

INSERT [dbo].[Buses] ([BusId], [BusName], [CountSeats], [Information]) VALUES (1, N'MAN Ayats Atlantis', 61, N'year 2003, the state of the normal')
INSERT [dbo].[Buses] ([BusId], [BusName], [CountSeats], [Information]) VALUES (2, N'Scania Irizar', 55, N'year 1997 the normal state')
INSERT [dbo].[Buses] ([BusId], [BusName], [CountSeats], [Information]) VALUES (3, N'Neoplan 116', 49, N'year 1988')
INSERT [dbo].[Buses] ([BusId], [BusName], [CountSeats], [Information]) VALUES (4, N'Hyundai Aerospace', 45, N'year 2003')
INSERT [dbo].[Buses] ([BusId], [BusName], [CountSeats], [Information]) VALUES (5, N'Volkswagen Crafter', 18, N'2013 New Year')
SET IDENTITY_INSERT [dbo].[Buses] OFF
SET IDENTITY_INSERT [dbo].[Cities] ON 

INSERT [dbo].[Cities] ([CityId], [CityName], [Information]) VALUES (1, N'Kiev', N'Ukraine')
INSERT [dbo].[Cities] ([CityId], [CityName], [Information]) VALUES (2, N'Kharkov', N'Ukraine')
INSERT [dbo].[Cities] ([CityId], [CityName], [Information]) VALUES (3, N'Lions', N'Ukraine')
INSERT [dbo].[Cities] ([CityId], [CityName], [Information]) VALUES (4, N'Donetsk', N'Ukraine')
INSERT [dbo].[Cities] ([CityId], [CityName], [Information]) VALUES (5, N'Odessa', N'Ukraine')
INSERT [dbo].[Cities] ([CityId], [CityName], [Information]) VALUES (6, N'Sevastopol', N'Ukraine')
SET IDENTITY_INSERT [dbo].[Cities] OFF
SET IDENTITY_INSERT [dbo].[Discounts] ON 

INSERT [dbo].[Discounts] ([DiscountId], [DiscountName], [Size], [Information]) VALUES (1, N'None', 0.0000, N'discount is not available')
INSERT [dbo].[Discounts] ([DiscountId], [DiscountName], [Size], [Information]) VALUES (2, N'Child', 15.0000, N'children up to seven years inclusive')
INSERT [dbo].[Discounts] ([DiscountId], [DiscountName], [Size], [Information]) VALUES (3, N'Student', 25.0000, N'student')
INSERT [dbo].[Discounts] ([DiscountId], [DiscountName], [Size], [Information]) VALUES (4, N'Pension', 20.0000, N'If the pension amounts payable udostovireniya')
SET IDENTITY_INSERT [dbo].[Discounts] OFF
SET IDENTITY_INSERT [dbo].[Flights] ON 

INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (1, N'406', 1, 2, CAST(0xFF3B0B00 AS Date), CAST(0x070010ACD1530000 AS Time), CAST(0xFF3B0B00 AS Date), CAST(0x070084B1109B0000 AS Time), 1, 170.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (2, N'406', 1, 2, CAST(0x003C0B00 AS Date), CAST(0x070010ACD1530000 AS Time), CAST(0x003C0B00 AS Date), CAST(0x070084B1109B0000 AS Time), 1, 170.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (3, N'406', 1, 2, CAST(0x013C0B00 AS Date), CAST(0x070010ACD1530000 AS Time), CAST(0x013C0B00 AS Date), CAST(0x070084B1109B0000 AS Time), 1, 170.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (4, N'406', 1, 2, CAST(0x023C0B00 AS Date), CAST(0x070010ACD1530000 AS Time), CAST(0x023C0B00 AS Date), CAST(0x070084B1109B0000 AS Time), 1, 170.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (5, N'406', 1, 2, CAST(0x033C0B00 AS Date), CAST(0x070010ACD1530000 AS Time), CAST(0x033C0B00 AS Date), CAST(0x070084B1109B0000 AS Time), 1, 170.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (6, N'406', 1, 2, CAST(0x043C0B00 AS Date), CAST(0x070010ACD1530000 AS Time), CAST(0x043C0B00 AS Date), CAST(0x070084B1109B0000 AS Time), 1, 170.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (7, N'406', 1, 2, CAST(0x053C0B00 AS Date), CAST(0x070010ACD1530000 AS Time), CAST(0x053C0B00 AS Date), CAST(0x070084B1109B0000 AS Time), 1, 170.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (8, N'406', 1, 2, CAST(0x063C0B00 AS Date), CAST(0x070010ACD1530000 AS Time), CAST(0x063C0B00 AS Date), CAST(0x070084B1109B0000 AS Time), 1, 170.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (9, N'406', 1, 2, CAST(0x073C0B00 AS Date), CAST(0x070010ACD1530000 AS Time), CAST(0x073C0B00 AS Date), CAST(0x070084B1109B0000 AS Time), 1, 170.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (10, N'406', 1, 2, CAST(0x083C0B00 AS Date), CAST(0x070010ACD1530000 AS Time), CAST(0x083C0B00 AS Date), CAST(0x070084B1109B0000 AS Time), 1, 170.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (11, N'406', 1, 2, CAST(0x093C0B00 AS Date), CAST(0x070010ACD1530000 AS Time), CAST(0x093C0B00 AS Date), CAST(0x070084B1109B0000 AS Time), 1, 170.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (12, N'406', 1, 2, CAST(0x0A3C0B00 AS Date), CAST(0x070010ACD1530000 AS Time), CAST(0x0A3C0B00 AS Date), CAST(0x070084B1109B0000 AS Time), 1, 170.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (13, N'406', 1, 2, CAST(0x0B3C0B00 AS Date), CAST(0x070010ACD1530000 AS Time), CAST(0x0B3C0B00 AS Date), CAST(0x070084B1109B0000 AS Time), 1, 170.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (14, N'406', 1, 2, CAST(0x0C3C0B00 AS Date), CAST(0x070010ACD1530000 AS Time), CAST(0x0C3C0B00 AS Date), CAST(0x070084B1109B0000 AS Time), 1, 170.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (15, N'406', 1, 2, CAST(0x0D3C0B00 AS Date), CAST(0x070010ACD1530000 AS Time), CAST(0x0D3C0B00 AS Date), CAST(0x070084B1109B0000 AS Time), 1, 170.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (16, N'406', 1, 2, CAST(0x0E3C0B00 AS Date), CAST(0x070010ACD1530000 AS Time), CAST(0x0E3C0B00 AS Date), CAST(0x070084B1109B0000 AS Time), 1, 170.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (17, N'406', 1, 2, CAST(0x0F3C0B00 AS Date), CAST(0x070010ACD1530000 AS Time), CAST(0x0F3C0B00 AS Date), CAST(0x070084B1109B0000 AS Time), 1, 170.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (18, N'406', 1, 2, CAST(0x103C0B00 AS Date), CAST(0x070010ACD1530000 AS Time), CAST(0x103C0B00 AS Date), CAST(0x070084B1109B0000 AS Time), 1, 170.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (19, N'406', 1, 2, CAST(0x113C0B00 AS Date), CAST(0x070010ACD1530000 AS Time), CAST(0x113C0B00 AS Date), CAST(0x070084B1109B0000 AS Time), 1, 170.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (20, N'406', 1, 2, CAST(0x123C0B00 AS Date), CAST(0x070010ACD1530000 AS Time), CAST(0x123C0B00 AS Date), CAST(0x070084B1109B0000 AS Time), 1, 170.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (21, N'406', 1, 2, CAST(0x133C0B00 AS Date), CAST(0x070010ACD1530000 AS Time), CAST(0x133C0B00 AS Date), CAST(0x070084B1109B0000 AS Time), 1, 170.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (22, N'507', 2, 5, CAST(0xFF3B0B00 AS Date), CAST(0x07000C41DD3E0000 AS Time), CAST(0xFF3B0B00 AS Date), CAST(0x0700365EC7940000 AS Time), 3, 200.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (23, N'507', 2, 5, CAST(0x003C0B00 AS Date), CAST(0x07000C41DD3E0000 AS Time), CAST(0x003C0B00 AS Date), CAST(0x0700365EC7940000 AS Time), 3, 200.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (24, N'507', 2, 5, CAST(0x013C0B00 AS Date), CAST(0x07000C41DD3E0000 AS Time), CAST(0x013C0B00 AS Date), CAST(0x0700365EC7940000 AS Time), 3, 200.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (25, N'507', 2, 5, CAST(0x023C0B00 AS Date), CAST(0x07000C41DD3E0000 AS Time), CAST(0x023C0B00 AS Date), CAST(0x0700365EC7940000 AS Time), 3, 200.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (26, N'507', 2, 5, CAST(0x033C0B00 AS Date), CAST(0x07000C41DD3E0000 AS Time), CAST(0x033C0B00 AS Date), CAST(0x0700365EC7940000 AS Time), 3, 200.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (27, N'507', 2, 5, CAST(0x043C0B00 AS Date), CAST(0x07000C41DD3E0000 AS Time), CAST(0x043C0B00 AS Date), CAST(0x0700365EC7940000 AS Time), 3, 200.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (28, N'507', 2, 5, CAST(0x053C0B00 AS Date), CAST(0x07000C41DD3E0000 AS Time), CAST(0x053C0B00 AS Date), CAST(0x0700365EC7940000 AS Time), 3, 200.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (29, N'507', 2, 5, CAST(0x063C0B00 AS Date), CAST(0x07000C41DD3E0000 AS Time), CAST(0x063C0B00 AS Date), CAST(0x0700365EC7940000 AS Time), 3, 200.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (30, N'507', 2, 5, CAST(0x073C0B00 AS Date), CAST(0x07000C41DD3E0000 AS Time), CAST(0x073C0B00 AS Date), CAST(0x0700365EC7940000 AS Time), 3, 200.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (31, N'507', 2, 5, CAST(0x083C0B00 AS Date), CAST(0x07000C41DD3E0000 AS Time), CAST(0x083C0B00 AS Date), CAST(0x0700365EC7940000 AS Time), 3, 200.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (32, N'507', 2, 5, CAST(0x093C0B00 AS Date), CAST(0x07000C41DD3E0000 AS Time), CAST(0x093C0B00 AS Date), CAST(0x0700365EC7940000 AS Time), 3, 200.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (33, N'507', 2, 5, CAST(0x0A3C0B00 AS Date), CAST(0x07000C41DD3E0000 AS Time), CAST(0x0A3C0B00 AS Date), CAST(0x0700365EC7940000 AS Time), 3, 200.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (34, N'507', 2, 5, CAST(0x0B3C0B00 AS Date), CAST(0x07000C41DD3E0000 AS Time), CAST(0x0B3C0B00 AS Date), CAST(0x0700365EC7940000 AS Time), 3, 200.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (35, N'507', 2, 5, CAST(0x0C3C0B00 AS Date), CAST(0x07000C41DD3E0000 AS Time), CAST(0x0C3C0B00 AS Date), CAST(0x0700365EC7940000 AS Time), 3, 200.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (36, N'507', 2, 5, CAST(0x0D3C0B00 AS Date), CAST(0x07000C41DD3E0000 AS Time), CAST(0x0D3C0B00 AS Date), CAST(0x0700365EC7940000 AS Time), 3, 200.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (37, N'507', 2, 5, CAST(0x0E3C0B00 AS Date), CAST(0x07000C41DD3E0000 AS Time), CAST(0x0E3C0B00 AS Date), CAST(0x0700365EC7940000 AS Time), 3, 200.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (38, N'507', 2, 5, CAST(0x0F3C0B00 AS Date), CAST(0x07000C41DD3E0000 AS Time), CAST(0x0F3C0B00 AS Date), CAST(0x0700365EC7940000 AS Time), 3, 200.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (39, N'507', 2, 5, CAST(0x103C0B00 AS Date), CAST(0x07000C41DD3E0000 AS Time), CAST(0x103C0B00 AS Date), CAST(0x0700365EC7940000 AS Time), 3, 200.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (40, N'507', 2, 5, CAST(0x113C0B00 AS Date), CAST(0x07000C41DD3E0000 AS Time), CAST(0x113C0B00 AS Date), CAST(0x0700365EC7940000 AS Time), 3, 200.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (41, N'507', 2, 5, CAST(0x123C0B00 AS Date), CAST(0x07000C41DD3E0000 AS Time), CAST(0x123C0B00 AS Date), CAST(0x0700365EC7940000 AS Time), 3, 200.0000)
INSERT [dbo].[Flights] ([FlightId], [FlightNumber], [CityIdStart], [CityIdEnd], [DepartureDate], [DepartureTime], [ArrivalDate], [ArrivaTime], [BusId], [Price]) VALUES (42, N'507', 2, 5, CAST(0x133C0B00 AS Date), CAST(0x07000C41DD3E0000 AS Time), CAST(0x133C0B00 AS Date), CAST(0x0700365EC7940000 AS Time), 3, 200.0000)
SET IDENTITY_INSERT [dbo].[Flights] OFF
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([RoleId], [RoleName]) VALUES (1, N'Admin')
INSERT [dbo].[Roles] ([RoleId], [RoleName]) VALUES (2, N'Menedger')
SET IDENTITY_INSERT [dbo].[Roles] OFF
SET IDENTITY_INSERT [dbo].[Seats] ON 

INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (1, 1, 1)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (2, 1, 2)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (3, 1, 3)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (4, 1, 4)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (5, 1, 5)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (6, 1, 6)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (7, 1, 7)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (8, 1, 8)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (9, 1, 9)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (10, 1, 10)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (11, 1, 11)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (12, 1, 12)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (13, 1, 13)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (14, 1, 14)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (15, 1, 15)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (16, 1, 16)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (17, 1, 17)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (18, 1, 18)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (19, 1, 19)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (20, 1, 20)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (21, 1, 21)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (22, 1, 22)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (23, 1, 23)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (24, 1, 24)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (25, 1, 25)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (26, 1, 26)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (27, 1, 27)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (28, 1, 28)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (29, 1, 29)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (30, 1, 30)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (31, 1, 31)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (32, 1, 32)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (33, 1, 33)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (34, 1, 34)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (35, 1, 35)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (36, 1, 36)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (37, 1, 37)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (38, 1, 38)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (39, 1, 39)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (40, 1, 40)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (41, 1, 41)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (42, 1, 42)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (43, 1, 43)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (44, 1, 44)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (45, 1, 45)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (46, 1, 46)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (47, 1, 47)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (48, 1, 48)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (49, 1, 49)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (50, 1, 50)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (51, 1, 51)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (52, 1, 52)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (53, 1, 53)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (54, 1, 54)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (55, 1, 55)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (56, 1, 56)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (57, 1, 57)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (58, 1, 58)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (59, 1, 59)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (60, 1, 60)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (61, 1, 61)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (62, 2, 1)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (63, 2, 2)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (64, 2, 3)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (65, 2, 4)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (66, 2, 5)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (67, 2, 6)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (68, 2, 7)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (69, 2, 8)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (70, 2, 9)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (71, 2, 10)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (72, 2, 11)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (73, 2, 12)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (74, 2, 13)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (75, 2, 14)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (76, 2, 15)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (77, 2, 16)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (78, 2, 17)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (79, 2, 18)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (80, 2, 19)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (81, 2, 20)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (82, 2, 21)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (83, 2, 22)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (84, 2, 23)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (85, 2, 24)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (86, 2, 25)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (87, 2, 26)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (88, 2, 27)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (89, 2, 28)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (90, 2, 29)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (91, 2, 30)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (92, 2, 31)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (93, 2, 32)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (94, 2, 33)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (95, 2, 34)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (96, 2, 35)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (97, 2, 36)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (98, 2, 37)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (99, 2, 38)
GO
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (100, 2, 39)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (101, 2, 40)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (102, 2, 41)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (103, 2, 42)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (104, 2, 43)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (105, 2, 44)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (106, 2, 45)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (107, 2, 46)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (108, 2, 47)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (109, 2, 48)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (110, 2, 49)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (111, 2, 50)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (112, 2, 51)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (113, 2, 52)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (114, 2, 53)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (115, 2, 54)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (116, 2, 55)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (117, 3, 1)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (118, 3, 2)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (119, 3, 3)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (120, 3, 4)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (121, 3, 5)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (122, 3, 6)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (123, 3, 7)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (124, 3, 8)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (125, 3, 9)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (126, 3, 10)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (127, 3, 11)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (128, 3, 12)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (129, 3, 13)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (130, 3, 14)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (131, 3, 15)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (132, 3, 16)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (133, 3, 17)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (134, 3, 18)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (135, 3, 19)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (136, 3, 20)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (137, 3, 21)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (138, 3, 22)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (139, 3, 23)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (140, 3, 24)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (141, 3, 25)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (142, 3, 26)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (143, 3, 27)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (144, 3, 28)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (145, 3, 29)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (146, 3, 30)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (147, 3, 31)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (148, 3, 32)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (149, 3, 33)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (150, 3, 34)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (151, 3, 35)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (152, 3, 36)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (153, 3, 37)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (154, 3, 38)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (155, 3, 39)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (156, 3, 40)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (157, 3, 41)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (158, 3, 42)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (159, 3, 43)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (160, 3, 44)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (161, 3, 45)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (162, 3, 46)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (163, 3, 47)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (164, 3, 48)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (165, 3, 49)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (166, 4, 1)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (167, 4, 2)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (168, 4, 3)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (169, 4, 4)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (170, 4, 5)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (171, 4, 6)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (172, 4, 7)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (173, 4, 8)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (174, 4, 9)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (175, 4, 10)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (176, 4, 11)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (177, 4, 12)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (178, 4, 13)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (179, 4, 14)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (180, 4, 15)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (181, 4, 16)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (182, 4, 17)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (183, 4, 18)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (184, 4, 19)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (185, 4, 20)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (186, 4, 21)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (187, 4, 22)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (188, 4, 23)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (189, 4, 24)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (190, 4, 25)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (191, 4, 26)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (192, 4, 27)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (193, 4, 28)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (194, 4, 29)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (195, 4, 30)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (196, 4, 31)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (197, 4, 32)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (198, 4, 33)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (199, 4, 34)
GO
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (200, 4, 35)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (201, 4, 36)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (202, 4, 37)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (203, 4, 38)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (204, 4, 39)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (205, 4, 40)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (206, 4, 41)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (207, 4, 42)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (208, 4, 43)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (209, 4, 44)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (210, 4, 45)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (211, 5, 1)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (212, 5, 2)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (213, 5, 3)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (214, 5, 4)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (215, 5, 5)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (216, 5, 6)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (217, 5, 7)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (218, 5, 8)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (219, 5, 9)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (220, 5, 10)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (221, 5, 11)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (222, 5, 12)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (223, 5, 13)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (224, 5, 14)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (225, 5, 15)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (226, 5, 16)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (227, 5, 17)
INSERT [dbo].[Seats] ([SeatId], [BusId], [NumberSeat]) VALUES (228, 5, 18)
SET IDENTITY_INSERT [dbo].[Seats] OFF
SET IDENTITY_INSERT [dbo].[UserInRoles] ON 

INSERT [dbo].[UserInRoles] ([UserInRoleId], [UserId], [RoleId], [HireDate]) VALUES (1, 1, 1, CAST(0x0000A6A401315E76 AS DateTime))
INSERT [dbo].[UserInRoles] ([UserInRoleId], [UserId], [RoleId], [HireDate]) VALUES (2, 2, 2, CAST(0x0000A6A401315E76 AS DateTime))
SET IDENTITY_INSERT [dbo].[UserInRoles] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserId], [UserName], [UserPassword], [FirstName], [LastName], [DateBirthday], [Telephon]) VALUES (1, N'Gektor', N'ierehon', NULL, NULL, CAST(0x00007B9300000000 AS DateTime), NULL)
INSERT [dbo].[Users] ([UserId], [UserName], [UserPassword], [FirstName], [LastName], [DateBirthday], [Telephon]) VALUES (2, N'ado@net', N'ado', N'Olga', N'Nesterenko', CAST(0x00006D5600000000 AS DateTime), N'0663456785')
SET IDENTITY_INSERT [dbo].[Users] OFF
/****** Object:  Index [IX_FK_UserInRoles_Roles]    Script Date: 19.10.2016 18:38:39 ******/
CREATE NONCLUSTERED INDEX [IX_FK_UserInRoles_Roles] ON [dbo].[UserInRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_UserInRoles_Users]    Script Date: 19.10.2016 18:38:39 ******/
CREATE NONCLUSTERED INDEX [IX_FK_UserInRoles_Users] ON [dbo].[UserInRoles]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Flights] ADD  DEFAULT (getdate()) FOR [DepartureDate]
GO
ALTER TABLE [dbo].[Flights] ADD  DEFAULT (getdate()) FOR [ArrivalDate]
GO
ALTER TABLE [dbo].[Tickets] ADD  DEFAULT (getdate()) FOR [ReleaseDate]
GO
ALTER TABLE [dbo].[Tickets] ADD  DEFAULT ((0)) FOR [Sold]
GO
ALTER TABLE [dbo].[Tickets] ADD  DEFAULT ((0)) FOR [Reserve]
GO
ALTER TABLE [dbo].[Tickets] ADD  DEFAULT ((0)) FOR [Canceled]
GO
ALTER TABLE [dbo].[Flights]  WITH CHECK ADD FOREIGN KEY([BusId])
REFERENCES [dbo].[Buses] ([BusId])
GO
ALTER TABLE [dbo].[Flights]  WITH CHECK ADD FOREIGN KEY([CityIdEnd])
REFERENCES [dbo].[Cities] ([CityId])
GO
ALTER TABLE [dbo].[Flights]  WITH CHECK ADD FOREIGN KEY([CityIdStart])
REFERENCES [dbo].[Cities] ([CityId])
GO
ALTER TABLE [dbo].[Seats]  WITH CHECK ADD FOREIGN KEY([BusId])
REFERENCES [dbo].[Buses] ([BusId])
GO
ALTER TABLE [dbo].[Tickets]  WITH CHECK ADD FOREIGN KEY([DiscountId])
REFERENCES [dbo].[Discounts] ([DiscountId])
GO
ALTER TABLE [dbo].[Tickets]  WITH CHECK ADD FOREIGN KEY([FlightId])
REFERENCES [dbo].[Flights] ([FlightId])
GO
ALTER TABLE [dbo].[Tickets]  WITH CHECK ADD FOREIGN KEY([SeatId])
REFERENCES [dbo].[Seats] ([SeatId])
GO
ALTER TABLE [dbo].[UserInRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserInRoles_Roles] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([RoleId])
GO
ALTER TABLE [dbo].[UserInRoles] CHECK CONSTRAINT [FK_UserInRoles_Roles]
GO
ALTER TABLE [dbo].[UserInRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserInRoles_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[UserInRoles] CHECK CONSTRAINT [FK_UserInRoles_Users]
GO
USE [master]
GO
ALTER DATABASE [BusStation] SET  READ_WRITE 
GO
