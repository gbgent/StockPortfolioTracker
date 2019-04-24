-- =============================================
-- Author:		Gerald Glass
-- Create date: 04-20-2019
-- Description:	Retrieve all Valuations
-- =============================================
CREATE PROCEDURE sp_Valuations_Get_All
 
	-- Add the parameters for the stored procedure here
	
	-- None
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	from dbo.Valuations
	Order by Date;

END
