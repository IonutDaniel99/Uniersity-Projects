USE [AppAvioane]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 1/3/2020 6:05:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nume] [varchar](30) NOT NULL,
	[Username] [varchar](30) NOT NULL,
	[Password] [varchar](30) NOT NULL,
	[IsAdmin] [bit] NOT NULL,
	[NumarZbor] [varchar](30) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Zboruri]    Script Date: 1/3/2020 6:05:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zboruri](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NumarZbor] [varchar](30) NOT NULL,
	[Companie] [varchar](30) NOT NULL,
	[Plecare] [varchar](30) NOT NULL,
	[Sosire] [varchar](30) NOT NULL,
	[OraPlecare] [varchar](30) NULL,
	[NumarLocuri] [int] NOT NULL,
	[LocuriLibere] [int] NOT NULL,
	[Pret] [int] NOT NULL,
	[Poarta] [int] NOT NULL
) ON [PRIMARY]
GO
