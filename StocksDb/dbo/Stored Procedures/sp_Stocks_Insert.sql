-- =============================================
-- Author:		Gerald Glass
-- Create date: 04/19/2019
-- Description:	Adds a new Stock to the Database
-- =============================================
CREATE PROCEDURE [dbo].[sp_Stocks_Insert]
 
	-- Parameters for the stored procedure here
	@BrokerId int,
	@Symbol nvarchar(5),
	@Name nvarchar(50),
	@StockId int = 0 output
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
	Insert into dbo.Stocks (BrokerId,Symbol,Name)
	Values (@BrokerId, @Symbol, @Name);

	Select @StockId = SCOPE_IDENTITY();

END
