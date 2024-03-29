USE [StudentManagementSystem]
GO
/****** Object:  StoredProcedure [dbo].[spUpdateStudentData]    Script Date: 14-Jun-19 11:12:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[spUpdateStudentData]      
(     
     @StudentID INTEGER,
    @FirstName varchar(20), 
	@LastName varchar(20),  
    @Address varchar(25),   
	@City varchar(20) ,   
	@State varchar(30) , 
    @Mobile varchar(20) ,    
    @Emailid varchar(26)  
)      
as      
begin      
   Update tblStudentMngSyst       
   set
    FirstName=@FirstName, 
	LastName=@LastName,  
    Address=@Address ,   
	City=@City,    
	State=@State , 
    Mobile=@Mobile ,    
    Emailid=@Emailid     
   where StudentID=@StudentID      
End
