USE [master]
GO
/****** Object:  User [NT SERVICE\ReportServer$LEGNA]    Script Date: 2012/5/29 18:45:49 ******/
CREATE USER [NT SERVICE\ReportServer$LEGNA] FOR LOGIN [NT SERVICE\ReportServer$LEGNA] WITH DEFAULT_SCHEMA=[NT SERVICE\ReportServer$LEGNA]
GO
/****** Object:  User [##MS_PolicyEventProcessingLogin##]    Script Date: 2012/5/29 18:45:49 ******/
CREATE USER [##MS_PolicyEventProcessingLogin##] FOR LOGIN [##MS_PolicyEventProcessingLogin##] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [##MS_AgentSigningCertificate##]    Script Date: 2012/5/29 18:45:49 ******/
CREATE USER [##MS_AgentSigningCertificate##] FOR LOGIN [##MS_AgentSigningCertificate##]
GO
/****** Object:  DatabaseRole [RSExecRole]    Script Date: 2012/5/29 18:45:49 ******/
CREATE ROLE [RSExecRole]
GO
ALTER ROLE [RSExecRole] ADD MEMBER [NT SERVICE\ReportServer$LEGNA]
GO
/****** Object:  Schema [NT SERVICE\ReportServer$LEGNA]    Script Date: 2012/5/29 18:45:49 ******/
CREATE SCHEMA [NT SERVICE\ReportServer$LEGNA]
GO
/****** Object:  Schema [RSExecRole]    Script Date: 2012/5/29 18:45:49 ******/
CREATE SCHEMA [RSExecRole]
GO
/****** Object:  Table [dbo].[Bills]    Script Date: 2012/5/29 18:45:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bills](
	[billID] [int] IDENTITY(1,1) NOT NULL,
	[sunPrice] [float] NOT NULL,
	[time] [timestamp] NULL,
 CONSTRAINT [PK_Bills] PRIMARY KEY CLUSTERED 
(
	[billID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cards]    Script Date: 2012/5/29 18:45:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cards](
	[cardID] [int] IDENTITY(1,1) NOT NULL,
	[password] [varbinary](50) NOT NULL,
	[amount] [float] NOT NULL,
 CONSTRAINT [PK_Cards] PRIMARY KEY CLUSTERED 
(
	[cardID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Facility]    Script Date: 2012/5/29 18:45:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Facility](
	[facilityID] [int] IDENTITY(1,1) NOT NULL,
	[facilityName] [varchar](30) NOT NULL,
	[state] [bit] NOT NULL,
 CONSTRAINT [PK_Facility] PRIMARY KEY CLUSTERED 
(
	[facilityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ItemLists]    Script Date: 2012/5/29 18:45:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemLists](
	[itemsListID] [int] IDENTITY(1,1) NOT NULL,
	[billID] [int] NOT NULL,
	[itemID] [int] NOT NULL,
	[itemNum] [int] NOT NULL,
 CONSTRAINT [PK_ItemLists] PRIMARY KEY CLUSTERED 
(
	[itemsListID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Items]    Script Date: 2012/5/29 18:45:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Items](
	[itemID] [int] IDENTITY(1,1) NOT NULL,
	[itemName] [varchar](30) NULL,
	[itemPrice] [float] NOT NULL,
	[itemQuan] [int] NULL,
	[repertory] [int] NULL,
	[itemType] [varchar](20) NULL,
 CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED 
(
	[itemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Login]    Script Date: 2012/5/29 18:45:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Login](
	[loginID] [int] IDENTITY(1,1) NOT NULL,
	[userName] [varchar](50) NOT NULL,
	[password] [varbinary](50) NOT NULL,
	[privilege] [tinyint] NOT NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[loginID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Outcome]    Script Date: 2012/5/29 18:45:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Outcome](
	[outcomeID] [int] IDENTITY(1,1) NOT NULL,
	[type] [varchar](50) NOT NULL,
	[amount] [float] NOT NULL,
	[time] [timestamp] NULL,
 CONSTRAINT [PK_Outcome] PRIMARY KEY CLUSTERED 
(
	[outcomeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[position]    Script Date: 2012/5/29 18:45:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[position](
	[positionID] [int] IDENTITY(1,1) NOT NULL,
	[department] [varchar](20) NULL,
	[positionName] [varchar](30) NULL,
	[salary] [float] NULL,
 CONSTRAINT [PK_position] PRIMARY KEY CLUSTERED 
(
	[positionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Workers]    Script Date: 2012/5/29 18:45:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Workers](
	[workerID] [int] IDENTITY(1,1) NOT NULL,
	[gender] [bit] NULL,
	[firstName] [varchar](30) NULL,
	[lastName] [varchar](30) NULL,
	[positionID] [int] NULL,
 CONSTRAINT [PK_Workers] PRIMARY KEY CLUSTERED 
(
	[workerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[ItemLists]  WITH CHECK ADD  CONSTRAINT [FK_ItemLists_Bills] FOREIGN KEY([billID])
REFERENCES [dbo].[Bills] ([billID])
GO
ALTER TABLE [dbo].[ItemLists] CHECK CONSTRAINT [FK_ItemLists_Bills]
GO
ALTER TABLE [dbo].[ItemLists]  WITH CHECK ADD  CONSTRAINT [FK_ItemLists_Items] FOREIGN KEY([itemID])
REFERENCES [dbo].[Items] ([itemID])
GO
ALTER TABLE [dbo].[ItemLists] CHECK CONSTRAINT [FK_ItemLists_Items]
GO
ALTER TABLE [dbo].[Workers]  WITH CHECK ADD  CONSTRAINT [FK_Workers_position] FOREIGN KEY([workerID])
REFERENCES [dbo].[position] ([positionID])
GO
ALTER TABLE [dbo].[Workers] CHECK CONSTRAINT [FK_Workers_position]
GO
