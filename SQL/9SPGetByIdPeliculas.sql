CREATE PROCEDURE PeliculaGetById
    @PeliculaId INT
AS
BEGIN
    SELECT *
    FROM Peliculas
    WHERE Id = @PeliculaId;
END;