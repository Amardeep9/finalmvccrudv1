USE [StudentManagementSystem]
GO

/****** Object:  Table [dbo].[tblStudentMngSyst]    Script Date: 14-Jun-19 11:05:07 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tblStudentMngSyst](
	[StudentID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](20) NOT NULL,
	[LastName] [varchar](20) NOT NULL,
	[Address] [varchar](25) NOT NULL,
	[City] [varchar](20) NOT NULL,
	[State] [varchar](30) NOT NULL,
	[Mobile] [bigint] NOT NULL,
	[Emailid] [varchar](26) NOT NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


