USE [grantapp]
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_grant_program_grant]') AND parent_object_id = OBJECT_ID(N'[dbo].[grant_program]'))
ALTER TABLE [dbo].[grant_program] DROP CONSTRAINT [FK_grant_program_grant]
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_grant_program_program]') AND parent_object_id = OBJECT_ID(N'[dbo].[grant_program]'))
ALTER TABLE [dbo].[grant_program] DROP CONSTRAINT [FK_grant_program_program]
GO

USE [grantapp]
GO

/****** Object:  Table [dbo].[grant_program]    Script Date: 11/14/2013 18:03:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[grant_program]') AND type in (N'U'))
DROP TABLE [dbo].[grant_program]
GO

USE [grantapp]
GO

/****** Object:  Table [dbo].[grant_program]    Script Date: 11/14/2013 18:03:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[grant_program](
	[grant_program_id] [int] IDENTITY(1,1) NOT NULL,
	[grant_id] [int] NOT NULL,
	[program_id] [int] NOT NULL,
 CONSTRAINT [PK_grant_program] PRIMARY KEY CLUSTERED 
(
	[grant_program_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[grant_program]  WITH CHECK ADD  CONSTRAINT [FK_grant_program_grant] FOREIGN KEY([grant_id])
REFERENCES [dbo].[grant] ([grant_id])
GO

ALTER TABLE [dbo].[grant_program] CHECK CONSTRAINT [FK_grant_program_grant]
GO

ALTER TABLE [dbo].[grant_program]  WITH CHECK ADD  CONSTRAINT [FK_grant_program_program] FOREIGN KEY([program_id])
REFERENCES [dbo].[program] ([program_id])
GO

ALTER TABLE [dbo].[grant_program] CHECK CONSTRAINT [FK_grant_program_program]
GO


