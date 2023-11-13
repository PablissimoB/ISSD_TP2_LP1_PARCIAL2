CREATE PROCEDURE PeliculaUpdate
    @id INT,
    @nombre VARCHAR(150),
    @idDirector INT
AS
BEGIN
    UPDATE Peliculas
    SET nombre = @nombre,
        idDirector = @idDirector
    WHERE id = @id;
END;
