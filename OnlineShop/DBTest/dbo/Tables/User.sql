CREATE TABLE [dbo].[User] (
    [ID]           BIGINT        IDENTITY (1, 1) NOT NULL,
    [UserName]     VARCHAR (50)  NULL,
    [Password]     VARCHAR (32)  NULL,
    [GroupID]      VARCHAR (20)  CONSTRAINT [DF_User_GroupID] DEFAULT ('MEMBER') NULL,
    [Name]         NVARCHAR (50) NULL,
    [Address]      NVARCHAR (50) NULL,
    [Email]        NVARCHAR (50) NULL,
    [Phone]        NVARCHAR (50) NULL,
    [ProvinceID]   INT           NULL,
    [DistrictID]   INT           NULL,
    [CreatedDate]  DATETIME      CONSTRAINT [DF_User_CreatedDate] DEFAULT (getdate()) NULL,
    [CreatedBy]    VARCHAR (50)  NULL,
    [ModifiedDate] DATETIME      NULL,
    [ModifiedBy]   VARCHAR (50)  NULL,
    [Status]       BIT           NOT NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([ID] ASC)
);

