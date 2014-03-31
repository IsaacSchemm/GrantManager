USE [grantapp]
GO

/****** Object:  Table [dbo].[approach]    Script Date: 11/14/2013 18:01:23 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[approach]') AND type in (N'U'))
DROP TABLE [dbo].[approach]
GO

USE [grantapp]
GO

/****** Object:  Table [dbo].[approach]    Script Date: 11/14/2013 18:01:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[approach](
	[approach_id] [int] IDENTITY(1,1) NOT NULL,
	[approach_type] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_approach] PRIMARY KEY CLUSTERED 
(
	[approach_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


