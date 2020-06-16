USE [master]
GO
/****** Object:  Database [Clinica]    Script Date: 6/12/2020 3:33:38 PM ******/
CREATE DATABASE [Clinica]
GO
ALTER DATABASE [Clinica] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Clinica].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Clinica] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Clinica] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Clinica] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Clinica] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Clinica] SET ARITHABORT OFF 
GO
ALTER DATABASE [Clinica] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Clinica] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Clinica] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Clinica] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Clinica] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Clinica] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Clinica] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Clinica] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Clinica] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Clinica] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Clinica] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Clinica] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Clinica] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Clinica] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Clinica] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Clinica] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Clinica] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Clinica] SET RECOVERY FULL 
GO
ALTER DATABASE [Clinica] SET  MULTI_USER 
GO
ALTER DATABASE [Clinica] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Clinica] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Clinica] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Clinica] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Clinica] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Clinica] SET QUERY_STORE = OFF
GO
USE [Clinica]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [Clinica]
GO
USE [Clinica]
GO
/****** Object:  Sequence [dbo].[EmpleadoSec]    Script Date: 6/12/2020 3:33:38 PM ******/
CREATE SEQUENCE [dbo].[EmpleadoSec] 
 AS [int]
 START WITH -2147483648
 INCREMENT BY 1
 MINVALUE -2147483648
 MAXVALUE 2147483647
 CACHE 
GO
USE [Clinica]
GO
/****** Object:  Sequence [dbo].[MedicoSec]    Script Date: 6/12/2020 3:33:38 PM ******/
CREATE SEQUENCE [dbo].[MedicoSec] 
 AS [int]
 START WITH -2147483648
 INCREMENT BY 1
 MINVALUE -2147483648
 MAXVALUE 2147483647
 CACHE 
