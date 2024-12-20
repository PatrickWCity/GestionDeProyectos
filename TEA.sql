USE [master]
GO

CREATE DATABASE [PFN3]
GO

USE [PFN3]
GO

Create Function [dbo].[fu_CaracterEspecial]()
RETURNS char(1)
AS
Begin
	declare @carEsp char(1);
	declare @numero int;
	declare @sw int;
	
	set @sw=0;
	While @sw = 0
	Begin
	
	   Select @numero = (Select caracter from v_CaracterEspecial)
	   if(@numero>=33)
	   begin
		   if(@numero<=47)
		   begin
				set @carEsp=char(@numero);
				set @sw=1;
		   end		   
	   end
	End;
	return @carEsp;
End;
GO

Create Function [dbo].[fu_CaracterMayuscula]()
RETURNS char(1)
AS
Begin
	declare @carMay char(1);
	declare @numero int;
	declare @sw int;
	
	set @sw=0;
	While @sw = 0
	Begin
	
	   Select @numero = (Select caracter from v_CaracterMayuscula)
	   if(@numero>=65)
	   begin
		   if(@numero<=90)
		   begin
				set @carMay=char(@numero);
				set @sw=1;
		   end		   
	   end
	End;
	return @carMay;
End;
GO

Create Function [dbo].[fu_CaracterMinuscula]()
RETURNS char(1)
AS
Begin
	declare @carMin char(1);
	declare @numero int;
	declare @sw int;
	
	set @sw=0;
	While @sw = 0
	Begin
	
	   Select @numero = (Select caracter from v_CaracterMinuscula)
	   if(@numero>=97)
	   begin
		   if(@numero<=122)
		   begin
				set @carMin=char(@numero);
				set @sw=1;
		   end		   
	   end
	End;
	return @carMin;
End;
GO

Create Function [dbo].[fu_CaracterNumerico]()
RETURNS char(1)
AS
Begin
	declare @carNum char(1);
	declare @numero int;
	declare @sw int;
	
	set @sw=0;
	While @sw = 0
	Begin
	
	   Select @numero = (Select caracter from v_CaracterNumerico)
	   if(@numero>=48)
	   begin
		   if(@numero<=57)
		   begin
				set @carNum=char(@numero);
				set @sw=1;
		   end		   
	   end
	End;
	return @carNum;
End;
GO

CREATE FUNCTION [dbo].[fu_existeUsuario](@username varchar(20))
RETURNS int
AS
BEGIN
  DECLARE @swExiste int;
  
       SET @swExiste=(
          SELECT COUNT (username)
          FROM ACCESO
          WHERE username=@username
          );
      RETURN @swExiste;    
 
END;  
GO

CREATE FUNCTION [dbo].[fu_obtieneUsername](@nombre VARCHAR(20), @appat VARCHAR(20))
RETURNS VARCHAR(100)
AS
BEGIN
  DECLARE @username VARCHAR(100)
  
  SET @username=UPPER(SUBSTRING(@nombre, 1,1))+LOWER(SUBSTRING(@nombre,2,2))
  SET @username=@username+'.'
  SET @username=@username+UPPER(SUBSTRING(@appat, 1,1))
  SET @username=@username+LOWER(SUBSTRING(@appat,2,2))
  RETURN @username
END;
GO

create FUNCTION [dbo].[fu_usuarioRepetido](@contador int)
RETURNS CHAR(3)
AS
BEGIN
	DECLARE @zeros char(3)
	DECLARE @clon varCHAR(3)
	DECLARE @clon2 varCHAR(3)
	DECLARE @len int

	SET @len = 3
	SET @clon = '0'
	SET @clon2 = '00'



	SET @len = @len - LEN(@contador)

	If (@len = 2)
	BEGIN
		SET @zeros =  @clon2 + CONVERT(char,@contador)
		RETURN @zeros 
	END
	ELSE IF (@len = 1)
	BEGIN	
		SET @zeros =  @clon + CONVERT(char,@contador)
		RETURN @zeros 
	END
	ELSE
	BEGIN
		SET @zeros = CONVERT(char,@contador)
		RETURN @zeros 	
	END

	RETURN @zeros 
END;
GO

create FUNCTION [dbo].[fu_ValidadFortalezaClave](@password VARCHAR (20))
RETURNS INT
AS
BEGIN
  DECLARE @listaCE char(10)
  DECLARE @sw INT
  DECLARE @contador int
  DECLARE @caracter char(1)
  DECLARE @listaNumeros CHAR (10)
  DECLARE @listaLetraMayusculas VARCHAR(10)
  DECLARE @listaLetraMinusculas VARCHAR(10)
  
  SET @listaCE='#$%&/()*@'
  SET @listaNumeros='0123456789'
  SET @listaLetraMayusculas ='ABCDEFGHIJKLMNÑOPQRSTUVWXYZ'
  SET @listaLetraMinusculas =LOWER(@listaLetraMayusculas)
  SET @sw=0 --Password Debil
  
  IF(LEN(@password)<7)
  BEGIN
    SET @sw=1 --Password Fuerte
  END 
  SET @contador=1;
  WHILE(@contador<=LEN(@password))
  BEGIN
      SET @caracter=SUBSTRING(@password,@contador,1)
      IF(CHARINDEX(@caracter,@listaNumeros)>0)
      BEGIN
           SET @sw=@sw+1
           BREAK;
      END
      SET @contador=@contador+1;
    END
  
  RETURN @sw
END;
GO

Create View [dbo].[v_CaracterEspecial]
As
Select ROUND(RAND()*47,0) as Caracter;
GO

Create View [dbo].[v_CaracterMayuscula]
As
Select ROUND(RAND()*90,0) as Caracter;
GO

Create View [dbo].[v_CaracterMinuscula]
As
Select ROUND(RAND()*122,0) as Caracter;
GO

Create View [dbo].[v_CaracterNumerico]
As
Select ROUND(RAND()*57,0) as Caracter;
GO

