CREATE PROCEDURE DirectorGetById
    @DirectorId INT
AS
BEGIN
    SELECT *
    FROM Directores
    WHERE Id = @DirectorId;
END;