CREATE PROCEDURE PeliculasGet
AS
BEGIN
    SELECT id, nombre, idDirector
    FROM Peliculas;
END;