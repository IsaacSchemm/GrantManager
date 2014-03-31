USE [grantapp]
GO

/****** Object:  Table [dbo].[user]    Script Date: 11/14/2013 17:58:34 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[user]') AND type in (N'U'))
DROP TABLE [dbo].[user]
GO

USE [grantapp]
GO

/****** Object:  Table [dbo].[user]    Script Date: 11/14/2013 17:58:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[user](
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[active] [bit] NOT NULL,
	[display_name] [nvarchar](50) NULL,
	[admin] [bit] NOT NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


USE [grantapp]
GO

/****** Object:  Table [dbo].[state]    Script Date: 11/14/2013 17:59:40 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[state]') AND type in (N'U'))
DROP TABLE [dbo].[state]
GO

USE [grantapp]
GO

/****** Object:  Table [dbo].[state]    Script Date: 11/14/2013 17:59:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[state](
	[state_id] [nchar](2) NOT NULL,
	[state_name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_state] PRIMARY KEY CLUSTERED 
(
	[state_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


DELETE FROM state WHERE state_id <> '--'
INSERT INTO state(state_id, state_name) VALUES
('AL','Alabama'),
('AK','Alaska'),
('AZ','Arizona'),
('AR','Arkansas'),
('CA','California'),
('CO','Colorado'),
('CT','Connecticut'),
('DE','Delaware'),
('FL','Florida'),
('GA','Georgia'),
('HI','Hawaii'),
('ID','Idaho'),
('IL','Illinois'),
('IN','Indiana'),
('IA','Iowa'),
('KS','Kansas'),
('KY','Kentucky'),
('LA','Louisiana'),
('ME','Maine'),
('MD','Maryland'),
('MA','Massachusetts'),
('MI','Michigan'),
('MN','Minnesota'),
('MS','Mississippi'),
('MO','Missouri'),
('MT','Montana'),
('NE','Nebraska'),
('NV','Nevada'),
('NH','New Hampshire'),
('NJ','New Jersey'),
('NM','New Mexico'),
('NY','New York'),
('NC','North Carolina'),
('ND','North Dakota'),
('OH','Ohio'),
('OK','Oklahoma'),
('OR','Oregon'),
('PA','Pennsylvania'),
('RI','Rhode Island'),
('SC','South Carolina'),
('SD','South Dakota'),
('TN','Tennessee'),
('TX','Texas'),
('UT','Utah'),
('VT','Vermont'),
('VA','Virginia'),
('WA','Washington'),
('WV','West Virginia'),
('WI','Wisconsin'),
('WY','Wyoming'),
('DC','District of Columbia'),
('PR','Puerto Rico');USE [grantapp]
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
('Potential');USE [grantapp]
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


USE [grantapp]
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_contact_history_approach]') AND parent_object_id = OBJECT_ID(N'[dbo].[contact_history]'))
ALTER TABLE [dbo].[contact_history] DROP CONSTRAINT [FK_contact_history_approach]
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_contact_history_grant]') AND parent_object_id = OBJECT_ID(N'[dbo].[contact_history]'))
ALTER TABLE [dbo].[contact_history] DROP CONSTRAINT [FK_contact_history_grant]
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_contact_history_user]') AND parent_object_id = OBJECT_ID(N'[dbo].[contact_history]'))
ALTER TABLE [dbo].[contact_history] DROP CONSTRAINT [FK_contact_history_user]
GO

USE [grantapp]
GO

/****** Object:  Table [dbo].[contact_history]    Script Date: 11/14/2013 18:01:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[contact_history]') AND type in (N'U'))
DROP TABLE [dbo].[contact_history]
GO

USE [grantapp]
GO

/****** Object:  Table [dbo].[contact_history]    Script Date: 11/14/2013 18:01:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[contact_history](
	[contact_history_id] [int] IDENTITY(1,1) NOT NULL,
	[grant_id] [int] NOT NULL,
	[initial_approach_id] [int] NULL,
	[contact_name] [nvarchar](50) NOT NULL,
	[call_date] [datetime] NOT NULL,
	[outcome] [nvarchar](max) NULL,
	[contacted_by] [nvarchar](50) NULL,
	[notes] [nvarchar](max) NULL,
 CONSTRAINT [PK_contact_history_1] PRIMARY KEY CLUSTERED 
(
	[contact_history_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[contact_history]  WITH CHECK ADD  CONSTRAINT [FK_contact_history_approach] FOREIGN KEY([initial_approach_id])
REFERENCES [dbo].[approach] ([approach_id])
GO

ALTER TABLE [dbo].[contact_history] CHECK CONSTRAINT [FK_contact_history_approach]
GO

ALTER TABLE [dbo].[contact_history]  WITH CHECK ADD  CONSTRAINT [FK_contact_history_grant] FOREIGN KEY([grant_id])
REFERENCES [dbo].[grant] ([grant_id])
GO

ALTER TABLE [dbo].[contact_history] CHECK CONSTRAINT [FK_contact_history_grant]
GO

ALTER TABLE [dbo].[contact_history]  WITH CHECK ADD  CONSTRAINT [FK_contact_history_user] FOREIGN KEY([contacted_by])
REFERENCES [dbo].[user] ([username])
GO

ALTER TABLE [dbo].[contact_history] CHECK CONSTRAINT [FK_contact_history_user]
GO


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


USE [grantapp]
GO

/****** Object:  Table [dbo].[changelog]    Script Date: 12/07/2013 21:01:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[changelog]') AND type in (N'U'))
DROP TABLE [dbo].[changelog]
GO

USE [grantapp]
GO

/****** Object:  Table [dbo].[changelog]    Script Date: 12/07/2013 21:01:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[changelog](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[date] [datetime] NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[object_edited] [nvarchar](max) NOT NULL,
	[details] [nvarchar](max) NULL,
 CONSTRAINT [PK_changelog] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


USE [grantapp]
GO

INSERT INTO [user](username, password, active, display_name, admin)
VALUES ('admin', 'admin', 11, 'Administrator', 1)
USE [grantapp]
GO

CREATE LOGIN grantuser WITH PASSWORD = 'pw,1,LVCV';
CREATE USER grantuser FOR LOGIN grantuser;

GRANT ALL ON approach TO grantuser;
GRANT ALL ON changelog TO grantuser;
GRANT ALL ON contact_history TO grantuser;
GRANT ALL ON documentation_requirement TO grantuser;
GRANT ALL ON documentation_type TO grantuser;
GRANT ALL ON [grant] TO grantuser;
GRANT ALL ON grant_program TO grantuser;
GRANT ALL ON grant_project TO grantuser;
GRANT ALL ON grantor TO grantuser;
GRANT ALL ON program TO grantuser;
GRANT ALL ON project TO grantuser;
GRANT ALL ON [state] TO grantuser;
GRANT ALL ON status_type TO grantuser;
GRANT ALL ON [user] TO grantuser;