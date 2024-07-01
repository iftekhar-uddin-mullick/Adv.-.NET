USE [master]
GO

/****** Object:  Database [DemoTask_BlogSite]    Script Date: 01-Jul-24 12:09:01 PM ******/
CREATE DATABASE [DemoTask_BlogSite]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DemoTask_BlogSite', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DemoTask_BlogSite.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DemoTask_BlogSite_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DemoTask_BlogSite_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [DemoTask_BlogSite] SET COMPATIBILITY_LEVEL = 120
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DemoTask_BlogSite].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [DemoTask_BlogSite] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [DemoTask_BlogSite] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [DemoTask_BlogSite] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [DemoTask_BlogSite] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [DemoTask_BlogSite] SET ARITHABORT OFF 
GO

ALTER DATABASE [DemoTask_BlogSite] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [DemoTask_BlogSite] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [DemoTask_BlogSite] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [DemoTask_BlogSite] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [DemoTask_BlogSite] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [DemoTask_BlogSite] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [DemoTask_BlogSite] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [DemoTask_BlogSite] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [DemoTask_BlogSite] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [DemoTask_BlogSite] SET  DISABLE_BROKER 
GO

ALTER DATABASE [DemoTask_BlogSite] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [DemoTask_BlogSite] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [DemoTask_BlogSite] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [DemoTask_BlogSite] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [DemoTask_BlogSite] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [DemoTask_BlogSite] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [DemoTask_BlogSite] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [DemoTask_BlogSite] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [DemoTask_BlogSite] SET  MULTI_USER 
GO

ALTER DATABASE [DemoTask_BlogSite] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [DemoTask_BlogSite] SET DB_CHAINING OFF 
GO

ALTER DATABASE [DemoTask_BlogSite] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [DemoTask_BlogSite] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [DemoTask_BlogSite] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [DemoTask_BlogSite] SET  READ_WRITE 
GO

