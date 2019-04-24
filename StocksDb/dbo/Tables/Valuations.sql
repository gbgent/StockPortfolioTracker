CREATE TABLE [dbo].[Valuations] (
    [ValuationID] INT             IDENTITY (1, 1) NOT NULL,
    [StockId]     INT             NOT NULL,
    [Date]        DATETIME2 (3)   NOT NULL,
    [Shares]      DECIMAL (14, 5) NOT NULL,
    [Price]       SMALLMONEY      NOT NULL,
    [Cost]        SMALLMONEY      NOT NULL,
    CONSTRAINT [PK_Valuations] PRIMARY KEY CLUSTERED ([ValuationID] ASC)
);

