USE [grantapp]
GO

/****** Object:  Table [dbo].[changelog]    Script Date: 12/07/2013 21:01:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[changelog]') AND type in (N'U'))
DROP TABLE [dbo].[changelog]
GO

USE [grantapp]
GO

/****** Object:  Table [dbo].[changelog]    Script Date: 12/07/2013 21:01:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[changelog](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[date] [datetime] NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[object_edited] [nvarchar](max) NOT NULL,
	[details] [nvarchar](max) NULL,
 CONSTRAINT [PK_changelog] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


