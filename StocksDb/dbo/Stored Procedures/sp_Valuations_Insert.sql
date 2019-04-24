-- =============================================
-- Author:		Gerald Glass
-- Create date: 04/20/2019
-- Description:	Add New Stock Valuation
-- =============================================
CREATE PROCEDURE [dbo].[sp_Valuations_Insert]
 
	-- Parameters for the stored procedure here
	
	@StockId int,
	@Date datetime2(3),
	@Shares decimal(14,5),
	@Price smallmoney,
	@Cost smallmoney,
	@ValuationId int = 0 output

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Statements for procedure here

	Insert into dbo.Valuations (StockId, Date, Shares,Price, Cost)
	Values (@StockId, @Date, @Shares, @Price, @Cost);

	Select @ValuationId = SCOPE_IDENTITY();

END
