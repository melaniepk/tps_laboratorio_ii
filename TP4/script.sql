USE [master]
GO
/****** Object:  Database [GimansioJustDoIt]    Script Date: 19/6/2022 15:08:29 ******/
CREATE DATABASE [GimansioJustDoIt]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GimansioJustDoIt', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\GimansioJustDoIt.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GimansioJustDoIt_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\GimansioJustDoIt_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [GimansioJustDoIt] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GimansioJustDoIt].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GimansioJustDoIt] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GimansioJustDoIt] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GimansioJustDoIt] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GimansioJustDoIt] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GimansioJustDoIt] SET ARITHABORT OFF 
GO
ALTER DATABASE [GimansioJustDoIt] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GimansioJustDoIt] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GimansioJustDoIt] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GimansioJustDoIt] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GimansioJustDoIt] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GimansioJustDoIt] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GimansioJustDoIt] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GimansioJustDoIt] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GimansioJustDoIt] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GimansioJustDoIt] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GimansioJustDoIt] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GimansioJustDoIt] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GimansioJustDoIt] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GimansioJustDoIt] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GimansioJustDoIt] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GimansioJustDoIt] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GimansioJustDoIt] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GimansioJustDoIt] SET RECOVERY FULL 
GO
ALTER DATABASE [GimansioJustDoIt] SET  MULTI_USER 
GO
ALTER DATABASE [GimansioJustDoIt] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GimansioJustDoIt] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GimansioJustDoIt] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GimansioJustDoIt] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GimansioJustDoIt] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GimansioJustDoIt] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'GimansioJustDoIt', N'ON'
GO
ALTER DATABASE [GimansioJustDoIt] SET QUERY_STORE = OFF
GO
USE [GimansioJustDoIt]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 19/6/2022 15:08:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Genero] [varchar](50) NOT NULL,
	[DNI] [int] NOT NULL,
	[Telefono] [int] NOT NULL,
	[Membresia] [varchar](50) NOT NULL,
	[EstaActivo] [bit] NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[DNI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Clientes] ([Nombre], [Apellido], [Genero], [DNI], [Telefono], [Membresia], [EstaActivo]) VALUES (N'HoSeok', N'Jung', N'1', 44555666, 1477885699, N'Full
', 1)
INSERT [dbo].[Clientes] ([Nombre], [Apellido], [Genero], [DNI], [Telefono], [Membresia], [EstaActivo]) VALUES (N'SeokJin', N'Kim', N'1', 45889665, 1477788556, N'Full
', 1)
INSERT [dbo].[Clientes] ([Nombre], [Apellido], [Genero], [DNI], [Telefono], [Membresia], [EstaActivo]) VALUES (N'JungKook', N'Jeon', N'1', 55666333, 1456235896, N'Full
', 1)
INSERT [dbo].[Clientes] ([Nombre], [Apellido], [Genero], [DNI], [Telefono], [Membresia], [EstaActivo]) VALUES (N'TaeHyung', N'Kim', N'1', 55888777, 1478556698, N'Basic
', 1)
INSERT [dbo].[Clientes] ([Nombre], [Apellido], [Genero], [DNI], [Telefono], [Membresia], [EstaActivo]) VALUES (N'NamJoon', N'Kim', N'1', 66444777, 1456232897, N'Full
', 1)
INSERT [dbo].[Clientes] ([Nombre], [Apellido], [Genero], [DNI], [Telefono], [Membresia], [EstaActivo]) VALUES (N'Jimin', N'Park', N'1', 77888999, 1455698785, N'Plus
', 1)
INSERT [dbo].[Clientes] ([Nombre], [Apellido], [Genero], [DNI], [Telefono], [Membresia], [EstaActivo]) VALUES (N'Yoongi', N'Min', N'1', 78444555, 1245632897, N'Basic
', 1)
GO
USE [master]
GO
ALTER DATABASE [GimansioJustDoIt] SET  READ_WRITE 
GO
