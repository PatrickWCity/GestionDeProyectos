create procedure [dbo].[sp_desasignarSubmoduloDeModulo]
@id_modulo int, @id_submodulo int
as
begin
      begin try
			delete from SubmoduloModulo
			where id_modulo=@id_modulo
			and id_submodulo=@id_submodulo
      end try
      begin catch
			print 'Error de Desasignar Submodulo';
      end catch
end;
go
create procedure [dbo].[sp_desasignarModuloDePerfil]
@id_perfil int, @id_modulo int
as
begin
      begin try
			delete from ModuloPerfil
			where id_modulo=@id_modulo
			and id_perfil=@id_perfil
      end try
      begin catch
			print 'Error de Desasignar Modulo';
      end catch
end;
go
create procedure [dbo].[sp_asignarSubmoduloAModulo]
@id_modulo int, @id_submodulo int
as
begin
      begin try
			insert into SubmoduloModulo
			values(GETDATE(), 1, @id_modulo, @id_submodulo);
      end try
      begin catch
			print 'Error de Asignar Submodulo';
      end catch
end;
go
create procedure [dbo].[sp_asignarModuloAPerfil]
@id_perfil int, @id_modulo int
as
begin
      begin try
			insert into ModuloPerfil
			values(GETDATE(), 1, @id_perfil, @id_modulo);
      end try
      begin catch
			print 'Error de Asignar Modulo';
      end catch
end;
go
create PROCEDURE [dbo].[sp_consultarSubmodulosSinModulo]
@id_modulo int
AS
BEGIN
	BEGIN TRY
		SELECT u.id_submodulo, u.nombre
		FROM Submodulo u
		WHERE u.id_submodulo NOT IN
		(
			SELECT u.id_submodulo
			FROM Submodulo u, SubmoduloModulo pu, Modulo p
			WHERE p.id_modulo = @id_modulo AND
				  p.id_modulo = pu.id_modulo AND
				  pu.id_submodulo = u.id_submodulo
		);
	END TRY
	BEGIN CATCH
		PRINT -1;
	END CATCH
END;
go
create PROCEDURE [dbo].[sp_consultarSubmodulosDeModulo] 
@id_modulo int
AS
BEGIN
	BEGIN TRY
		SELECT u.id_submodulo, u.nombre
		FROM Submodulo u, SubmoduloModulo pu, Modulo p
		WHERE p.id_modulo = @id_modulo AND
			  p.id_modulo = pu.id_modulo AND
			  pu.id_submodulo = u.id_submodulo;
	END TRY
	BEGIN CATCH
		PRINT -1;
	END CATCH
END;
go
create PROCEDURE [dbo].[sp_consultarModulosSinPerfil]--idperfil
@id_perfil int
AS
BEGIN
	BEGIN TRY
		SELECT u.id_modulo, u.nombre
		FROM Modulo u
		WHERE u.id_modulo NOT IN
		(
			SELECT u.id_modulo
			FROM Modulo u, ModuloPerfil pu, Perfil p
			WHERE p.id_perfil = @id_perfil AND--p.id_perfil
				  p.id_perfil = pu.id_perfil AND
				  pu.id_modulo = u.id_modulo
		);
	END TRY
	BEGIN CATCH
		PRINT -1;
	END CATCH
END;
go
create PROCEDURE [dbo].[sp_consultarModulosDePerfil]
@id_perfil int
AS
BEGIN
	BEGIN TRY
		SELECT u.id_modulo, u.nombre
		FROM Modulo u, ModuloPerfil pu, Perfil p
		WHERE p.id_perfil = @id_perfil AND
			  p.id_perfil = pu.id_perfil AND
			  pu.id_modulo = u.id_modulo;
	END TRY
	BEGIN CATCH
		PRINT -1;
	END CATCH
END;