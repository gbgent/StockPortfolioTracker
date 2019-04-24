CREATE TABLE [dbo].[Transactions] (
    [TransactionId] INT             IDENTITY (1, 1) NOT NULL,
    [StockId]       INT             NOT NULL,
    [BrokerId]      INT             NOT NULL,
    [Type]          INT             NOT NULL,
    [Date]          DATETIME2 (3)   NOT NULL,
    [Shares]        DECIMAL (14, 5) NOT NULL,
    [Price]         SMALLMONEY      NOT NULL,
    [Fee]           SMALLMONEY      NOT NULL,
    CONSTRAINT [PK_Transactions] PRIMARY KEY CLUSTERED ([TransactionId] ASC),
    CONSTRAINT [FK_Transactions_Brokerages] FOREIGN KEY ([BrokerId]) REFERENCES [dbo].[Brokerages] ([BrokerId]),
    CONSTRAINT [FK_Transactions_Stock] FOREIGN KEY ([StockId]) REFERENCES [dbo].[Stocks] ([StockId])
);

