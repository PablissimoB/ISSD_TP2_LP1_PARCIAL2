CREATE PROCEDURE PeliculasInsert
    @nombre VARCHAR(150),
    @idDirector INT
AS
BEGIN
    INSERT INTO Peliculas (nombre, idDirector, activo)
    VALUES (@nombre, @idDirector, 1);
END;