CREATE TABLE [dbo].[Acceso](
	[id_acceso] [int] IDENTITY(1,1) NOT NULL,
	[nroInterno] [int] NOT NULL,
	[username] [varchar](20) NOT NULL,
	[clave] [varchar](20) NOT NULL,
	[diasCad] [int] NOT NULL,
	[fechaCaducidad] [date] NOT NULL,
	[estadoInicial] [bit] NOT NULL,
	[codigoAut] [varchar](20) NOT NULL,
	[estadoAcceso] [bit] NOT NULL,
	[pregunta] [varchar](255) NULL,
	[respuesta] [varchar](255) NULL,
 CONSTRAINT [PK_Acceso] PRIMARY KEY CLUSTERED 
(
	[id_acceso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Cargo](
	[id_cargo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](60) NOT NULL,
	[descripcion] [varchar](255) NULL,
 CONSTRAINT [PK_Cargo] PRIMARY KEY CLUSTERED 
(
	[id_cargo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Cliente](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[rut] [char](10) NULL,
	[nombre] [varchar](60) NOT NULL,
	[domicilio] [varchar](255) NULL,
	[id_localidad] [int] NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[EmailCliente](
	[id_ec] [int] IDENTITY(1,1) NOT NULL,
	[email] [varchar](255) NOT NULL,
	[id_cliente] [int] NOT NULL,
 CONSTRAINT [PK_EmailCliente] PRIMARY KEY CLUSTERED 
(
	[id_ec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[EmailUsuario](
	[id_eu] [int] IDENTITY(1,1) NOT NULL,
	[email] [varchar](255) NOT NULL,
	[nroInterno] [int] NOT NULL,
 CONSTRAINT [PK_EmailUsuario] PRIMARY KEY CLUSTERED 
(
	[id_eu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[EmpleadoProyecto](
	[id_ep] [int] IDENTITY(1,1) NOT NULL,
	[nroInterno] [int] NULL,
	[id_proyecto] [int] NULL,
	[id_cargo] [int] NULL,
 CONSTRAINT [PK_EmpleadoProyecto] PRIMARY KEY CLUSTERED 
(
	[id_ep] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Especialidad](
	[id_especialidad] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](60) NOT NULL,
	[descripcion] [varchar](255) NULL,
 CONSTRAINT [PK_Especialidad] PRIMARY KEY CLUSTERED 
(
	[id_especialidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[EspecialidadEmpleado](
	[id_ee] [int] IDENTITY(1,1) NOT NULL,
	[id_especialidad] [int] NULL,
	[nroInterno] [int] NULL,
 CONSTRAINT [PK_EspecialidadEmpleado] PRIMARY KEY CLUSTERED 
(
	[id_ee] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[FuenteFinanciamiento](
	[id_fuenteFinanciamiento] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](60) NOT NULL,
	[id_tff] [int] NULL,
 CONSTRAINT [PK_FuenteFinanciamiento] PRIMARY KEY CLUSTERED 
(
	[id_fuenteFinanciamiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[FuenteFinanciamientoProyecto](
	[id_ffp] [int] IDENTITY(1,1) NOT NULL,
	[id_fuenteFinanciamiento] [int] NOT NULL,
	[id_proyecto] [int] NOT NULL,
 CONSTRAINT [PK_FuenteFinanciamientoProyecto] PRIMARY KEY CLUSTERED 
(
	[id_ffp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[GastoEjecutado](
	[id_gastoEjecutado] [int] IDENTITY(1,1) NOT NULL,
	[id_item] [int] NOT NULL,
 CONSTRAINT [PK_GastoEjecutado] PRIMARY KEY CLUSTERED 
(
	[id_gastoEjecutado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[HistoricoAcceso](
	[id_ha] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[estado] [bit] NOT NULL,
	[nroInterno] [int] NOT NULL,
 CONSTRAINT [PK_HistoricoAcceso] PRIMARY KEY CLUSTERED 
(
	[id_ha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[HistoricoPassword](
	[id_hp] [int] IDENTITY(1,1) NOT NULL,
	[clave] [varchar](20) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[nroInterno] [int] NOT NULL,
 CONSTRAINT [PK_HistoricoPassword] PRIMARY KEY CLUSTERED 
(
	[id_hp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[HistoricoUsuario](
	[id_hu] [int] IDENTITY(1,1) NOT NULL,
	[nroInterno] [int] NOT NULL,
	[run] [char](10) NULL,
	[nombre] [varchar](60) NOT NULL,
	[appat] [varchar](60) NOT NULL,
	[apmat] [varchar](60) NULL,
	[direccion] [varchar](255) NOT NULL,
 CONSTRAINT [PK_HistoricoUsuario] PRIMARY KEY CLUSTERED 
(
	[id_hu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Item](
	[id_item] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](60) NOT NULL,
	[descripcion] [varchar](255) NULL,
	[monto] [int] NOT NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[id_item] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ItemPresupuesto](
	[id_ip] [int] IDENTITY(1,1) NOT NULL,
	[id_item] [int] NOT NULL,
	[id_presupuesto] [int] NOT NULL,
 CONSTRAINT [PK_ItemPresupuesto] PRIMARY KEY CLUSTERED 
(
	[id_ip] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Localidad](
	[id_localidad] [int] IDENTITY(1,1) NOT NULL,
	[region] [varchar](60) NOT NULL,
	[providencia] [varchar](60) NOT NULL,
	[comuna] [varchar](60) NOT NULL,
 CONSTRAINT [PK_Localidad] PRIMARY KEY CLUSTERED 
(
	[id_localidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Modulo](
	[id_modulo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](255) NOT NULL,
	[descripcion] [varchar](255) NULL,
 CONSTRAINT [PK_Modulo] PRIMARY KEY CLUSTERED 
(
	[id_modulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ModuloPerfil](
	[id_mp] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[estado] [bit] NOT NULL,
	[id_perfil] [int] NOT NULL,
	[id_modulo] [int] NOT NULL,
 CONSTRAINT [PK_ModuloPerfil] PRIMARY KEY CLUSTERED 
(
	[id_mp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Perfil](
	[id_perfil] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](255) NOT NULL,
	[descripcion] [varchar](255) NULL,
 CONSTRAINT [PK_Perfil] PRIMARY KEY CLUSTERED 
(
	[id_perfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Presupuesto](
	[id_presupuesto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](60) NOT NULL,
	[id_proyecto] [int] NOT NULL,
 CONSTRAINT [PK_Presupuesto] PRIMARY KEY CLUSTERED 
(
	[id_presupuesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Proyecto](
	[id_proyecto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](60) NOT NULL,
	[id_presupuesto] [int] NOT NULL,
	[id_cliente] [int] NULL,
 CONSTRAINT [PK_Proyecto] PRIMARY KEY CLUSTERED 
(
	[id_proyecto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Submodulo](
	[id_submodulo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](255) NOT NULL,
	[descripcion] [varchar](255) NULL,
	[ubicacion] [varchar](255) NOT NULL,
 CONSTRAINT [PK_Submodulo] PRIMARY KEY CLUSTERED 
(
	[id_submodulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[SubmoduloModulo](
	[id_sm] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[estado] [bit] NOT NULL,
	[id_modulo] [int] NOT NULL,
	[id_submodulo] [int] NOT NULL,
 CONSTRAINT [PK_SubmoduloModulo] PRIMARY KEY CLUSTERED 
(
	[id_sm] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TelefonoCliente](
	[id_tc] [int] IDENTITY(1,1) NOT NULL,
	[telefono] [varchar](60) NOT NULL,
	[id_cliente] [int] NOT NULL,
 CONSTRAINT [PK_TelefonoCliente] PRIMARY KEY CLUSTERED 
(
	[id_tc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TelefonoUsuario](
	[id_tu] [int] IDENTITY(1,1) NOT NULL,
	[telefono] [varchar](60) NOT NULL,
	[nroInterno] [int] NOT NULL,
 CONSTRAINT [PK_TelefonoUsuario] PRIMARY KEY CLUSTERED 
(
	[id_tu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TipoFuenteFinanciamiento](
	[id_tff] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](60) NOT NULL,
	[descripcion] [varchar](255) NULL,
 CONSTRAINT [PK_TipoFuenteFinanciamiento] PRIMARY KEY CLUSTERED 
(
	[id_tff] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Usuario](
	[nroInterno] [int] IDENTITY(1,1) NOT NULL,
	[run] [char](10) NULL,
	[nombre] [varchar](60) NOT NULL,
	[appat] [varchar](60) NOT NULL,
	[apmat] [varchar](60) NULL,
	[direccion] [varchar](255) NOT NULL,
	[id_localidad] [int] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[nroInterno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[UsuarioPerfil](
	[id_up] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[estado] [bit] NOT NULL,
	[nroInterno] [int] NOT NULL,
	[id_perfil] [int] NOT NULL,
 CONSTRAINT [PK_UsuarioPerfil] PRIMARY KEY CLUSTERED 
(
	[id_up] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Acceso]  WITH CHECK ADD  CONSTRAINT [FK_Acceso_Usuario] FOREIGN KEY([nroInterno])
REFERENCES [dbo].[Usuario] ([nroInterno])
GO
ALTER TABLE [dbo].[Acceso] CHECK CONSTRAINT [FK_Acceso_Usuario]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Localidad] FOREIGN KEY([id_localidad])
REFERENCES [dbo].[Localidad] ([id_localidad])
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_Cliente_Localidad]
GO
ALTER TABLE [dbo].[EmailCliente]  WITH CHECK ADD  CONSTRAINT [FK_EmailCliente_Cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Cliente] ([id_cliente])
GO
ALTER TABLE [dbo].[EmailCliente] CHECK CONSTRAINT [FK_EmailCliente_Cliente]
GO
ALTER TABLE [dbo].[EmailUsuario]  WITH CHECK ADD  CONSTRAINT [FK_EmailUsuario_Usuario] FOREIGN KEY([nroInterno])
REFERENCES [dbo].[Usuario] ([nroInterno])
GO
ALTER TABLE [dbo].[EmailUsuario] CHECK CONSTRAINT [FK_EmailUsuario_Usuario]
GO
ALTER TABLE [dbo].[EmpleadoProyecto]  WITH CHECK ADD  CONSTRAINT [FK_EmpleadoProyecto_Cargo] FOREIGN KEY([id_cargo])
REFERENCES [dbo].[Cargo] ([id_cargo])
GO
ALTER TABLE [dbo].[EmpleadoProyecto] CHECK CONSTRAINT [FK_EmpleadoProyecto_Cargo]
GO
ALTER TABLE [dbo].[EmpleadoProyecto]  WITH CHECK ADD  CONSTRAINT [FK_EmpleadoProyecto_Proyecto] FOREIGN KEY([id_proyecto])
REFERENCES [dbo].[Proyecto] ([id_proyecto])
GO
ALTER TABLE [dbo].[EmpleadoProyecto] CHECK CONSTRAINT [FK_EmpleadoProyecto_Proyecto]
GO
ALTER TABLE [dbo].[EmpleadoProyecto]  WITH CHECK ADD  CONSTRAINT [FK_EmpleadoProyecto_Usuario] FOREIGN KEY([nroInterno])
REFERENCES [dbo].[Usuario] ([nroInterno])
GO
ALTER TABLE [dbo].[EmpleadoProyecto] CHECK CONSTRAINT [FK_EmpleadoProyecto_Usuario]
GO
ALTER TABLE [dbo].[EspecialidadEmpleado]  WITH CHECK ADD  CONSTRAINT [FK_EspecialidadEmpleado_Especialidad] FOREIGN KEY([id_especialidad])
REFERENCES [dbo].[Especialidad] ([id_especialidad])
GO
ALTER TABLE [dbo].[EspecialidadEmpleado] CHECK CONSTRAINT [FK_EspecialidadEmpleado_Especialidad]
GO
ALTER TABLE [dbo].[EspecialidadEmpleado]  WITH CHECK ADD  CONSTRAINT [FK_EspecialidadEmpleado_Usuario] FOREIGN KEY([nroInterno])
REFERENCES [dbo].[Usuario] ([nroInterno])
GO
ALTER TABLE [dbo].[EspecialidadEmpleado] CHECK CONSTRAINT [FK_EspecialidadEmpleado_Usuario]
GO
ALTER TABLE [dbo].[FuenteFinanciamiento]  WITH CHECK ADD  CONSTRAINT [FK_FuenteFinanciamiento_TipoFuenteFinanciamiento] FOREIGN KEY([id_tff])
REFERENCES [dbo].[TipoFuenteFinanciamiento] ([id_tff])
GO
ALTER TABLE [dbo].[FuenteFinanciamiento] CHECK CONSTRAINT [FK_FuenteFinanciamiento_TipoFuenteFinanciamiento]
GO
ALTER TABLE [dbo].[FuenteFinanciamientoProyecto]  WITH CHECK ADD  CONSTRAINT [FK_FuenteFinanciamientoProyecto_FuenteFinanciamiento] FOREIGN KEY([id_fuenteFinanciamiento])
REFERENCES [dbo].[FuenteFinanciamiento] ([id_fuenteFinanciamiento])
GO
ALTER TABLE [dbo].[FuenteFinanciamientoProyecto] CHECK CONSTRAINT [FK_FuenteFinanciamientoProyecto_FuenteFinanciamiento]
GO
ALTER TABLE [dbo].[FuenteFinanciamientoProyecto]  WITH CHECK ADD  CONSTRAINT [FK_FuenteFinanciamientoProyecto_Proyecto] FOREIGN KEY([id_proyecto])
REFERENCES [dbo].[Proyecto] ([id_proyecto])
GO
ALTER TABLE [dbo].[FuenteFinanciamientoProyecto] CHECK CONSTRAINT [FK_FuenteFinanciamientoProyecto_Proyecto]
GO
ALTER TABLE [dbo].[GastoEjecutado]  WITH CHECK ADD  CONSTRAINT [FK_GastoEjecutado_Item] FOREIGN KEY([id_item])
REFERENCES [dbo].[Item] ([id_item])
GO
ALTER TABLE [dbo].[GastoEjecutado] CHECK CONSTRAINT [FK_GastoEjecutado_Item]
GO
ALTER TABLE [dbo].[HistoricoAcceso]  WITH CHECK ADD  CONSTRAINT [FK_HistoricoAcceso_Usuario] FOREIGN KEY([nroInterno])
REFERENCES [dbo].[Usuario] ([nroInterno])
GO
ALTER TABLE [dbo].[HistoricoAcceso] CHECK CONSTRAINT [FK_HistoricoAcceso_Usuario]
GO
ALTER TABLE [dbo].[HistoricoPassword]  WITH CHECK ADD  CONSTRAINT [FK_HistoricoPassword_Usuario] FOREIGN KEY([nroInterno])
REFERENCES [dbo].[Usuario] ([nroInterno])
GO
ALTER TABLE [dbo].[HistoricoPassword] CHECK CONSTRAINT [FK_HistoricoPassword_Usuario]
GO
ALTER TABLE [dbo].[ItemPresupuesto]  WITH CHECK ADD  CONSTRAINT [FK_ItemPresupuesto_Item] FOREIGN KEY([id_item])
REFERENCES [dbo].[Item] ([id_item])
GO
ALTER TABLE [dbo].[ItemPresupuesto] CHECK CONSTRAINT [FK_ItemPresupuesto_Item]
GO
ALTER TABLE [dbo].[ItemPresupuesto]  WITH CHECK ADD  CONSTRAINT [FK_ItemPresupuesto_Presupuesto] FOREIGN KEY([id_presupuesto])
REFERENCES [dbo].[Presupuesto] ([id_presupuesto])
GO
ALTER TABLE [dbo].[ItemPresupuesto] CHECK CONSTRAINT [FK_ItemPresupuesto_Presupuesto]
GO
ALTER TABLE [dbo].[ModuloPerfil]  WITH CHECK ADD  CONSTRAINT [FK_ModuloPerfil_Modulo] FOREIGN KEY([id_modulo])
REFERENCES [dbo].[Modulo] ([id_modulo])
GO
ALTER TABLE [dbo].[ModuloPerfil] CHECK CONSTRAINT [FK_ModuloPerfil_Modulo]
GO
ALTER TABLE [dbo].[ModuloPerfil]  WITH CHECK ADD  CONSTRAINT [FK_ModuloPerfil_Perfil] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[Perfil] ([id_perfil])
GO
ALTER TABLE [dbo].[ModuloPerfil] CHECK CONSTRAINT [FK_ModuloPerfil_Perfil]
GO
ALTER TABLE [dbo].[Presupuesto]  WITH CHECK ADD  CONSTRAINT [FK_Presupuesto_Proyecto] FOREIGN KEY([id_proyecto])
REFERENCES [dbo].[Proyecto] ([id_proyecto])
GO
ALTER TABLE [dbo].[Presupuesto] CHECK CONSTRAINT [FK_Presupuesto_Proyecto]
GO
ALTER TABLE [dbo].[Proyecto]  WITH CHECK ADD  CONSTRAINT [FK_Proyecto_Cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Cliente] ([id_cliente])
GO
ALTER TABLE [dbo].[Proyecto] CHECK CONSTRAINT [FK_Proyecto_Cliente]
GO
ALTER TABLE [dbo].[SubmoduloModulo]  WITH CHECK ADD  CONSTRAINT [FK_SubmoduloModulo_Modulo] FOREIGN KEY([id_modulo])
REFERENCES [dbo].[Modulo] ([id_modulo])
GO
ALTER TABLE [dbo].[SubmoduloModulo] CHECK CONSTRAINT [FK_SubmoduloModulo_Modulo]
GO
ALTER TABLE [dbo].[SubmoduloModulo]  WITH CHECK ADD  CONSTRAINT [FK_SubmoduloModulo_Submodulo] FOREIGN KEY([id_submodulo])
REFERENCES [dbo].[Submodulo] ([id_submodulo])
GO
ALTER TABLE [dbo].[SubmoduloModulo] CHECK CONSTRAINT [FK_SubmoduloModulo_Submodulo]
GO
ALTER TABLE [dbo].[TelefonoCliente]  WITH CHECK ADD  CONSTRAINT [FK_TelefonoCliente_Cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Cliente] ([id_cliente])
GO
ALTER TABLE [dbo].[TelefonoCliente] CHECK CONSTRAINT [FK_TelefonoCliente_Cliente]
GO
ALTER TABLE [dbo].[TelefonoUsuario]  WITH CHECK ADD  CONSTRAINT [FK_TelefonoUsuario_Usuario] FOREIGN KEY([nroInterno])
REFERENCES [dbo].[Usuario] ([nroInterno])
GO
ALTER TABLE [dbo].[TelefonoUsuario] CHECK CONSTRAINT [FK_TelefonoUsuario_Usuario]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Localidad] FOREIGN KEY([id_localidad])
REFERENCES [dbo].[Localidad] ([id_localidad])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Localidad]
GO
ALTER TABLE [dbo].[UsuarioPerfil]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioPerfil_Perfil] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[Perfil] ([id_perfil])
GO
ALTER TABLE [dbo].[UsuarioPerfil] CHECK CONSTRAINT [FK_UsuarioPerfil_Perfil]
GO
ALTER TABLE [dbo].[UsuarioPerfil]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioPerfil_Usuario] FOREIGN KEY([nroInterno])
REFERENCES [dbo].[Usuario] ([nroInterno])
GO
ALTER TABLE [dbo].[UsuarioPerfil] CHECK CONSTRAINT [FK_UsuarioPerfil_Usuario]
GO

CREATE procedure [dbo].[sp_actualizarCargo]
@id_cargo int, @nombre varchar(60), @descripcion varchar(255)
as
begin
	begin try
		update Cargo
		set nombre = @nombre, descripcion = @descripcion 
		where id_cargo = @id_cargo
	end try
	begin catch
		print '12';
	end catch
end;
GO

CREATE procedure [dbo].[sp_actualizarClave]
@username varchar(20), @claveActual varchar(20), @claveNueva varchar(20)
as
begin
	begin try
		declare @nroInterno int;
	declare @swe int;

		set @swe=(select count(id_acceso) from Acceso where username = @username and clave = @claveActual);
			if(@swe>1)
			begin
				print 100; -- existen mas 
			end
			if(@swe<1)
			begin
				print 100; -- no existe
			end
			if(@swe=1)
			begin
				update Acceso
				set clave=@claveNueva, DiasCad = 7, fechaCaducidad = Getdate()+7,estadoInicial = 0
				where username = @username and clave=@claveActual;
				set @nroInterno = (select nroInterno from Acceso where username = @username and clave = @claveNueva); --revisar	
				insert into HistoricoPassword
			    values(@claveNueva,GETDATE(),@nroInterno);	
			end
	end try
	begin catch
		print '12';
	end catch
end;
GO

CREATE procedure [dbo].[sp_actualizarCliente]
@id_cliente int, @rut char(10), @nombre varchar(60), @domicilio varchar(255), @id_localidad int
as
begin
	begin try
		update Cliente
		set rut = @rut, nombre = @nombre, domicilio = @domicilio, id_localidad=@id_localidad
		where id_cliente = @id_cliente
	end try
	begin catch
		print '12';
	end catch
end;
GO

create procedure [dbo].[sp_actualizarEmpleadoProyecto]
@id_ep int, @nroInterno int, @id_proyecto int, @id_cargo int
as
begin
	begin try
		update EmpleadoProyecto
		set nroInterno = @nroInterno, id_proyecto = @id_proyecto, id_cargo = @id_cargo
		where id_ep = @id_ep
	end try
	begin catch
		print '12';
	end catch
end;
GO

create procedure [dbo].[sp_actualizarEspecialidad]
@id_especialidad int, @nombre varchar(60), @descripcion varchar(255)
as
begin
	begin try
		update Especialidad
		set nombre = @nombre, descripcion = @descripcion 
		where id_especialidad = @id_especialidad
	end try
	begin catch
		print '12';
	end catch
end;
GO

create procedure [dbo].[sp_actualizarFuenteFinanciamiento]
@id_fuenteFinanciamiento int, @nombre varchar(60), @id_tff int
as
begin
	begin try
		update FuenteFinanciamiento
		set id_tff = @id_tff, nombre = @nombre
		where id_fuenteFinanciamiento = @id_fuenteFinanciamiento
	end try
	begin catch
		print '12';
	end catch
end;
GO

create procedure [dbo].[sp_actualizarGastoEjecutado]
@id_gastoEjecutado int, @id_item int
as
begin
	begin try
		update GastoEjecutado
		set id_item = @id_item
		where id_gastoEjecutado = @id_gastoEjecutado
	end try
	begin catch
		print '12';
	end catch
end;
GO

CREATE procedure [dbo].[sp_actualizarItem]
@id_item int, @nombre varchar(60), @descripcion varchar(255), @monto int
as
begin
	begin try
		update Item
		set nombre = @nombre, descripcion = @descripcion, monto = @monto
		where id_item = @id_item
	end try
	begin catch
		print '12';
	end catch
end;
GO

CREATE procedure [dbo].[sp_actualizarLocalidad]
@id_localidad int, @region varchar(60), @providencia varchar(60), @comuna varchar(60)
as
begin
	begin try
		update Localidad
		set region = @region, providencia =@providencia, comuna=@comuna
		where id_localidad = @id_localidad
	end try
	begin catch
		print '12';
	end catch
end;
GO

create procedure [dbo].[sp_actualizarModulo]
@id_modulo int, @nombre varchar(255), @descripcion varchar(255)
as
begin
	begin try
		update Modulo
		set nombre = @nombre, descripcion = @descripcion 
		where id_modulo = @id_modulo
	end try
	begin catch
		print '12';
	end catch
end;
GO

create procedure [dbo].[sp_actualizarPerfil]
@id_perfil int, @nombre varchar(255), @descripcion varchar(255)
as
begin
	begin try
		update Perfil
		set nombre = @nombre, descripcion = @descripcion 
		where id_perfil = @id_perfil
	end try
	begin catch
		print '12';
	end catch
end;
GO

CREATE procedure [dbo].[sp_actualizarPresupuesto]
@id_proyecto int, @nombre varchar(60), @id_presupuesto int
as
begin
	begin try
		update Presupuesto
		set nombre = @nombre, id_proyecto = @id_proyecto
		where id_presupuesto = @id_presupuesto
	end try
	begin catch
		print '12';
	end catch
end;
GO

CREATE procedure [dbo].[sp_actualizarProyecto]
@id_proyecto int, @nombre varchar(60), @id_cliente int, @id_presupuesto int
as
begin
	begin try
		update Proyecto
		set nombre = @nombre, id_cliente = @id_cliente, id_presupuesto = @id_presupuesto
		where id_proyecto = @id_proyecto
	end try
	begin catch
		print '12';
	end catch
end;
GO

create procedure [dbo].[sp_actualizarSubmodulo]
@id_submodulo int, @nombre varchar(255), @descripcion varchar(255), @ubicacion varchar(255)
as
begin
	begin try
		update Submodulo
		set nombre = @nombre, descripcion = @descripcion, ubicacion = @ubicacion 
		where id_submodulo = @id_submodulo	
	end try
	begin catch
		print '12';
	end catch
end;
GO

create procedure [dbo].[sp_actualizarTipoFuenteFinanciamiento]
@id_tff int, @nombre varchar(60), @descripcion varchar(255)
as
begin
	begin try
		update TipoFuenteFinanciamiento
		set nombre = @nombre, descripcion = @descripcion 
		where id_tff = @id_tff
	end try
	begin catch
		print '12';
	end catch
end;
GO

CREATE procedure [dbo].[sp_actualizarUsuario]
@nroInterno int, @run char(10), @nombre varchar(60), @apmat varchar(60), @appat varchar(60), @direccion varchar(255), @id_localidad int
as
begin
	begin try
		update Usuario
		set run=@run, nombre=@nombre,appat=@appat,apmat=@apmat,direccion=@direccion, id_localidad=@id_localidad
		where nroInterno = @nroInterno		
	end try
	begin catch
		print '12';
	end catch
end;
GO

CREATE procedure [dbo].[sp_agregarCargo]
@nombre varchar(60), @descripcion varchar(255)
as
begin
	begin try
		insert into Cargo
		values(@nombre,@descripcion);
	end try
	begin catch
		print '11';
	end catch
end;
GO

CREATE procedure [dbo].[sp_agregarCliente]
@rut char(10), @nombre varchar(60), @domicilio varchar(255), @id_localidad int
as
begin
	begin try
		insert into Cliente
		values(@rut,@nombre,@domicilio,@id_localidad);
	end try
	begin catch
		print '11';
	end catch
end;
GO

create procedure [dbo].[sp_agregarEmpleadoProyecto]
@nroInterno int, @id_proyecto int, @id_cargo int
as
begin
	begin try
		insert into EmpleadoProyecto
		values(@nroInterno, @id_proyecto, @id_proyecto);
	end try
	begin catch
		print '11';
	end catch
end;
GO

create procedure [dbo].[sp_agregarEspecialidad]
@nombre varchar(60), @descripcion varchar(255)
as
begin
	begin try
		insert into Especialidad
		values(@nombre,@descripcion);
	end try
	begin catch
		print '11';
	end catch
end;
GO

create procedure [dbo].[sp_agregarFuenteFinanciamiento]
@nombre varchar(60), @id_tff int
as
begin
	begin try
		insert into FuenteFinanciamiento
		values(@nombre, @id_tff);
	end try
	begin catch
		print '11';
	end catch
end;
GO

create procedure [dbo].[sp_agregarGastoEjecutado]
@id_item int
as
begin
	begin try
		insert into GastoEjecutado
		values(@id_item);
	end try
	begin catch
		print '11';
	end catch
end;
GO

CREATE procedure [dbo].[sp_agregarItem]
@nombre varchar(60), @descripcion varchar(255), @monto int
as
begin
	begin try
		insert into Item
		values(@nombre,@descripcion,@monto);
	end try
	begin catch
		print '11';
	end catch
end;
GO

CREATE procedure [dbo].[sp_agregarLocalidad]
@region varchar(60), @providencia varchar(60), @comuna varchar(60)
as
begin
	begin try
		insert into Localidad
		values(@region,@providencia,@comuna);
	end try
	begin catch
		print '11';
	end catch
end;
GO

create procedure [dbo].[sp_agregarModulo]
@nombre varchar(255), @descripcion varchar(255)
as
begin
	begin try
		insert into Modulo
		values(@nombre,@descripcion);
	end try
	begin catch
		print '11';
	end catch
end;
GO

create procedure [dbo].[sp_agregarPerfil]
@nombre varchar(255), @descripcion varchar(255)
as
begin
	begin try
		insert into Perfil
		values(@nombre,@descripcion);
	end try
	begin catch
		print '11';
	end catch
end;
GO

CREATE procedure [dbo].[sp_agregarPresupuesto]
@nombre varchar(60), @id_proyecto int
as
begin
	begin try
		insert into Presupuesto
		values(@nombre, @id_proyecto);
	end try
	begin catch
		print '11';
	end catch
end;
GO

CREATE procedure [dbo].[sp_agregarProyecto]
@nombre varchar(60), @id_cliente int, @id_presupuesto int
as
begin
	begin try
		insert into Proyecto
		values(@nombre, @id_cliente, @id_presupuesto);
	end try
	begin catch
		print '11';
	end catch
end;
GO

create procedure [dbo].[sp_agregarSubmodulo]
@nombre varchar(255), @descripcion varchar(255), @ubicacion varchar(255)
as
begin
	begin try
		insert into Submodulo
		values(@nombre,@descripcion,@ubicacion);
	end try
	begin catch
		print '11';
	end catch
end;
GO

create procedure [dbo].[sp_agregarTipoFuenteFinanciamiento]
@nombre varchar(60), @descripcion varchar(255)
as
begin
	begin try
		insert into TipoFuenteFinanciamiento
		values(@nombre,@descripcion);
	end try
	begin catch
		print '11';
	end catch
end;
GO

CREATE procedure [dbo].[sp_agregarUsuario]
@run char(10), @nombre varchar(60), @apmat varchar(60), @appat varchar(60), @direccion varchar(255), @id_localidad int
as
begin
	begin try
		insert into Usuario
		values(@run, @nombre,@appat,@apmat,@direccion, @id_localidad);
	end try
	begin catch
		print '11';
	end catch
end;
GO

CREATE procedure [dbo].[sp_asignarEspecialidadAEmpleado]
@id_especialidad int, @nroInterno int
as
begin
      begin try
			insert into EspecialidadEmpleado
			values(@id_especialidad, @nroInterno);
      end try
      begin catch
			print 'Error de Asignar Especialidad';
      end catch
end;
GO

CREATE procedure [dbo].[sp_asignarFuenteFinanciamientoAProyecto]
@id_fuenteFinanciamiento int, @id_proyecto int
as
begin
      begin try
			insert into FuenteFinanciamientoProyecto
			values(@id_fuenteFinanciamiento, @id_proyecto);
      end try
      begin catch
			print 'Error de Asignar Fuente Financiamiento';
      end catch
end;
GO

create procedure [dbo].[sp_asignarItemAPresupuesto]
@id_item int, @id_presupuesto int
as
begin
      begin try
			insert into ItemPresupuesto
			values(@id_item, @id_presupuesto);
      end try
      begin catch
			print 'Error de Asignar Item';
      end catch
end;
GO

CREATE procedure [dbo].[sp_asignarUsuarioAPerfil]
@nroInterno int, @id_perfil int
as
begin
      begin try
			insert into UsuarioPerfil
			values(GETDATE(), 1, @nroInterno, @id_perfil);
      end try
      begin catch
			print 'Error de Asignar Usuario';
      end catch
end;
GO

CREATE PROCEDURE [dbo].[sp_consultaAcceso] 
@username varchar(20), @clave varchar(20)
AS
Begin
	Begin Try
		SELECT COUNT(id_acceso) 
		FROM Acceso
		WHERE username=@username AND
		clave = @clave;
	End try
	Begin Catch
		Select -1;
	End Catch
End;
GO

CREATE PROCEDURE [dbo].[sp_consultaAccesoExisteUsername]
@username varchar(20)
AS
Begin
	Begin Try
		SELECT COUNT(id_acceso) 
		FROM Acceso
		WHERE username=@username;
	End try
	Begin Catch
		Select -1;
	End Catch
End;
GO

Create PROCEDURE [dbo].[sp_consultaAccesoFechaCad] 
@username varchar(20), @clave varchar(20)
AS
Begin
	Begin Try
		SELECT fechaCaducidad 
		FROM Acceso
		WHERE username=@username AND
		clave = @clave;
	End try
	Begin Catch
		Select -1;
	End Catch
End;
GO

create PROCEDURE [dbo].[sp_consultaAccesoHabilitado] 
@username varchar(20), @clave varchar(20)
AS
Begin
	Begin Try
		SELECT COUNT(id_acceso) 
		FROM Acceso
		WHERE username=@username AND
		clave = @clave AND
		estadoAcceso=1; -- si esta habilitado
	End try
	Begin Catch
		Select -1;
	End Catch
End;
GO

create PROCEDURE [dbo].[sp_consultaAccesoPrimera] 
@username varchar(20), @clave varchar(20)
AS
Begin
	Begin Try
		SELECT COUNT(id_acceso) 
		FROM Acceso
		WHERE username=@username AND
		clave = @clave
		and estadoInicial=1;
	End try
	Begin Catch
		Select -1;
	End Catch
End;
GO

CREATE PROCEDURE [dbo].[sp_consultarEspecialidadesDeEmpleado]
@id_especialidad int
AS
BEGIN
	BEGIN TRY
		SELECT p.nroInterno, p.nombre, p.appat, p.apmat
		FROM Especialidad u, EspecialidadEmpleado pu, Usuario p
		WHERE u.id_especialidad = @id_especialidad AND
			  p.nroInterno = pu.nroInterno AND
			  pu.id_especialidad = u.id_especialidad;
	END TRY
	BEGIN CATCH
		PRINT -1;
	END CATCH
END;

GO

CREATE PROCEDURE [dbo].[sp_consultarEspecialidadesSinEmpleado]
@id_especialidad int
AS
BEGIN
	BEGIN TRY
		SELECT u.nroInterno, u.nombre
		FROM Usuario u
		WHERE u.nroInterno NOT IN
		(
			SELECT p.nroInterno
			FROM Especialidad u, EspecialidadEmpleado pu, Usuario p
			WHERE u.id_especialidad = @id_especialidad AND
				  p.nroInterno = pu.nroInterno AND
				  pu.id_especialidad = u.id_especialidad
		);
	END TRY
	BEGIN CATCH
		PRINT -1;
	END CATCH
END;
GO

CREATE PROCEDURE [dbo].[sp_consultarFuenteFinanciamientosDeProyecto]
@id_proyecto int
AS
BEGIN
	BEGIN TRY
		SELECT u.id_fuenteFinanciamiento, u.nombre
		FROM FuenteFinanciamiento u, FuenteFinanciamientoProyecto pu, Proyecto p
		WHERE p.id_proyecto = @id_proyecto AND
			  p.id_proyecto = pu.id_proyecto AND
			  pu.id_fuenteFinanciamiento = u.id_fuenteFinanciamiento;
	END TRY
	BEGIN CATCH
		PRINT -1;
	END CATCH
END;

GO

create PROCEDURE [dbo].[sp_consultarFuenteFinanciamientosSinProyecto]
@id_proyecto int
AS
BEGIN
	BEGIN TRY
		SELECT u.id_fuenteFinanciamiento, u.nombre
		FROM FuenteFinanciamiento u
		WHERE u.id_fuenteFinanciamiento NOT IN
		(
			SELECT u.id_fuenteFinanciamiento
			FROM FuenteFinanciamiento u, FuenteFinanciamientoProyecto pu, Proyecto p
			WHERE p.id_proyecto = @id_proyecto AND
				  p.id_proyecto = pu.id_proyecto AND
				  pu.id_fuenteFinanciamiento = u.id_fuenteFinanciamiento
		);
	END TRY
	BEGIN CATCH
		PRINT -1;
	END CATCH
END;
GO

create PROCEDURE [dbo].[sp_consultarItemsDePresupuesto]
@id_presupuesto int
AS
BEGIN
	BEGIN TRY
		SELECT u.id_item, u.nombre
		FROM Item u, ItemPresupuesto pu, Presupuesto p
		WHERE p.id_presupuesto = @id_presupuesto AND
			  p.id_presupuesto = pu.id_Presupuesto AND
			  pu.id_item = u.id_item;
	END TRY
	BEGIN CATCH
		PRINT -1;
	END CATCH
END;

GO

create PROCEDURE [dbo].[sp_consultarItemsSinPresupuesto]
@id_presupuesto int
AS
BEGIN
	BEGIN TRY
		SELECT u.id_item, u.nombre, u.monto
		FROM Item u
		WHERE u.id_item NOT IN
		(
			SELECT u.id_item
			FROM item u, ItemPresupuesto pu, Presupuesto p
			WHERE p.id_presupuesto = @id_presupuesto AND
				  p.id_presupuesto = pu.id_Presupuesto AND
				  pu.id_item = u.id_item
		);
	END TRY
	BEGIN CATCH
		PRINT -1;
	END CATCH
END;
GO

create procedure [dbo].[sp_consultarTODOSCargo]
as
begin
	begin try
		Select * 
		from Cargo
	end try
	begin catch
		print '15';
	end catch
end;
GO

create procedure [dbo].[sp_consultarTODOSCliente]
as
begin
	begin try
		Select * 
		from Cliente
	end try
	begin catch
		print '15';
	end catch
end;
GO

create procedure [dbo].[sp_consultarTODOSEmpleadoProyecto]
as
begin
	begin try
		Select * 
		from EmpleadoProyecto
	end try
	begin catch
		print '15';
	end catch
end;
GO

create procedure [dbo].[sp_consultarTODOSEspecialidad]
as
begin
	begin try
		Select * 
		from Especialidad
	end try
	begin catch
		print '15';
	end catch
end;
GO

create procedure [dbo].[sp_consultarTODOSFuenteFinanciamiento]
as
begin
	begin try
		Select * 
		from FuenteFinanciamiento
	end try
	begin catch
		print '15';
	end catch
end;
GO

create procedure [dbo].[sp_consultarTODOSGastoEjecutado]
as
begin
	begin try
		Select * 
		from GastoEjecutado
	end try
	begin catch
		print '15';
	end catch
end;
GO

create procedure [dbo].[sp_consultarTODOSItem]
as
begin
	begin try
		Select * 
		from Item
	end try
	begin catch
		print '15';
	end catch
end;
GO

create procedure [dbo].[sp_consultarTODOSLocalidad]
as
begin
	begin try
		Select * 
		from Localidad
	end try
	begin catch
		print '15';
	end catch
end;
GO

create procedure [dbo].[sp_consultarTODOSModulo]
as
begin
	begin try
		Select * 
		from Modulo
	end try
	begin catch
		print '15';
	end catch
end;
GO

create procedure [dbo].[sp_consultarTODOSPerfil]
as
begin
	begin try
		Select * 
		from Perfil
	end try
	begin catch
		print '15';
	end catch
end;
GO

create procedure [dbo].[sp_consultarTODOSPresupuesto]
as
begin
	begin try
		Select * 
		from Presupuesto
	end try
	begin catch
		print '15';
	end catch
end;
GO

create procedure [dbo].[sp_consultarTODOSProyecto]
as
begin
	begin try
		Select * 
		from Proyecto
	end try
	begin catch
		print '15';
	end catch
end;
GO

create procedure [dbo].[sp_consultarTODOSSubmodulo]
as
begin
	begin try
		Select * 
		from Submodulo
	end try
	begin catch
		print '15';
	end catch
end;
GO

create procedure [dbo].[sp_consultarTODOSTipoFuenteFinanciamiento]
as
begin
	begin try
		Select * 
		from TipoFuenteFinanciamiento
	end try
	begin catch
		print '15';
	end catch
end;
GO

create procedure [dbo].[sp_consultarTODOSUsuario]
as
begin
	begin try
		Select * 
		from Usuario
	end try
	begin catch
		print '15';
	end catch
end;
GO

create procedure [dbo].[sp_consultarUnCargo]
@id_cargo int, @palabraClave varchar(60) -- no seria 255 con direccion y el nro interno no estaria demas ?
as
begin
	begin try
		Select * 
		from Cargo
		Where id_cargo = @id_cargo OR
		nombre like'%'+@palabraClave+'%' OR
		descripcion like'%'+@palabraClave+'%';
	end try
	begin catch
		print '14';
	end catch
end;
GO

create procedure [dbo].[sp_consultarUnCliente]
@id_cliente int, @palabraClave varchar(60) -- no seria 255 con direccion y el nro interno no estaria demas ?
as
begin
	begin try
		Select * 
		from Cliente
		Where id_cliente = @id_cliente OR
		nombre like'%'+@palabraClave+'%' OR
		domicilio like'%'+@palabraClave+'%';
	end try
	begin catch
		print '14';
	end catch
end;
GO

create procedure [dbo].[sp_consultarUnEspecialidad]
@id_especialidad int, @palabraClave varchar(60) -- no seria 255 con direccion y el nro interno no estaria demas ?
as
begin
	begin try
		Select * 
		from Especialidad
		Where id_especialidad = @id_especialidad OR
		nombre like'%'+@palabraClave+'%' OR
		descripcion like'%'+@palabraClave+'%';
	end try
	begin catch
		print '14';
	end catch
end;
GO

create procedure [dbo].[sp_consultarUnItem]
@id_item int, @palabraClave varchar(60) -- no seria 255 con direccion y el nro interno no estaria demas ?
as
begin
	begin try
		Select * 
		from Item
		Where id_item = @id_item OR
		nombre like'%'+@palabraClave+'%' OR
		descripcion like'%'+@palabraClave+'%';
	end try
	begin catch
		print '14';
	end catch
end;
GO

CREATE procedure [dbo].[sp_consultarUnLocalidad]
@id_localidad int, @palabraClave varchar(60) -- no seria 255 con direccion y el nro interno no estaria demas ?
as
begin
	begin try
		Select * 
		from Localidad
		Where id_localidad = @id_localidad OR
		region like'%'+@palabraClave+'%' OR
		providencia like'%'+@palabraClave+'%' OR
		comuna like'%'+@palabraClave+'%';
	end try
	begin catch
		print '14';
	end catch
end;
GO

create procedure [dbo].[sp_consultarUnModulo]
@id_modulo int, @palabraClave varchar(60) -- no seria 255 con direccion y el nro interno no estaria demas ?
as
begin
	begin try
		Select * 
		from Modulo
		Where id_modulo = @id_modulo OR
		nombre like'%'+@palabraClave+'%' OR
		descripcion like'%'+@palabraClave+'%';
	end try
	begin catch
		print '14';
	end catch
end;
GO

create procedure [dbo].[sp_consultarUnPerfil]
@id_perfil int, @palabraClave varchar(60) -- no seria 255 con direccion y el nro interno no estaria demas ?
as
begin
	begin try
		Select * 
		from Perfil
		Where id_perfil = @id_perfil OR
		nombre like'%'+@palabraClave+'%' OR
		descripcion like'%'+@palabraClave+'%';
	end try
	begin catch
		print '14';
	end catch
end;
GO

create procedure [dbo].[sp_consultarUnSubmodulo]
@id_submodulo int, @palabraClave varchar(60) -- no seria 255 con direccion y el nro interno no estaria demas ?
as
begin
	begin try
		Select * 
		from Submodulo
		Where id_submodulo = @id_submodulo OR
		nombre like'%'+@palabraClave+'%' OR
		descripcion like'%'+@palabraClave+'%' OR
		ubicacion like'%'+@palabraClave+'%';
	end try
	begin catch
		print '14';
	end catch
end;
GO

create procedure [dbo].[sp_consultarUnTipoFuenteFinanciamiento]
@id_tff int, @palabraClave varchar(60) -- no seria 255 con direccion y el nro interno no estaria demas ?
as
begin
	begin try
		Select * 
		from TipoFuenteFinanciamiento
		Where id_tff = @id_tff OR
		nombre like'%'+@palabraClave+'%' OR
		descripcion like'%'+@palabraClave+'%';
	end try
	begin catch
		print '14';
	end catch
end;
GO

create procedure [dbo].[sp_consultarUnUsuario]
@nroInterno int, @palabraClave varchar(60) -- no seria 255 con direccion y el nro interno no estaria demas ?
as
begin
	begin try
		Select * 
		from Usuario
		Where nroInterno=@nroInterno OR
		run like'%'+@palabraClave+'%' OR
		nombre like'%'+@palabraClave+'%' OR
		appat like'%'+@palabraClave+'%' OR
		apmat like'%'+@palabraClave+'%' OR
		direccion like'%'+@palabraClave+'%';
	end try
	begin catch
		print '14';
	end catch
end;
GO

CREATE PROCEDURE [dbo].[sp_consultarUsuariosDePerfil]
@id_perfil int
AS
BEGIN
	BEGIN TRY
		SELECT u.nroInterno, u.nombre, u.appat, u.apmat
		FROM Usuario u, UsuarioPerfil pu, Perfil p
		WHERE p.id_perfil = @id_perfil AND
			  p.id_perfil = pu.id_perfil AND
			  pu.nroInterno = u.nroInterno;
	END TRY
	BEGIN CATCH
		PRINT -1;
	END CATCH
END;
GO

create procedure [dbo].[sp_consultarUsuariosDeshabilitados]
as
begin
	begin try
		Select B.*
		from HistoricoAcceso A, Usuario B
		Where A.estado = 0;
	end try
	begin catch
		print '14';
	end catch
end;
GO

CREATE procedure [dbo].[sp_consultarUsuariosDeshabilitadosPorFecha]
@fechaInicio DateTime, @fechaFinal DateTime -- no seria 255 con direccion y el nro interno no estaria demas ?
as
begin
	begin try
		Select B.*, A.fecha
		from HistoricoAcceso A, Usuario B
		Where A.nroInterno = B.nroInterno
		and A.fecha 
		between @fechaInicio
		and @fechaFinal
		and estado = 0;
	end try
	begin catch
		print '14';
	end catch
end;
GO

create procedure [dbo].[sp_consultarUsuariosHabilitados]
as
begin
	begin try
		Select B.*
		from HistoricoAcceso A, Usuario B
		Where A.estado = 1;
	end try
	begin catch
		print '14';
	end catch
end;
GO

CREATE procedure [dbo].[sp_consultarUsuariosHabilitadosPorFecha]
@fechaInicio DateTime, @fechaFinal DateTime 
as
begin
	begin try
		Select B.*, A.fecha
		from HistoricoAcceso A, Usuario B
		Where A.nroInterno = B.nroInterno
		and A.fecha 
		between @fechaInicio
		and @fechaFinal
		and estado = 1;
	end try
	begin catch
		print '14';
	end catch
end;
GO

CREATE PROCEDURE [dbo].[sp_consultarUsuariosSinPerfil]
@id_perfil int
AS
BEGIN
	BEGIN TRY
		SELECT u.nroInterno, u.nombre, u.appat, u.apmat
		FROM Usuario u
		WHERE u.nroInterno NOT IN
		(
			SELECT u.nroInterno
			FROM Usuario u, UsuarioPerfil pu, Perfil p
			WHERE p.id_perfil = @id_perfil AND
				  p.id_perfil = pu.id_perfil AND
				  pu.nroInterno = u.nroInterno
		);
	END TRY
	BEGIN CATCH
		PRINT -1;
	END CATCH
END;
GO

create procedure [dbo].[sp_CreaClave]
AS
Begin
	Declare @clave varchar(20);
	Declare @carMay1 char(1);
	Declare @carMay2 char(1);	
	Declare @carMin1 char(1);
	Declare @carMin2 char(1);
	Declare @carNum1 char(1);
	Declare @carNum2 char(1);	
	Declare @carNum3 char(1);		
	Declare @carEsp char(1);		
	Begin Try
		Set @carMay1=dbo.fu_CaracterMayuscula();
		Set @carMay2=dbo.fu_CaracterMayuscula();		 
		Set @carMin1=dbo.fu_CaracterMinuscula(); 
		Set @carMin2=dbo.fu_CaracterMinuscula(); 		
		Set @carNum1=dbo.fu_CaracterNumerico(); 
		Set @carNum2=dbo.fu_CaracterNumerico(); 
		Set @carNum3=dbo.fu_CaracterNumerico(); 				
		Set @carEsp=dbo.fu_CaracterEspecial();
		set @clave=@carMay1+@carMay2+@carMin1+@carMin2+@carNum1+@carNum2+@carNum3+@carEsp;
		
		Select @clave;
		
	End Try
	Begin Catch
		Print 'Error Clave';
	End Catch
End;
GO

create procedure [dbo].[sp_desasignarEspecialidadDeEmpleado]
@id_especialidad int, @nroInterno int
as
begin
      begin try
			delete from EspecialidadEmpleado
			where id_especialidad=@id_especialidad
			and nroInterno=@nroInterno
      end try
      begin catch
			print 'Error de Desasignar Especialidad';
      end catch
end;
GO

CREATE procedure [dbo].[sp_desasignarFuenteFinanciamientoDeProyecto]
@id_fuenteFinanciamiento int, @id_proyecto int
as
begin
      begin try
			delete from FuenteFinanciamientoProyecto
			where id_fuenteFinanciamiento=@id_fuenteFinanciamiento
			and id_proyecto=@id_proyecto
      end try
      begin catch
			print 'Error de Desasignar FuenteFinanciamiento';
      end catch
end;
GO

create procedure [dbo].[sp_desasignarItemDePresupuesto]
@id_item int, @id_presupuesto int
as
begin
      begin try
			delete from ItemPresupuesto
			where id_item=@id_item
			and id_Presupuesto=@id_presupuesto
      end try
      begin catch
			print 'Error de Desasignar Item';
      end catch
end;
GO

CREATE procedure [dbo].[sp_desasignarUsuarioDePerfil]
@nroInterno int, @id_perfil int
as
begin
      begin try
			delete from UsuarioPerfil
			where nroInterno=@nroInterno 
			and id_perfil=@id_perfil
      end try
      begin catch
			print 'Error de Desasignar Usuario';
      end catch
end;
GO

create procedure [dbo].[sp_deshabilitarAcceso]
@nroInterno int
as
begin
	begin try
			begin
				update Acceso
				set estadoAcceso = 0
				where nroInterno =@nroInterno;		
			end
	end try
	begin catch
		print '12';
	end catch
end;
GO

create procedure [dbo].[sp_eliminarCargo]
@id_cargo int
as
begin
	begin try
		declare @swe int;

		set @swe=(select count(*) from EmpleadoProyecto where id_cargo = @id_cargo);
			if(@swe>0)
			begin
				print 100; -- existen telefonos asociados al usaurio
				delete from EmpleadoProyecto 
				where id_cargo = @id_cargo;	
				delete from Cargo
				where id_cargo = @id_cargo;	
			end
			if(@swe=0)
			begin
				delete from Cargo
				where id_cargo = @id_cargo;	
			end	
	end try
	begin catch
		print '13';
	end catch
end;
GO

CREATE procedure [dbo].[sp_eliminarCliente]
@id_cliente int
as
begin
	begin try
		declare @swe int;

		set @swe=(select count(id_ec) from EmailCliente where id_cliente = @id_cliente);
			if(@swe>0)
			begin
				print 100; -- existen telefonos asociados al usaurio
			end
			if(@swe=0)
			
			begin
				set @swe=(select count(id_tc) from TelefonoCliente where id_cliente = @id_cliente);
					if(@swe>0)
					begin
						print 200; -- existen telefonos asociados al usaurio
					end
			end
			
			if(@swe=0)
			
			begin
				set @swe=(select count(id_proyecto) from Proyecto where id_cliente = @id_cliente);
					if(@swe>0)
					begin
						print 300; -- existen usuarioperfil asociados al usaurio
					end
			end
			if(@swe=0)
			begin
				delete from EmailCliente
				where id_cliente = @id_cliente;	
				delete from TelefonoCliente
				where id_cliente = @id_cliente;	
				delete from Proyecto
				where id_cliente = @id_cliente;	
				delete from Cliente
				where id_cliente = @id_cliente;	
			end	
	end try
	begin catch
		print '13';
	end catch
end;
GO

create procedure [dbo].[sp_eliminarEmpleadoProyecto]
@id_ep int
as
begin
	begin try
				delete from EmpleadoProyecto
				where id_ep= @id_ep;	

	end try
	begin catch
		print '13';
	end catch
end;
GO

create procedure [dbo].[sp_eliminarEspecialidad]
@id_especialidad int
as
begin
	begin try
		declare @swe int;

		set @swe=(select count(*) from EspecialidadEmpleado where id_especialidad = @id_especialidad);
			if(@swe>0)
			begin
				print 100; -- existen telefonos asociados al usaurio
				delete from EspecialidadEmpleado 
				where id_especialidad = @id_especialidad;	
				delete from Especialidad
				where id_especialidad = @id_especialidad;	
			end
			if(@swe=0)
			begin
				delete from EspecialidadEmpleado 
				where id_especialidad = @id_especialidad;	
				delete from Especialidad
				where id_especialidad = @id_especialidad;	
			end	
	end try
	begin catch
		print '13';
	end catch
end;
GO

create procedure [dbo].[sp_eliminarFuenteFinanciamiento]
@id_fuenteFinanciamiento int
as
begin
	begin try
			delete from FuenteFinanciamiento
			where id_fuenteFinanciamiento = @id_fuenteFinanciamiento;	

	end try
	begin catch
		print '13';
	end catch
end;
GO

create procedure [dbo].[sp_eliminarGastoEjecutado]
@id_gastoEjecutado int
as
begin
	begin try
			delete from GastoEjecutado
			where id_gastoEjecutado = @id_gastoEjecutado;	

	end try
	begin catch
		print '13';
	end catch
end;
GO

create procedure [dbo].[sp_eliminarItem]
@id_item int
as
begin
	begin try
		declare @swe int;

		set @swe=(select count(*) from ItemPresupuesto where id_item = @id_item);
			if(@swe>0)
			begin
				print 100; -- existen telefonos asociados al usaurio
				delete from ItemPresupuesto 
				where id_item = @id_item;
				delete from GastoEjecutado 
				where id_item = @id_item;
				delete from Item
				where id_item = @id_item;	
			end
			if(@swe=0)
			begin
				delete from ItemPresupuesto 
				where id_item = @id_item;
				delete from GastoEjecutado 
				where id_item = @id_item;
				delete from Item
				where id_item = @id_item;	
			end	
	end try
	begin catch
		print '13';
	end catch
end;
GO

CREATE procedure [dbo].[sp_eliminarLocalidad]
@id_localidad int
as
begin
	begin try
		declare @swe int;

		set @swe=(select count(*) from Usuario where id_localidad = @id_localidad);
			if(@swe>0)
			begin
				print 100; -- existen telefonos asociados al usaurio
				delete from Cliente
				where id_localidad = @id_localidad;	
				delete from Usuario
				where id_localidad = @id_localidad;	
				delete from Localidad
				where id_localidad = @id_localidad;	
			end
			if(@swe=0)
			begin
				delete from Localidad
				where id_localidad = @id_localidad;	
			end	
	end try
	begin catch
		print '13';
	end catch
end;
GO

create procedure [dbo].[sp_eliminarModulo]
@id_modulo int
as
begin
	begin try
		declare @swe int;

		set @swe=(select count(*) from ModuloPerfil where id_modulo = @id_modulo);
			if(@swe>0)
			begin
				print 100; -- existen telefonos asociados al usaurio
			end
			if(@swe=0)
			
			begin
				set @swe=(select count(*) from SubmoduloModulo where id_modulo = @id_modulo);
					if(@swe>0)
					begin
						print 200; -- existen telefonos asociados al usaurio
					end
			end
			if(@swe=0)
			begin
				delete from Modulo
				where id_modulo = @id_modulo;	
			end	
	end try
	begin catch
		print '13';
	end catch
end;
GO

CREATE procedure [dbo].[sp_eliminarPerfil]
@id_perfil int
as
begin
	begin try
		declare @swe int;

		set @swe=(select count(*) from UsuarioPerfil where id_perfil = @id_perfil);
			if(@swe>0)
			begin
				print 100; -- existen telefonos asociados al usaurio
			end
			if(@swe=0)
			
			begin
				set @swe=(select count(*) from ModuloPerfil where id_perfil = @id_perfil);
					if(@swe>0)
					begin
						print 200; -- existen telefonos asociados al usaurio
					end
			end
			if(@swe=0)
			begin
				delete from Perfil
				where id_perfil = @id_perfil;	
			end	
	end try
	begin catch
		print '13';
	end catch
end;
GO

create procedure [dbo].[sp_eliminarPresupuesto]
@id_presupuesto int
as
begin
	begin try
				delete from Presupuesto
				where id_presupuesto = @id_presupuesto;	

	end try
	begin catch
		print '13';
	end catch
end;
GO

create procedure [dbo].[sp_eliminarProyecto]
@id_proyecto int
as
begin
	begin try
				delete from Proyecto
				where id_proyecto = @id_proyecto;	

	end try
	begin catch
		print '13';
	end catch
end;
GO

create procedure [dbo].[sp_eliminarSubmodulo]
@id_submodulo int
as
begin
	begin try
		declare @swe int;

		set @swe=(select count(*) from SubmoduloModulo where id_submodulo = @id_submodulo);
			if(@swe>0)
			begin
				print 100; -- existen telefonos asociados al usaurio
			end
			if(@swe=0)
			begin
				delete from Submodulo
				where id_submodulo = @id_submodulo;	
			end	
	end try
	begin catch
		print '13';
	end catch
end;
GO

create procedure [dbo].[sp_eliminarTipoFuenteFinanciamiento]
@id_tff int
as
begin
	begin try
		declare @swe int;

		set @swe=(select count(*) from FuenteFinanciamiento where id_tff = @id_tff);
			if(@swe>0)
			begin
				print 100; -- existen telefonos asociados al usaurio
				delete from FuenteFinanciamiento
				where id_tff = @id_tff;	
				delete from TipoFuenteFinanciamiento
				where id_tff = @id_tff;	
			end
			if(@swe=0)
			begin
				delete from FuenteFinanciamiento
				where id_tff = @id_tff;	
				delete from TipoFuenteFinanciamiento
				where id_tff = @id_tff;	
			end	
	end try
	begin catch
		print '13';
	end catch
end;
GO

CREATE procedure [dbo].[sp_eliminarUsuario]
@nroInterno int
as
begin
	begin try
		declare @swe int;

		set @swe=(select count(id_eu) from EmailUsuario where nroInterno = @nroInterno);
			if(@swe>0)
			begin
				print 100; -- existen telefonos asociados al usaurio
			end
			if(@swe=0)
			
			begin
				set @swe=(select count(id_tu) from TelefonoUsuario where nroInterno = @nroInterno);
					if(@swe>0)
					begin
						print 200; -- existen telefonos asociados al usaurio
					end
			end
			
			if(@swe=0)
			
			begin
				set @swe=(select count(id_up) from UsuarioPerfil where nroInterno = @nroInterno);
					if(@swe>0)
					begin
						print 300; -- existen usuarioperfil asociados al usaurio
					end
			end
			
			if(@swe=0)
			begin
				delete from HistoricoAcceso
				where nroInterno = @nroInterno;
				delete from HistoricoPassword
				where nroInterno = @nroInterno;
				delete from Acceso
				where nroInterno = @nroInterno;
				delete from Usuario
				where nroInterno = @nroInterno;	
			end	
	end try
	begin catch
		print '13';
	end catch
end;
GO

create procedure [dbo].[sp_habilitarAcceso]
@nroInterno int
as
begin
	begin try
			begin
				update Acceso
				set estadoAcceso = 1
				where nroInterno =@nroInterno;		
			end
	end try
	begin catch
		print '12';
	end catch
end;
GO

create procedure [dbo].[sp_verificarClaveUsuario]
@username varchar(20), @clave varchar(20) -- no seria 255 con direccion y el nro interno no estaria demas ?
as
begin
	begin try
		Select * 
		from Acceso A, HistoricoPassword B
		Where A.username=@username 
		and A.nroInterno = B.nroInterno
		and B.clave = @clave;
	end try
	begin catch
		print '14';
	end catch
end;
GO

create trigger [dbo].[tr_CambioClave] on [dbo].[Acceso]
		after update
		as
		begin
		
			Declare @nroInterno int
			Declare @clave varchar(20)
			begin try
			set @nroInterno=(select nroInterno from inserted);
			set @clave = (select clave from Inserted);
			
			insert into HistoricoPassword
			values(@clave,GETDATE(),@nroInterno);
			end try
			begin catch
				print 1000;
			end catch
		end
GO

CREATE trigger [dbo].[tr_AgregarAcceso] on [dbo].[Usuario]
		after insert
		as
		begin
			Declare @nroInterno int
			Declare @nombre varchar(60)
			Declare @appat varchar(60)
			declare @username varchar(20)
			declare @username2 varchar(20)
			declare @clave varchar(20)
			declare @diasCad int
			declare @fechaCaducidad DateTime
			declare @estadoInicial bit
			declare @codigoAut varchar(20)
			declare @estadoAcceso bit
			declare @Pregunta varchar(255)
			declare @Respuesta varchar(255)
			DECLARE @swExiste int
			DECLARE @contador int
			DECLARE @zeros varchar(3)


			begin try
			set @nroInterno=(select nroInterno from Inserted);
			set @nombre=(select nombre from Inserted);
			set @appat=(select appat from Inserted);
			set @username = dbo.fu_obtieneUsername(@nombre,@appat)
			set @clave = dbo.fu_obtieneUsername(@appat,@nombre)
			set @diasCad = 7
			set @fechaCaducidad = getdate()+7
			set @estadoInicial = 1
			set @codigoAut = 'modificar'
			set @estadoAcceso = 1
			set @Pregunta = '?'
			set @Respuesta = '.'
			



						SET @swExiste=(SELECT dbo.fu_existeUsuario(@username));
			IF (@swExiste=0)
				BEGIN
					insert into Acceso
					values(@nroInterno,@username,@clave,@diasCad,@fechaCaducidad,@estadoInicial,@codigoAut,@estadoAcceso, @Pregunta, @Respuesta);
					insert into HistoricoPassword
					values(@clave, getdate(),@nroInterno);
				END
			ELSE
				BEGIN
					SET @contador = 0
					SET @zeros =(SELECT dbo.fu_usuarioRepetido(@contador));
					SET @username2 = @username+@zeros
					WHILE(@contador<=999)
					BEGIN
						SET @swExiste=(SELECT dbo.fu_existeUsuario(@username2));
						IF (@swExiste=0)
							BEGIN
								insert into Acceso
			values(@nroInterno,@username2,@clave,@diasCad,@fechaCaducidad,@estadoInicial,@codigoAut,@estadoAcceso, @Pregunta, @Respuesta);
			insert into HistoricoPassword
			values(@clave, getdate(),@nroInterno);
								
								BREAK;
							END
						ELSE 
							BEGIN
								SET @contador = @contador + 1
								
								SET @zeros =(SELECT dbo.fu_usuarioRepetido(@contador));
								SET @username2 = @username+@zeros
								
								
								CONTINUE;
								
								
							END
						
					END
				END


			end try
			begin catch
				print 1000;
			end catch
		end
GO

create trigger [dbo].[tr_AgregarUsuarioH] on [dbo].[Usuario]
		after insert
		as
		begin
			Declare @nroInterno int
			Declare @run char(10)
			Declare @nombre varchar(60)
			Declare @appat varchar(60)
			Declare @apmat varchar(60)
			Declare @direccion varchar(255)
			begin try
			set @nroInterno=(select nroInterno from Inserted);
			set @run=(select run from Inserted);
			set @nombre=(select nombre from Inserted);
			set @appat=(select appat from Inserted);
			set @apmat=(select apmat from Inserted);
			set @direccion=(select direccion from Inserted);
			insert into HistoricoUsuario
			values(@nroInterno,@run,@nombre,@appat,@apmat,@direccion);
			end try
			begin catch
				print 1000;
			end catch
		end
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[sp_agregarUsuario]
		@run = NULL,
		@nombre = N'Nicolas',
		@apmat = NULL,
		@appat = N'Lopez',
		@direccion = N'Mi Casa 1234',
		@id_localidad = NULL

SELECT	'Return Value' = @return_value

GO

UPDATE [dbo].[Acceso]
   SET [estadoInicial] = 0
 WHERE id_acceso = 1 
GO