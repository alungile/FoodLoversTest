
CREATE PROCEDURE spInsertBranchProduct
@BranchID int,
@ProductID int,
@ActionType VARCHAR(25)  

AS
BEGIN
	IF @ActionType = 'SaveData'  
    BEGIN  
		   INSERT INTO BranchProduct
				  (BranchID, ProductID)
		   VALUES
				  (@BranchID, @ProductID)
	END
	ELSE  
    BEGIN  
       DELETE BranchProduct WHERE @BranchID = @BranchID    
    END  
END