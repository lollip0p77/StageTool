USE [master]
GO
/****** Object:  Database [Stages]    Script Date: 2023-03-10 11:22:54 ******/
CREATE DATABASE [Stages]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Stages', FILENAME = N'D:\Programation\SQL\SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Stages.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Stages_log', FILENAME = N'D:\Programation\SQL\SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Stages_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Stages] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Stages].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Stages] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Stages] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Stages] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Stages] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Stages] SET ARITHABORT OFF 
GO
ALTER DATABASE [Stages] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Stages] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Stages] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Stages] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Stages] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Stages] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Stages] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Stages] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Stages] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Stages] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Stages] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Stages] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Stages] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Stages] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Stages] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Stages] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Stages] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Stages] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Stages] SET  MULTI_USER 
GO
ALTER DATABASE [Stages] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Stages] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Stages] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Stages] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Stages] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Stages] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Stages] SET QUERY_STORE = OFF
GO
USE [Stages]
GO
/****** Object:  Table [dbo].[Demande]    Script Date: 2023-03-10 11:22:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Demande](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Etat] [nvarchar](50) NOT NULL,
	[DateEnvoie] [date] NOT NULL,
	[EntrepriseId] [int] NOT NULL,
	[Nom] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Demande] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Entreprise]    Script Date: 2023-03-10 11:22:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entreprise](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [nvarchar](50) NOT NULL,
	[Telephone] [nvarchar](14) NOT NULL,
	[Email] [nvarchar](255) NULL,
	[Adresse] [nvarchar](255) NOT NULL,
	[Ville] [nvarchar](255) NOT NULL,
	[CodePostal] [nvarchar](7) NOT NULL,
	[Actif] [bit] NOT NULL,
 CONSTRAINT [PK_Entreprise] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Entrevues]    Script Date: 2023-03-10 11:22:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entrevues](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EntrepriseId] [int] NOT NULL,
	[Date] [date] NOT NULL,
	[Heure] [nvarchar](5) NOT NULL,
 CONSTRAINT [PK_Entrevues] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Retours]    Script Date: 2023-03-10 11:22:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Retours](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Etat] [nvarchar](50) NOT NULL,
	[Contact] [nvarchar](255) NOT NULL,
	[DateRetour] [date] NOT NULL,
	[Concluant] [nvarchar](5) NOT NULL,
	[DemandeId] [int] NOT NULL,
 CONSTRAINT [PK_Retours] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Demande] ON 

INSERT [dbo].[Demande] ([Id], [Etat], [DateEnvoie], [EntrepriseId], [Nom]) VALUES (1, N'Traité', CAST(N'2023-03-06' AS Date), 1002, N'Demande pour Ciao')
INSERT [dbo].[Demande] ([Id], [Etat], [DateEnvoie], [EntrepriseId], [Nom]) VALUES (2, N'Traité', CAST(N'2023-03-06' AS Date), 1003, N'Demande Groupe CMI')
INSERT [dbo].[Demande] ([Id], [Etat], [DateEnvoie], [EntrepriseId], [Nom]) VALUES (3, N'Non traité', CAST(N'2023-03-03' AS Date), 1004, N'Demande CGSI Solution')
INSERT [dbo].[Demande] ([Id], [Etat], [DateEnvoie], [EntrepriseId], [Nom]) VALUES (4, N'Traité', CAST(N'2023-03-02' AS Date), 1005, N'Demande pour TLM')
SET IDENTITY_INSERT [dbo].[Demande] OFF
GO
SET IDENTITY_INSERT [dbo].[Entreprise] ON 

INSERT [dbo].[Entreprise] ([Id], [Nom], [Telephone], [Email], [Adresse], [Ville], [CodePostal], [Actif]) VALUES (1002, N'Ciao', N'(418) 948-8803', N'carriere@ciao.ca', N'3150 Bd Hochelaga', N'Québec', N'G1W-2R2', 1)
INSERT [dbo].[Entreprise] ([Id], [Nom], [Telephone], [Email], [Adresse], [Ville], [CodePostal], [Actif]) VALUES (1003, N'Groupe CMI', N'(418) 529-5899', N'alexandre.godfroid@gcmi.ca', N'420 Boulevard Charest E #400', N'Québec', N'G1K-8M4', 1)
INSERT [dbo].[Entreprise] ([Id], [Nom], [Telephone], [Email], [Adresse], [Ville], [CodePostal], [Actif]) VALUES (1004, N'CGSI Solution TI', N'(418) 623-3442', N'mario.fournier@cgsi.qc.ca', N'1145 Bd Lebourgneuf', N'Québec', N'G2K-2K8', 1)
INSERT [dbo].[Entreprise] ([Id], [Nom], [Telephone], [Email], [Adresse], [Ville], [CodePostal], [Actif]) VALUES (1005, N'TLM', N'(877) 896-4472', N'info@tlmgo.com', N'1165 Bd Lebourgneuf Bureau 320', N'Québec', N'G2K-2C9', 1)
SET IDENTITY_INSERT [dbo].[Entreprise] OFF
GO
SET IDENTITY_INSERT [dbo].[Entrevues] ON 

INSERT [dbo].[Entrevues] ([Id], [EntrepriseId], [Date], [Heure]) VALUES (1002, 1004, CAST(N'2023-03-09' AS Date), N'10:30')
SET IDENTITY_INSERT [dbo].[Entrevues] OFF
GO
SET IDENTITY_INSERT [dbo].[Retours] ON 

INSERT [dbo].[Retours] ([Id], [Etat], [Contact], [DateRetour], [Concluant], [DemandeId]) VALUES (1, N'Traité', N'Samuel Lachance', CAST(N'2023-03-08' AS Date), N'non', 1)
INSERT [dbo].[Retours] ([Id], [Etat], [Contact], [DateRetour], [Concluant], [DemandeId]) VALUES (2, N'Non traité', N'Mario Fournier', CAST(N'2023-03-06' AS Date), N'Oui', 3)
INSERT [dbo].[Retours] ([Id], [Etat], [Contact], [DateRetour], [Concluant], [DemandeId]) VALUES (3, N'Traité', N'
Alexandre Godfroid', CAST(N'2023-03-06' AS Date), N'Non', 2)
INSERT [dbo].[Retours] ([Id], [Etat], [Contact], [DateRetour], [Concluant], [DemandeId]) VALUES (4, N'Traité', N'RH', CAST(N'2023-03-03' AS Date), N'Non', 4)
SET IDENTITY_INSERT [dbo].[Retours] OFF
GO
ALTER TABLE [dbo].[Entrevues]  WITH CHECK ADD  CONSTRAINT [FK_Entrevues_Entreprise] FOREIGN KEY([EntrepriseId])
REFERENCES [dbo].[Entreprise] ([Id])
GO
ALTER TABLE [dbo].[Entrevues] CHECK CONSTRAINT [FK_Entrevues_Entreprise]
GO
ALTER TABLE [dbo].[Retours]  WITH CHECK ADD  CONSTRAINT [FK_Retours_Demande] FOREIGN KEY([DemandeId])
REFERENCES [dbo].[Demande] ([Id])
GO
ALTER TABLE [dbo].[Retours] CHECK CONSTRAINT [FK_Retours_Demande]
GO
USE [master]
GO
ALTER DATABASE [Stages] SET  READ_WRITE 
GO
