CREATE PROCEDURE PeliculaInsert
    @nombre VARCHAR(150),
    @idDirector INT
AS
BEGIN
    INSERT INTO Peliculas (nombre, idDirector)
    VALUES (@nombre, @idDirector);
END;