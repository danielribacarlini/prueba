USE [Noticias]
GO
/****** Object:  Table [dbo].[News]    Script Date: 12/12/2017 9:06:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[News](
	[title] [varchar](200) NOT NULL,
	[description] [varchar](50) NULL,
	[userCreate] [varchar](50) NULL,
	[userModif] [varchar](50) NOT NULL,
	[creationDate] [datetime] NOT NULL,
	[updateDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[title] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 12/12/2017 9:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[userName] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[userName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[News]  WITH CHECK ADD FOREIGN KEY([userCreate])
REFERENCES [dbo].[users] ([userName])
GO
ALTER TABLE [dbo].[News]  WITH CHECK ADD FOREIGN KEY([userModif])
REFERENCES [dbo].[users] ([userName])
GO
