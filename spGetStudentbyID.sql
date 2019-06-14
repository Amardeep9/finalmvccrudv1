USE [StudentManagementSystem]
GO
/****** Object:  StoredProcedure [dbo].[spGetStudentbyID]    Script Date: 14-Jun-19 11:07:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[spGetStudentbyID]   
@StudentID int=0
as    
Begin    
    select *    
    from tblStudentMngSyst 
	where StudentID=@StudentID
    order by StudentID    
End
