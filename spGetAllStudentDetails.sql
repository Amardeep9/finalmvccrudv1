USE [StudentManagementSystem]
GO
/****** Object:  StoredProcedure [dbo].[spGetAllStudentDetails]    Script Date: 14-Jun-19 11:06:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[spGetAllStudentDetails]    
as    
Begin    
    select *    
    from tblStudentMngSyst 
    order by StudentID    
End
