USE [BD_PARQUEADERO]
GO
/****** Object:  Table [dbo].[Parqueadero]    Script Date: 26/1/2022 0:46:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parqueadero](
	[ParqueaderoID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Direccion] [nvarchar](max) NOT NULL,
	[EspaciosTotal] [int] NOT NULL,
	[EspaciosOcupados] [int] NOT NULL,
	[EspaciosDisponibles] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Parqueadero] PRIMARY KEY CLUSTERED 
(
	[ParqueaderoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Parqueadero] ADD  DEFAULT ('') FOR [Nombre]
GO
ALTER TABLE [dbo].[Parqueadero] ADD  DEFAULT ('') FOR [Direccion]
GO
