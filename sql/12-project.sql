USE [grantapp]
GO

/****** Object:  Table [dbo].[project]    Script Date: 11/14/2013 18:03:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[project]') AND type in (N'U'))
DROP TABLE [dbo].[project]
GO

USE [grantapp]
GO

/****** Object:  Table [dbo].[project]    Script Date: 11/14/2013 18:03:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[project](
	[project_id] [int] IDENTITY(1,1) NOT NULL,
	[project_name] [nvarchar](50) NOT NULL,
	[project_overview] [nvarchar](max) NOT NULL,
	[project_need_statement] [nvarchar](max) NOT NULL,
	[project_objectives] [nvarchar](max) NOT NULL,
	[project_evaluation_plan] [nvarchar](max) NOT NULL,
	[organizational_budget] [nvarchar](max) NOT NULL,
	[project_timeline] [nvarchar](max) NULL,
	[project_letters_support] [nvarchar](max) NULL,
	[notes] [nvarchar](max) NULL,
 CONSTRAINT [PK_project] PRIMARY KEY CLUSTERED 
(
	[project_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


