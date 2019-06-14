USE [StudentManagementSystem]
GO
/****** Object:  StoredProcedure [dbo].[spAddStudent]    Script Date: 14-Jun-19 11:05:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[spAddStudent]     
(    
    @FirstName varchar(20), 
	@LastName varchar(20),  
    @Address varchar(25),   
	@City varchar(20) ,   
	@State varchar(30) , 
    @Mobile varchar(20) ,    
    @Emailid varchar(26) 
	
 
)    
as     
Begin     
    Insert into tblStudentMngSyst (FirstName ,LastName ,Address , City ,State ,Mobile ,Emailid )     
    Values (@FirstName,@LastName,@Address, @City, @State,@Mobile,@Emailid)     
End
