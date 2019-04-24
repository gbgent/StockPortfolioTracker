-- =============================================
-- Author:		Gerald Glass
-- Create date: 04/12/2019
-- Description:	Initial Creation
-- =============================================
CREATE PROCEDURE [sp_Brokages_Insert]

	-- Add the parameters for the stored procedure here

	@BrokerageName nvarchar(30),
	@BrokerageAddress nvarchar(250),
	@AccountNumber nvarchar(50),
	@BrokerName nvarchar(60),
	@PhoneNum nchar(10),
	@Email nvarchar(90),
	@CommissionRate decimal(5,2),
	@BrokerId int = 0 output

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

	Insert into dbo.Brokerages(BrokerageName, BrokerageAddress, AccountNum,
								BrokerName, PhoneNum, Email, CommissionRate)
	values (@BrokerageName, @BrokerageAddress, @AccountNumber,
			@BrokerName, @PhoneNum, @Email, @CommissionRate);

	Select @BrokerId = SCOPE_IDENTITY();

END
