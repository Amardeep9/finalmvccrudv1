USE [StudentManagementSystem]
GO
/****** Object:  StoredProcedure [dbo].[spDeleteStudentDetails]    Script Date: 14-Jun-19 11:06:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[spDeleteStudentDetails]     
(      
   @StudentID int      
)      
as       
begin      
   Delete from tblStudentMngSyst where StudentID=@StudentID     
End
