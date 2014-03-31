USE [grantapp]
GO

/****** Object:  Table [dbo].[program]    Script Date: 11/14/2013 18:02:25 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[program]') AND type in (N'U'))
DROP TABLE [dbo].[program]
GO

USE [grantapp]
GO

/****** Object:  Table [dbo].[program]    Script Date: 11/14/2013 18:02:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[program](
	[program_id] [int] IDENTITY(1,1) NOT NULL,
	[program_name] [nvarchar](50) NOT NULL,
	[program_description] [nvarchar](max) NULL,
 CONSTRAINT [PK_program] PRIMARY KEY CLUSTERED 
(
	[program_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


