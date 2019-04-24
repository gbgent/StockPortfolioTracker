CREATE TABLE [dbo].[Stocks] (
    [StockId]  INT           IDENTITY (1, 1) NOT NULL,
    [BrokerId] INT           NOT NULL,
    [Symbol]   NVARCHAR (5)  NOT NULL,
    [Name]     NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Stocks] PRIMARY KEY CLUSTERED ([StockId] ASC),
    CONSTRAINT [FK_Stocks_Brokerages] FOREIGN KEY ([BrokerId]) REFERENCES [dbo].[Brokerages] ([BrokerId])
);

