CREATE PROC [dbo].[SP_Account_Login]
    @UserName VARCHAR(20) ,
    @PassWord VARCHAR(20)
AS
    BEGIN
        DECLARE @count INT;
        DECLARE @res BIT;
        SELECT  @count = COUNT(*)
        FROM    dbo.Account
        WHERE   UserName = @UserName
                AND PassWord = @PassWord;
        IF @count > 0
            SET @res = 1;
        ELSE
            SET @res = 0;
        SELECT  @res;	
    END;