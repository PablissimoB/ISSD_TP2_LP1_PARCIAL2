CREATE PROCEDURE PeliculaUpdate
    @id INT,
    @nombre VARCHAR(150),
    @idDirector INT,
	@activo INT
AS
BEGIN
    UPDATE Peliculas
    SET nombre = @nombre,
        idDirector = @idDirector,
		activo = @activo
    WHERE id = @id;
END;
