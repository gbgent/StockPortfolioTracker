-- =============================================
-- Author:		Gerald Glass
-- Create date: 04/22/2019
-- Description:	Load All Transactions for a specific Stock
-- =============================================
CREATE PROCEDURE sp_Transactions_GetbyId
 
	-- Parameters for the stored procedure here
	
	@StockId int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

	SELECT *
	from dbo.Transactions
	where StockId = @StockId
	Order by Date;

END
