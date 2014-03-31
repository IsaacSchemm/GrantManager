USE [grantapp]
GO

/****** Object:  Table [dbo].[documentation_type]    Script Date: 11/14/2013 18:01:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[documentation_type]') AND type in (N'U'))
DROP TABLE [dbo].[documentation_type]
GO

USE [grantapp]
GO

/****** Object:  Table [dbo].[documentation_type]    Script Date: 11/14/2013 18:01:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[documentation_type](
	[documentation_type_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_documentation_type] PRIMARY KEY CLUSTERED 
(
	[documentation_type_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


