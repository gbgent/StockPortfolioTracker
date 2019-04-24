-- =============================================
-- Author:		Gerald Glass
-- Create date: 04/16/2019
-- Description:	Returns all Brokerages
-- =============================================
CREATE PROCEDURE sp_Brokerages_Get_All
	-- No parameters for this stored procedure
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	From dbo.Brokerages;
END
