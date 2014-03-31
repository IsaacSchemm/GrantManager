USE [grantapp]
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_grant_project_grant]') AND parent_object_id = OBJECT_ID(N'[dbo].[grant_project]'))
ALTER TABLE [dbo].[grant_project] DROP CONSTRAINT [FK_grant_project_grant]
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_grant_project_project]') AND parent_object_id = OBJECT_ID(N'[dbo].[grant_project]'))
ALTER TABLE [dbo].[grant_project] DROP CONSTRAINT [FK_grant_project_project]
GO

USE [grantapp]
GO

/****** Object:  Table [dbo].[grant_project]    Script Date: 11/14/2013 18:03:32 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[grant_project]') AND type in (N'U'))
DROP TABLE [dbo].[grant_project]
GO

USE [grantapp]
GO

/****** Object:  Table [dbo].[grant_project]    Script Date: 11/14/2013 18:03:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[grant_project](
	[grant_project_id] [int] IDENTITY(1,1) NOT NULL,
	[grant_id] [int] NOT NULL,
	[project_id] [int] NOT NULL,
	[grant_project_amount] [money] NULL,
 CONSTRAINT [PK_grant_project] PRIMARY KEY CLUSTERED 
(
	[grant_project_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[grant_project]  WITH CHECK ADD  CONSTRAINT [FK_grant_project_grant] FOREIGN KEY([grant_id])
REFERENCES [dbo].[grant] ([grant_id])
GO

ALTER TABLE [dbo].[grant_project] CHECK CONSTRAINT [FK_grant_project_grant]
GO

ALTER TABLE [dbo].[grant_project]  WITH CHECK ADD  CONSTRAINT [FK_grant_project_project] FOREIGN KEY([project_id])
REFERENCES [dbo].[project] ([project_id])
GO

ALTER TABLE [dbo].[grant_project] CHECK CONSTRAINT [FK_grant_project_project]
GO


