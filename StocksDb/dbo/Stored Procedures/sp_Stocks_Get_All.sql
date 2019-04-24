-- =============================================
-- Author:		Gerald Glass
-- Create date: 4-20-2019	
-- Description:	Retrieve All Stocks Owned
-- =============================================
CREATE PROCEDURE sp_Stocks_Get_All

	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	From dbo.Stocks;
END
