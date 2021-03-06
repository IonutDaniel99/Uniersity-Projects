USE [SGBD2k20]
GO
/****** Object:  Table [dbo].[Studenti]    Script Date: 1/3/2020 6:06:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Studenti](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nume] [varchar](30) NOT NULL,
	[Prenume] [varchar](30) NULL,
	[Sex] [varchar](30) NOT NULL,
	[Varsta] [int] NOT NULL,
	[Oras] [varchar](30) NULL,
	[Engleza] [bit] NULL,
	[Franceza] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
