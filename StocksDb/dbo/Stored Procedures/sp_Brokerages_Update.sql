-- =============================================
-- Author:		Gerald Glass
-- Create date: 04/16/2019
-- Description:	Update Brokage Information based on BrokerId
-- =============================================
CREATE PROCEDURE [sp_Brokerages_Update]

	-- Add the parameters for the stored procedure here
	@BrokerId int,
	@BrokerageName nvarchar(30),
	@BrokerageAddress nvarchar(250),
	@AccountNumber nvarchar(50),
	@BrokerName nvarchar(60),
	@PhoneNum nchar(10),
	@Email nvarchar(90),
	@CommissionRate decimal(5,2)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
	Update dbo.Brokerages
	Set 
		BrokerageName = @BrokerageName,
		BrokerageAddress = @BrokerageAddress,
		AccountNum = @AccountNumber,
		BrokerName = @BrokerName,
		PhoneNum = @PhoneNum,
		Email = @Email,
		CommissionRate = @CommissionRate
	Where BrokerId = @BrokerId
END
