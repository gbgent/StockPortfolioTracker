-- =============================================
-- Author:		Gerald Glass
-- Create date: 4/20/2019
-- Description:	For Adding A Buy, Sale, Split, or Dividend Transaction
--              to the Transaction Table
-- =============================================
CREATE PROCEDURE [dbo].[sp_Transaction_Insert]
 
	-- Parameters for the stored procedure here
	@StockId int,
	@BrokerId int,
	@Type int,
	@Date Datetime2(3),
	@Shares decimal(14,5),
	@Price smallmoney,
	@Fee smallmoney,
	@TransactionId int = 0 output

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

	Insert into dbo.Transactions (StockId, BrokerId, Type,
								  Date, Shares, Price, Fee)
	values (@StockId, @BrokerId, @Type, 
	        @Date, @Shares, @Price, @Fee);

	Select @TransactionId = SCOPE_IDENTITY();

END
