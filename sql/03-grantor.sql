USE [grantapp]
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_grantor_state]') AND parent_object_id = OBJECT_ID(N'[dbo].[grantor]'))
ALTER TABLE [dbo].[grantor] DROP CONSTRAINT [FK_grantor_state]
GO

USE [grantapp]
GO

/****** Object:  Table [dbo].[grantor]    Script Date: 11/14/2013 17:59:28 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[grantor]') AND type in (N'U'))
DROP TABLE [dbo].[grantor]
GO

USE [grantapp]
GO

/****** Object:  Table [dbo].[grantor]    Script Date: 11/14/2013 17:59:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[grantor](
	[grantor_id] [int] IDENTITY(1,1) NOT NULL,
	[organization_name] [nvarchar](50) NOT NULL,
	[contact_name] [nvarchar](50) NOT NULL,
	[contact_title] [nvarchar](50) NOT NULL,
	[address] [nvarchar](100) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[phone] [nvarchar](50) NULL,
	[fax] [nvarchar](20) NOT NULL,
	[city] [nvarchar](50) NOT NULL,
	[state_id] [nchar](2) NOT NULL,
	[zipcode] [nvarchar](15) NOT NULL,
	[types_of_support] [nvarchar](max) NULL,
	[average_gift] [money] NULL,
	[giving_history] [nvarchar](max) NULL,
	[buzzwords] [nvarchar](max) NULL,
	[notes] [nvarchar](max) NULL,
 CONSTRAINT [PK_grantor] PRIMARY KEY CLUSTERED 
(
	[grantor_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[grantor]  WITH CHECK ADD  CONSTRAINT [FK_grantor_state] FOREIGN KEY([state_id])
REFERENCES [dbo].[state] ([state_id])
GO

ALTER TABLE [dbo].[grantor] CHECK CONSTRAINT [FK_grantor_state]
GO


