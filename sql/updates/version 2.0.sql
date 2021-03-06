CREATE TABLE [dbo].[attachment] (
    [attachment_id] INT             IDENTITY (1, 1) NOT NULL,
    [grant_id]      INT             NOT NULL,
    [filename]      NVARCHAR (MAX)  NOT NULL,
    [data]          VARBINARY (MAX) NOT NULL,
    CONSTRAINT [PK_attachment] PRIMARY KEY CLUSTERED ([attachment_id] ASC),
    CONSTRAINT [FK_attachment_grant] FOREIGN KEY ([grant_id]) REFERENCES [dbo].[grant] ([grant_id])
);

INSERT INTO attachment (grant_id, filename, data)
SELECT grant_id, attachment_name, attachment
FROM [grant]
WHERE attachment IS NOT NULL

ALTER TABLE [grant] DROP COLUMN attachment_name, attachment

CREATE TABLE [dbo].[timeline_date]
(
	[timeline_date_id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [grant_id] INT NOT NULL, 
    [name] VARCHAR(MAX) NOT NULL, 
    [date] DATE NOT NULL, 
    [color] VARCHAR(MAX) NULL, 
    CONSTRAINT [FK_timeline_date_grant] FOREIGN KEY (grant_id) REFERENCES [grant](grant_id)
)

EXEC sp_rename 'dbo.project.project_evaluation_plan', 'project_outcomes', 'COLUMN'

ALTER TABLE [project] DROP COLUMN project_need_statement, organizational_budget

CREATE TABLE [dbo].[budget_item]
(
	[budget_item_id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [grant_id] INT NOT NULL, 
    [name] VARCHAR(MAX) NOT NULL, 
    [amount] MONEY NOT NULL,
	[sort_order] INT NOT NULL DEFAULT(0),
    CONSTRAINT [FK_budget_item_grant] FOREIGN KEY (grant_id) REFERENCES [grant](grant_id)
)

GRANT ALL ON [attachment] TO grantuser;
GRANT ALL ON [timeline_date] TO grantuser;
GRANT ALL ON [budget_item] TO grantuser;
