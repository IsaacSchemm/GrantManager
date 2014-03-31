USE [grantapp]
GO

/****** Object:  Table [dbo].[status_type]    Script Date: 11/14/2013 18:00:21 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[status_type]') AND type in (N'U'))
DROP TABLE [dbo].[status_type]
GO

USE [grantapp]
GO

/****** Object:  Table [dbo].[status_type]    Script Date: 11/14/2013 18:00:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[status_type](
	[status_id] [int] IDENTITY(1,1) NOT NULL,
	[description] [varchar](max) NOT NULL,
 CONSTRAINT [PK_status_type] PRIMARY KEY CLUSTERED 
(
	[status_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

INSERT INTO status_type(description) VALUES
('Active'),
('Investigate'),
('Inactive'),
('Potential');