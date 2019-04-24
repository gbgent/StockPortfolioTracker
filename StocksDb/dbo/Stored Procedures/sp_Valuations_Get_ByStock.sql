-- =============================================
-- Author:		Gerald Glass
-- Create date: 04-20-2019
-- Description:	Retrieves Stock Values by Stock ID
-- =============================================
CREATE PROCEDURE [dbo].[sp_Valuations_Get_ByStock]

	-- Parameters for the stored procedure

	@StockId int
	 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Statements for procedure here
	
	Select *
	From dbo.Valuations
	Where StockId = @StockId
	Order by Date;


END
