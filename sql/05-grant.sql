USE [grantapp]
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_grant_grantor]') AND parent_object_id = OBJECT_ID(N'[dbo].[grant]'))
ALTER TABLE [dbo].[grant] DROP CONSTRAINT [FK_grant_grantor]
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_grant_status_type]') AND parent_object_id = OBJECT_ID(N'[dbo].[grant]'))
ALTER TABLE [dbo].[grant] DROP CONSTRAINT [FK_grant_status_type]
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_grant_user]') AND parent_object_id = OBJECT_ID(N'[dbo].[grant]'))
ALTER TABLE [dbo].[grant] DROP CONSTRAINT [FK_grant_user]
GO

USE [grantapp]
GO

/****** Object:  Table [dbo].[grant]    Script Date: 11/14/2013 18:00:08 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[grant]') AND type in (N'U'))
DROP TABLE [dbo].[grant]
GO

USE [grantapp]
GO

/****** Object:  Table [dbo].[grant]    Script Date: 11/14/2013 18:00:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[grant](
	[grant_id] [int] IDENTITY(1,1) NOT NULL,
	[grantor_id] [int] NOT NULL,
	[grant_name] [nvarchar](50) NULL,
	[grant_description] [nvarchar](50) NULL,
	[submit_date] [datetime] NULL,
	[due_date] [datetime] NULL,
	[turnaround_time] [datetime] NULL,
	[start_date] [datetime] NULL,
	[payment_date] [datetime] NULL,
	[grant_requested_amount] [money] NOT NULL,
	[grant_actual_amount] [money] NULL,
	[status] [int] NOT NULL,
	[grantor_website] [nvarchar](MAX) NULL,
	[grantor_username] [nvarchar](50) NULL,
	[grantor_password] [nvarchar](50) NULL,
	[submit_to_email] [nvarchar](50) NULL,
	[submit_to_website] [nvarchar](200) NULL,
	[program_emphasis] [nvarchar](max) NULL,
	[grant_writer] [nvarchar](50) NULL,
	[attachment] [varbinary](max) NULL,
	[attachment_name] [nvarchar](256) NULL,
	[notes] [nvarchar](max) NULL,
 CONSTRAINT [PK_grant] PRIMARY KEY CLUSTERED 
(
	[grant_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[grant]  WITH CHECK ADD  CONSTRAINT [FK_grant_grantor] FOREIGN KEY([grantor_id])
REFERENCES [dbo].[grantor] ([grantor_id])
GO

ALTER TABLE [dbo].[grant] CHECK CONSTRAINT [FK_grant_grantor]
GO

ALTER TABLE [dbo].[grant]  WITH CHECK ADD  CONSTRAINT [FK_grant_status_type] FOREIGN KEY([status])
REFERENCES [dbo].[status_type] ([status_id])
GO

ALTER TABLE [dbo].[grant] CHECK CONSTRAINT [FK_grant_status_type]
GO

ALTER TABLE [dbo].[grant]  WITH CHECK ADD  CONSTRAINT [FK_grant_user] FOREIGN KEY([grant_writer])
REFERENCES [dbo].[user] ([username])
GO

ALTER TABLE [dbo].[grant] CHECK CONSTRAINT [FK_grant_user]
GO


