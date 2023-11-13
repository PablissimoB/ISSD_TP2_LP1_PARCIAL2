CREATE PROCEDURE DirectorUpdate
    @id INT,
    @apellido VARCHAR(50),
    @nombre VARCHAR(50),
	@activo INT
AS
BEGIN
    UPDATE Directores
    SET apellido = @apellido,
        nombre = @nombre,
		activo = @activo
    WHERE id = @id;
END;
