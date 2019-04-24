CREATE TABLE [dbo].[Brokerages] (
    [BrokerId]         INT            IDENTITY (1, 1) NOT NULL,
    [BrokerageName]    NVARCHAR (30)  NOT NULL,
    [BrokerageAddress] NVARCHAR (250) NULL,
    [AccountNum]       NVARCHAR (50)  NULL,
    [BrokerName]       NVARCHAR (60)  NULL,
    [PhoneNum]         NCHAR (10)     NULL,
    [Email]            NVARCHAR (90)  NULL,
    [CommissionRate]   DECIMAL (5, 2) NOT NULL,
    CONSTRAINT [PK_Brokerages] PRIMARY KEY CLUSTERED ([BrokerId] ASC)
);

