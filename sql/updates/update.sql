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
