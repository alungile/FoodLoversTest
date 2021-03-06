USE [FoodLovers]
CREATE TABLE dbo.Branch
	(
	ID int NOT NULL,
	[Name] varchar(100) NOT NULL,
	TelephoneNumber nvarchar(15) NULL,
	OpenDate datetime NULL,
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Branch ADD CONSTRAINT
	PK_Branch PRIMARY KEY CLUSTERED 
	(
	ID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