GO
/****** Object:  Table [dbo].[CitaV1]    Script Date: 6/12/2020 3:33:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CitaV1](
	[idProgramacionMedica] [int] IDENTITY(1,1) NOT NULL,
	[Mes] [varchar](40) NULL,
	[Semana] [varchar](40) NULL,
	[Dia] [varchar](40) NULL,
	[fecCita] [datetime] NULL,
	[idProgra] [int] NULL,
	[idDoctor] [int] NULL,
	[dsDoctor] [varchar](80) NULL,
	[idEspecialidad] [int] NULL,
	[dsEspecialidad] [varchar](80) NULL,
	[idConsultorio] [int] NULL,
	[dsConsultorio] [varchar](80) NULL,
	[dsObsProgr] [varchar](80) NULL,
	[idTipoConsultorio] [int] NULL,
	[dsTipoConsultorio] [varchar](80) NULL,
	[idAdmicionista] [int] NULL,
	[dsAdmicionista] [varchar](80) NULL,
	[idPaciente] [int] NULL,
	[dsPaciente] [varchar](80) NULL,
	[idTipoCita] [int] NULL,
	[dsTipoCita] [varchar](80) NULL,
	[dsHrIniCita] [varchar](40) NULL,
	[dsHrFinCita] [varchar](40) NULL,
	[idEstadoCita] [int] NULL,
	[dsEstadoCita] [varchar](40) NULL,
	[dsObsCita] [varchar](80) NULL,
	[dsECG] [varchar](80) NULL,
	[dsInfoMed] [varchar](80) NULL,
	[dcPrecio] [decimal](18, 6) NULL,
	[dcDesct] [decimal](18, 6) NULL,
	[dcCoa] [decimal](18, 6) NULL,
	[dcIGV] [decimal](18, 6) NULL,
	[dsNumOrden] [varchar](20) NULL,
	[dsEstadoPag] [varchar](80) NULL,
	[dsEstadoAte] [varchar](80) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D00_TBDETALLE]    Script Date: 6/12/2020 3:33:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D00_TBDETALLE](
	[idDet] [int] IDENTITY(1,1) NOT NULL,
	[coddetTab] [varchar](9) NULL,
	[descripcion] [varchar](50) NULL,
	[abrev] [varchar](15) NULL,
	[fuente] [varchar](80) NULL,
	[estado] [char](10) NULL,
	[idTab] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idDet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D00_TBGENERAL]    Script Date: 6/12/2020 3:33:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D00_TBGENERAL](
	[idTab] [int] IDENTITY(1,1) NOT NULL,
	[codTab] [varchar](9) NULL,
	[descripcion] [varchar](100) NULL,
	[tipo] [varchar](50) NULL,
	[fechaCreate] [date] NULL,
	[usuCreate] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[idTab] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D001_USUARIO]    Script Date: 6/12/2020 3:33:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D001_USUARIO](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[loginUser] [varchar](35) NULL,
	[claveUser] [varchar](35) NULL,
	[idEmpleado] [int] NULL,
	[estado] [char](3) NULL,
	[usuRegistra] [varchar](50) NULL,
	[fechaRegistra] [varchar](15) NULL,
	[usuMod] [varchar](50) NULL,
	[fechaMod] [varchar](15) NULL,
 CONSTRAINT [PK__D001_USU__645723A674AE501B] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D002_PERFIL]    Script Date: 6/12/2020 3:33:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D002_PERFIL](
	[idPerfil] [int] IDENTITY(1,1) NOT NULL,
	[codPerfil] [varchar](35) NULL,
	[nombrePerfil] [varchar](35) NULL,
	[idUsuario] [int] NOT NULL,
	[estado] [char](3) NULL,
 CONSTRAINT [PK__D002_PER__40F13B60CFEE3423] PRIMARY KEY CLUSTERED 
(
	[idPerfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D003_PERMISO]    Script Date: 6/12/2020 3:33:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D003_PERMISO](
	[idPermiso] [int] IDENTITY(1,1) NOT NULL,
	[codPermiso] [varchar](35) NULL,
	[nomPermiso] [varchar](35) NULL,
	[idModulo] [int] NOT NULL,
	[estado] [char](3) NULL,
 CONSTRAINT [PK__D003_PER__06A58486093F6845] PRIMARY KEY CLUSTERED 
(
	[idPermiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D004_MODULO]    Script Date: 6/12/2020 3:33:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D004_MODULO](
	[idModulo] [int] IDENTITY(1,1) NOT NULL,
	[codModulo] [varchar](35) NULL,
	[nombreModulo] [varchar](35) NULL,
	[estado] [char](3) NULL,
 CONSTRAINT [PK__D004_MOD__3CE613FA77737833] PRIMARY KEY CLUSTERED 
(
	[idModulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D005_MENU]    Script Date: 6/12/2020 3:33:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D005_MENU](
	[idMenu] [int] NOT NULL,
	[codMenu] [varchar](35) NULL,
	[nombreMenu] [varchar](35) NULL,
	[idModulo] [int] NOT NULL,
	[estado] [char](3) NULL,
PRIMARY KEY CLUSTERED 
(
	[idMenu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D006_PERMISOPERFIL]    Script Date: 6/12/2020 3:33:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D006_PERMISOPERFIL](
	[idPermiso] [int] NOT NULL,
	[idPerfil] [int] NOT NULL,
	[estado] [char](3) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D007_HORARIO]    Script Date: 6/12/2020 3:33:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D007_HORARIO](
	[idHorario] [int] IDENTITY(1,1) NOT NULL,
	[fecHorario] [date] NULL,
	[dia] [varchar](15) NULL,
	[turno] [char](5) NULL,
	[horaini] [date] NULL,
	[horafin] [date] NULL,
	[timeAtencion] [int] NULL,
	[idMedico] [int] NOT NULL,
	[idConsultorio] [int] NOT NULL,
 CONSTRAINT [PK__D007_HOR__DE60F33A55EE6DBE] PRIMARY KEY CLUSTERED 
(
	[idHorario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D008_CONSULTORIO]    Script Date: 6/12/2020 3:33:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D008_CONSULTORIO](
	[idConsultorio] [int] IDENTITY(1,1) NOT NULL,
	[nroConsultorio] [int] NULL,
	[tpConsultorio] [int] NULL,
	[descripcion] [varchar](50) NULL,
	[area] [varchar](45) NULL,
	[piso] [varchar](20) NULL,
	[idEspecialidad] [int] NULL,
 CONSTRAINT [PK__D008_CON__DE60F33ADCAECD64] PRIMARY KEY CLUSTERED 
(
	[idConsultorio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D009_EMPRCONVENIODET]    Script Date: 6/12/2020 3:33:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D009_EMPRCONVENIODET](
	[idemprConvenio] [int] NOT NULL,
	[idPacConvenio] [int] NOT NULL,
	[idservicioCli] [int] NOT NULL,
	[modoPago] [int] NULL,
	[codPlan] [int] NULL,
	[tpAtencion] [int] NULL,
	[coberAtenTit] [varchar](10) NULL,
	[vigenciaConv] [int] NULL,
	[estado] [char](5) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D010_PACACOMPANA]    Script Date: 6/12/2020 3:33:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D010_PACACOMPANA](
	[idPacAcom] [int] NOT NULL,
	[tpDocumento] [varchar](30) NULL,
	[dniAcom] [int] NULL,
	[apePatAcom] [varchar](50) NULL,
	[apeMatAcom] [varchar](50) NULL,
	[nombresAcom] [varchar](50) NULL,
	[parentesco] [varchar](30) NULL,
	[idPaciente] [int] NULL,
	[idPersona] [int] NULL,
	[estado] [char](5) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D011_UBIGEO]    Script Date: 6/12/2020 3:33:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D011_UBIGEO](
	[idUbigeo] [int] NOT NULL,
	[descripcion] [varchar](45) NULL,
PRIMARY KEY CLUSTERED 
(
	[idUbigeo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D011_UBIGEONACE]    Script Date: 6/12/2020 3:33:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D011_UBIGEONACE](
	[idUbigeoNace] [int] NOT NULL,
	[descripcion] [varchar](45) NULL,
	[idUbigeo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idUbigeoNace] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D011_UBIGEORESIDE]    Script Date: 6/12/2020 3:33:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D011_UBIGEORESIDE](
	[idUbigeoResi] [int] NOT NULL,
	[descripcion] [varchar](45) NULL,
	[idUbigeo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idUbigeoResi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D012_CRONOMEDICO]    Script Date: 6/12/2020 3:33:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D012_CRONOMEDICO](
	[idProgramMedica] [int] IDENTITY(1,1) NOT NULL,
	[mes] [varchar](20) NULL,
	[semana] [varchar](20) NULL,
	[dia] [varchar](20) NULL,
	[fecProgramMedica] [datetime] NULL,
	[idMedico] [int] NULL,
	[idEspecialidad] [int] NULL,
	[idConsultorio] [int] NULL,
	[hrInicio] [varchar](6) NULL,
	[hrFin] [varchar](6) NULL,
	[idEstado] [char](5) NULL,
 CONSTRAINT [PK__D012_CRO__6BCD0A871829A280] PRIMARY KEY CLUSTERED 
(
	[idProgramMedica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D013_CRONOCONSULTORIO]    Script Date: 6/12/2020 3:33:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D013_CRONOCONSULTORIO](
	[idCronoConsul] [int] NOT NULL,
	[disponibilidad] [varchar](30) NULL,
	[fecHora] [datetime] NULL,
	[estado] [char](5) NULL,
 CONSTRAINT [PK__D013_CON__230EBF0FA76F42B6] PRIMARY KEY CLUSTERED 
(
	[idCronoConsul] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D013_PAIS]    Script Date: 6/12/2020 3:33:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D013_PAIS](
	[idPais] [int] NOT NULL,
	[descripcion] [varchar](45) NULL,
	[codigo] [varchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[idPais] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D014_CONSULESPDET]    Script Date: 6/12/2020 3:33:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D014_CONSULESPDET](
	[idConsulEspDet] [int] NOT NULL,
	[idConsultorio] [int] NULL,
	[idEspecialidad] [int] NULL,
	[descripcion] [varchar](200) NULL,
	[fecha] [datetime] NULL,
	[estado] [char](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D014_DPTO]    Script Date: 6/12/2020 3:33:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D014_DPTO](
	[idDpto] [int] NOT NULL,
	[descripcion] [varchar](45) NULL,
	[codigo] [varchar](40) NULL,
	[idPais] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idDpto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D014_TELEQUERY]    Script Date: 6/12/2020 3:33:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D014_TELEQUERY](
	[idTelequery] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](150) NULL,
	[fechaCall] [date] NULL,
	[timeCall] [int] NULL,
	[rutaFile] [varchar](180) NULL,
	[idPaciente] [int] NULL,
	[idMedico] [int] NULL,
	[idEspecialidad] [int] NULL,
	[idConsultorio] [int] NULL,
	[idCita] [int] NULL,
	[estado] [char](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[idTelequery] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D015_PAGO]    Script Date: 6/12/2020 3:33:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D015_PAGO](
	[idPago] [int] IDENTITY(1,1) NOT NULL,
	[codTransaccion] [varchar](50) NULL,
	[codTransacRetorno] [varchar](50) NULL,
	[idFormaPago] [int] NULL,
	[monto] [numeric](18, 2) NULL,
	[fecRegistro] [datetime] NULL,
	[fecOkPasarela] [datetime] NULL,
	[idCita] [int] NULL,
	[estado] [char](5) NULL,
 CONSTRAINT [PK__D015_PAG__BD2295ADB8822C59] PRIMARY KEY CLUSTERED 
(
	[idPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D015_PAGODETA]    Script Date: 6/12/2020 3:33:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D015_PAGODETA](
	[idPago] [int] NULL,
	[descripcion] [varchar](150) NULL,
	[cantidad] [int] NULL,
	[idReceta] [int] NULL,
	[idservicioCli] [int] NULL,
	[idLaboratorio] [int] NULL,
	[idExamSpecial] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D015_PROV]    Script Date: 6/12/2020 3:33:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D015_PROV](
	[idProvincia] [int] NOT NULL,
	[descripcion] [varchar](45) NULL,
	[codigo] [varchar](40) NULL,
	[idDpto] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idProvincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D015_TPEMPLEADO]    Script Date: 6/12/2020 3:33:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D015_TPEMPLEADO](
	[idtpEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_D015_TIPOEMPLEADO] PRIMARY KEY CLUSTERED 
(
	[idtpEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D016_DETLABORATORIO]    Script Date: 6/12/2020 3:33:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D016_DETLABORATORIO](
	[idLaboratorio] [int] NOT NULL,
	[idCita] [int] NOT NULL,
	[descripcion] [varchar](35) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D016_DETRECETA]    Script Date: 6/12/2020 3:33:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D016_DETRECETA](
	[idReceta] [int] NOT NULL,
	[idMedicaNrcg] [int] NULL,
	[descripcion] [varchar](35) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D016_DISTRITO]    Script Date: 6/12/2020 3:33:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D016_DISTRITO](
	[idDistrito] [int] NOT NULL,
	[descripcion] [varchar](45) NULL,
	[codigo] [varchar](40) NULL,
	[idDpto] [int] NULL,
	[idProv] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idDistrito] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D018_DETEXAMEN]    Script Date: 6/12/2020 3:33:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D018_DETEXAMEN](
	[idExamSpecial] [int] NOT NULL,
	[idCita] [int] NOT NULL,
	[descripcion] [varchar](35) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D019_FORMAPAGO]    Script Date: 6/12/2020 3:33:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D019_FORMAPAGO](
	[idFormaPago] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](35) NULL,
PRIMARY KEY CLUSTERED 
(
	[idFormaPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D020_TARJETA]    Script Date: 6/12/2020 3:33:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D020_TARJETA](
	[idTarjeta] [int] IDENTITY(1,1) NOT NULL,
	[nroTarjeta] [varchar](35) NULL,
	[nombresTarjeta] [varchar](40) NULL,
	[apellidoTarjeta] [varchar](40) NULL,
	[fechaVenceMes] [datetime] NULL,
	[fechaVenceAnho] [datetime] NULL,
	[codSeguridad] [varchar](6) NULL,
	[idTarjCredito] [int] NULL,
	[idPago] [int] NULL,
 CONSTRAINT [PK__D020_TAR__C456D5388A2BB14B] PRIMARY KEY CLUSTERED 
(
	[idTarjeta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D021_TARJETACREDIT]    Script Date: 6/12/2020 3:33:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D021_TARJETACREDIT](
	[idTarjCredito] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](35) NULL,
PRIMARY KEY CLUSTERED 
(
	[idTarjCredito] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D022_TIPOVIA]    Script Date: 6/12/2020 3:33:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D022_TIPOVIA](
	[idTipoVia] [int] NOT NULL,
	[descripcionVia] [nvarchar](50) NULL,
 CONSTRAINT [PK_D040_TIPOVIA] PRIMARY KEY CLUSTERED 
(
	[idTipoVia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D023_TBLICENCIA]    Script Date: 6/12/2020 3:33:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D023_TBLICENCIA](
	[idLicencia] [int] IDENTITY(1,1) NOT NULL,
	[codHorario] [varchar](8) NULL,
	[turno] [varchar](35) NULL,
	[dia] [varchar](8) NULL,
	[medRemplazo] [varchar](45) NULL,
	[horaIni] [varchar](9) NULL,
	[horaFin] [varchar](9) NULL,
	[fecIni] [date] NULL,
	[fecFin] [date] NULL,
	[idCronomed] [int] NULL,
	[idCita] [int] NULL,
	[idEmpleado] [int] NULL,
	[estado] [char](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[idLicencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D024_CAJA]    Script Date: 6/12/2020 3:33:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D024_CAJA](
	[idCaja] [int] IDENTITY(1,1) NOT NULL,
	[nroCaja] [int] NULL,
	[estado] [char](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[idCaja] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[D025_ASIGNACAJA]    Script Date: 6/12/2020 3:33:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[D025_ASIGNACAJA](
	[idCaja] [int] NULL,
	[idEmpleado] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DT004_ETNICO]    Script Date: 6/12/2020 3:33:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DT004_ETNICO](
	[idEtnico] [int] IDENTITY(1,1) NOT NULL,
	[codHis] [varchar](5) NULL,
	[tipos] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[idEtnico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T000_HCESTANDAR]    Script Date: 6/12/2020 3:33:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T000_HCESTANDAR](
	[idhcEstandar] [int] NOT NULL,
	[descripcion] [varchar](45) NULL,
	[estado] [char](4) NULL,
PRIMARY KEY CLUSTERED 
(
	[idhcEstandar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T000_HCGINECOLOGIA]    Script Date: 6/12/2020 3:33:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T000_HCGINECOLOGIA](
	[idhcGineco] [int] NOT NULL,
	[descripcion] [varchar](45) NULL,
	[idPatoGestacion] [int] NOT NULL,
	[idPeritorio] [int] NOT NULL,
	[idPerfilSalud] [int] NOT NULL,
	[codPlanWork] [varchar](5) NULL,
	[idtpRecetaElec] [int] NOT NULL,
	[idEstAtencion] [int] NOT NULL,
	[idtpPacFrecuente] [int] NOT NULL,
	[idFormatAnxHis] [int] NOT NULL,
	[idClasifiAtencion] [int] NOT NULL,
	[idDatospacHCE] [int] NOT NULL,
	[idAtcSustancia] [int] NOT NULL,
	[idCIE10Especial] [int] NOT NULL,
	[idHojaSiteds] [int] NOT NULL,
	[idProtocolo] [int] NOT NULL,
	[idtpPartoDeta] [int] NOT NULL,
	[idPatologiaNace] [int] NOT NULL,
	[idtpEmbarazo] [int] NOT NULL,
	[idtpProcPsico] [int] NOT NULL,
	[estado] [char](4) NULL,
PRIMARY KEY CLUSTERED 
(
	[idhcGineco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T000_HCNUTRICION]    Script Date: 6/12/2020 3:33:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T000_HCNUTRICION](
	[idhcNutricion] [int] NOT NULL,
	[descripcion] [varchar](45) NULL,
	[idEstaActual] [int] NOT NULL,
	[idAnamnesiAli] [int] NOT NULL,
	[idFreconsumoAli] [int] NOT NULL,
	[idEvaluaAli] [int] NOT NULL,
	[idEdadEvaluaAli] [int] NOT NULL,
	[idEstaNutricion] [int] NOT NULL,
	[idgpoNutricion] [int] NOT NULL,
	[idvalorNutricion] [int] NOT NULL,
	[idEsquemaAli] [int] NOT NULL,
	[idInventAlimento] [int] NOT NULL,
	[idRecomendaNutri] [int] NOT NULL,
	[idFormatoNutri] [int] NOT NULL,
	[idtpLactancia] [int] NOT NULL,
	[idAntropometrico] [int] NOT NULL,
	[estado] [char](4) NULL,
PRIMARY KEY CLUSTERED 
(
	[idhcNutricion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T000_HISTORIACLIDETA]    Script Date: 6/12/2020 3:33:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T000_HISTORIACLIDETA](
	[idHistoClinica] [int] NOT NULL,
	[descripcion] [varchar](45) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T000_HISTORIACLINICA]    Script Date: 6/12/2020 3:33:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T000_HISTORIACLINICA](
	[idHistoClinica] [int] NOT NULL,
	[descripcion] [varchar](50) NULL,
	[fechaRegistro] [date] NULL,
	[planTrabajo] [varchar](200) NULL,
	[idPaciente] [int] NOT NULL,
	[idEmpleado] [int] NOT NULL,
	[idCita] [int] NOT NULL,
	[idDiagnostico] [int] NOT NULL,
	[idReceta] [int] NOT NULL,
	[idExamen] [int] NOT NULL,
	[idhcEstandar] [int] NOT NULL,
	[idhcGineco] [int] NOT NULL,
	[idhcNutricion] [int] NOT NULL,
	[estado] [char](4) NULL,
PRIMARY KEY CLUSTERED 
(
	[idHistoClinica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T000_PERSONA]    Script Date: 6/12/2020 3:33:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T000_PERSONA](
	[idPersona] [int] IDENTITY(1,1) NOT NULL,
	[apePaterno] [varchar](50) NULL,
	[apeMaterno] [varchar](50) NULL,
	[nombres] [varchar](50) NULL,
	[idtpDocumento] [int] NULL,
	[dniPersona] [int] NULL,
	[idSexo] [int] NULL,
	[idEtnico] [int] NULL,
	[fecNacimiento] [varchar](15) NULL,
	[idUbigeoResi] [int] NULL,
	[idtipoVia] [int] NULL,
	[nombreVia] [varchar](50) NULL,
	[nroVia] [int] NULL,
	[nroDpto] [int] NULL,
	[interior] [int] NULL,
	[manzana] [int] NULL,
	[nroLote] [int] NULL,
	[nroKm] [int] NULL,
	[nroBlock] [int] NULL,
	[nroEtapa] [int] NULL,
	[edad] [int] NULL,
	[idUbigeoNace] [int] NULL,
	[fotografia] [varchar](150) NULL,
	[idGrdInstruc] [int] NULL,
	[idReligion] [int] NULL,
	[centroEduca] [varchar](50) NULL,
	[idEstCivil] [int] NULL,
	[idOcupacion] [int] NULL,
	[idgpoSangre] [int] NULL,
	[idFactorrh] [int] NULL,
	[nroRuc] [int] NULL,
	[razonSocial] [varchar](80) NULL,
	[estadoRuc] [varchar](15) NULL,
	[condicionRuc] [varchar](15) NULL,
	[domiFiscal] [varchar](50) NULL,
	[idParentesco] [int] NULL,
	[telefono] [varchar](15) NULL,
	[celular] [varchar](15) NULL,
	[correo] [varchar](150) NULL,
	[tpPersona] [int] NULL,
	[iddatoSiteds] [int] NULL,
	[idemprConvenio] [int] NULL,
	[idciaSeguro] [int] NULL,
	[idtipoIafa] [int] NULL,
	[estado] [char](5) NULL,
 CONSTRAINT [PK__T001_PAC__F48A08F2EC43D268] PRIMARY KEY CLUSTERED 
(
	[idPersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T001_PACASEGURADO]    Script Date: 6/12/2020 3:33:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T001_PACASEGURADO](
	[idAsegurado] [int] NOT NULL,
	[cobertura] [varchar](25) NULL,
	[ordenAtenMed] [varchar](25) NULL,
	[nomAseguradora] [varchar](50) NULL,
	[codAsegurado] [varchar](8) NULL,
	[poliza] [varchar](25) NULL,
	[idParentesco] [int] NULL,
	[iniVigencia] [datetime] NULL,
	[finVigencia] [datetime] NULL,
	[tpPlanSalud] [varchar](40) NULL,
	[nroplanSalud] [int] NULL,
	[estadoSeguro] [char](10) NULL,
	[tpAfiliacion] [varchar](30) NULL,
	[fecAfiliacion] [datetime] NULL,
	[codTitular] [int] NULL,
	[moneda] [varchar](25) NULL,
	[nomContratante] [varchar](30) NULL,
	[idtpDocumento] [int] NULL,
	[dniContratante] [int] NULL,
	[planSalud] [varchar](40) NULL,
	[codCobertura] [varchar](6) NULL,
	[beneficio] [varchar](50) NULL,
	[restriccion] [varchar](50) NULL,
	[copagoFijo] [int] NULL,
	[copagoVariable] [int] NULL,
	[finCarencia] [int] NULL,
	[convenio] [varchar](25) NULL,
	[descuento] [decimal](18, 0) NULL,
	[idPaciente] [int] NULL,
	[estado] [char](5) NULL,
 CONSTRAINT [PK__T002_ASE__0DEE65BD9A48E0D9] PRIMARY KEY CLUSTERED 
(
	[idAsegurado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T001_PACCONVENIO]    Script Date: 6/12/2020 3:33:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T001_PACCONVENIO](
	[idPacConvenio] [int] NOT NULL,
	[ordAtenMedica] [varchar](35) NULL,
	[idParentesco] [int] NULL,
	[cobertura] [varchar](35) NULL,
	[iniVigencia] [datetime] NULL,
	[finVigencia] [datetime] NULL,
	[estadoConvenio] [char](10) NULL,
	[tpAfiliacion] [varchar](30) NULL,
	[fecAfiliacion] [datetime] NULL,
	[codTitular] [int] NULL,
	[moneda] [varchar](25) NULL,
	[nomContratante] [varchar](35) NULL,
	[idtpDocumento] [int] NULL,
	[dniContratante] [int] NULL,
	[beneficio] [varchar](30) NULL,
	[restriccion] [varchar](30) NULL,
	[copagoFijo] [int] NULL,
	[copagoVariable] [int] NULL,
	[idPaciente] [int] NULL,
	[estado] [char](3) NULL,
 CONSTRAINT [PK__T003_PAC__ED800601DCA5DA00] PRIMARY KEY CLUSTERED 
(
	[idPacConvenio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T001_PACDETA]    Script Date: 6/12/2020 3:33:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T001_PACDETA](
	[idPacdeta] [int] IDENTITY(1,1) NOT NULL,
	[cobertura] [varchar](50) NULL,
	[ordenAtenMed] [varchar](25) NULL,
	[nomAseguradora] [varchar](50) NULL,
	[codAsegurado] [varchar](15) NULL,
	[poliza] [varchar](35) NULL,
	[parentesco] [varchar](35) NULL,
	[iniVigencia] [datetime] NULL,
	[finVigencia] [datetime] NULL,
	[tpPlanSalud] [varchar](40) NULL,
	[nroplanSalud] [int] NULL,
	[estadoSeguro] [char](10) NULL,
	[tpAfiliacion] [varchar](30) NULL,
	[fecAfiliacion] [datetime] NULL,
	[codTitular] [int] NULL,
	[moneda] [varchar](30) NULL,
	[nomContratante] [varchar](30) NULL,
	[tpDocumento] [varchar](35) NULL,
	[dniContratante] [int] NULL,
	[planSalud] [varchar](40) NULL,
	[codCobertura] [int] NULL,
	[beneficio] [varchar](50) NULL,
	[restriccion] [varchar](50) NULL,
	[copagoFijo] [int] NULL,
	[copagoVariable] [int] NULL,
	[finCarencia] [int] NULL,
	[convenio] [varchar](40) NULL,
	[descuento] [decimal](18, 0) NULL,
	[asegurado1] [varchar](30) NULL,
	[asegurado2] [varchar](30) NULL,
	[asegurado3] [varchar](30) NULL,
	[asegurado4] [varchar](30) NULL,
	[asegurado5] [varchar](30) NULL,
	[codPaConvenio] [varchar](6) NULL,
	[dsPacConv] [varchar](40) NULL,
	[statPaconv] [char](10) NULL,
	[pacConvenio1] [varchar](30) NULL,
	[pacConvenio2] [varchar](30) NULL,
	[pacConvenio3] [varchar](30) NULL,
	[pacConvenio4] [varchar](30) NULL,
	[pacConvenio5] [varchar](30) NULL,
	[codPacSoat] [varchar](6) NULL,
	[dsPacSoat] [varchar](40) NULL,
	[statPacSoat] [char](10) NULL,
	[pacSoat1] [varchar](30) NULL,
	[pacSoat2] [varchar](30) NULL,
	[pacSoat3] [varchar](30) NULL,
	[pacSoat4] [varchar](30) NULL,
	[pacSoat5] [varchar](30) NULL,
	[codpacExterno] [varchar](6) NULL,
	[dspacExter] [varchar](40) NULL,
	[stapacexter] [char](10) NULL,
	[idPacciente] [int] NULL,
	[estado] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[idPacdeta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T001_PACIENTE]    Script Date: 6/12/2020 3:33:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T001_PACIENTE](
	[idPaciente] [int] IDENTITY(1,1) NOT NULL,
	[codPaciente] [varchar](6) NULL,
	[idtpPaciente] [int] NULL,
	[descripcion] [varchar](60) NULL,
	[nrohc] [int] NULL,
	[nombreAcom] [varchar](60) NULL,
	[edadAcom] [int] NULL,
	[dniAcom] [int] NULL,
	[idgpoSangre] [int] NULL,
	[idFactorrh] [int] NULL,
	[idPersona] [int] NULL,
	[idAsegurado] [int] NULL,
	[idPacConvenio] [int] NULL,
	[estado] [char](8) NULL,
 CONSTRAINT [PK__T001_PAC__F48A08F29659AC03] PRIMARY KEY CLUSTERED 
(
	[idPaciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T004_DATOSRENIEC]    Script Date: 6/12/2020 3:33:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T004_DATOSRENIEC](
	[iddatoReniec] [int] NOT NULL,
	[apePaterno] [varchar](25) NULL,
	[apeMaterno] [varchar](25) NULL,
	[nombre] [varchar](25) NULL,
	[sexo] [int] NULL,
	[pertEtnica] [int] NULL,
	[edad] [int] NULL,
	[paisReside] [int] NULL,
	[dptoReside] [int] NULL,
	[provReside] [int] NULL,
	[distReside] [int] NULL,
	[tipoVia] [int] NULL,
	[nombreVia] [varchar](50) NULL,
	[numeroVia] [int] NULL,
	[dptoNro] [int] NULL,
	[interior] [int] NULL,
	[manzana] [varchar](10) NULL,
	[nroLote] [int] NULL,
	[nroKm] [int] NULL,
	[nroBlock] [int] NULL,
	[nroEtapa] [int] NULL,
	[tipDocumento] [int] NULL,
	[nrodni] [int] NULL,
	[fecNacimiento] [int] NULL,
	[paisNace] [int] NULL,
	[dptoNace] [int] NULL,
	[provNace] [int] NULL,
	[ditNasce] [int] NULL,
	[fotografia] [varchar](100) NULL,
	[grdInstruccion] [int] NULL,
	[estCivil] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[iddatoReniec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T005_DATOSSUNAT]    Script Date: 6/12/2020 3:33:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T005_DATOSSUNAT](
	[iddatoSunat] [int] NOT NULL,
	[ruc] [int] NULL,
	[estadoRuc] [char](5) NULL,
	[condicionRuc] [char](5) NULL,
	[domiFiscal] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[iddatoSunat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T006_DATOSITEDS]    Script Date: 6/12/2020 3:33:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T006_DATOSITEDS](
	[iddatoSiteds] [int] NOT NULL,
	[cobertura] [int] NULL,
	[ordAtenMed] [char](5) NULL,
	[nomEmpresa] [char](5) NULL,
	[nomAseguradora] [varchar](25) NULL,
	[codAsegurado] [int] NULL,
	[poliza] [int] NULL,
	[parentesco] [varchar](25) NULL,
	[iniVigencia] [date] NULL,
	[finVigencia] [date] NULL,
	[tipoplanSalud] [int] NULL,
	[nroplanSalud] [int] NULL,
	[estadoSeguro] [char](3) NULL,
	[apepatTitular] [varchar](50) NULL,
	[apematTitular] [varchar](50) NULL,
	[tipdocTitular] [int] NULL,
	[nrodocTitular] [int] NULL,
	[tipAfiliacion] [int] NULL,
	[nroAfiliacion] [int] NULL,
	[fecAfiliacion] [date] NULL,
	[codTitular] [int] NULL,
	[moneda] [varchar](25) NULL,
	[nombreContratante] [varchar](25) NULL,
	[tipoDocContratante] [int] NULL,
	[dniContratante] [int] NULL,
	[nroDocuContranate] [int] NULL,
	[planSalud] [varchar](25) NULL,
	[codCobertura] [int] NULL,
	[beneficio] [varchar](25) NULL,
	[restriccion] [varchar](25) NULL,
	[copagoFijo] [int] NULL,
	[copagoVariable] [int] NULL,
	[finCarencia] [int] NULL,
	[producto] [varchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[iddatoSiteds] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T007_MEDICAMENTONRCG]    Script Date: 6/12/2020 3:33:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T007_MEDICAMENTONRCG](
	[idMedicaNrcg] [int] IDENTITY(1,1) NOT NULL,
	[codMedicaNrcg] [varchar](5) NULL,
	[nomIafa] [varchar](35) NULL,
	[seccion] [varchar](40) NULL,
	[subSeccion] [varchar](40) NULL,
	[codSigesa] [varchar](6) NULL,
	[descSigesa] [varchar](45) NULL,
	[codMedicamento] [varchar](5) NULL,
	[nomComercial] [varchar](40) NULL,
	[dci] [varchar](35) NULL,
	[dsDci] [varchar](35) NULL,
	[formFarmaceutico] [varchar](35) NULL,
	[concentracion] [varchar](20) NULL,
	[cie10] [varchar](5) NULL,
	[cie10Excluido] [varchar](250) NULL,
PRIMARY KEY CLUSTERED 
(
	[idMedicaNrcg] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T009_TPPRESTACION]    Script Date: 6/12/2020 3:33:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T009_TPPRESTACION](
	[idtpPrestacion] [int] NOT NULL,
	[codExpedient] [varchar](6) NULL,
	[tpExpedient] [varchar](30) NULL,
	[codIafa] [varchar](6) NULL,
	[descIafa] [varchar](25) NULL,
	[idtpDocuPago] [int] NULL,
	[codDocu] [varchar](6) NULL,
	[descDocu] [varchar](35) NULL,
PRIMARY KEY CLUSTERED 
(
	[idtpPrestacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T011_EMPRCONVENIO]    Script Date: 6/12/2020 3:33:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T011_EMPRCONVENIO](
	[idemprConvenio] [int] NOT NULL,
	[nroOrdEmpr] [int] NULL,
	[codEmpresa] [int] NULL,
	[nomEmpresa] [varchar](50) NULL,
	[codServicio] [int] NULL,
	[modoPago] [int] NULL,
	[descServicio] [varchar](50) NULL,
	[codPlan] [int] NULL,
	[tipAtencion] [int] NULL,
	[coberaAtenTit] [varchar](10) NULL,
	[vigenciaConv] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idemprConvenio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T017_TIPOIAFA]    Script Date: 6/12/2020 3:33:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T017_TIPOIAFA](
	[idtipoIafa] [int] IDENTITY(1,1) NOT NULL,
	[codTipo] [varchar](6) NULL,
	[descripcion] [varchar](65) NULL,
 CONSTRAINT [PK__T017_TIP__1AACB3FABD5A7E98] PRIMARY KEY CLUSTERED 
(
	[idtipoIafa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T018_CIASEGURO]    Script Date: 6/12/2020 3:33:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T018_CIASEGURO](
	[idciaSeguro] [int] IDENTITY(1,1) NOT NULL,
	[codciaSeguro] [varchar](6) NULL,
	[descripcion] [varchar](50) NULL,
	[activo] [char](3) NULL,
 CONSTRAINT [PK__T018_CIA__74C427B571031EF8] PRIMARY KEY CLUSTERED 
(
	[idciaSeguro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T020_TIPOPACIENTE]    Script Date: 6/12/2020 3:33:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T020_TIPOPACIENTE](
	[idtpPaciente] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [varchar](7) NULL,
	[descripcion] [varchar](50) NULL,
	[abreviatura] [varchar](5) NULL,
	[obli] [char](5) NULL,
	[origen] [varchar](15) NULL,
 CONSTRAINT [PK__T020_TIP__C3B1765F4C08A546] PRIMARY KEY CLUSTERED 
(
	[idtpPaciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T022_TARIFA]    Script Date: 6/12/2020 3:33:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T022_TARIFA](
	[idTarifa] [int] NOT NULL,
	[codTarifa] [varchar](6) NULL,
	[nomTarifa] [varchar](50) NULL,
	[tarifaBase] [varchar](50) NULL,
	[idIafa] [int] NOT NULL,
	[estado] [char](3) NULL,
PRIMARY KEY CLUSTERED 
(
	[idTarifa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T031_PREFACTURACION]    Script Date: 6/12/2020 3:33:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T031_PREFACTURACION](
	[idPrefacturacion] [int] NOT NULL,
	[codEmpresa] [varchar](6) NULL,
	[descripcion] [varchar](30) NULL,
	[modoPago] [int] NULL,
	[vigencia] [int] NULL,
	[periodo] [varchar](25) NULL,
	[diaplazo] [int] NULL,
	[observacion] [varchar](35) NULL,
PRIMARY KEY CLUSTERED 
(
	[idPrefacturacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T056_PATOGESTACION]    Script Date: 6/12/2020 3:33:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T056_PATOGESTACION](
	[idPatoGestacion] [int] NOT NULL,
	[codPatoGestacion] [int] NULL,
	[descripcion] [varchar](35) NULL,
	[abreviatura] [char](5) NULL,
	[obligatorio] [char](5) NULL,
	[fuente] [varchar](35) NULL,
	[observacion] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idPatoGestacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T057_RELIGION]    Script Date: 6/12/2020 3:33:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T057_RELIGION](
	[idReligion] [int] IDENTITY(1,1) NOT NULL,
	[codReligion] [varchar](6) NULL,
	[descripcion] [varchar](35) NULL,
	[abreviatura] [char](5) NULL,
	[fuente] [varchar](30) NULL,
	[observacion] [varchar](35) NULL,
 CONSTRAINT [PK__T057_REL__21E8CB05BF07FCF5] PRIMARY KEY CLUSTERED 
(
	[idReligion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T068_CITA]    Script Date: 6/12/2020 3:33:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T068_CITA](
	[idCita] [int] IDENTITY(1,1) NOT NULL,
	[codCita] [int] NULL,
	[nroCita] [int] NULL,
	[descripcion] [varchar](60) NULL,
	[fechaCita] [datetime] NULL,
	[ultCie10] [varchar](5) NULL,
	[tpAtencion] [varchar](30) NULL,
	[nroHC] [int] NULL,
	[idEstadoCita] [int] NULL,
	[idEstaGralPac] [int] NULL,
	[estadoReprogram] [char](5) NULL,
	[ejecutado] [char](5) NULL,
	[prioridad] [char](5) NULL,
	[precio] [decimal](18, 6) NULL,
	[descuento] [decimal](18, 6) NULL,
	[coa] [decimal](18, 6) NULL,
	[igv] [decimal](18, 6) NULL,
	[tipoCita] [varchar](35) NULL,
	[motivoRepro] [varchar](80) NULL,
	[motivoAnula] [varchar](80) NULL,
	[idPaciente] [int] NULL,
	[idEmpleado] [int] NULL,
	[idConsultorio] [int] NULL,
	[idProgramMedica] [int] NULL,
	[idservicioCli] [int] NULL,
	[estado] [char](8) NULL,
 CONSTRAINT [PK__T068_CIT__814F3126E4AA01D5] PRIMARY KEY CLUSTERED 
(
	[idCita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T071_SEXO]    Script Date: 6/12/2020 3:33:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T071_SEXO](
	[idSexo] [int] IDENTITY(1,1) NOT NULL,
	[codSexo] [int] NULL,
	[descripcion] [varchar](20) NULL,
	[abreviatura] [char](5) NULL,
	[origen] [varchar](15) NULL,
 CONSTRAINT [PK__T071_SEX__C5AFCD4D5E6E470B] PRIMARY KEY CLUSTERED 
(
	[idSexo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T072_HISTOCLINICA]    Script Date: 6/12/2020 3:33:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T072_HISTOCLINICA](
	[idHistoriClinica] [int] IDENTITY(1,1) NOT NULL,
	[codhc] [varchar](6) NULL,
	[descripcion] [varchar](45) NULL,
	[anho] [varchar](10) NULL,
	[mes] [varchar](15) NULL,
	[semana] [varchar](15) NULL,
	[dia] [varchar](15) NULL,
	[numhc] [varchar](9) NULL,
	[prioridad] [varchar](15) NULL,
	[codInforme] [varchar](6) NULL,
	[empresaIafa] [varchar](45) NULL,
	[cie10] [varchar](9) NULL,
	[tpDiagnostico] [varchar](35) NULL,
	[diagnostico] [varchar](45) NULL,
	[interpretacion] [varchar](90) NULL,
	[conclusion] [varchar](90) NULL,
	[fecElaboracion] [date] NULL,
	[hrElaboracion] [varchar](8) NULL,
	[firmaDigital] [varchar](70) NULL,
	[codEcografia] [varchar](8) NULL,
	[dsEcografia] [varchar](70) NULL,
	[uniMedina] [varchar](30) NULL,
	[cantidad] [int] NULL,
	[stockIni] [int] NULL,
	[stockFin] [int] NULL,
	[anhoEcogra] [varchar](10) NULL,
	[mesEcogra] [varchar](20) NULL,
	[diaEcogra] [varchar](15) NULL,
	[codRequerimiento] [varchar](5) NULL,
	[fecSolicitud] [date] NULL,
	[fecVence] [date] NULL,
	[usuSolicitante] [varchar](55) NULL,
	[almacenSoli] [varchar](55) NULL,
	[codInsumo] [varchar](8) NULL,
	[dsInsumo] [varchar](55) NULL,
	[uniMedida] [varchar](5) NULL,
	[cantSolicitante] [varchar](5) NULL,
	[cantRecibida] [varchar](5) NULL,
	[lote] [varchar](5) NULL,
	[nroTransfer] [varchar](15) NULL,
	[recepcion] [varchar](55) NULL,
	[stock] [int] NULL,
	[observacion] [varchar](90) NULL,
	[fecPago] [datetime] NULL,
	[horaPago] [varchar](5) NULL,
	[nroOrden] [varchar](5) NULL,
	[tallaPac] [varchar](5) NULL,
	[pesoPac] [varchar](5) NULL,
	[menopaucia] [varchar](5) NULL,
	[fecMenopaucia] [date] NULL,
	[edadIniMeno] [varchar](5) NULL,
	[fecFractura] [date] NULL,
	[anatomicoFrac] [varchar](5) NULL,
	[mecaFractura] [varchar](5) NULL,
	[fracCadera] [varchar](5) NULL,
	[fumadorActivo] [varchar](5) NULL,
	[glucorticoides] [varchar](35) NULL,
	[artritiReuma] [varchar](35) NULL,
	[osteoporosiSec] [varchar](35) NULL,
	[alcoholDosis] [varchar](35) NULL,
	[fecTomaAlcohol] [date] NULL,
	[hrTomaAlcohol] [varchar](5) NULL,
	[diagDensi] [varchar](45) NULL,
	[areaDensi] [varchar](45) NULL,
	[staDensi] [varchar](5) NULL,
	[prioridadDensi] [varchar](45) NULL,
	[fecIniDensi] [date] NULL,
	[fecFinDensi] [date] NULL,
	[planInfoDensi] [varchar](45) NULL,
	[infoDensi] [varchar](45) NULL,
	[idCita] [int] NULL,
	[idPaciente] [int] NULL,
	[idMedico] [int] NULL,
	[idEspecialidad] [int] NULL,
	[estado] [char](8) NULL,
PRIMARY KEY CLUSTERED 
(
	[idHistoriClinica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T080_TPDOCUPAGO]    Script Date: 6/12/2020 3:33:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T080_TPDOCUPAGO](
	[idtpDocuPago] [int] IDENTITY(1,1) NOT NULL,
	[codDocuPago] [varchar](6) NULL,
	[descripcion] [varchar](55) NULL,
 CONSTRAINT [PK__T080_TPD__291BE33942685099] PRIMARY KEY CLUSTERED 
(
	[idtpDocuPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T083_PERITORIO]    Script Date: 6/12/2020 3:33:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T083_PERITORIO](
	[idPeritorio] [int] NOT NULL,
	[codPeritorio] [varchar](5) NOT NULL,
	[descripcion] [varchar](35) NULL,
PRIMARY KEY CLUSTERED 
(
	[idPeritorio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T109_ESTADOCITA]    Script Date: 6/12/2020 3:33:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T109_ESTADOCITA](
	[idEstadoCita] [int] IDENTITY(1,1) NOT NULL,
	[codEstadoCita] [varchar](5) NULL,
	[estado] [varchar](20) NULL,
	[origen] [varchar](150) NULL,
 CONSTRAINT [PK__T109_EST__FDA623A13B1651F0] PRIMARY KEY CLUSTERED 
(
	[idEstadoCita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T119_PERFILSALUD]    Script Date: 6/12/2020 3:33:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T119_PERFILSALUD](
	[idPerfilSalud] [int] NOT NULL,
	[codPerfilSalud] [varchar](4) NULL,
	[descPerfil] [varchar](40) NULL,
	[estado] [char](5) NULL,
	[codEspecial] [varchar](4) NULL,
	[descEspecial] [varchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[idPerfilSalud] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T120_EMPLEADO]    Script Date: 6/12/2020 3:33:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T120_EMPLEADO](
	[idEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[genero] [varchar](50) NULL,
	[salario] [int] NULL,
	[precio] [decimal](16, 5) NULL,
	[fecIngreso] [date] NULL,
	[idtpEmpleado] [int] NULL,
	[codEmpleado] [varchar](6) NULL,
	[descArea] [varchar](50) NULL,
	[cargo] [varchar](40) NULL,
	[idPersona] [int] NULL,
	[estado] [char](5) NULL,
 CONSTRAINT [PK__T120_EMP__5295297C978D2F8E] PRIMARY KEY CLUSTERED 
(
	[idEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T120_ESPECIALIDAD]    Script Date: 6/12/2020 3:33:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T120_ESPECIALIDAD](
	[idEspecialidad] [int] IDENTITY(1,1) NOT NULL,
	[codEspecial] [varchar](6) NULL,
	[codSigesa] [varchar](5) NULL,
	[descripcion] [varchar](40) NULL,
	[codSubEspecial] [varchar](6) NULL,
	[descSubEspecial] [varchar](30) NULL,
 CONSTRAINT [PK__T120_ESP__E8AB16005F40EFAE] PRIMARY KEY CLUSTERED 
(
	[idEspecialidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T126_GPOSANGRE]    Script Date: 6/12/2020 3:33:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T126_GPOSANGRE](
	[idgpoSangre] [int] IDENTITY(1,1) NOT NULL,
	[codgpoSangre] [varchar](6) NULL,
	[descripcion] [varchar](20) NULL,
	[abreviatura] [char](4) NULL,
 CONSTRAINT [PK__T126_GPO__1469320EB02BD464] PRIMARY KEY CLUSTERED 
(
	[idgpoSangre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T128_TPRECETAELECTRO]    Script Date: 6/12/2020 3:33:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T128_TPRECETAELECTRO](
	[idtpRecetaElec] [int] NOT NULL,
	[codtpRecetaElec] [varchar](15) NOT NULL,
	[descripcion] [varchar](15) NULL,
	[estado] [char](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[idtpRecetaElec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T129_ESTADOATENCION]    Script Date: 6/12/2020 3:33:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T129_ESTADOATENCION](
	[idEstAtencion] [int] NOT NULL,
	[codEstAtencion] [int] NULL,
	[descripcion] [varchar](20) NULL,
	[detalle] [varchar](50) NULL,
	[abreviatura] [char](5) NULL,
	[visualizado] [char](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[idEstAtencion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T139_TPPACFRECUENTE]    Script Date: 6/12/2020 3:33:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T139_TPPACFRECUENTE](
	[idtpPacFrecuente] [int] NOT NULL,
	[codtpPacFrecuente] [int] NULL,
	[descripcion] [varchar](25) NULL,
	[detalle] [varchar](60) NULL,
PRIMARY KEY CLUSTERED 
(
	[idtpPacFrecuente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T140_FORMATOANXHIS]    Script Date: 6/12/2020 3:33:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T140_FORMATOANXHIS](
	[idFormatAnxHis] [int] NOT NULL,
	[codigo] [varchar](3) NULL,
	[modulo] [varchar](50) NULL,
	[codFormato] [varchar](8) NULL,
	[formato] [varchar](30) NULL,
	[tipoDocu] [varchar](20) NULL,
	[descripcion] [varchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[idFormatAnxHis] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T144_CLASIFIATENCION]    Script Date: 6/12/2020 3:33:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T144_CLASIFIATENCION](
	[idClasifiAtencion] [int] NOT NULL,
	[codClasifiAtencion] [int] NULL,
	[descripcion] [varchar](20) NULL,
	[detalle] [varchar](50) NULL,
	[abreviatura] [char](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[idClasifiAtencion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T145_DATOSPACHCE]    Script Date: 6/12/2020 3:33:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T145_DATOSPACHCE](
	[idDatospacHCE] [int] NOT NULL,
	[codDatospacHCE] [int] NULL,
	[descripcion] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idDatospacHCE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T146_ATCSUSTANCIA]    Script Date: 6/12/2020 3:33:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T146_ATCSUSTANCIA](
	[idAtcSustancia] [int] NOT NULL,
	[codATC] [int] NULL,
	[levelage] [int] NULL,
	[descIngles] [varchar](80) NULL,
	[descEspanol] [varchar](80) NULL,
	[nivel] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idAtcSustancia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T147_CIE10ESPECIALIDAD]    Script Date: 6/12/2020 3:33:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T147_CIE10ESPECIALIDAD](
	[idCIE10Especial] [int] NOT NULL,
	[orden] [int] NULL,
	[descDiagnostico] [varchar](80) NULL,
PRIMARY KEY CLUSTERED 
(
	[idCIE10Especial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T148_HOJASITEDS]    Script Date: 6/12/2020 3:33:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T148_HOJASITEDS](
	[idHojaSiteds] [int] NOT NULL,
	[codigo] [varchar](5) NULL,
	[grupo] [varchar](40) NULL,
	[campos] [varchar](50) NULL,
	[componentHIS] [varchar](50) NULL,
	[oblig] [varchar](4) NULL,
PRIMARY KEY CLUSTERED 
(
	[idHojaSiteds] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T149_PROTOCOLO]    Script Date: 6/12/2020 3:33:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T149_PROTOCOLO](
	[idProtocolo] [int] NOT NULL,
	[cie10] [varchar](5) NULL,
	[descripcion] [varchar](40) NULL,
	[tpPlanork] [varchar](40) NULL,
	[codProtocolo] [varchar](5) NULL,
	[resumen] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idProtocolo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T172_TPDOCUMENTO]    Script Date: 6/12/2020 3:33:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T172_TPDOCUMENTO](
	[idtpDocumento] [int] IDENTITY(1,1) NOT NULL,
	[codtpDocumento] [varchar](6) NOT NULL,
	[descripcion] [varchar](45) NULL,
	[abreviatura] [char](12) NULL,
	[fuente] [varchar](65) NULL,
 CONSTRAINT [PK__T172_TPD__4287F65C3E5A2B98] PRIMARY KEY CLUSTERED 
(
	[idtpDocumento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T175_LABORATORIO]    Script Date: 6/12/2020 3:33:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T175_LABORATORIO](
	[idLaboratorio] [int] IDENTITY(1,1) NOT NULL,
	[codCentroCosto] [varchar](5) NULL,
	[centroCosto] [varchar](40) NULL,
	[codigo] [varchar](6) NULL,
	[descripcion] [varchar](80) NULL,
	[origen] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[idLaboratorio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T185_FACTORRH]    Script Date: 6/12/2020 3:33:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T185_FACTORRH](
	[idFactorrh] [int] IDENTITY(1,1) NOT NULL,
	[codFactorrh] [varchar](6) NULL,
	[descripcion] [varchar](25) NULL,
	[fuente] [varchar](35) NULL,
 CONSTRAINT [PK__T185_FAC__FD320464146FDCE0] PRIMARY KEY CLUSTERED 
(
	[idFactorrh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T188_TPPARTODETA]    Script Date: 6/12/2020 3:33:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T188_TPPARTODETA](
	[idtpPartoDeta] [int] NOT NULL,
	[codtpPartoDeta] [varchar](6) NULL,
	[nivel] [varchar](15) NULL,
	[descripcion] [varchar](45) NULL,
	[fuente] [varchar](45) NULL,
	[obs] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idtpPartoDeta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T192_PARENTESCO]    Script Date: 6/12/2020 3:33:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T192_PARENTESCO](
	[idParentesco] [int] IDENTITY(1,1) NOT NULL,
	[codParentesco] [varchar](6) NULL,
	[descripcion] [varchar](25) NULL,
	[abreviatura] [char](4) NULL,
	[fuente] [varchar](35) NULL,
 CONSTRAINT [PK__T192_PAR__9FA875F1BA52DB7A] PRIMARY KEY CLUSTERED 
(
	[idParentesco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T193_PATOLOGIANACE]    Script Date: 6/12/2020 3:33:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T193_PATOLOGIANACE](
	[idPatologiaNace] [int] NOT NULL,
	[codPatologiaNace] [varchar](6) NULL,
	[descripcion] [varchar](45) NULL,
	[fuente] [varchar](45) NULL,
	[obs] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idPatologiaNace] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T194_TPEMBARAZO]    Script Date: 6/12/2020 3:33:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T194_TPEMBARAZO](
	[idtpEmbarazo] [int] NOT NULL,
	[codtpEmbarazo] [varchar](4) NULL,
	[descripcion] [varchar](25) NULL,
	[abreviatura] [char](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[idtpEmbarazo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T196_TPPROCPSICO]    Script Date: 6/12/2020 3:33:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T196_TPPROCPSICO](
	[idtpProcPsico] [int] NOT NULL,
	[codtpProcPsico] [varchar](6) NULL,
	[modulo] [varchar](35) NULL,
PRIMARY KEY CLUSTERED 
(
	[idtpProcPsico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T198_GRADINSTRUCCION]    Script Date: 6/12/2020 3:33:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T198_GRADINSTRUCCION](
	[idGrdInstruc] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [varchar](5) NULL,
	[descripcion] [varchar](35) NULL,
	[abreviatura] [char](5) NULL,
	[fuente] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idGrdInstruc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T199_ESTCIVIL]    Script Date: 6/12/2020 3:33:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T199_ESTCIVIL](
	[idEstCivil] [int] IDENTITY(1,1) NOT NULL,
	[codEstCivil] [varchar](6) NULL,
	[descripcion] [varchar](45) NULL,
	[abreviatura] [char](5) NULL,
	[fuente] [varchar](30) NULL,
 CONSTRAINT [PK__T199_EST__FB343C74851A899A] PRIMARY KEY CLUSTERED 
(
	[idEstCivil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T200_OCUPACION]    Script Date: 6/12/2020 3:33:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T200_OCUPACION](
	[idOcupacion] [int] IDENTITY(1,1) NOT NULL,
	[codOcupacion] [varchar](6) NULL,
	[descripcion] [varchar](40) NULL,
	[abreviatura] [char](4) NULL,
	[fuente] [varchar](45) NULL,
 CONSTRAINT [PK__T200_OCU__BE5FA2043A777C80] PRIMARY KEY CLUSTERED 
(
	[idOcupacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T201_ESTADOACTUAL]    Script Date: 6/12/2020 3:33:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T201_ESTADOACTUAL](
	[idEstaActual] [int] NOT NULL,
	[codEstaActual] [int] NOT NULL,
	[nivel1] [varchar](40) NULL,
	[descripcion] [varchar](45) NULL,
PRIMARY KEY CLUSTERED 
(
	[idEstaActual] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T202_ANAMNESIALI]    Script Date: 6/12/2020 3:33:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T202_ANAMNESIALI](
	[idAnamnesiAli] [int] NOT NULL,
	[codAnamnesiAli] [int] NOT NULL,
	[descripcion] [varchar](45) NULL,
	[abreviatura] [char](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[idAnamnesiAli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T203_FRECONSUMOALI]    Script Date: 6/12/2020 3:33:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T203_FRECONSUMOALI](
	[idFreconsumoAli] [int] NOT NULL,
	[codFreconsumoAli] [int] NOT NULL,
	[nivel1] [varchar](40) NULL,
	[descripcion] [varchar](45) NULL,
PRIMARY KEY CLUSTERED 
(
	[idFreconsumoAli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T204_EVALUAALI]    Script Date: 6/12/2020 3:33:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T204_EVALUAALI](
	[idEvaluaAli] [int] NOT NULL,
	[codEvaluaAli] [int] NOT NULL,
	[descripcion] [varchar](60) NULL,
	[fuente] [varchar](30) NULL,
	[obs] [varchar](30) NULL,
	[consideracion] [varchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[idEvaluaAli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T205_EDADEVALUAALI]    Script Date: 6/12/2020 3:33:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T205_EDADEVALUAALI](
	[idEdadEvaluaAli] [int] NOT NULL,
	[codEdadEvaluaAli] [int] NOT NULL,
	[descripcion] [varchar](15) NULL,
	[fuente] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[idEdadEvaluaAli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T208_ESTADONUTRICION]    Script Date: 6/12/2020 3:33:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T208_ESTADONUTRICION](
	[idEstaNutricion] [int] NOT NULL,
	[codEstaNutricion] [int] NOT NULL,
	[descripcion] [varchar](50) NULL,
	[origen] [varchar](35) NULL,
	[obs] [varchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[idEstaNutricion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T212_MEDICO]    Script Date: 6/12/2020 3:33:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T212_MEDICO](
	[idMedico] [int] IDENTITY(1,1) NOT NULL,
	[codMedico] [varchar](6) NULL,
	[nroColegio] [int] NULL,
	[nroRne] [varchar](6) NULL,
	[nroRuc] [int] NULL,
	[idtpDocumento] [int] NULL,
	[condicion] [varchar](20) NULL,
	[idEmpleado] [int] NULL,
	[idEspecialidad] [int] NULL,
	[idPersona] [int] NULL,
	[estado] [varchar](10) NULL,
 CONSTRAINT [PK__T212_MED__4E03DEBAD92F7BA8] PRIMARY KEY CLUSTERED 
(
	[idMedico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T213_RECETAELEC]    Script Date: 6/12/2020 3:33:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T213_RECETAELEC](
	[idReceta] [int] IDENTITY(1,1) NOT NULL,
	[idPaciente] [int] NOT NULL,
	[sexo] [varchar](15) NULL,
	[edad] [varchar](10) NULL,
	[peso] [varchar](10) NULL,
	[tpPaciente] [int] NOT NULL,
	[idIafa] [int] NOT NULL,
	[empresa] [varchar](50) NULL,
	[modoPago] [varchar](25) NULL,
	[idCie10] [int] NOT NULL,
	[descCie10] [varchar](50) NULL,
	[descDCI] [varchar](10) NULL,
	[nomComercial] [varchar](50) NULL,
	[concentracion] [varchar](10) NULL,
	[formFarmacia] [varchar](10) NULL,
	[dosis] [varchar](10) NULL,
	[via] [varchar](10) NULL,
	[frecuencia] [varchar](10) NULL,
	[duracion] [varchar](10) NULL,
	[cantidad] [int] NULL,
	[observacion] [varchar](60) NULL,
	[idCita] [int] NULL,
	[delivery] [char](3) NULL,
PRIMARY KEY CLUSTERED 
(
	[idReceta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T218_SERVICIOSCLI]    Script Date: 6/12/2020 3:33:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T218_SERVICIOSCLI](
	[idservicioCli] [int] NOT NULL,
	[descripcion] [varchar](35) NULL,
	[estado] [char](10) NULL,
 CONSTRAINT [PK__T218_SER__C162F34C8B31AA5A] PRIMARY KEY CLUSTERED 
(
	[idservicioCli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T257_EXAMESPECIAL]    Script Date: 6/12/2020 3:33:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T257_EXAMESPECIAL](
	[idExamSpecial] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [varchar](8) NULL,
	[descripcion] [varchar](40) NULL,
	[nombreCorto] [varchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[idExamSpecial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T263_GPONUTRICION]    Script Date: 6/12/2020 3:33:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T263_GPONUTRICION](
	[idgpoNutricion] [int] NOT NULL,
	[codgpoNutricion] [int] NOT NULL,
	[descripcion] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idgpoNutricion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T264_VALORNUTRICION]    Script Date: 6/12/2020 3:33:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T264_VALORNUTRICION](
	[idvalorNutricion] [int] NOT NULL,
	[codvalorNutricion] [int] NOT NULL,
	[indicador] [varchar](30) NULL,
	[unidad] [varchar](8) NULL,
PRIMARY KEY CLUSTERED 
(
	[idvalorNutricion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T267_ESQUEMALIMENTO]    Script Date: 6/12/2020 3:33:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T267_ESQUEMALIMENTO](
	[idEsquemaAli] [int] NOT NULL,
	[codGrupo] [int] NOT NULL,
	[grupo] [varchar](20) NULL,
	[codCampos] [varchar](30) NULL,
	[campos] [varchar](30) NULL,
	[unidad] [varchar](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[idEsquemaAli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T268_INVENTALIMENTO]    Script Date: 6/12/2020 3:33:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T268_INVENTALIMENTO](
	[idInventAlimento] [int] NOT NULL,
	[codigo] [int] NOT NULL,
	[descripcion] [varchar](50) NULL,
	[kca] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[idInventAlimento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T269_RECOMENDANUTRI]    Script Date: 6/12/2020 3:33:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T269_RECOMENDANUTRI](
	[idRecomendaNutri] [int] NOT NULL,
	[codrecomendaNutri] [int] NOT NULL,
	[descripcion] [varchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[idRecomendaNutri] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T277_FORMATONUTRI]    Script Date: 6/12/2020 3:33:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T277_FORMATONUTRI](
	[idFormatoNutri] [int] NOT NULL,
	[grupo] [varchar](35) NULL,
	[codFormato] [varchar](4) NULL,
	[formato] [varchar](150) NULL,
	[via] [varchar](15) NULL,
	[ruta] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[idFormatoNutri] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T278_TIPOLACTANCIA]    Script Date: 6/12/2020 3:33:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T278_TIPOLACTANCIA](
	[idtpLactancia] [int] NOT NULL,
	[codLactancia] [varchar](5) NULL,
	[descripcion] [varchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[idtpLactancia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T280_ANTROPOMETRICO]    Script Date: 6/12/2020 3:33:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T280_ANTROPOMETRICO](
	[idAntropometrico] [int] NOT NULL,
	[tipo] [varchar](25) NULL,
	[valores] [varchar](35) NULL,
	[abreviatura] [varchar](8) NULL,
	[unidad] [varchar](2) NULL,
	[udmcorta] [varchar](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[idAntropometrico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TMP_CRONOMEDICO]    Script Date: 6/12/2020 3:33:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TMP_CRONOMEDICO](
	[idProgramMedica] [int] IDENTITY(1,1) NOT NULL,
	[mes] [varchar](20) NULL,
	[semana] [varchar](20) NULL,
	[dia] [varchar](20) NULL,
	[fecProgramMedica] [datetime] NULL,
	[idMedico] [int] NULL,
	[idEspecialidad] [int] NULL,
	[idConsultorio] [int] NULL,
	[hrInicio] [varchar](6) NULL,
	[hrFin] [varchar](6) NULL,
	[estado] [char](5) NULL,
	[turno] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[idProgramMedica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TMP_PACIENTE]    Script Date: 6/12/2020 3:33:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TMP_PACIENTE](
	[idPaciente] [int] IDENTITY(1,1) NOT NULL,
	[codPaciente] [int] NOT NULL,
	[descripcion] [varchar](50) NULL,
	[nrohc] [varchar](50) NULL,
	[nombreAcom] [varchar](50) NULL,
	[edadAcom] [int] NULL,
	[dniAcom] [int] NULL,
	[idgpoSangre] [varchar](50) NULL,
	[idFactorrrh] [varchar](50) NULL,
	[cobertura] [varchar](50) NULL,
	[ordenAtenMed] [varchar](25) NULL,
	[nomAseguradora] [varchar](50) NULL,
	[codAsegurado] [varchar](15) NULL,
	[poliza] [varchar](35) NULL,
	[parentesco] [varchar](35) NULL,
	[iniVigencia] [datetime] NULL,
	[finVigencia] [datetime] NULL,
	[tpPlanSalud] [varchar](40) NULL,
	[nroplanSalud] [int] NULL,
	[estadoSeguro] [char](10) NULL,
	[tpAfiliacion] [varchar](30) NULL,
	[fecAfiliacion] [datetime] NULL,
	[codTitular] [int] NULL,
	[moneda] [varchar](30) NULL,
	[nomContratante] [varchar](35) NULL,
	[tpDocumento] [varchar](35) NULL,
	[dniContratante] [int] NULL,
	[planSalud] [varchar](40) NULL,
	[codCobertura] [int] NULL,
	[beneficio] [varchar](50) NULL,
	[restriccion] [varchar](50) NULL,
	[copagoFijo] [int] NULL,
	[copagoVariable] [int] NULL,
	[finCarencia] [int] NULL,
	[convenio] [varchar](40) NULL,
	[descuento] [decimal](18, 0) NULL,
	[codPaConvenio] [varchar](6) NULL,
	[dsPacConv] [varchar](40) NULL,
	[statPaconv] [char](10) NULL,
	[codPacSoat] [varchar](6) NULL,
	[dsPacSoat] [varchar](40) NULL,
	[statPacSoat] [char](10) NULL,
	[codpacExterno] [varchar](6) NULL,
	[dspacExter] [varchar](40) NULL,
	[stapacexter] [char](10) NULL,
	[tpPaciente] [varchar](9) NULL,
	[idPersona] [int] NULL,
	[hojafiliacion] [bit] NULL,
	[concienteDato] [bit] NULL,
	[estado] [char](10) NULL,
 CONSTRAINT [PK__TMP_PACI__F48A08F20AFB57BB] PRIMARY KEY CLUSTERED 
(
	[idPaciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[D00_TBDETALLE] ON 
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (1, N'TPD001', N'LIBRETA ELECTORAL O DNI', N'L.E/ DNI', N'www.sunat.gob.pe/pdt/pdtModulos/independientes/p695/TipoDoc.htm', N'          ', 1)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (2, N'TPD002', N'CARNET DE EXTRANJERIA', N'CARNET EXT', N'www.sunat.gob.pe/pdt/pdtModulos/independientes/p695/TipoDoc.htm', N'          ', 1)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (3, N'TPD003', N'REGISTRO UNICO CONTRIBUYENTES', N'RUC', N'www.sunat.gob.pe/pdt/pdtModulos/independientes/p695/TipoDoc.htm', N'          ', 1)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (4, N'TPD004', N'PASAPORTE', N'', N'www.sunat.gob.pe/pdt/pdtModulos/independientes/p695/TipoDoc.htm', N'          ', 1)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (5, N'TPD005', N'PARTIDA NACIMIENTO -IDENTIDAD', N'', N'www.sunat.gob.pe/pdt/pdtModulos/independientes/p695/TipoDoc.htm', N'          ', 1)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (6, N'TPD006', N'OTROS', N'', N'www.sunat.gob.pe/pdt/pdtModulos/independientes/p695/TipoDoc.htm', N'          ', 1)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (7, N'SEX0001', N'MASCULINO', N'M', N'', N'          ', 2)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (8, N'SEX0002', N'FEMENINO', N'F', N'', N'          ', 2)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (9, N'GRD0001', N'SIN INSTRUCCIÓN', N'SI', N'NTS N° 139 MINSA/2018/DGAIN', N'          ', 3)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (10, N'GRD0002', N'INICIAL', N'I', N'NTS N° 139 MINSA/2018/DGAIN', N'          ', 3)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (11, N'GRD0001', N'PRIMARIA COMPLETA', N'PC', N'NTS N° 139 MINSA/2018/DGAIN', N'          ', 3)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (12, N'GRD0002', N'PRIMARIA INCOMPLETA', N'PI', N'NTS N° 139 MINSA/2018/DGAIN', N'          ', 3)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (13, N'GRD0001', N'SECUNDARIA COMPLETA', N'SC', N'NTS N° 139 MINSA/2018/DGAIN', N'          ', 3)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (14, N'GRD0002', N'SECUNDARIA INCOMPLETA', N'SI', N'NTS N° 139 MINSA/2018/DGAIN', N'          ', 3)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (15, N'GRD0001', N'SUPERIOR COMPLETO	', N'SUC', N'NTS N° 139 MINSA/2018/DGAIN', N'          ', 3)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (16, N'GRD0001', N'SUPERIOR INCOMPLETO', N'SUI', N'NTS N° 139 MINSA/2018/DGAIN', N'          ', 3)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (17, N'EDC001', N'SOLTERA/O', N'S', N'NTS N° 139 MINSA/2018/DGAIN', N'          ', 4)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (18, N'EDC002', N'CONVIVIENTE', N'CO', N'NTS N° 139 MINSA/2018/DGAIN', N'          ', 4)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (19, N'EDC003', N'CASADA/O', N'C', N'NTS N° 139 MINSA/2018/DGAIN', N'          ', 4)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (20, N'EDC004', N'SEPARADA/O', N'SP', N'NTS N° 139 MINSA/2018/DGAIN', N'          ', 4)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (21, N'EDC005', N'DIVORCIADA/O', N'D', N'NTS N° 139 MINSA/2018/DGAIN', N'          ', 4)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (22, N'EDC006', N'VIUDA/O', N'V', N'NTS N° 139 MINSA/2018/DGAIN', N'          ', 4)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (23, N'EDC007', N'OTROS', N'O', N'NTS N° 139 MINSA/2018/DGAIN', N'          ', 4)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (24, N'DHO001', N'TRABAJADOR/A ESTABLE', N'S', N'NTS N° 139 MINSA/2018/DGAIN', N'          ', 5)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (25, N'DHO002', N'EVENTUAL', N'V', N'NTS N° 139 MINSA/2018/DGAIN', N'          ', 5)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (26, N'DHO003', N'SIN OCUPACION', N'SO', N'NTS N° 139 MINSA/2018/DGAIN', N'          ', 5)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (27, N'DHO004', N'JUBILADA/O', N'J', N'NTS N° 139 MINSA/2018/DGAIN', N'          ', 5)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (28, N'DHO005', N'ESTUDIANTE', N'E', N'NTS N° 139 MINSA/2018/DGAIN', N'          ', 5)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (29, N'G00001', N'AB POSITIVO', N'AB+', N'', N'          ', 6)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (30, N'G00002', N'AB NEGATIVO', N'AB-', N'', N'          ', 6)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (31, N'G00003', N'A POSITIVO', N'A+', N'', N'          ', 6)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (32, N'G00004', N'A NEGATIVO', N'A-', N'', N'          ', 6)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (33, N'G00005', N'B POSITIVO', N'B+', N'', N'          ', 6)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (34, N'G00006', N'B NEGATIVO', N'B-', N'', N'          ', 6)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (35, N'G00007', N'O POSITIVO', N'O+', N'', N'          ', 6)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (36, N'G00008', N'O NEGATIVO', N'O-', N'', N'          ', 6)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (37, N'G00009', N'NO REFIERE', N'', N'', N'          ', 6)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (38, N'DHC035', N'POSITIVO', N'+', N'NTS N° 139 MINSA/2018/DGAIN', N'          ', 7)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (39, N'DHC035', N'NEGATIVO', N'-', N'NTS N° 139 MINSA/2018/DGAIN', N'          ', 7)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (40, N'ANP001', N'PADRE', N'P', N'NTS N° 139 MINSA/2018/DGAIN', N'          ', 8)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (41, N'ANP002', N'MADRE', N'M', N'NTS N° 139 MINSA/2018/DGAIN', N'          ', 8)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (42, N'ANP003', N'HIJO/A', N'H', N'NTS N° 139 MINSA/2018/DGAIN', N'          ', 8)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (43, N'ANP004', N'ABUELA/O', N'A', N'NTS N° 139 MINSA/2018/DGAIN', N'          ', 8)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (44, N'ANP005', N'TIA/O', N'T', N'NTS N° 139 MINSA/2018/DGAIN', N'          ', 8)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (45, N'ANP006', N'NIETA/O', N'N', N'NTS N° 139 MINSA/2018/DGAIN', N'          ', 8)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (46, N'ANP007', N'PADRASTRO', N'PA', N'NTS N° 139 MINSA/2018/DGAIN', N'          ', 8)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (47, N'ANP008', N'MADRASTRA', N'MA', N'NTS N° 139 MINSA/2018/DGAIN', N'          ', 8)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (48, N'ANP009', N'SOBRINA/O', N'S', N'NTS N° 139 MINSA/2018/DGAIN', N'          ', 8)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (49, N'ANP010', N'PRIMA/O', N'PR', N'NTS N° 139 MINSA/2018/DGAIN', N'          ', 8)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (50, N'ANP011', N'BIS-ABUELA/O', N'BA', N'NTS N° 139 MINSA/2018/DGAIN', N'          ', 8)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (51, N'ANP012', N'AMIGA/O', N'AMG', N'NTS N° 139 MINSA/2018/DGAIN', N'          ', 8)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (52, N'ANP013', N'HERMANA/O', N'HM', N'NTS N° 139 MINSA/2018/DGAIN', N'          ', 8)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (53, N'ANP014', N'YERNO', N'Y', N'NTS N° 139 MINSA/2018/DGAIN', N'          ', 8)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (54, N'ANP015', N'NUERA', N'NA', N'NTS N° 139 MINSA/2018/DGAIN', N'          ', 8)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (55, N'TPV001', N'ALAMEDA', N'AL', N'', N'          ', 9)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (56, N'TPV002', N'AVENIDA', N'AV', N'', N'          ', 9)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (57, N'TPV003', N'BAJADA', N'BA', N'', N'          ', 9)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (58, N'TPV004', N'BOULEVARD', N'BO', N'', N'          ', 9)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (59, N'TPV005', N'CALLE', N'CA', N'', N'          ', 9)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (60, N'TPV006', N'CALLEJON', N'CLL', N'', N'          ', 9)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (61, N'TPV07', N'CAMINO', N'CM', N'', N'          ', 9)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (62, N'TPV008', N'CARRETERA', N'CR', N'', N'          ', 9)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (63, N'TPV009', N'CUESTA', N'CU', N'', N'          ', 9)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (64, N'TPV010', N'GALERIA', N'GA', N'', N'          ', 9)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (65, N'TPV011', N'JIRON', N'JR', N'', N'          ', 9)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (66, N'TPV012', N'MALECON', N'ML', N'', N'          ', 9)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (68, N'TPV013', N'OVALO', N'OV', N'', N'          ', 9)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (69, N'TPV014', N'PASAJE', N'PJE', N'', N'          ', 9)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (70, N'TPV015', N'PARQUE', N'PQ', N'', N'          ', 9)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (71, N'TPV016', N'PASEO', N'PAS', N'', N'          ', 9)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (72, N'TPV017', N'PLAZA', N'PL', N'', N'          ', 9)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (73, N'TPV018', N'PLAZUELA', N'PZ', N'', N'          ', 9)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (74, N'TPV019', N'PROLONGACION', N'PRO', N'', N'          ', 9)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (75, N'TPV020', N'PUENTE', N'PU', N'', N'          ', 9)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (76, N'TPV021', N'SENDERO', N'SE', N'', N'          ', 9)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (77, N'DOE01', N'ASIATICO', N'', N'', N'          ', 10)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (78, N'DOE02', N'NEGRO', N'', N'', N'          ', 10)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (79, N'DOE03', N'HISPANO', N'', N'', N'          ', 10)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (80, N'DOE04', N'BLANCO', N'', N'', N'          ', 10)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (81, N'DOE05', N'OTROS', N'', N'', N'          ', 10)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (82, N'DHR001', N'JUDAISMO', N'', N'RM N° 329, 2011/MINSA', N'          ', 11)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (83, N'DHR002', N'ISLAMISMO', N'', N'RM N° 329, 2011/MINSA', N'          ', 11)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (84, N'DHR003', N'CRISTIANISMO', N'', N'RM N° 329, 2011/MINSA', N'          ', 11)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (85, N'DHR004', N'HINDUISMO', N'', N'RM N° 329, 2011/MINSA', N'          ', 11)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (86, N'DHR005', N'BUDISMO', N'', N'RM N° 329, 2011/MINSA', N'          ', 11)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (87, N'DHR006', N'RELIGION TRADICIONAL CHINA', N'', N'RM N° 329, 2011/MINSA', N'          ', 11)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (88, N'DHR007', N'ESPIRITISMO', N'', N'RM N° 329, 2011/MINSA', N'          ', 11)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (89, N'DHR008', N'HELENISMO', N'', N'RM N° 329, 2011/MINSA', N'          ', 11)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (90, N'DHR009', N'INDIGENAS', N'', N'RM N° 329, 2011/MINSA', N'          ', 11)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (91, N'DHR010', N'NEOPAGANISMO', N'', N'RM N° 329, 2011/MINSA', N'          ', 11)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (92, N'DHR011', N'TAOISMO', N'', N'329, 2011/MINSA', N'          ', 11)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (93, N'DHR012', N'OTROS', N'', N'329, 2011/MINSA', N'          ', 11)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (94, N'CONS01', N'CONSULTORIO1', N'', N'', N'          ', 12)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (95, N'CONS02', N'CONSULTORIO2', N'', N'', N'          ', 12)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (96, N'CONS03', N'CONSULTORIO3', N'', N'', N'          ', 12)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (97, N'CONS04', N'CONSULTORIO4', N'', N'', N'          ', 12)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (98, N'CONS05', N'CONSULTORIO5', N'', N'', N'          ', 12)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (99, N'CONS06', N'CONSULTORIO6', N'', N'', N'          ', 12)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (100, N'CONS07', N'CONSULTORIO7', N'', N'', N'          ', 12)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (101, N'CONS08', N'CONSULTORIO8', N'', N'', N'          ', 12)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (102, N'CONS09', N'CONSULTORIO9', N'', N'', N'          ', 12)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (103, N'CONS10', N'CONSULTORIO10', N'', N'', N'          ', 12)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (104, N'CONS11', N'CONSULTORIO11', N'', N'', N'          ', 12)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (105, N'CONS12', N'CONSULTORIO12', N'', N'', N'          ', 12)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (106, N'CONS13', N'CONSULTORIO13', N'', N'', N'          ', 12)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (107, N'CONS14', N'CONSULTORIO14', N'', N'', N'          ', 12)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (108, N'CONS15', N'CONSULTORIO15', N'', N'', N'          ', 12)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (109, N'EMP001', N'ADMINISIONISTA', N'', N'', N'          ', 13)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (110, N'EMP002', N'MEDICA/O', N'', N'', N'          ', 13)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (111, N'EMP003', N'ENFERMERA/O', N'', N'', N'          ', 13)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (112, N'EMP004', N'LABORATORISTA', N'', N'', N'          ', 13)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (113, N'EMP05', N'FARMACEUTICA/O', N'', N'', N'          ', 13)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (114, N'EMP006', N'TECNICO', N'', N'', N'          ', 13)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (115, N'EMP007', N'DELIVERY', N'', N'', N'          ', 13)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (116, N'EMP008', N'ARCHIVERO', N'', N'', N'          ', 13)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (117, N'EMP009', N'SEGURIDAD', N'', N'', N'          ', 13)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (118, N'EMP010', N'SERVICIOS', N'', N'', N'          ', 13)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (119, N'EMP011', N'MED. TEMPORAL', N'', N'', N'          ', 13)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (120, N'TPAC01', N'PARTICULAR', N'', N'', N'          ', 14)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (121, N'TPAC02', N'ASEGURADO', N'', N'', N'          ', 14)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (122, N'TPAC03', N'CONVENIO', N'', N'', N'          ', 14)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (123, N'TPAC04', N'SOAT', N'', N'', N'          ', 14)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (124, N'TPAC05', N'EXTERNO', N'', N'', N'          ', 14)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (125, N'TPAC05', N'EXTERNO', N'', N'', N'          ', 14)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (126, N'E001', N'ALERGIA E INMUNOLOGIA', N'', N'', N'          ', 15)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (127, N'E002', N'CARDIOLOGIA', N'', N'', N'          ', 15)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (128, N'E003', N'CIRUGIA ONCOLOGICA DE CABEZA Y CUELLO', N'', N'', N'          ', 15)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (129, N'E004', N'CIRUGIA DE TORAX Y CARDIOVASCULAR', N'', N'', N'          ', 15)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (130, N'E005', N'CIRUGIA GENERAL Y LAPAROSCOPICA', N'', N'', N'          ', 15)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (131, N'E006', N'CIRUGIA GENERAL Y ONCOLOGICA', N'', N'', N'          ', 15)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (132, N'E007', N'DERMATOLOGIA', N'', N'', N'          ', 15)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (133, N'E008', N'RADIOLOGIA', N'', N'', N'          ', 15)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (134, N'E009', N'ENDOCRINOLOGIA', N'', N'', N'          ', 15)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (135, N'E0010', N'ENFERMERIA', N'', N'', N'          ', 15)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (136, N'E0011', N'GASTROENTEROLOGIA', N'', N'', N'          ', 15)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (137, N'E0012', N'GERIATRIA', N'', N'', N'          ', 15)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (138, N'E0013', N'GINECOLOGIA Y OBSTETRICIA', N'', N'', N'          ', 15)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (139, N'E0014', N'GINECOLOGIA ONCOLOGICA', N'', N'', N'          ', 15)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (140, N'E0015', N'HEMATOLOGIA', N'', N'', N'          ', 15)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (141, N'E0016', N'MASTOLOGIA ', N'', N'', N'          ', 15)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (142, N'E0017', N'MEDICINA FISICA Y REHABILITACION', N'', N'', N'          ', 15)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (143, N'E0018', N'MEDICINA GENERAL', N'', N'', N'          ', 15)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (144, N'E0019', N'MEDICINA INTERNA', N'', N'', N'          ', 15)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (145, N'E0020', N'NEFROLOGIA', N'', N'', N'          ', 15)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (146, N'E0021', N'NEUMOLOGIA', N'', N'', N'          ', 15)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (147, N'E0022', N'NEUROCIRUGIA', N'', N'', N'          ', 15)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (148, N'E0023', N'NEUROLOGIA', N'', N'', N'          ', 15)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (149, N'E0024', N'NUTRICION Y DIETETICA', N'', N'', N'          ', 15)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (150, N'E0025', N'ODONTOLOGIA INTEGRAL', N'', N'', N'          ', 15)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (151, N'SE001', N'CENTRO QUIRURGICO', N'', N'', N'          ', 16)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (152, N'SE002', N'CONSULTA AMBULATORIA', N'', N'', N'          ', 16)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (153, N'SE003', N'DENSITOMETRIA', N'', N'', N'          ', 16)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (154, N'SE004', N'ECOGRAFIAS', N'', N'', N'          ', 16)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (155, N'SE005', N'EMERGENCIA', N'', N'', N'          ', 16)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (156, N'SE006', N'HOSPITALIZACION', N'', N'', N'          ', 16)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (157, N'SE007', N'LABORATORIO', N'', N'', N'          ', 16)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (158, N'SE008', N'OD. CIRUGIA DENTAL', N'', N'', N'          ', 16)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (159, N'SE009', N'COD. INTEGRAL', N'', N'', N'          ', 16)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (160, N'SE010', N'OD. ORTODONCIA', N'', N'', N'          ', 16)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (161, N'SE011', N'OD. PROTESIS', N'', N'', N'          ', 16)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (162, N'SE012', N'ODONTOLOGIA', N'', N'', N'          ', 16)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (163, N'SE013', N'PEDIATRIA PD', N'', N'', N'          ', 16)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (164, N'SE014', N'RAYOS X', N'', N'', N'          ', 16)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (165, N'SE015', N'SALA DE PROCEDIMIENTOS', N'', N'', N'          ', 16)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (166, N'SE016', N'SANIDAD', N'', N'', N'          ', 16)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (167, N'SE017', N'TOMOGRAFIA Y RESONANCIAS', N'', N'', N'          ', 16)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (168, N'SE018', N'TOPICO', N'', N'', N'          ', 16)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (169, N'CIT001', N'CONSULTA', N'', N'', N'          ', 17)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (170, N'CIT002', N'EXAMEN', N'', N'', N'          ', 17)
GO
INSERT [dbo].[D00_TBDETALLE] ([idDet], [coddetTab], [descripcion], [abrev], [fuente], [estado], [idTab]) VALUES (171, N'CIT003', N'PROCEDIMIENTO', N'', N'', N'          ', 17)
GO
SET IDENTITY_INSERT [dbo].[D00_TBDETALLE] OFF
GO
SET IDENTITY_INSERT [dbo].[D00_TBGENERAL] ON 
GO
INSERT [dbo].[D00_TBGENERAL] ([idTab], [codTab], [descripcion], [tipo], [fechaCreate], [usuCreate]) VALUES (1, N'1', N'Tipo Documento', N'tpdoc01', CAST(N'1900-01-01' AS Date), N'')
GO
INSERT [dbo].[D00_TBGENERAL] ([idTab], [codTab], [descripcion], [tipo], [fechaCreate], [usuCreate]) VALUES (2, N'2', N'sexo', N'sex001', CAST(N'1900-01-01' AS Date), N'')
GO
INSERT [dbo].[D00_TBGENERAL] ([idTab], [codTab], [descripcion], [tipo], [fechaCreate], [usuCreate]) VALUES (3, N'3', N'grado instruccion', N'grd001', CAST(N'1900-01-01' AS Date), N'')
GO
INSERT [dbo].[D00_TBGENERAL] ([idTab], [codTab], [descripcion], [tipo], [fechaCreate], [usuCreate]) VALUES (4, N'4', N'Estado Civil', N'cvl001', CAST(N'1900-01-01' AS Date), N'')
GO
INSERT [dbo].[D00_TBGENERAL] ([idTab], [codTab], [descripcion], [tipo], [fechaCreate], [usuCreate]) VALUES (5, N'5', N'Ocupacion', N'ocu001', CAST(N'1900-01-01' AS Date), N'')
GO
INSERT [dbo].[D00_TBGENERAL] ([idTab], [codTab], [descripcion], [tipo], [fechaCreate], [usuCreate]) VALUES (6, N'6', N'Grupo Sangre', N'sang001', CAST(N'1900-01-01' AS Date), N'')
GO
INSERT [dbo].[D00_TBGENERAL] ([idTab], [codTab], [descripcion], [tipo], [fechaCreate], [usuCreate]) VALUES (7, N'7', N'Factor RH', N'fh001', CAST(N'1900-01-01' AS Date), N'')
GO
INSERT [dbo].[D00_TBGENERAL] ([idTab], [codTab], [descripcion], [tipo], [fechaCreate], [usuCreate]) VALUES (8, N'8', N'Parentesco', N'par001', CAST(N'1900-01-01' AS Date), N'')
GO
INSERT [dbo].[D00_TBGENERAL] ([idTab], [codTab], [descripcion], [tipo], [fechaCreate], [usuCreate]) VALUES (9, N'9', N'Tipo Via', N'tpv01', CAST(N'1900-01-01' AS Date), N'')
GO
INSERT [dbo].[D00_TBGENERAL] ([idTab], [codTab], [descripcion], [tipo], [fechaCreate], [usuCreate]) VALUES (10, N'10', N'Etnico', N'etn01', CAST(N'1900-01-01' AS Date), N'')
GO
INSERT [dbo].[D00_TBGENERAL] ([idTab], [codTab], [descripcion], [tipo], [fechaCreate], [usuCreate]) VALUES (11, N'11', N'Religion', N'rel01', CAST(N'1900-01-01' AS Date), N'')
GO
INSERT [dbo].[D00_TBGENERAL] ([idTab], [codTab], [descripcion], [tipo], [fechaCreate], [usuCreate]) VALUES (12, N'12', N'Consultorio', N'consu01', CAST(N'1900-01-01' AS Date), N'')
GO
INSERT [dbo].[D00_TBGENERAL] ([idTab], [codTab], [descripcion], [tipo], [fechaCreate], [usuCreate]) VALUES (13, N'13', N'Tipo Empleado', N'emp01', CAST(N'1900-01-01' AS Date), N'')
GO
INSERT [dbo].[D00_TBGENERAL] ([idTab], [codTab], [descripcion], [tipo], [fechaCreate], [usuCreate]) VALUES (14, N'14', N'Tipo Paciente', N'tpac01', CAST(N'1900-01-01' AS Date), N'')
GO
INSERT [dbo].[D00_TBGENERAL] ([idTab], [codTab], [descripcion], [tipo], [fechaCreate], [usuCreate]) VALUES (15, N'15', N'Especialidad', N'esp01', CAST(N'1900-01-01' AS Date), N'')
GO
INSERT [dbo].[D00_TBGENERAL] ([idTab], [codTab], [descripcion], [tipo], [fechaCreate], [usuCreate]) VALUES (16, N'16', N'Servicio Clinica', N'srv001', CAST(N'1900-01-01' AS Date), N'')
GO
INSERT [dbo].[D00_TBGENERAL] ([idTab], [codTab], [descripcion], [tipo], [fechaCreate], [usuCreate]) VALUES (17, N'17', N'Tipo Cita', N'cit01', CAST(N'1900-01-01' AS Date), N'')
GO
SET IDENTITY_INSERT [dbo].[D00_TBGENERAL] OFF
GO
SET IDENTITY_INSERT [dbo].[D008_CONSULTORIO] ON 
GO
INSERT [dbo].[D008_CONSULTORIO] ([idConsultorio], [nroConsultorio], [tpConsultorio], [descripcion], [area], [piso], [idEspecialidad]) VALUES (1, 2, 1, N'nutricion', N'medicina', N'5', 1)
GO
INSERT [dbo].[D008_CONSULTORIO] ([idConsultorio], [nroConsultorio], [tpConsultorio], [descripcion], [area], [piso], [idEspecialidad]) VALUES (2, 3, 2, N'ginecologia', N'medicina', N'4', 2)
GO
INSERT [dbo].[D008_CONSULTORIO] ([idConsultorio], [nroConsultorio], [tpConsultorio], [descripcion], [area], [piso], [idEspecialidad]) VALUES (3, 4, 4, N'pediatria', N'medicina', N'3', 3)
GO
INSERT [dbo].[D008_CONSULTORIO] ([idConsultorio], [nroConsultorio], [tpConsultorio], [descripcion], [area], [piso], [idEspecialidad]) VALUES (4, 5, 5, N'odontologia', N'medicina', N'1', 4)
GO
SET IDENTITY_INSERT [dbo].[D008_CONSULTORIO] OFF
GO
SET IDENTITY_INSERT [dbo].[D012_CRONOMEDICO] ON 
GO
INSERT [dbo].[D012_CRONOMEDICO] ([idProgramMedica], [mes], [semana], [dia], [fecProgramMedica], [idMedico], [idEspecialidad], [idConsultorio], [hrInicio], [hrFin], [idEstado]) VALUES (1, N'junio', N'25', N'180', CAST(N'2020-06-20T00:00:00.000' AS DateTime), 1, NULL, NULL, N'07:00', N'07:20', NULL)
GO
INSERT [dbo].[D012_CRONOMEDICO] ([idProgramMedica], [mes], [semana], [dia], [fecProgramMedica], [idMedico], [idEspecialidad], [idConsultorio], [hrInicio], [hrFin], [idEstado]) VALUES (2, N'junio', N'25', N'181', CAST(N'2020-06-25T00:00:00.000' AS DateTime), 2, NULL, NULL, N'14:20', N'14:40', NULL)
GO
INSERT [dbo].[D012_CRONOMEDICO] ([idProgramMedica], [mes], [semana], [dia], [fecProgramMedica], [idMedico], [idEspecialidad], [idConsultorio], [hrInicio], [hrFin], [idEstado]) VALUES (3, N'julio', N'27', N'190', CAST(N'2020-07-15T00:00:00.000' AS DateTime), 3, NULL, NULL, N'18:20', N'18:40', NULL)
GO
INSERT [dbo].[D012_CRONOMEDICO] ([idProgramMedica], [mes], [semana], [dia], [fecProgramMedica], [idMedico], [idEspecialidad], [idConsultorio], [hrInicio], [hrFin], [idEstado]) VALUES (4, N'julio', N'28', N'195', CAST(N'2020-07-20T00:00:00.000' AS DateTime), 2, NULL, NULL, N'13:20', N'13:40', NULL)
GO
SET IDENTITY_INSERT [dbo].[D012_CRONOMEDICO] OFF
GO
INSERT [dbo].[D013_PAIS] ([idPais], [descripcion], [codigo]) VALUES (1, N'Peru', NULL)
GO
INSERT [dbo].[D013_PAIS] ([idPais], [descripcion], [codigo]) VALUES (2, N'PERU', N'cod')
GO
INSERT [dbo].[D014_DPTO] ([idDpto], [descripcion], [codigo], [idPais]) VALUES (2, N'LIMA', N'cod', 2)
GO
INSERT [dbo].[D014_DPTO] ([idDpto], [descripcion], [codigo], [idPais]) VALUES (3, N'ICA', N'cod', 2)
GO
INSERT [dbo].[D015_PROV] ([idProvincia], [descripcion], [codigo], [idDpto]) VALUES (1, N'LIMA', N'cod', 2)
GO
INSERT [dbo].[D015_PROV] ([idProvincia], [descripcion], [codigo], [idDpto]) VALUES (2, N'ICA', N'cod', 3)
GO
SET IDENTITY_INSERT [dbo].[D015_TPEMPLEADO] ON 
GO
INSERT [dbo].[D015_TPEMPLEADO] ([idtpEmpleado], [Descripcion]) VALUES (1, N'Admisionista')
GO
INSERT [dbo].[D015_TPEMPLEADO] ([idtpEmpleado], [Descripcion]) VALUES (2, N'Medico')
GO
INSERT [dbo].[D015_TPEMPLEADO] ([idtpEmpleado], [Descripcion]) VALUES (3, N'Laboratorista')
GO
INSERT [dbo].[D015_TPEMPLEADO] ([idtpEmpleado], [Descripcion]) VALUES (4, N'Farmaceutico')
GO
SET IDENTITY_INSERT [dbo].[D015_TPEMPLEADO] OFF
GO
INSERT [dbo].[D016_DISTRITO] ([idDistrito], [descripcion], [codigo], [idDpto], [idProv]) VALUES (1, N'Cercado', N'cod', NULL, 1)
GO
INSERT [dbo].[D016_DISTRITO] ([idDistrito], [descripcion], [codigo], [idDpto], [idProv]) VALUES (2, N'distr ica', N'cod', NULL, 2)
GO
SET IDENTITY_INSERT [dbo].[T000_PERSONA] ON 
GO
INSERT [dbo].[T000_PERSONA] ([idPersona], [apePaterno], [apeMaterno], [nombres], [idtpDocumento], [dniPersona], [idSexo], [idEtnico], [fecNacimiento], [idUbigeoResi], [idtipoVia], [nombreVia], [nroVia], [nroDpto], [interior], [manzana], [nroLote], [nroKm], [nroBlock], [nroEtapa], [edad], [idUbigeoNace], [fotografia], [idGrdInstruc], [idReligion], [centroEduca], [idEstCivil], [idOcupacion], [idgpoSangre], [idFactorrh], [nroRuc], [razonSocial], [estadoRuc], [condicionRuc], [domiFiscal], [idParentesco], [telefono], [celular], [correo], [tpPersona], [iddatoSiteds], [idemprConvenio], [idciaSeguro], [idtipoIafa], [estado]) VALUES (1, N'Galvez', N'Galvez', N'Julio', NULL, 99887658, NULL, NULL, N'15-06-2000', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 26, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'gabrilg@gmail.com', NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[T000_PERSONA] ([idPersona], [apePaterno], [apeMaterno], [nombres], [idtpDocumento], [dniPersona], [idSexo], [idEtnico], [fecNacimiento], [idUbigeoResi], [idtipoVia], [nombreVia], [nroVia], [nroDpto], [interior], [manzana], [nroLote], [nroKm], [nroBlock], [nroEtapa], [edad], [idUbigeoNace], [fotografia], [idGrdInstruc], [idReligion], [centroEduca], [idEstCivil], [idOcupacion], [idgpoSangre], [idFactorrh], [nroRuc], [razonSocial], [estadoRuc], [condicionRuc], [domiFiscal], [idParentesco], [telefono], [celular], [correo], [tpPersona], [iddatoSiteds], [idemprConvenio], [idciaSeguro], [idtipoIafa], [estado]) VALUES (2, N'Mendoza', N'Mendoza', N'Juan', NULL, 12345678, NULL, NULL, N'15-06-2001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 19, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'juang@gmail.com', NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[T000_PERSONA] ([idPersona], [apePaterno], [apeMaterno], [nombres], [idtpDocumento], [dniPersona], [idSexo], [idEtnico], [fecNacimiento], [idUbigeoResi], [idtipoVia], [nombreVia], [nroVia], [nroDpto], [interior], [manzana], [nroLote], [nroKm], [nroBlock], [nroEtapa], [edad], [idUbigeoNace], [fotografia], [idGrdInstruc], [idReligion], [centroEduca], [idEstCivil], [idOcupacion], [idgpoSangre], [idFactorrh], [nroRuc], [razonSocial], [estadoRuc], [condicionRuc], [domiFiscal], [idParentesco], [telefono], [celular], [correo], [tpPersona], [iddatoSiteds], [idemprConvenio], [idciaSeguro], [idtipoIafa], [estado]) VALUES (3, N'Ruiz', N'Ruiz', N'Sophia', NULL, 12345671, NULL, NULL, N'15-06-1990', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 30, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'ruizsophi@gmail.com', NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[T000_PERSONA] ([idPersona], [apePaterno], [apeMaterno], [nombres], [idtpDocumento], [dniPersona], [idSexo], [idEtnico], [fecNacimiento], [idUbigeoResi], [idtipoVia], [nombreVia], [nroVia], [nroDpto], [interior], [manzana], [nroLote], [nroKm], [nroBlock], [nroEtapa], [edad], [idUbigeoNace], [fotografia], [idGrdInstruc], [idReligion], [centroEduca], [idEstCivil], [idOcupacion], [idgpoSangre], [idFactorrh], [nroRuc], [razonSocial], [estadoRuc], [condicionRuc], [domiFiscal], [idParentesco], [telefono], [celular], [correo], [tpPersona], [iddatoSiteds], [idemprConvenio], [idciaSeguro], [idtipoIafa], [estado]) VALUES (4, N'Hidalgo', N'Hidalgo', N'Lady', NULL, 10345678, NULL, NULL, N'15-06-1995', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 25, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'hilay@gmail.com', NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[T000_PERSONA] ([idPersona], [apePaterno], [apeMaterno], [nombres], [idtpDocumento], [dniPersona], [idSexo], [idEtnico], [fecNacimiento], [idUbigeoResi], [idtipoVia], [nombreVia], [nroVia], [nroDpto], [interior], [manzana], [nroLote], [nroKm], [nroBlock], [nroEtapa], [edad], [idUbigeoNace], [fotografia], [idGrdInstruc], [idReligion], [centroEduca], [idEstCivil], [idOcupacion], [idgpoSangre], [idFactorrh], [nroRuc], [razonSocial], [estadoRuc], [condicionRuc], [domiFiscal], [idParentesco], [telefono], [celular], [correo], [tpPersona], [iddatoSiteds], [idemprConvenio], [idciaSeguro], [idtipoIafa], [estado]) VALUES (5, N'Malca', N'Cardenas', N'Julio', NULL, 70452945, NULL, NULL, N'01032020', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 23, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'jotace.11.01.03@gmail.com', NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[T000_PERSONA] ([idPersona], [apePaterno], [apeMaterno], [nombres], [idtpDocumento], [dniPersona], [idSexo], [idEtnico], [fecNacimiento], [idUbigeoResi], [idtipoVia], [nombreVia], [nroVia], [nroDpto], [interior], [manzana], [nroLote], [nroKm], [nroBlock], [nroEtapa], [edad], [idUbigeoNace], [fotografia], [idGrdInstruc], [idReligion], [centroEduca], [idEstCivil], [idOcupacion], [idgpoSangre], [idFactorrh], [nroRuc], [razonSocial], [estadoRuc], [condicionRuc], [domiFiscal], [idParentesco], [telefono], [celular], [correo], [tpPersona], [iddatoSiteds], [idemprConvenio], [idciaSeguro], [idtipoIafa], [estado]) VALUES (6, N'franco', N'palacios', N'bertol', NULL, 74446454, NULL, NULL, N'10/20/2019', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 22, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'yopmail@.com', NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[T000_PERSONA] ([idPersona], [apePaterno], [apeMaterno], [nombres], [idtpDocumento], [dniPersona], [idSexo], [idEtnico], [fecNacimiento], [idUbigeoResi], [idtipoVia], [nombreVia], [nroVia], [nroDpto], [interior], [manzana], [nroLote], [nroKm], [nroBlock], [nroEtapa], [edad], [idUbigeoNace], [fotografia], [idGrdInstruc], [idReligion], [centroEduca], [idEstCivil], [idOcupacion], [idgpoSangre], [idFactorrh], [nroRuc], [razonSocial], [estadoRuc], [condicionRuc], [domiFiscal], [idParentesco], [telefono], [celular], [correo], [tpPersona], [iddatoSiteds], [idemprConvenio], [idciaSeguro], [idtipoIafa], [estado]) VALUES (7, N'palacios', N'franco', N'erick', NULL, 74446454, NULL, NULL, N'1020202', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 22, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'gdfgfdg@gmail.com', NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[T000_PERSONA] ([idPersona], [apePaterno], [apeMaterno], [nombres], [idtpDocumento], [dniPersona], [idSexo], [idEtnico], [fecNacimiento], [idUbigeoResi], [idtipoVia], [nombreVia], [nroVia], [nroDpto], [interior], [manzana], [nroLote], [nroKm], [nroBlock], [nroEtapa], [edad], [idUbigeoNace], [fotografia], [idGrdInstruc], [idReligion], [centroEduca], [idEstCivil], [idOcupacion], [idgpoSangre], [idFactorrh], [nroRuc], [razonSocial], [estadoRuc], [condicionRuc], [domiFiscal], [idParentesco], [telefono], [celular], [correo], [tpPersona], [iddatoSiteds], [idemprConvenio], [idciaSeguro], [idtipoIafa], [estado]) VALUES (8, N'tomcat', N'guerra', N'tom', NULL, 74446454, NULL, NULL, N'10301030', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 22, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'tomcat@gmail.com', NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[T000_PERSONA] ([idPersona], [apePaterno], [apeMaterno], [nombres], [idtpDocumento], [dniPersona], [idSexo], [idEtnico], [fecNacimiento], [idUbigeoResi], [idtipoVia], [nombreVia], [nroVia], [nroDpto], [interior], [manzana], [nroLote], [nroKm], [nroBlock], [nroEtapa], [edad], [idUbigeoNace], [fotografia], [idGrdInstruc], [idReligion], [centroEduca], [idEstCivil], [idOcupacion], [idgpoSangre], [idFactorrh], [nroRuc], [razonSocial], [estadoRuc], [condicionRuc], [domiFiscal], [idParentesco], [telefono], [celular], [correo], [tpPersona], [iddatoSiteds], [idemprConvenio], [idciaSeguro], [idtipoIafa], [estado]) VALUES (9, N'pierre', N'santos', N'zodiac', NULL, 74446454, NULL, NULL, N'10401040', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 22, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'pierresantosg@gmail.com', NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[T000_PERSONA] ([idPersona], [apePaterno], [apeMaterno], [nombres], [idtpDocumento], [dniPersona], [idSexo], [idEtnico], [fecNacimiento], [idUbigeoResi], [idtipoVia], [nombreVia], [nroVia], [nroDpto], [interior], [manzana], [nroLote], [nroKm], [nroBlock], [nroEtapa], [edad], [idUbigeoNace], [fotografia], [idGrdInstruc], [idReligion], [centroEduca], [idEstCivil], [idOcupacion], [idgpoSangre], [idFactorrh], [nroRuc], [razonSocial], [estadoRuc], [condicionRuc], [domiFiscal], [idParentesco], [telefono], [celular], [correo], [tpPersona], [iddatoSiteds], [idemprConvenio], [idciaSeguro], [idtipoIafa], [estado]) VALUES (10, N'Cardenas', N'Malca', N'Luis', NULL, 173945, NULL, NULL, N'01031997', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 19, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'luis_3@gmail.com', NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[T000_PERSONA] ([idPersona], [apePaterno], [apeMaterno], [nombres], [idtpDocumento], [dniPersona], [idSexo], [idEtnico], [fecNacimiento], [idUbigeoResi], [idtipoVia], [nombreVia], [nroVia], [nroDpto], [interior], [manzana], [nroLote], [nroKm], [nroBlock], [nroEtapa], [edad], [idUbigeoNace], [fotografia], [idGrdInstruc], [idReligion], [centroEduca], [idEstCivil], [idOcupacion], [idgpoSangre], [idFactorrh], [nroRuc], [razonSocial], [estadoRuc], [condicionRuc], [domiFiscal], [idParentesco], [telefono], [celular], [correo], [tpPersona], [iddatoSiteds], [idemprConvenio], [idciaSeguro], [idtipoIafa], [estado]) VALUES (11, N'Ramirez', N'Salgado', N'Luis', NULL, 70452946, NULL, NULL, N'01031997', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 20, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'luis_3@gmail.com', NULL, NULL, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[T000_PERSONA] OFF
GO
SET IDENTITY_INSERT [dbo].[T017_TIPOIAFA] ON 
GO
INSERT [dbo].[T017_TIPOIAFA] ([idtipoIafa], [codTipo], [descripcion]) VALUES (1, N'DHC001', N'SEGURO INTEGRAL DE SALUD')
GO
INSERT [dbo].[T017_TIPOIAFA] ([idtipoIafa], [codTipo], [descripcion]) VALUES (2, N'DHC002', N'SEGURO SOCIAL DE SALUD')
GO
INSERT [dbo].[T017_TIPOIAFA] ([idtipoIafa], [codTipo], [descripcion]) VALUES (3, N'DHC003', N'FONDO INTANGIBLE SOLIDARIO EN SALUD')
GO
INSERT [dbo].[T017_TIPOIAFA] ([idtipoIafa], [codTipo], [descripcion]) VALUES (4, N'DHC004', N'SANIDADES DE LAS FUERZAS ARMADAS')
GO
INSERT [dbo].[T017_TIPOIAFA] ([idtipoIafa], [codTipo], [descripcion]) VALUES (5, N'DHC005', N'SANIDAD DE LA POLICÍA NACIONAL DEL PERÚ')
GO
INSERT [dbo].[T017_TIPOIAFA] ([idtipoIafa], [codTipo], [descripcion]) VALUES (6, N'DHC006', N'ENTIDADES PRESTADORAS DE SALUD (EPS)')
GO
INSERT [dbo].[T017_TIPOIAFA] ([idtipoIafa], [codTipo], [descripcion]) VALUES (7, N'DHC007', N'COMPAÑÍAS DE SEGUROS PRIVADOS DE SALUD')
GO
INSERT [dbo].[T017_TIPOIAFA] ([idtipoIafa], [codTipo], [descripcion]) VALUES (8, N'DHC008', N'ENTIDADES DE SALUD QUE OFRECEN SERVICIOS DE SALUD PREPAGADOS')
GO
INSERT [dbo].[T017_TIPOIAFA] ([idtipoIafa], [codTipo], [descripcion]) VALUES (9, N'DHC009', N'AUTOSEGUROS Y FONDOS DE SALUD')
GO
INSERT [dbo].[T017_TIPOIAFA] ([idtipoIafa], [codTipo], [descripcion]) VALUES (10, N'DHC010', N'AFOCATS')
GO
SET IDENTITY_INSERT [dbo].[T017_TIPOIAFA] OFF
GO
SET IDENTITY_INSERT [dbo].[T018_CIASEGURO] ON 
GO
INSERT [dbo].[T018_CIASEGURO] ([idciaSeguro], [codciaSeguro], [descripcion], [activo]) VALUES (1, N'DHC001', N'AUTOSEGURO BCRP', N'NO ')
GO
INSERT [dbo].[T018_CIASEGURO] ([idciaSeguro], [codciaSeguro], [descripcion], [activo]) VALUES (2, N'DHC002', N'AUTOSEGURO SEMEFA', N'NO ')
GO
INSERT [dbo].[T018_CIASEGURO] ([idciaSeguro], [codciaSeguro], [descripcion], [activo]) VALUES (3, N'DHC003', N'CARDIF SEGUROS', N'NO ')
GO
INSERT [dbo].[T018_CIASEGURO] ([idciaSeguro], [codciaSeguro], [descripcion], [activo]) VALUES (4, N'DHC004', N'CLÍNICA SAN BORJA', N'NO ')
GO
INSERT [dbo].[T018_CIASEGURO] ([idciaSeguro], [codciaSeguro], [descripcion], [activo]) VALUES (5, N'DHC005', N'FEBAN', N'NO ')
GO
INSERT [dbo].[T018_CIASEGURO] ([idciaSeguro], [codciaSeguro], [descripcion], [activo]) VALUES (6, N'DHC006', N'FOSPEME', N'NO ')
GO
INSERT [dbo].[T018_CIASEGURO] ([idciaSeguro], [codciaSeguro], [descripcion], [activo]) VALUES (7, N'DHC007', N'LA POSITIVA EPS', N'NO ')
GO
INSERT [dbo].[T018_CIASEGURO] ([idciaSeguro], [codciaSeguro], [descripcion], [activo]) VALUES (8, N'DHC008', N'LA POSITIVA SEGUROS', N'NO ')
GO
INSERT [dbo].[T018_CIASEGURO] ([idciaSeguro], [codciaSeguro], [descripcion], [activo]) VALUES (9, N'DHC009', N'MAPFRE EPS', N'SI ')
GO
INSERT [dbo].[T018_CIASEGURO] ([idciaSeguro], [codciaSeguro], [descripcion], [activo]) VALUES (10, N'DHC010', N'PACÍFICO EPS', N'SI ')
GO
INSERT [dbo].[T018_CIASEGURO] ([idciaSeguro], [codciaSeguro], [descripcion], [activo]) VALUES (11, N'DHC011', N'LA POSITIVA  EPS', N'SI ')
GO
SET IDENTITY_INSERT [dbo].[T018_CIASEGURO] OFF
GO
SET IDENTITY_INSERT [dbo].[T020_TIPOPACIENTE] ON 
GO
INSERT [dbo].[T020_TIPOPACIENTE] ([idtpPaciente], [codigo], [descripcion], [abreviatura], [obli], [origen]) VALUES (1, N'TPAC001', N'PACIENTE PARTICULAR', N'part', N'     ', N'FORM CEM')
GO
INSERT [dbo].[T020_TIPOPACIENTE] ([idtpPaciente], [codigo], [descripcion], [abreviatura], [obli], [origen]) VALUES (2, N'TPAC002', N'PACIENTE ASEGURADO', N'Aseg', N'     ', N'FORM CEM')
GO
INSERT [dbo].[T020_TIPOPACIENTE] ([idtpPaciente], [codigo], [descripcion], [abreviatura], [obli], [origen]) VALUES (3, N'TPAC003', N'PACIENTE CONVENIO', N'Conv', N'     ', N'FORM CEM')
GO
SET IDENTITY_INSERT [dbo].[T020_TIPOPACIENTE] OFF
GO
SET IDENTITY_INSERT [dbo].[T057_RELIGION] ON 
GO
INSERT [dbo].[T057_RELIGION] ([idReligion], [codReligion], [descripcion], [abreviatura], [fuente], [observacion]) VALUES (1, N'DHR001', N'JUDAISMO', N'     ', N'RM N° 329, 2011/MINSA', N'')
GO
INSERT [dbo].[T057_RELIGION] ([idReligion], [codReligion], [descripcion], [abreviatura], [fuente], [observacion]) VALUES (2, N'DHR002', N'ISLAMISMO', N'     ', N'RM N° 329, 2011/MINSA', N'')
GO
INSERT [dbo].[T057_RELIGION] ([idReligion], [codReligion], [descripcion], [abreviatura], [fuente], [observacion]) VALUES (3, N'DHR003', N'CRISTIANISMO', N'     ', N'RM N° 329, 2011/MINSA', N'')
GO
INSERT [dbo].[T057_RELIGION] ([idReligion], [codReligion], [descripcion], [abreviatura], [fuente], [observacion]) VALUES (4, N'DHR004', N'HINDUISMO', N'     ', N'RM N° 329, 2011/MINSA', N'')
GO
INSERT [dbo].[T057_RELIGION] ([idReligion], [codReligion], [descripcion], [abreviatura], [fuente], [observacion]) VALUES (5, N'DHR005', N'BUDISMO', N'     ', N'RM N° 329, 2011/MINSA', N'')
GO
INSERT [dbo].[T057_RELIGION] ([idReligion], [codReligion], [descripcion], [abreviatura], [fuente], [observacion]) VALUES (7, N'DHR007', N'ESPIRITISMO', N'     ', N'RM N° 329, 2011/MINSA', N'')
GO
INSERT [dbo].[T057_RELIGION] ([idReligion], [codReligion], [descripcion], [abreviatura], [fuente], [observacion]) VALUES (8, N'DHR008', N'HELENISMO', N'     ', N'RM N° 329, 2011/MINSA', N'')
GO
INSERT [dbo].[T057_RELIGION] ([idReligion], [codReligion], [descripcion], [abreviatura], [fuente], [observacion]) VALUES (9, N'DHR006', N'RELIGION TRADICIONAL CHINA', N'     ', N'RM N° 329, 2011/MINSA', N'')
GO
INSERT [dbo].[T057_RELIGION] ([idReligion], [codReligion], [descripcion], [abreviatura], [fuente], [observacion]) VALUES (10, N'DHR009', N'INDIGENAS', N'     ', N'RM N° 329, 2011/MINSA', N'')
GO
INSERT [dbo].[T057_RELIGION] ([idReligion], [codReligion], [descripcion], [abreviatura], [fuente], [observacion]) VALUES (11, N'DHR011', N'TAOISMO', N'     ', N'RM N° 329, 2011/MINSA', N'')
GO
INSERT [dbo].[T057_RELIGION] ([idReligion], [codReligion], [descripcion], [abreviatura], [fuente], [observacion]) VALUES (12, N'DHR012', N'OTROS', N'     ', N'RM N° 329, 2011/MINSA', N'')
GO
SET IDENTITY_INSERT [dbo].[T057_RELIGION] OFF
GO
SET IDENTITY_INSERT [dbo].[T068_CITA] ON 
GO
INSERT [dbo].[T068_CITA] ([idCita], [codCita], [nroCita], [descripcion], [fechaCita], [ultCie10], [tpAtencion], [nroHC], [idEstadoCita], [idEstaGralPac], [estadoReprogram], [ejecutado], [prioridad], [precio], [descuento], [coa], [igv], [tipoCita], [motivoRepro], [motivoAnula], [idPaciente], [idEmpleado], [idConsultorio], [idProgramMedica], [idservicioCli], [estado]) VALUES (3, 12121, 1200, N'general', CAST(N'2020-06-20T00:00:00.000' AS DateTime), N'12', N'gen', 2345, 1, 1, N'12345', N'12345', N'12345', CAST(20.000000 AS Decimal(18, 6)), CAST(0.000000 AS Decimal(18, 6)), CAST(0.000000 AS Decimal(18, 6)), CAST(0.000000 AS Decimal(18, 6)), NULL, NULL, NULL, 1, 1, 1, 1, NULL, NULL)
GO
INSERT [dbo].[T068_CITA] ([idCita], [codCita], [nroCita], [descripcion], [fechaCita], [ultCie10], [tpAtencion], [nroHC], [idEstadoCita], [idEstaGralPac], [estadoReprogram], [ejecutado], [prioridad], [precio], [descuento], [coa], [igv], [tipoCita], [motivoRepro], [motivoAnula], [idPaciente], [idEmpleado], [idConsultorio], [idProgramMedica], [idservicioCli], [estado]) VALUES (4, 12122, 1204, N'general', CAST(N'2020-06-21T00:00:00.000' AS DateTime), N'11', N'gen', 2345, 1, 1, N'12345', N'12345', N'12345', CAST(20.000000 AS Decimal(18, 6)), CAST(0.000000 AS Decimal(18, 6)), CAST(0.000000 AS Decimal(18, 6)), CAST(0.000000 AS Decimal(18, 6)), NULL, NULL, NULL, 2, 1, 2, 2, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[T068_CITA] OFF
GO
SET IDENTITY_INSERT [dbo].[T071_SEXO] ON 
GO
INSERT [dbo].[T071_SEXO] ([idSexo], [codSexo], [descripcion], [abreviatura], [origen]) VALUES (1, 1, N'Masculino', N'M    ', N'')
GO
INSERT [dbo].[T071_SEXO] ([idSexo], [codSexo], [descripcion], [abreviatura], [origen]) VALUES (2, 2, N'Femenino', N'F    ', N'')
GO
SET IDENTITY_INSERT [dbo].[T071_SEXO] OFF
GO
SET IDENTITY_INSERT [dbo].[T080_TPDOCUPAGO] ON 
GO
INSERT [dbo].[T080_TPDOCUPAGO] ([idtpDocuPago], [codDocuPago], [descripcion]) VALUES (1, N'CMP001', N'Facturas')
GO
INSERT [dbo].[T080_TPDOCUPAGO] ([idtpDocuPago], [codDocuPago], [descripcion]) VALUES (2, N'CMP002', N'Recibos por honorarios')
GO
INSERT [dbo].[T080_TPDOCUPAGO] ([idtpDocuPago], [codDocuPago], [descripcion]) VALUES (3, N'CMP003', N'Boletas de venta')
GO
INSERT [dbo].[T080_TPDOCUPAGO] ([idtpDocuPago], [codDocuPago], [descripcion]) VALUES (4, N'CMP004', N'Liquidaciones de compra')
GO
INSERT [dbo].[T080_TPDOCUPAGO] ([idtpDocuPago], [codDocuPago], [descripcion]) VALUES (5, N'CMP005', N'Tickets o cintas emitidos por máquinas registradoras')
GO
INSERT [dbo].[T080_TPDOCUPAGO] ([idtpDocuPago], [codDocuPago], [descripcion]) VALUES (6, N'CMP006', N'Ticket POS')
GO
INSERT [dbo].[T080_TPDOCUPAGO] ([idtpDocuPago], [codDocuPago], [descripcion]) VALUES (7, N'CMP007', N'Ticket Monedero Electrónico')
GO
SET IDENTITY_INSERT [dbo].[T080_TPDOCUPAGO] OFF
GO
SET IDENTITY_INSERT [dbo].[T109_ESTADOCITA] ON 
GO
INSERT [dbo].[T109_ESTADOCITA] ([idEstadoCita], [codEstadoCita], [estado], [origen]) VALUES (1, N'E1', N'RESERVADO', N'se genera cuando el paciente realiza una reserva telefónica de una cita (solo consulta)')
GO
INSERT [dbo].[T109_ESTADOCITA] ([idEstadoCita], [codEstadoCita], [estado], [origen]) VALUES (2, N'E2', N'REPROGRAMADO', N'se genera cuando el paciente reprograma su cita (consulta o procedimiento)')
GO
INSERT [dbo].[T109_ESTADOCITA] ([idEstadoCita], [codEstadoCita], [estado], [origen]) VALUES (3, N'E3', N'ATENDIDO', N'se genera luego de guardar el registro la cita (consulta o procedimiento)')
GO
INSERT [dbo].[T109_ESTADOCITA] ([idEstadoCita], [codEstadoCita], [estado], [origen]) VALUES (4, N'E4', N'EN ESPERA', N'se genera luego de realizado el pago de la cita en admisión (consulta o procedimiento)')
GO
INSERT [dbo].[T109_ESTADOCITA] ([idEstadoCita], [codEstadoCita], [estado], [origen]) VALUES (5, N'E5', N'FINALIZADO', N'se genera al generar  el informe final del procedimiento (neurologia, cardiologia)')
GO
INSERT [dbo].[T109_ESTADOCITA] ([idEstadoCita], [codEstadoCita], [estado], [origen]) VALUES (6, N'E6', N'ANULADO', N'se genera cuando el paciente no asiste a su cita (consulta) y no ha realizado pago)')
GO
INSERT [dbo].[T109_ESTADOCITA] ([idEstadoCita], [codEstadoCita], [estado], [origen]) VALUES (7, N'E7', N'ABANDONADO', N'se genera cuando el paciente no asiste a su cita (consulta) pese a haberla pagado)')
GO
SET IDENTITY_INSERT [dbo].[T109_ESTADOCITA] OFF
GO
SET IDENTITY_INSERT [dbo].[T120_EMPLEADO] ON 
GO
INSERT [dbo].[T120_EMPLEADO] ([idEmpleado], [genero], [salario], [precio], [fecIngreso], [idtpEmpleado], [codEmpleado], [descArea], [cargo], [idPersona], [estado]) VALUES (1, N'A', 2000, CAST(1000.00000 AS Decimal(16, 5)), CAST(N'2020-01-02' AS Date), 1, N'10', N'Admision', N'Admisionista', NULL, N'1    ')
GO
SET IDENTITY_INSERT [dbo].[T120_EMPLEADO] OFF
GO
SET IDENTITY_INSERT [dbo].[T120_ESPECIALIDAD] ON 
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (1, N'E001', N'', N'Oftalmologo', N'1', N'Oftalmologo')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (2, N'E002', N'', N'Pediatria', N'2', N'Pediatria')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (3, N'E003', N'', N'Cardiologo', N'3', N'Cardiologo')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (4, N'E004', N'', N'Infectologo', N'4', N'Infectologo')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (5, N'E005', N'', N'CIRUGIA GENERAL Y LAPAROSCOPICA', N'CE0001', N'CIRUGIA PEDIATRICA')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (6, N'E006', N'', N'CIRUGIA GENERAL Y ONCOLOGICA', N'', N'')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (7, N'E007', N'', N'DERMATOLOGIA', N'', N'')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (8, N'E008', N'', N'RADIOLOGIA', N'', N'')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (9, N'E009', N'', N'ENDOCRINOLOGIA', N'', N'')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (10, N'E010', N'', N'ENFERMERIA', N'', N'')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (11, N'E0011', N'', N'GASTROENTEROLOGIA', N'', N'')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (12, N'E012', N'', N'GERIATRIA', N'', N'')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (13, N'E013', N'', N'GINECOLOGIA Y OBSTETRICIA', N'', N'')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (14, N'E014', N'', N'GINECOLOGIA ONCOLOGICA', N'', N'')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (15, N'E015', N'', N'HEMATOLOGIA', N'', N'')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (16, N'E016', N'', N'MASTOLOGIA', N'', N'')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (17, N'E017', N'', N'MEDICINA FISICA Y REHABILITACION', N'', N'')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (18, N'E018', N'', N'MEDICINA GENERAL', N'', N'')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (19, N'E019', N'', N'MEDICINA INTERNA', N'', N'')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (20, N'E020', N'', N'NEFROLOGIA', N'', N'')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (21, N'E021', N'', N'NEUMOLOGIA', N'', N'')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (22, N'E022', N'', N'NEUROCIRUGIA', N'', N'')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (23, N'E023', N'', N'NEUROLOGIA', N'', N'')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (24, N'E024', N'', N'NUTRICION Y DIETETICA', N'', N'')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (25, N'E025', N'', N'ODONTOLOGIA INTEGRAL', N'CE0002', N'REHABILITACION ORAL')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (26, N'E025', N'', N'ODONTOLOGIA INTEGRAL', N'CE0003', N'PERIODONCIA  E IMPLANTES')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (27, N'E025', N'', N'ODONTOLOGIA INTEGRAL ', N'CE0004', N'ODONTOPEDIATRIA')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (28, N'E025', N'', N'ODONTOLOGIA INTEGRAL', N'CE0005', N'ORTODONCIA')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (29, N'E025', N'', N'ODONTOLOGIA INTEGRAL', N'CE0006', N'ENDODONCIA')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (30, N'E025', N'', N'ODONTOLOGIA INTEGRAL', N'CE0007', N'CIRUGIA BUCAL MAXILO FACIAL')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (31, N'E026', N'', N'OFTALMOLOGIA', N'', N'')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (32, N'E027', N'', N'OTORRINOLARINGOLOGIA', N'', N'')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (33, N'E028', N'', N'PEDIATRIA', N'', N'')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (34, N'E029', N'', N'PSICOLOGIA', N'', N'')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (35, N'E030', N'', N'REUMATOLOGIA', N'', N'')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (36, N'E031', N'', N'PSIQUIATRIA', N'', N'')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (37, N'E032', N'', N'TRAUMATOLOGIA Y ORTOPEDIA', N'', N'')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (38, N'E033', N'', N'UROLOGIA', N'', N'')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (39, N'E034', N'', N'MEDICINA DE EMERGENCIAS Y DESASTRES', N'', N'')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (40, N'E035', N'', N'ANESTESIOLOGIA', N'', N'')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (41, N'E036', N'', N'AUDITORIA MEDICA', N'', N'')
GO
INSERT [dbo].[T120_ESPECIALIDAD] ([idEspecialidad], [codEspecial], [codSigesa], [descripcion], [codSubEspecial], [descSubEspecial]) VALUES (42, N'E037', N'', N'TERAPIA FISICA Y REHABILITACION', N'', N'')
GO
SET IDENTITY_INSERT [dbo].[T120_ESPECIALIDAD] OFF
GO
SET IDENTITY_INSERT [dbo].[T126_GPOSANGRE] ON 
GO
INSERT [dbo].[T126_GPOSANGRE] ([idgpoSangre], [codgpoSangre], [descripcion], [abreviatura]) VALUES (1, N'G00001', N'AB POSITIVO', N'AB+ ')
GO
INSERT [dbo].[T126_GPOSANGRE] ([idgpoSangre], [codgpoSangre], [descripcion], [abreviatura]) VALUES (2, N'G00002', N'AB NEGATIVO', N'AB- ')
GO
INSERT [dbo].[T126_GPOSANGRE] ([idgpoSangre], [codgpoSangre], [descripcion], [abreviatura]) VALUES (3, N'G00003', N'A POSITIVO', N'A+  ')
GO
INSERT [dbo].[T126_GPOSANGRE] ([idgpoSangre], [codgpoSangre], [descripcion], [abreviatura]) VALUES (4, N'G00004', N'A NEGATIVO', N'A-  ')
GO
INSERT [dbo].[T126_GPOSANGRE] ([idgpoSangre], [codgpoSangre], [descripcion], [abreviatura]) VALUES (5, N'G00005', N'B POSITIVO', N'B+  ')
GO
INSERT [dbo].[T126_GPOSANGRE] ([idgpoSangre], [codgpoSangre], [descripcion], [abreviatura]) VALUES (6, N'G00006', N'B NEGATIVO', N'B-  ')
GO
INSERT [dbo].[T126_GPOSANGRE] ([idgpoSangre], [codgpoSangre], [descripcion], [abreviatura]) VALUES (7, N'G00007', N'O POSITIVO', N'O+  ')
GO
INSERT [dbo].[T126_GPOSANGRE] ([idgpoSangre], [codgpoSangre], [descripcion], [abreviatura]) VALUES (8, N'G00008', N'O NEGATIVO', N'O-  ')
GO
INSERT [dbo].[T126_GPOSANGRE] ([idgpoSangre], [codgpoSangre], [descripcion], [abreviatura]) VALUES (9, N'G00009', N'REFIEREO', N'    ')
GO
SET IDENTITY_INSERT [dbo].[T126_GPOSANGRE] OFF
GO
SET IDENTITY_INSERT [dbo].[T172_TPDOCUMENTO] ON 
GO
INSERT [dbo].[T172_TPDOCUMENTO] ([idtpDocumento], [codtpDocumento], [descripcion], [abreviatura], [fuente]) VALUES (1, N'TPD001', N'LIBRETA ELECTORAL O DNI', N'L.E / DNI   ', N'www.sunat.gob.pe/pdt/pdtModulos/independientes/p695/TipoDoc.htm')
GO
INSERT [dbo].[T172_TPDOCUMENTO] ([idtpDocumento], [codtpDocumento], [descripcion], [abreviatura], [fuente]) VALUES (2, N'TPD002', N'CARNET DE EXTRANJERIA', N'CARNET EXT  ', N'www.sunat.gob.pe/pdt/pdtModulos/independientes/p695/TipoDoc.htm')
GO
INSERT [dbo].[T172_TPDOCUMENTO] ([idtpDocumento], [codtpDocumento], [descripcion], [abreviatura], [fuente]) VALUES (3, N'TPD003', N'REGISTRO UNICO DE CONTRIBUYENTES', N'RUC         ', N'www.sunat.gob.pe/pdt/pdtModulos/independientes/p695/TipoDoc.htm')
GO
INSERT [dbo].[T172_TPDOCUMENTO] ([idtpDocumento], [codtpDocumento], [descripcion], [abreviatura], [fuente]) VALUES (4, N'TPD004', N'PASAPORTE', N'            ', N'www.sunat.gob.pe/pdt/pdtModulos/independientes/p695/TipoDoc.htm')
GO
INSERT [dbo].[T172_TPDOCUMENTO] ([idtpDocumento], [codtpDocumento], [descripcion], [abreviatura], [fuente]) VALUES (5, N'TPD005', N'PARTIDA DE NACIMIENTO- IDENTIDAD', N'P. NAC.     ', N'www.sunat.gob.pe/pdt/pdtModulos/independientes/p695/TipoDoc.htm')
GO
INSERT [dbo].[T172_TPDOCUMENTO] ([idtpDocumento], [codtpDocumento], [descripcion], [abreviatura], [fuente]) VALUES (6, N'TPD006', N'OTROS', N'            ', N'www.sunat.gob.pe/pdt/pdtModulos/independientes/p695/TipoDoc.htm')
GO
SET IDENTITY_INSERT [dbo].[T172_TPDOCUMENTO] OFF
GO
SET IDENTITY_INSERT [dbo].[T185_FACTORRH] ON 
GO
INSERT [dbo].[T185_FACTORRH] ([idFactorrh], [codFactorrh], [descripcion], [fuente]) VALUES (1, N'DHC035', N'POSITIVIO+', N'NTS N° 139 MINSA/2018/DGAIN')
GO
INSERT [dbo].[T185_FACTORRH] ([idFactorrh], [codFactorrh], [descripcion], [fuente]) VALUES (2, N'DHC035', N'NEGATIVO-', N'NTS N° 139 MINSA/2018/DGAIN')
GO
SET IDENTITY_INSERT [dbo].[T185_FACTORRH] OFF
GO
SET IDENTITY_INSERT [dbo].[T192_PARENTESCO] ON 
GO
INSERT [dbo].[T192_PARENTESCO] ([idParentesco], [codParentesco], [descripcion], [abreviatura], [fuente]) VALUES (1, N'ANP001', N'PADRE', N'P   ', N'NTS N° 139 MINSA/2018/DGAIN')
GO
INSERT [dbo].[T192_PARENTESCO] ([idParentesco], [codParentesco], [descripcion], [abreviatura], [fuente]) VALUES (2, N'ANP002', N'MADRE', N'M   ', N'NTS N° 139 MINSA/2018/DGAIN')
GO
INSERT [dbo].[T192_PARENTESCO] ([idParentesco], [codParentesco], [descripcion], [abreviatura], [fuente]) VALUES (3, N'ANP003', N'HIJO/A', N'H   ', N'NTS N° 139 MINSA/2018/DGAIN')
GO
INSERT [dbo].[T192_PARENTESCO] ([idParentesco], [codParentesco], [descripcion], [abreviatura], [fuente]) VALUES (4, N'ANP004', N'ABUELA/O', N'A   ', N'NTS N° 139 MINSA/2018/DGAIN')
GO
INSERT [dbo].[T192_PARENTESCO] ([idParentesco], [codParentesco], [descripcion], [abreviatura], [fuente]) VALUES (5, N'ANP005', N'TIA/O', N'T   ', N'NTS N° 139 MINSA/2018/DGAIN')
GO
INSERT [dbo].[T192_PARENTESCO] ([idParentesco], [codParentesco], [descripcion], [abreviatura], [fuente]) VALUES (6, N'ANP006', N'NIETA/O', N'N   ', N'NTS N° 139 MINSA/2018/DGAIN')
GO
INSERT [dbo].[T192_PARENTESCO] ([idParentesco], [codParentesco], [descripcion], [abreviatura], [fuente]) VALUES (7, N'ANP007', N'PADRASTRO', N'PA  ', N'NTS N° 139 MINSA/2018/DGAIN')
GO
INSERT [dbo].[T192_PARENTESCO] ([idParentesco], [codParentesco], [descripcion], [abreviatura], [fuente]) VALUES (8, N'ANP008', N'MADRASTRA', N'MA  ', N'NTS N° 139 MINSA/2018/DGAIN')
GO
INSERT [dbo].[T192_PARENTESCO] ([idParentesco], [codParentesco], [descripcion], [abreviatura], [fuente]) VALUES (9, N'ANP009', N'SOBRINA/O', N'S   ', N'NTS N° 139 MINSA/2018/DGAIN')
GO
INSERT [dbo].[T192_PARENTESCO] ([idParentesco], [codParentesco], [descripcion], [abreviatura], [fuente]) VALUES (10, N'ANP010', N'PRIMA/O', N'PR  ', N'NTS N° 139 MINSA/2018/DGAIN')
GO
INSERT [dbo].[T192_PARENTESCO] ([idParentesco], [codParentesco], [descripcion], [abreviatura], [fuente]) VALUES (11, N'ANP011', N'BIS-ABUELA/O', N'BA  ', N'NTS N° 139 MINSA/2018/DGAIN')
GO
INSERT [dbo].[T192_PARENTESCO] ([idParentesco], [codParentesco], [descripcion], [abreviatura], [fuente]) VALUES (12, N'ANP012', N'AMIGA/O', N'AMG ', N'NTS N° 139 MINSA/2018/DGAIN')
GO
INSERT [dbo].[T192_PARENTESCO] ([idParentesco], [codParentesco], [descripcion], [abreviatura], [fuente]) VALUES (13, N'ANP013', N'YERNO', N'Y   ', N'NTS N° 139 MINSA/2018/DGAIN')
GO
INSERT [dbo].[T192_PARENTESCO] ([idParentesco], [codParentesco], [descripcion], [abreviatura], [fuente]) VALUES (14, N'ANP014', N'NUERA', N'NA  ', N'NTS N° 139 MINSA/2018/DGAIN')
GO
SET IDENTITY_INSERT [dbo].[T192_PARENTESCO] OFF
GO
SET IDENTITY_INSERT [dbo].[T199_ESTCIVIL] ON 
GO
INSERT [dbo].[T199_ESTCIVIL] ([idEstCivil], [codEstCivil], [descripcion], [abreviatura], [fuente]) VALUES (1, N'EDC001', N'SOLTERA/O', N'S    ', N'NTS N° 139 MINSA/2018/DGAIN')
GO
INSERT [dbo].[T199_ESTCIVIL] ([idEstCivil], [codEstCivil], [descripcion], [abreviatura], [fuente]) VALUES (2, N'EDC002', N'CONVIVIENTE', N'CO   ', N'NTS N° 139 MINSA/2018/DGAIN')
GO
INSERT [dbo].[T199_ESTCIVIL] ([idEstCivil], [codEstCivil], [descripcion], [abreviatura], [fuente]) VALUES (3, N'EDC003', N'CASADA/O', N'C    ', N'NTS N° 139 MINSA/2018/DGAIN')
GO
INSERT [dbo].[T199_ESTCIVIL] ([idEstCivil], [codEstCivil], [descripcion], [abreviatura], [fuente]) VALUES (4, N'EDC004', N'SEPARADA/O', N'SP   ', N'NTS N° 139 MINSA/2018/DGAIN')
GO
INSERT [dbo].[T199_ESTCIVIL] ([idEstCivil], [codEstCivil], [descripcion], [abreviatura], [fuente]) VALUES (5, N'EDC005', N'DIVORCIADA/O', N'D    ', N'NTS N° 139 MINSA/2018/DGAIN')
GO
INSERT [dbo].[T199_ESTCIVIL] ([idEstCivil], [codEstCivil], [descripcion], [abreviatura], [fuente]) VALUES (6, N'EDC006', N'VIUDA/O', N'V    ', N'NTS N° 139 MINSA/2018/DGAIN')
GO
INSERT [dbo].[T199_ESTCIVIL] ([idEstCivil], [codEstCivil], [descripcion], [abreviatura], [fuente]) VALUES (7, N'EDC007', N'OTROS', N'O    ', N'NTS N° 139 MINSA/2018/DGAIN')
GO
SET IDENTITY_INSERT [dbo].[T199_ESTCIVIL] OFF
GO
SET IDENTITY_INSERT [dbo].[T200_OCUPACION] ON 
GO
INSERT [dbo].[T200_OCUPACION] ([idOcupacion], [codOcupacion], [descripcion], [abreviatura], [fuente]) VALUES (1, N'DHO001', N'TRABAJADOR/A ESTABLE', N'S   ', N'NTS N° 139 MINSA/2018/DGAIN')
GO
INSERT [dbo].[T200_OCUPACION] ([idOcupacion], [codOcupacion], [descripcion], [abreviatura], [fuente]) VALUES (2, N'DHO002', N'EVENTUAL', N'V   ', N'NTS N° 139 MINSA/2018/DGAIN')
GO
INSERT [dbo].[T200_OCUPACION] ([idOcupacion], [codOcupacion], [descripcion], [abreviatura], [fuente]) VALUES (3, N'EDC003', N'SIN OCUPACION', N'SO  ', N'NTS N° 139 MINSA/2018/DGAIN')
GO
INSERT [dbo].[T200_OCUPACION] ([idOcupacion], [codOcupacion], [descripcion], [abreviatura], [fuente]) VALUES (4, N'EDC004', N'JUBILADA/O', N'J   ', N'NTS N° 139 MINSA/2018/DGAIN')
GO
INSERT [dbo].[T200_OCUPACION] ([idOcupacion], [codOcupacion], [descripcion], [abreviatura], [fuente]) VALUES (5, N'EDC005', N'ESTUDIANTE', N'E   ', N'NTS N° 139 MINSA/2018/DGAIN')
GO
SET IDENTITY_INSERT [dbo].[T200_OCUPACION] OFF
GO
SET IDENTITY_INSERT [dbo].[T212_MEDICO] ON 
GO
INSERT [dbo].[T212_MEDICO] ([idMedico], [codMedico], [nroColegio], [nroRne], [nroRuc], [idtpDocumento], [condicion], [idEmpleado], [idEspecialidad], [idPersona], [estado]) VALUES (1, N'2', 1345, N'12445', 10939939, NULL, NULL, NULL, NULL, NULL, N'Inactivo')
GO
INSERT [dbo].[T212_MEDICO] ([idMedico], [codMedico], [nroColegio], [nroRne], [nroRuc], [idtpDocumento], [condicion], [idEmpleado], [idEspecialidad], [idPersona], [estado]) VALUES (2, N'3', 32342, N'23232', 23939939, NULL, NULL, NULL, NULL, NULL, N'Inactivo')
GO
INSERT [dbo].[T212_MEDICO] ([idMedico], [codMedico], [nroColegio], [nroRne], [nroRuc], [idtpDocumento], [condicion], [idEmpleado], [idEspecialidad], [idPersona], [estado]) VALUES (3, N'4', 32343, N'23453', 13939939, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[T212_MEDICO] ([idMedico], [codMedico], [nroColegio], [nroRne], [nroRuc], [idtpDocumento], [condicion], [idEmpleado], [idEspecialidad], [idPersona], [estado]) VALUES (4, N'5', 34345, N'23254', 13930239, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[T212_MEDICO] ([idMedico], [codMedico], [nroColegio], [nroRne], [nroRuc], [idtpDocumento], [condicion], [idEmpleado], [idEspecialidad], [idPersona], [estado]) VALUES (5, N'*', 12345678, NULL, 45678945, NULL, NULL, -2147483648, NULL, NULL, N'Activo')
GO
INSERT [dbo].[T212_MEDICO] ([idMedico], [codMedico], [nroColegio], [nroRne], [nroRuc], [idtpDocumento], [condicion], [idEmpleado], [idEspecialidad], [idPersona], [estado]) VALUES (6, N'*', 132312, NULL, 12321323, NULL, NULL, -2147483647, NULL, NULL, N'Inactivo')
GO
INSERT [dbo].[T212_MEDICO] ([idMedico], [codMedico], [nroColegio], [nroRne], [nroRuc], [idtpDocumento], [condicion], [idEmpleado], [idEspecialidad], [idPersona], [estado]) VALUES (7, N'*', 12345678, NULL, 45678945, NULL, NULL, -2147483646, NULL, NULL, N'Activo')
GO
INSERT [dbo].[T212_MEDICO] ([idMedico], [codMedico], [nroColegio], [nroRne], [nroRuc], [idtpDocumento], [condicion], [idEmpleado], [idEspecialidad], [idPersona], [estado]) VALUES (8, N'*', 12312, NULL, 312312, NULL, NULL, -2147483645, NULL, NULL, N'Inactivo')
GO
INSERT [dbo].[T212_MEDICO] ([idMedico], [codMedico], [nroColegio], [nroRne], [nroRuc], [idtpDocumento], [condicion], [idEmpleado], [idEspecialidad], [idPersona], [estado]) VALUES (9, N'*', 5647, NULL, 1070452945, NULL, NULL, -2147483644, NULL, NULL, N'Inactivo')
GO
SET IDENTITY_INSERT [dbo].[T212_MEDICO] OFF
GO
INSERT [dbo].[T218_SERVICIOSCLI] ([idservicioCli], [descripcion], [estado]) VALUES (1, N'CENTRO QUIRURGICO', N'          ')
GO
INSERT [dbo].[T218_SERVICIOSCLI] ([idservicioCli], [descripcion], [estado]) VALUES (2, N'CONSULTA AMBULATORIA', N'          ')
GO
INSERT [dbo].[T218_SERVICIOSCLI] ([idservicioCli], [descripcion], [estado]) VALUES (3, N'DENSITOMETRIA', N'          ')
GO
INSERT [dbo].[T218_SERVICIOSCLI] ([idservicioCli], [descripcion], [estado]) VALUES (4, N'ECOGRAFIAS', N'          ')
GO
INSERT [dbo].[T218_SERVICIOSCLI] ([idservicioCli], [descripcion], [estado]) VALUES (5, N'EMERGENCIA', N'          ')
GO
INSERT [dbo].[T218_SERVICIOSCLI] ([idservicioCli], [descripcion], [estado]) VALUES (6, N'HOSPITALIZACION', N'          ')
GO
INSERT [dbo].[T218_SERVICIOSCLI] ([idservicioCli], [descripcion], [estado]) VALUES (7, N'LABORATORIO', N'          ')
GO
INSERT [dbo].[T218_SERVICIOSCLI] ([idservicioCli], [descripcion], [estado]) VALUES (8, N'OD. CIRUGIA DENTAL', N'          ')
GO
INSERT [dbo].[T218_SERVICIOSCLI] ([idservicioCli], [descripcion], [estado]) VALUES (9, N'COD. INTEGRAL', N'          ')
GO
INSERT [dbo].[T218_SERVICIOSCLI] ([idservicioCli], [descripcion], [estado]) VALUES (10, N'OD. ORTODONCIA', N'          ')
GO
INSERT [dbo].[T218_SERVICIOSCLI] ([idservicioCli], [descripcion], [estado]) VALUES (11, N'OD. PROTESIS', N'          ')
GO
INSERT [dbo].[T218_SERVICIOSCLI] ([idservicioCli], [descripcion], [estado]) VALUES (12, N'ODONTOLOGIA', N'          ')
GO
INSERT [dbo].[T218_SERVICIOSCLI] ([idservicioCli], [descripcion], [estado]) VALUES (13, N'PEDIATRIA PD', N'          ')
GO
INSERT [dbo].[T218_SERVICIOSCLI] ([idservicioCli], [descripcion], [estado]) VALUES (14, N'RAYOS X', N'          ')
GO
INSERT [dbo].[T218_SERVICIOSCLI] ([idservicioCli], [descripcion], [estado]) VALUES (15, N'SALA DE PROCEDIMIENTOS', N'          ')
GO
INSERT [dbo].[T218_SERVICIOSCLI] ([idservicioCli], [descripcion], [estado]) VALUES (16, N'SANIDAD', N'          ')
GO
INSERT [dbo].[T218_SERVICIOSCLI] ([idservicioCli], [descripcion], [estado]) VALUES (17, N'TOMOGRAFIA Y RESONANCIAS', N'          ')
GO
ALTER TABLE [dbo].[D015_PAGO] ADD  CONSTRAINT [dfPagoFecRegistro]  DEFAULT (getdate()) FOR [fecRegistro]
GO
ALTER TABLE [dbo].[D00_TBDETALLE]  WITH CHECK ADD  CONSTRAINT [fk_gralDeta] FOREIGN KEY([idTab])
REFERENCES [dbo].[D00_TBGENERAL] ([idTab])
GO
ALTER TABLE [dbo].[D00_TBDETALLE] CHECK CONSTRAINT [fk_gralDeta]
GO
ALTER TABLE [dbo].[D001_USUARIO]  WITH CHECK ADD  CONSTRAINT [fk_usuEmp] FOREIGN KEY([idEmpleado])
REFERENCES [dbo].[T120_EMPLEADO] ([idEmpleado])
GO
ALTER TABLE [dbo].[D001_USUARIO] CHECK CONSTRAINT [fk_usuEmp]
GO
ALTER TABLE [dbo].[D002_PERFIL]  WITH CHECK ADD  CONSTRAINT [fk_perfUsuario] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[D001_USUARIO] ([idUsuario])
GO
ALTER TABLE [dbo].[D002_PERFIL] CHECK CONSTRAINT [fk_perfUsuario]
GO
ALTER TABLE [dbo].[D003_PERMISO]  WITH CHECK ADD  CONSTRAINT [fk_permiModulo] FOREIGN KEY([idModulo])
REFERENCES [dbo].[D004_MODULO] ([idModulo])
GO
ALTER TABLE [dbo].[D003_PERMISO] CHECK CONSTRAINT [fk_permiModulo]
GO
ALTER TABLE [dbo].[D005_MENU]  WITH CHECK ADD  CONSTRAINT [fk_menuModulo] FOREIGN KEY([idModulo])
REFERENCES [dbo].[D004_MODULO] ([idModulo])
GO
ALTER TABLE [dbo].[D005_MENU] CHECK CONSTRAINT [fk_menuModulo]
GO
ALTER TABLE [dbo].[D006_PERMISOPERFIL]  WITH CHECK ADD  CONSTRAINT [fk_perfilDetail] FOREIGN KEY([idPerfil])
REFERENCES [dbo].[D002_PERFIL] ([idPerfil])
GO
ALTER TABLE [dbo].[D006_PERMISOPERFIL] CHECK CONSTRAINT [fk_perfilDetail]
GO
ALTER TABLE [dbo].[D006_PERMISOPERFIL]  WITH CHECK ADD  CONSTRAINT [fk_permisoDetail] FOREIGN KEY([idPermiso])
REFERENCES [dbo].[D003_PERMISO] ([idPermiso])
GO
ALTER TABLE [dbo].[D006_PERMISOPERFIL] CHECK CONSTRAINT [fk_permisoDetail]
GO
ALTER TABLE [dbo].[D009_EMPRCONVENIODET]  WITH CHECK ADD  CONSTRAINT [fk_empconvDeta] FOREIGN KEY([idemprConvenio])
REFERENCES [dbo].[T011_EMPRCONVENIO] ([idemprConvenio])
GO
ALTER TABLE [dbo].[D009_EMPRCONVENIODET] CHECK CONSTRAINT [fk_empconvDeta]
GO
ALTER TABLE [dbo].[D011_UBIGEONACE]  WITH CHECK ADD  CONSTRAINT [fk_ubiNace] FOREIGN KEY([idUbigeo])
REFERENCES [dbo].[D011_UBIGEO] ([idUbigeo])
GO
ALTER TABLE [dbo].[D011_UBIGEONACE] CHECK CONSTRAINT [fk_ubiNace]
GO
ALTER TABLE [dbo].[D011_UBIGEORESIDE]  WITH CHECK ADD  CONSTRAINT [fk_ubiResi] FOREIGN KEY([idUbigeo])
REFERENCES [dbo].[D011_UBIGEO] ([idUbigeo])
GO
ALTER TABLE [dbo].[D011_UBIGEORESIDE] CHECK CONSTRAINT [fk_ubiResi]
GO
ALTER TABLE [dbo].[D012_CRONOMEDICO]  WITH CHECK ADD  CONSTRAINT [fk_cronoConsul] FOREIGN KEY([idConsultorio])
REFERENCES [dbo].[D008_CONSULTORIO] ([idConsultorio])
GO
ALTER TABLE [dbo].[D012_CRONOMEDICO] CHECK CONSTRAINT [fk_cronoConsul]
GO
ALTER TABLE [dbo].[D012_CRONOMEDICO]  WITH CHECK ADD  CONSTRAINT [fk_cronoEspecial] FOREIGN KEY([idEspecialidad])
REFERENCES [dbo].[T120_ESPECIALIDAD] ([idEspecialidad])
GO
ALTER TABLE [dbo].[D012_CRONOMEDICO] CHECK CONSTRAINT [fk_cronoEspecial]
GO
ALTER TABLE [dbo].[D012_CRONOMEDICO]  WITH CHECK ADD  CONSTRAINT [fk_cronoMedico] FOREIGN KEY([idMedico])
REFERENCES [dbo].[T212_MEDICO] ([idMedico])
GO
ALTER TABLE [dbo].[D012_CRONOMEDICO] CHECK CONSTRAINT [fk_cronoMedico]
GO
ALTER TABLE [dbo].[D014_CONSULESPDET]  WITH CHECK ADD  CONSTRAINT [fk_conConDet] FOREIGN KEY([idConsultorio])
REFERENCES [dbo].[D008_CONSULTORIO] ([idConsultorio])
GO
ALTER TABLE [dbo].[D014_CONSULESPDET] CHECK CONSTRAINT [fk_conConDet]
GO
ALTER TABLE [dbo].[D014_CONSULESPDET]  WITH CHECK ADD  CONSTRAINT [fk_espConsDet] FOREIGN KEY([idEspecialidad])
REFERENCES [dbo].[T120_ESPECIALIDAD] ([idEspecialidad])
GO
ALTER TABLE [dbo].[D014_CONSULESPDET] CHECK CONSTRAINT [fk_espConsDet]
GO
ALTER TABLE [dbo].[D014_TELEQUERY]  WITH CHECK ADD  CONSTRAINT [fk_teleqCita] FOREIGN KEY([idCita])
REFERENCES [dbo].[T068_CITA] ([idCita])
GO
ALTER TABLE [dbo].[D014_TELEQUERY] CHECK CONSTRAINT [fk_teleqCita]
GO
ALTER TABLE [dbo].[D014_TELEQUERY]  WITH CHECK ADD  CONSTRAINT [fk_teleqConsul] FOREIGN KEY([idConsultorio])
REFERENCES [dbo].[D008_CONSULTORIO] ([idConsultorio])
GO
ALTER TABLE [dbo].[D014_TELEQUERY] CHECK CONSTRAINT [fk_teleqConsul]
GO
ALTER TABLE [dbo].[D014_TELEQUERY]  WITH CHECK ADD  CONSTRAINT [fk_teleqEspec] FOREIGN KEY([idEspecialidad])
REFERENCES [dbo].[T120_ESPECIALIDAD] ([idEspecialidad])
GO
ALTER TABLE [dbo].[D014_TELEQUERY] CHECK CONSTRAINT [fk_teleqEspec]
GO
ALTER TABLE [dbo].[D014_TELEQUERY]  WITH CHECK ADD  CONSTRAINT [fk_teleqMed] FOREIGN KEY([idMedico])
REFERENCES [dbo].[T212_MEDICO] ([idMedico])
GO
ALTER TABLE [dbo].[D014_TELEQUERY] CHECK CONSTRAINT [fk_teleqMed]
GO
ALTER TABLE [dbo].[D014_TELEQUERY]  WITH CHECK ADD  CONSTRAINT [fk_teleqPer] FOREIGN KEY([idPaciente])
REFERENCES [dbo].[T000_PERSONA] ([idPersona])
GO
ALTER TABLE [dbo].[D014_TELEQUERY] CHECK CONSTRAINT [fk_teleqPer]
GO
ALTER TABLE [dbo].[D015_PAGO]  WITH CHECK ADD  CONSTRAINT [fk_pagoCita] FOREIGN KEY([idCita])
REFERENCES [dbo].[T068_CITA] ([idCita])
GO
ALTER TABLE [dbo].[D015_PAGO] CHECK CONSTRAINT [fk_pagoCita]
GO
ALTER TABLE [dbo].[D015_PAGO]  WITH CHECK ADD  CONSTRAINT [fk_pagoFormaPag] FOREIGN KEY([idFormaPago])
REFERENCES [dbo].[D019_FORMAPAGO] ([idFormaPago])
GO
ALTER TABLE [dbo].[D015_PAGO] CHECK CONSTRAINT [fk_pagoFormaPag]
GO
ALTER TABLE [dbo].[D015_PAGODETA]  WITH CHECK ADD  CONSTRAINT [fk_detaExamen] FOREIGN KEY([idExamSpecial])
REFERENCES [dbo].[T257_EXAMESPECIAL] ([idExamSpecial])
GO
ALTER TABLE [dbo].[D015_PAGODETA] CHECK CONSTRAINT [fk_detaExamen]
GO
ALTER TABLE [dbo].[D015_PAGODETA]  WITH CHECK ADD  CONSTRAINT [fk_detaLaboratory] FOREIGN KEY([idLaboratorio])
REFERENCES [dbo].[T175_LABORATORIO] ([idLaboratorio])
GO
ALTER TABLE [dbo].[D015_PAGODETA] CHECK CONSTRAINT [fk_detaLaboratory]
GO
ALTER TABLE [dbo].[D015_PAGODETA]  WITH CHECK ADD  CONSTRAINT [fk_detaPago] FOREIGN KEY([idPago])
REFERENCES [dbo].[D015_PAGO] ([idPago])
GO
ALTER TABLE [dbo].[D015_PAGODETA] CHECK CONSTRAINT [fk_detaPago]
GO
ALTER TABLE [dbo].[D015_PAGODETA]  WITH CHECK ADD  CONSTRAINT [fk_detaReceta] FOREIGN KEY([idReceta])
REFERENCES [dbo].[T213_RECETAELEC] ([idReceta])
GO
ALTER TABLE [dbo].[D015_PAGODETA] CHECK CONSTRAINT [fk_detaReceta]
GO
ALTER TABLE [dbo].[D015_PAGODETA]  WITH CHECK ADD  CONSTRAINT [fk_detaServicio] FOREIGN KEY([idservicioCli])
REFERENCES [dbo].[T218_SERVICIOSCLI] ([idservicioCli])
GO
ALTER TABLE [dbo].[D015_PAGODETA] CHECK CONSTRAINT [fk_detaServicio]
GO
ALTER TABLE [dbo].[D016_DETLABORATORIO]  WITH CHECK ADD  CONSTRAINT [fk_detLaborCita] FOREIGN KEY([idCita])
REFERENCES [dbo].[T068_CITA] ([idCita])
GO
ALTER TABLE [dbo].[D016_DETLABORATORIO] CHECK CONSTRAINT [fk_detLaborCita]
GO
ALTER TABLE [dbo].[D016_DETLABORATORIO]  WITH CHECK ADD  CONSTRAINT [fk_detLaboroLab] FOREIGN KEY([idLaboratorio])
REFERENCES [dbo].[T175_LABORATORIO] ([idLaboratorio])
GO
ALTER TABLE [dbo].[D016_DETLABORATORIO] CHECK CONSTRAINT [fk_detLaboroLab]
GO
ALTER TABLE [dbo].[D016_DETRECETA]  WITH CHECK ADD  CONSTRAINT [fk_detReceta] FOREIGN KEY([idReceta])
REFERENCES [dbo].[T213_RECETAELEC] ([idReceta])
GO
ALTER TABLE [dbo].[D016_DETRECETA] CHECK CONSTRAINT [fk_detReceta]
GO
ALTER TABLE [dbo].[D016_DETRECETA]  WITH CHECK ADD  CONSTRAINT [fk_detRecetaMedica] FOREIGN KEY([idMedicaNrcg])
REFERENCES [dbo].[T007_MEDICAMENTONRCG] ([idMedicaNrcg])
GO
ALTER TABLE [dbo].[D016_DETRECETA] CHECK CONSTRAINT [fk_detRecetaMedica]
GO
ALTER TABLE [dbo].[D018_DETEXAMEN]  WITH CHECK ADD  CONSTRAINT [fk_detExamCita] FOREIGN KEY([idCita])
REFERENCES [dbo].[T068_CITA] ([idCita])
GO
ALTER TABLE [dbo].[D018_DETEXAMEN] CHECK CONSTRAINT [fk_detExamCita]
GO
ALTER TABLE [dbo].[D018_DETEXAMEN]  WITH CHECK ADD  CONSTRAINT [fk_detExamSpec] FOREIGN KEY([idExamSpecial])
REFERENCES [dbo].[T257_EXAMESPECIAL] ([idExamSpecial])
GO
ALTER TABLE [dbo].[D018_DETEXAMEN] CHECK CONSTRAINT [fk_detExamSpec]
GO
ALTER TABLE [dbo].[D020_TARJETA]  WITH CHECK ADD  CONSTRAINT [fk_tarjetaPago] FOREIGN KEY([idPago])
REFERENCES [dbo].[D015_PAGO] ([idPago])
GO
ALTER TABLE [dbo].[D020_TARJETA] CHECK CONSTRAINT [fk_tarjetaPago]
GO
ALTER TABLE [dbo].[D020_TARJETA]  WITH CHECK ADD  CONSTRAINT [fk_tarjTargetCred] FOREIGN KEY([idTarjCredito])
REFERENCES [dbo].[D021_TARJETACREDIT] ([idTarjCredito])
GO
ALTER TABLE [dbo].[D020_TARJETA] CHECK CONSTRAINT [fk_tarjTargetCred]
GO
ALTER TABLE [dbo].[D025_ASIGNACAJA]  WITH CHECK ADD  CONSTRAINT [fk_cajaAdmicion] FOREIGN KEY([idCaja])
REFERENCES [dbo].[D024_CAJA] ([idCaja])
GO
ALTER TABLE [dbo].[D025_ASIGNACAJA] CHECK CONSTRAINT [fk_cajaAdmicion]
GO
ALTER TABLE [dbo].[D025_ASIGNACAJA]  WITH CHECK ADD  CONSTRAINT [fk_cajaEmpl] FOREIGN KEY([idEmpleado])
REFERENCES [dbo].[T120_EMPLEADO] ([idEmpleado])
GO
ALTER TABLE [dbo].[D025_ASIGNACAJA] CHECK CONSTRAINT [fk_cajaEmpl]
GO
ALTER TABLE [dbo].[T000_HCGINECOLOGIA]  WITH CHECK ADD  CONSTRAINT [fk_hcgAtcSustancia] FOREIGN KEY([idAtcSustancia])
REFERENCES [dbo].[T146_ATCSUSTANCIA] ([idAtcSustancia])
GO
ALTER TABLE [dbo].[T000_HCGINECOLOGIA] CHECK CONSTRAINT [fk_hcgAtcSustancia]
GO
ALTER TABLE [dbo].[T000_HCGINECOLOGIA]  WITH CHECK ADD  CONSTRAINT [fk_hcgCie10Especial] FOREIGN KEY([idCIE10Especial])
REFERENCES [dbo].[T147_CIE10ESPECIALIDAD] ([idCIE10Especial])
GO
ALTER TABLE [dbo].[T000_HCGINECOLOGIA] CHECK CONSTRAINT [fk_hcgCie10Especial]
GO
ALTER TABLE [dbo].[T000_HCGINECOLOGIA]  WITH CHECK ADD  CONSTRAINT [fk_hcgClasiAtencion] FOREIGN KEY([idClasifiAtencion])
REFERENCES [dbo].[T144_CLASIFIATENCION] ([idClasifiAtencion])
GO
ALTER TABLE [dbo].[T000_HCGINECOLOGIA] CHECK CONSTRAINT [fk_hcgClasiAtencion]
GO
ALTER TABLE [dbo].[T000_HCGINECOLOGIA]  WITH CHECK ADD  CONSTRAINT [fk_hcgDatoPacHCE] FOREIGN KEY([idDatospacHCE])
REFERENCES [dbo].[T145_DATOSPACHCE] ([idDatospacHCE])
GO
ALTER TABLE [dbo].[T000_HCGINECOLOGIA] CHECK CONSTRAINT [fk_hcgDatoPacHCE]
GO
ALTER TABLE [dbo].[T000_HCGINECOLOGIA]  WITH CHECK ADD  CONSTRAINT [fk_hcgEstaAtencion] FOREIGN KEY([idEstAtencion])
REFERENCES [dbo].[T129_ESTADOATENCION] ([idEstAtencion])
GO
ALTER TABLE [dbo].[T000_HCGINECOLOGIA] CHECK CONSTRAINT [fk_hcgEstaAtencion]
GO
ALTER TABLE [dbo].[T000_HCGINECOLOGIA]  WITH CHECK ADD  CONSTRAINT [fk_hcgFormatAnxHIS] FOREIGN KEY([idFormatAnxHis])
REFERENCES [dbo].[T140_FORMATOANXHIS] ([idFormatAnxHis])
GO
ALTER TABLE [dbo].[T000_HCGINECOLOGIA] CHECK CONSTRAINT [fk_hcgFormatAnxHIS]
GO
ALTER TABLE [dbo].[T000_HCGINECOLOGIA]  WITH CHECK ADD  CONSTRAINT [fk_hcgPatoGesta] FOREIGN KEY([idPatoGestacion])
REFERENCES [dbo].[T056_PATOGESTACION] ([idPatoGestacion])
GO
ALTER TABLE [dbo].[T000_HCGINECOLOGIA] CHECK CONSTRAINT [fk_hcgPatoGesta]
GO
ALTER TABLE [dbo].[T000_HCGINECOLOGIA]  WITH CHECK ADD  CONSTRAINT [fk_hcgPatoNace] FOREIGN KEY([idPatologiaNace])
REFERENCES [dbo].[T193_PATOLOGIANACE] ([idPatologiaNace])
GO
ALTER TABLE [dbo].[T000_HCGINECOLOGIA] CHECK CONSTRAINT [fk_hcgPatoNace]
GO
ALTER TABLE [dbo].[T000_HCGINECOLOGIA]  WITH CHECK ADD  CONSTRAINT [fk_hcgPerfilSalud] FOREIGN KEY([idPerfilSalud])
REFERENCES [dbo].[T119_PERFILSALUD] ([idPerfilSalud])
GO
ALTER TABLE [dbo].[T000_HCGINECOLOGIA] CHECK CONSTRAINT [fk_hcgPerfilSalud]
GO
ALTER TABLE [dbo].[T000_HCGINECOLOGIA]  WITH CHECK ADD  CONSTRAINT [fk_hcgProtocolo] FOREIGN KEY([idProtocolo])
REFERENCES [dbo].[T149_PROTOCOLO] ([idProtocolo])
GO
ALTER TABLE [dbo].[T000_HCGINECOLOGIA] CHECK CONSTRAINT [fk_hcgProtocolo]
GO
ALTER TABLE [dbo].[T000_HCGINECOLOGIA]  WITH CHECK ADD  CONSTRAINT [fk_hcgRecetaElec] FOREIGN KEY([idtpRecetaElec])
REFERENCES [dbo].[T128_TPRECETAELECTRO] ([idtpRecetaElec])
GO
ALTER TABLE [dbo].[T000_HCGINECOLOGIA] CHECK CONSTRAINT [fk_hcgRecetaElec]
GO
ALTER TABLE [dbo].[T000_HCGINECOLOGIA]  WITH CHECK ADD  CONSTRAINT [fk_hcgSiteds] FOREIGN KEY([idHojaSiteds])
REFERENCES [dbo].[T148_HOJASITEDS] ([idHojaSiteds])
GO
ALTER TABLE [dbo].[T000_HCGINECOLOGIA] CHECK CONSTRAINT [fk_hcgSiteds]
GO
ALTER TABLE [dbo].[T000_HCGINECOLOGIA]  WITH CHECK ADD  CONSTRAINT [fk_hcgtpEmbarazo] FOREIGN KEY([idtpEmbarazo])
REFERENCES [dbo].[T194_TPEMBARAZO] ([idtpEmbarazo])
GO
ALTER TABLE [dbo].[T000_HCGINECOLOGIA] CHECK CONSTRAINT [fk_hcgtpEmbarazo]
GO
ALTER TABLE [dbo].[T000_HCGINECOLOGIA]  WITH CHECK ADD  CONSTRAINT [fk_hcgTpPacFrec] FOREIGN KEY([idtpPacFrecuente])
REFERENCES [dbo].[T139_TPPACFRECUENTE] ([idtpPacFrecuente])
GO
ALTER TABLE [dbo].[T000_HCGINECOLOGIA] CHECK CONSTRAINT [fk_hcgTpPacFrec]
GO
ALTER TABLE [dbo].[T000_HCGINECOLOGIA]  WITH CHECK ADD  CONSTRAINT [fk_hcgTpPartoDeta] FOREIGN KEY([idtpPartoDeta])
REFERENCES [dbo].[T188_TPPARTODETA] ([idtpPartoDeta])
GO
ALTER TABLE [dbo].[T000_HCGINECOLOGIA] CHECK CONSTRAINT [fk_hcgTpPartoDeta]
GO
ALTER TABLE [dbo].[T000_HCGINECOLOGIA]  WITH CHECK ADD  CONSTRAINT [fk_hcgtpProcPsico] FOREIGN KEY([idtpProcPsico])
REFERENCES [dbo].[T196_TPPROCPSICO] ([idtpProcPsico])
GO
ALTER TABLE [dbo].[T000_HCGINECOLOGIA] CHECK CONSTRAINT [fk_hcgtpProcPsico]
GO
ALTER TABLE [dbo].[T000_HCGINECOLOGIA]  WITH CHECK ADD  CONSTRAINT [fk_hcnPeritorio] FOREIGN KEY([idPeritorio])
REFERENCES [dbo].[T083_PERITORIO] ([idPeritorio])
GO
ALTER TABLE [dbo].[T000_HCGINECOLOGIA] CHECK CONSTRAINT [fk_hcnPeritorio]
GO
ALTER TABLE [dbo].[T000_HCNUTRICION]  WITH CHECK ADD  CONSTRAINT [fk_hcgEdadEvaluaAli] FOREIGN KEY([idEdadEvaluaAli])
REFERENCES [dbo].[T205_EDADEVALUAALI] ([idEdadEvaluaAli])
GO
ALTER TABLE [dbo].[T000_HCNUTRICION] CHECK CONSTRAINT [fk_hcgEdadEvaluaAli]
GO
ALTER TABLE [dbo].[T000_HCNUTRICION]  WITH CHECK ADD  CONSTRAINT [fk_hcnAnamneAli] FOREIGN KEY([idAnamnesiAli])
REFERENCES [dbo].[T202_ANAMNESIALI] ([idAnamnesiAli])
GO
ALTER TABLE [dbo].[T000_HCNUTRICION] CHECK CONSTRAINT [fk_hcnAnamneAli]
GO
ALTER TABLE [dbo].[T000_HCNUTRICION]  WITH CHECK ADD  CONSTRAINT [fk_hcnAntropome] FOREIGN KEY([idAntropometrico])
REFERENCES [dbo].[T280_ANTROPOMETRICO] ([idAntropometrico])
GO
ALTER TABLE [dbo].[T000_HCNUTRICION] CHECK CONSTRAINT [fk_hcnAntropome]
GO
ALTER TABLE [dbo].[T000_HCNUTRICION]  WITH CHECK ADD  CONSTRAINT [fk_hcnEsquemaAli] FOREIGN KEY([idEsquemaAli])
REFERENCES [dbo].[T267_ESQUEMALIMENTO] ([idEsquemaAli])
GO
ALTER TABLE [dbo].[T000_HCNUTRICION] CHECK CONSTRAINT [fk_hcnEsquemaAli]
GO
ALTER TABLE [dbo].[T000_HCNUTRICION]  WITH CHECK ADD  CONSTRAINT [fk_hcnEstadoA] FOREIGN KEY([idEstaActual])
REFERENCES [dbo].[T201_ESTADOACTUAL] ([idEstaActual])
GO
ALTER TABLE [dbo].[T000_HCNUTRICION] CHECK CONSTRAINT [fk_hcnEstadoA]
GO
ALTER TABLE [dbo].[T000_HCNUTRICION]  WITH CHECK ADD  CONSTRAINT [fk_hcnEstaNutri] FOREIGN KEY([idEstaNutricion])
REFERENCES [dbo].[T208_ESTADONUTRICION] ([idEstaNutricion])
GO
ALTER TABLE [dbo].[T000_HCNUTRICION] CHECK CONSTRAINT [fk_hcnEstaNutri]
GO
ALTER TABLE [dbo].[T000_HCNUTRICION]  WITH CHECK ADD  CONSTRAINT [fk_hcnEvaluAli] FOREIGN KEY([idEvaluaAli])
REFERENCES [dbo].[T204_EVALUAALI] ([idEvaluaAli])
GO
ALTER TABLE [dbo].[T000_HCNUTRICION] CHECK CONSTRAINT [fk_hcnEvaluAli]
GO
ALTER TABLE [dbo].[T000_HCNUTRICION]  WITH CHECK ADD  CONSTRAINT [fk_hcnFormatNut] FOREIGN KEY([idFormatoNutri])
REFERENCES [dbo].[T277_FORMATONUTRI] ([idFormatoNutri])
GO
ALTER TABLE [dbo].[T000_HCNUTRICION] CHECK CONSTRAINT [fk_hcnFormatNut]
GO
ALTER TABLE [dbo].[T000_HCNUTRICION]  WITH CHECK ADD  CONSTRAINT [fk_hcnFrecAli] FOREIGN KEY([idFreconsumoAli])
REFERENCES [dbo].[T203_FRECONSUMOALI] ([idFreconsumoAli])
GO
ALTER TABLE [dbo].[T000_HCNUTRICION] CHECK CONSTRAINT [fk_hcnFrecAli]
GO
ALTER TABLE [dbo].[T000_HCNUTRICION]  WITH CHECK ADD  CONSTRAINT [fk_hcngpoNutri] FOREIGN KEY([idgpoNutricion])
REFERENCES [dbo].[T263_GPONUTRICION] ([idgpoNutricion])
GO
ALTER TABLE [dbo].[T000_HCNUTRICION] CHECK CONSTRAINT [fk_hcngpoNutri]
GO
ALTER TABLE [dbo].[T000_HCNUTRICION]  WITH CHECK ADD  CONSTRAINT [fk_hcnInventAli] FOREIGN KEY([idInventAlimento])
REFERENCES [dbo].[T268_INVENTALIMENTO] ([idInventAlimento])
GO
ALTER TABLE [dbo].[T000_HCNUTRICION] CHECK CONSTRAINT [fk_hcnInventAli]
GO
ALTER TABLE [dbo].[T000_HCNUTRICION]  WITH CHECK ADD  CONSTRAINT [fk_hcnRecomendaNut] FOREIGN KEY([idRecomendaNutri])
REFERENCES [dbo].[T269_RECOMENDANUTRI] ([idRecomendaNutri])
GO
ALTER TABLE [dbo].[T000_HCNUTRICION] CHECK CONSTRAINT [fk_hcnRecomendaNut]
GO
ALTER TABLE [dbo].[T000_HCNUTRICION]  WITH CHECK ADD  CONSTRAINT [fk_hcntpLactancia] FOREIGN KEY([idtpLactancia])
REFERENCES [dbo].[T278_TIPOLACTANCIA] ([idtpLactancia])
GO
ALTER TABLE [dbo].[T000_HCNUTRICION] CHECK CONSTRAINT [fk_hcntpLactancia]
GO
ALTER TABLE [dbo].[T000_HCNUTRICION]  WITH CHECK ADD  CONSTRAINT [fk_hcnValorNutri] FOREIGN KEY([idvalorNutricion])
REFERENCES [dbo].[T264_VALORNUTRICION] ([idvalorNutricion])
GO
ALTER TABLE [dbo].[T000_HCNUTRICION] CHECK CONSTRAINT [fk_hcnValorNutri]
GO
ALTER TABLE [dbo].[T000_HISTORIACLIDETA]  WITH CHECK ADD  CONSTRAINT [fk_hcDetalle] FOREIGN KEY([idHistoClinica])
REFERENCES [dbo].[T000_HISTORIACLINICA] ([idHistoClinica])
GO
ALTER TABLE [dbo].[T000_HISTORIACLIDETA] CHECK CONSTRAINT [fk_hcDetalle]
GO
ALTER TABLE [dbo].[T000_HISTORIACLINICA]  WITH CHECK ADD  CONSTRAINT [fk_hcEstandar] FOREIGN KEY([idhcEstandar])
REFERENCES [dbo].[T000_HCESTANDAR] ([idhcEstandar])
GO
ALTER TABLE [dbo].[T000_HISTORIACLINICA] CHECK CONSTRAINT [fk_hcEstandar]
GO
ALTER TABLE [dbo].[T000_HISTORIACLINICA]  WITH CHECK ADD  CONSTRAINT [fk_hcGineco] FOREIGN KEY([idhcGineco])
REFERENCES [dbo].[T000_HCGINECOLOGIA] ([idhcGineco])
GO
ALTER TABLE [dbo].[T000_HISTORIACLINICA] CHECK CONSTRAINT [fk_hcGineco]
GO
ALTER TABLE [dbo].[T000_HISTORIACLINICA]  WITH CHECK ADD  CONSTRAINT [fk_hcNutricion] FOREIGN KEY([idhcNutricion])
REFERENCES [dbo].[T000_HCNUTRICION] ([idhcNutricion])
GO
ALTER TABLE [dbo].[T000_HISTORIACLINICA] CHECK CONSTRAINT [fk_hcNutricion]
GO
ALTER TABLE [dbo].[T000_PERSONA]  WITH CHECK ADD  CONSTRAINT [fk_pacciaSeguro] FOREIGN KEY([idciaSeguro])
REFERENCES [dbo].[T018_CIASEGURO] ([idciaSeguro])
GO
ALTER TABLE [dbo].[T000_PERSONA] CHECK CONSTRAINT [fk_pacciaSeguro]
GO
ALTER TABLE [dbo].[T000_PERSONA]  WITH CHECK ADD  CONSTRAINT [fk_pacEmprConvenio] FOREIGN KEY([idemprConvenio])
REFERENCES [dbo].[T011_EMPRCONVENIO] ([idemprConvenio])
GO
ALTER TABLE [dbo].[T000_PERSONA] CHECK CONSTRAINT [fk_pacEmprConvenio]
GO
ALTER TABLE [dbo].[T000_PERSONA]  WITH CHECK ADD  CONSTRAINT [fk_perEstCivil] FOREIGN KEY([idEstCivil])
REFERENCES [dbo].[T199_ESTCIVIL] ([idEstCivil])
GO
ALTER TABLE [dbo].[T000_PERSONA] CHECK CONSTRAINT [fk_perEstCivil]
GO
ALTER TABLE [dbo].[T000_PERSONA]  WITH CHECK ADD  CONSTRAINT [fk_perEtnico] FOREIGN KEY([idEtnico])
REFERENCES [dbo].[DT004_ETNICO] ([idEtnico])
GO
ALTER TABLE [dbo].[T000_PERSONA] CHECK CONSTRAINT [fk_perEtnico]
GO
ALTER TABLE [dbo].[T000_PERSONA]  WITH CHECK ADD  CONSTRAINT [fk_perFactorh] FOREIGN KEY([idFactorrh])
REFERENCES [dbo].[T185_FACTORRH] ([idFactorrh])
GO
ALTER TABLE [dbo].[T000_PERSONA] CHECK CONSTRAINT [fk_perFactorh]
GO
ALTER TABLE [dbo].[T000_PERSONA]  WITH CHECK ADD  CONSTRAINT [fk_perGpoSangre] FOREIGN KEY([idgpoSangre])
REFERENCES [dbo].[T126_GPOSANGRE] ([idgpoSangre])
GO
ALTER TABLE [dbo].[T000_PERSONA] CHECK CONSTRAINT [fk_perGpoSangre]
GO
ALTER TABLE [dbo].[T000_PERSONA]  WITH CHECK ADD  CONSTRAINT [fk_perGrdInstruc] FOREIGN KEY([idGrdInstruc])
REFERENCES [dbo].[T198_GRADINSTRUCCION] ([idGrdInstruc])
GO
ALTER TABLE [dbo].[T000_PERSONA] CHECK CONSTRAINT [fk_perGrdInstruc]
GO
ALTER TABLE [dbo].[T000_PERSONA]  WITH CHECK ADD  CONSTRAINT [fk_perIafa] FOREIGN KEY([idtipoIafa])
REFERENCES [dbo].[T017_TIPOIAFA] ([idtipoIafa])
GO
ALTER TABLE [dbo].[T000_PERSONA] CHECK CONSTRAINT [fk_perIafa]
GO
ALTER TABLE [dbo].[T000_PERSONA]  WITH CHECK ADD  CONSTRAINT [fk_perNace] FOREIGN KEY([idUbigeoNace])
REFERENCES [dbo].[D011_UBIGEONACE] ([idUbigeoNace])
GO
ALTER TABLE [dbo].[T000_PERSONA] CHECK CONSTRAINT [fk_perNace]
GO
ALTER TABLE [dbo].[T000_PERSONA]  WITH CHECK ADD  CONSTRAINT [fk_perOcupa] FOREIGN KEY([idOcupacion])
REFERENCES [dbo].[T200_OCUPACION] ([idOcupacion])
GO
ALTER TABLE [dbo].[T000_PERSONA] CHECK CONSTRAINT [fk_perOcupa]
GO
ALTER TABLE [dbo].[T000_PERSONA]  WITH CHECK ADD  CONSTRAINT [fk_perParent] FOREIGN KEY([idParentesco])
REFERENCES [dbo].[T192_PARENTESCO] ([idParentesco])
GO
ALTER TABLE [dbo].[T000_PERSONA] CHECK CONSTRAINT [fk_perParent]
GO
ALTER TABLE [dbo].[T000_PERSONA]  WITH CHECK ADD  CONSTRAINT [fk_perReligion] FOREIGN KEY([idReligion])
REFERENCES [dbo].[T057_RELIGION] ([idReligion])
GO
ALTER TABLE [dbo].[T000_PERSONA] CHECK CONSTRAINT [fk_perReligion]
GO
ALTER TABLE [dbo].[T000_PERSONA]  WITH CHECK ADD  CONSTRAINT [fk_perReside] FOREIGN KEY([idUbigeoResi])
REFERENCES [dbo].[D011_UBIGEORESIDE] ([idUbigeoResi])
GO
ALTER TABLE [dbo].[T000_PERSONA] CHECK CONSTRAINT [fk_perReside]
GO
ALTER TABLE [dbo].[T000_PERSONA]  WITH CHECK ADD  CONSTRAINT [fk_perSexo] FOREIGN KEY([idSexo])
REFERENCES [dbo].[T071_SEXO] ([idSexo])
GO
ALTER TABLE [dbo].[T000_PERSONA] CHECK CONSTRAINT [fk_perSexo]
GO
ALTER TABLE [dbo].[T000_PERSONA]  WITH CHECK ADD  CONSTRAINT [fk_perSiteds] FOREIGN KEY([iddatoSiteds])
REFERENCES [dbo].[T006_DATOSITEDS] ([iddatoSiteds])
GO
ALTER TABLE [dbo].[T000_PERSONA] CHECK CONSTRAINT [fk_perSiteds]
GO
ALTER TABLE [dbo].[T000_PERSONA]  WITH CHECK ADD  CONSTRAINT [fk_perTipoVia] FOREIGN KEY([idtipoVia])
REFERENCES [dbo].[D022_TIPOVIA] ([idTipoVia])
GO
ALTER TABLE [dbo].[T000_PERSONA] CHECK CONSTRAINT [fk_perTipoVia]
GO
ALTER TABLE [dbo].[T000_PERSONA]  WITH CHECK ADD  CONSTRAINT [fk_pertpDocu] FOREIGN KEY([idtpDocumento])
REFERENCES [dbo].[T172_TPDOCUMENTO] ([idtpDocumento])
GO
ALTER TABLE [dbo].[T000_PERSONA] CHECK CONSTRAINT [fk_pertpDocu]
GO
ALTER TABLE [dbo].[T000_PERSONA]  WITH CHECK ADD  CONSTRAINT [fk_perUbiNace] FOREIGN KEY([idUbigeoNace])
REFERENCES [dbo].[D011_UBIGEONACE] ([idUbigeoNace])
GO
ALTER TABLE [dbo].[T000_PERSONA] CHECK CONSTRAINT [fk_perUbiNace]
GO
ALTER TABLE [dbo].[T000_PERSONA]  WITH CHECK ADD  CONSTRAINT [fk_perUbiReside] FOREIGN KEY([idUbigeoResi])
REFERENCES [dbo].[D011_UBIGEORESIDE] ([idUbigeoResi])
GO
ALTER TABLE [dbo].[T000_PERSONA] CHECK CONSTRAINT [fk_perUbiReside]
GO
ALTER TABLE [dbo].[T001_PACASEGURADO]  WITH CHECK ADD  CONSTRAINT [fk_PacAsegurado] FOREIGN KEY([idPaciente])
REFERENCES [dbo].[T001_PACIENTE] ([idPaciente])
GO
ALTER TABLE [dbo].[T001_PACASEGURADO] CHECK CONSTRAINT [fk_PacAsegurado]
GO
ALTER TABLE [dbo].[T001_PACCONVENIO]  WITH CHECK ADD  CONSTRAINT [fk_pacConvenio] FOREIGN KEY([idPaciente])
REFERENCES [dbo].[T001_PACIENTE] ([idPaciente])
GO
ALTER TABLE [dbo].[T001_PACCONVENIO] CHECK CONSTRAINT [fk_pacConvenio]
GO
ALTER TABLE [dbo].[T001_PACDETA]  WITH CHECK ADD  CONSTRAINT [fk_pacDetalle] FOREIGN KEY([idPacciente])
REFERENCES [dbo].[T001_PACIENTE] ([idPaciente])
GO
ALTER TABLE [dbo].[T001_PACDETA] CHECK CONSTRAINT [fk_pacDetalle]
GO
ALTER TABLE [dbo].[T001_PACIENTE]  WITH CHECK ADD  CONSTRAINT [fk_pacTipoPac] FOREIGN KEY([idtpPaciente])
REFERENCES [dbo].[T020_TIPOPACIENTE] ([idtpPaciente])
GO
ALTER TABLE [dbo].[T001_PACIENTE] CHECK CONSTRAINT [fk_pacTipoPac]
GO
ALTER TABLE [dbo].[T001_PACIENTE]  WITH CHECK ADD  CONSTRAINT [fk_perPaciente] FOREIGN KEY([idPersona])
REFERENCES [dbo].[T000_PERSONA] ([idPersona])
GO
ALTER TABLE [dbo].[T001_PACIENTE] CHECK CONSTRAINT [fk_perPaciente]
GO
ALTER TABLE [dbo].[T009_TPPRESTACION]  WITH CHECK ADD  CONSTRAINT [fk_docuPagoPrestacion] FOREIGN KEY([idtpDocuPago])
REFERENCES [dbo].[T080_TPDOCUPAGO] ([idtpDocuPago])
GO
ALTER TABLE [dbo].[T009_TPPRESTACION] CHECK CONSTRAINT [fk_docuPagoPrestacion]
GO
ALTER TABLE [dbo].[T068_CITA]  WITH CHECK ADD  CONSTRAINT [fk_citaServicio] FOREIGN KEY([idservicioCli])
REFERENCES [dbo].[T218_SERVICIOSCLI] ([idservicioCli])
GO
ALTER TABLE [dbo].[T068_CITA] CHECK CONSTRAINT [fk_citaServicio]
GO
ALTER TABLE [dbo].[T120_EMPLEADO]  WITH CHECK ADD  CONSTRAINT [fk_emplPer] FOREIGN KEY([idPersona])
REFERENCES [dbo].[T000_PERSONA] ([idPersona])
GO
ALTER TABLE [dbo].[T120_EMPLEADO] CHECK CONSTRAINT [fk_emplPer]
GO
ALTER TABLE [dbo].[T120_EMPLEADO]  WITH CHECK ADD  CONSTRAINT [fk_empTipoEmp] FOREIGN KEY([idtpEmpleado])
REFERENCES [dbo].[D015_TPEMPLEADO] ([idtpEmpleado])
GO
ALTER TABLE [dbo].[T120_EMPLEADO] CHECK CONSTRAINT [fk_empTipoEmp]
GO
ALTER TABLE [dbo].[TMP_PACIENTE]  WITH CHECK ADD  CONSTRAINT [fk_pertmpPacient] FOREIGN KEY([idPersona])
REFERENCES [dbo].[T000_PERSONA] ([idPersona])
GO
ALTER TABLE [dbo].[TMP_PACIENTE] CHECK CONSTRAINT [fk_pertmpPacient]
GO
ALTER TABLE [dbo].[T000_PERSONA]  WITH CHECK ADD  CONSTRAINT [chkPersoncel] CHECK  (([celular] like '[0-9]*10'))
GO
ALTER TABLE [dbo].[T000_PERSONA] CHECK CONSTRAINT [chkPersoncel]
GO
ALTER TABLE [dbo].[T000_PERSONA]  WITH CHECK ADD  CONSTRAINT [chkPersondni] CHECK  ((len([dniPersona])<=(8)))
GO
ALTER TABLE [dbo].[T000_PERSONA] CHECK CONSTRAINT [chkPersondni]
GO
ALTER TABLE [dbo].[T000_PERSONA]  WITH CHECK ADD  CONSTRAINT [chkPersonruc] CHECK  ((len([nroRuc])<=(11)))
GO
ALTER TABLE [dbo].[T000_PERSONA] CHECK CONSTRAINT [chkPersonruc]
GO
ALTER TABLE [dbo].[T000_PERSONA]  WITH CHECK ADD  CONSTRAINT [chkPersontlf] CHECK  (([telefono] like '[0-9]*10'))
GO
ALTER TABLE [dbo].[T000_PERSONA] CHECK CONSTRAINT [chkPersontlf]
GO

USE [master]
GO
ALTER DATABASE [Clinica] SET  READ_WRITE 
GO
