USE [grantapp]
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_documentation_requirement_documentation_type]') AND parent_object_id = OBJECT_ID(N'[dbo].[documentation_requirement]'))
ALTER TABLE [dbo].[documentation_requirement] DROP CONSTRAINT [FK_documentation_requirement_documentation_type]
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_documentation_requirement_grant]') AND parent_object_id = OBJECT_ID(N'[dbo].[documentation_requirement]'))
ALTER TABLE [dbo].[documentation_requirement] DROP CONSTRAINT [FK_documentation_requirement_grant]
GO

USE [grantapp]
GO

/****** Object:  Table [dbo].[documentation_requirement]    Script Date: 11/14/2013 18:01:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[documentation_requirement]') AND type in (N'U'))
DROP TABLE [dbo].[documentation_requirement]
GO

USE [grantapp]
GO

/****** Object:  Table [dbo].[documentation_requirement]    Script Date: 11/14/2013 18:01:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[documentation_requirement](
	[grant_id] [int] NOT NULL,
	[documentation_type_id] [int] NOT NULL,
 CONSTRAINT [PK_documentation_requirement] PRIMARY KEY CLUSTERED 
(
	[grant_id] ASC,
	[documentation_type_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[documentation_requirement]  WITH CHECK ADD  CONSTRAINT [FK_documentation_requirement_documentation_type] FOREIGN KEY([documentation_type_id])
REFERENCES [dbo].[documentation_type] ([documentation_type_id])
GO

ALTER TABLE [dbo].[documentation_requirement] CHECK CONSTRAINT [FK_documentation_requirement_documentation_type]
GO

ALTER TABLE [dbo].[documentation_requirement]  WITH CHECK ADD  CONSTRAINT [FK_documentation_requirement_grant] FOREIGN KEY([grant_id])
REFERENCES [dbo].[grant] ([grant_id])
GO

ALTER TABLE [dbo].[documentation_requirement] CHECK CONSTRAINT [FK_documentation_requirement_grant]
GO


