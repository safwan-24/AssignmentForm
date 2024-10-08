USE [Student]
GO
/****** Object:  Table [dbo].[StudentTbl]    Script Date: 9/19/2024 4:35:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentTbl](
	[StudentId] [int] IDENTITY(500,1) NOT NULL,
	[StudentName] [varchar](50) NOT NULL,
	[StudentAge] [varchar](50) NOT NULL,
	[StudentPhone] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[StudentTbl] ON 

INSERT [dbo].[StudentTbl] ([StudentId], [StudentName], [StudentAge], [StudentPhone]) VALUES (504, N'1', N'1', N'018')
INSERT [dbo].[StudentTbl] ([StudentId], [StudentName], [StudentAge], [StudentPhone]) VALUES (505, N'1', N'3', N'0188')
INSERT [dbo].[StudentTbl] ([StudentId], [StudentName], [StudentAge], [StudentPhone]) VALUES (506, N's', N'5', N'6')
INSERT [dbo].[StudentTbl] ([StudentId], [StudentName], [StudentAge], [StudentPhone]) VALUES (508, N'123', N'2', N'1')
INSERT [dbo].[StudentTbl] ([StudentId], [StudentName], [StudentAge], [StudentPhone]) VALUES (509, N'aa', N'34', N'756')
SET IDENTITY_INSERT [dbo].[StudentTbl] OFF
GO
