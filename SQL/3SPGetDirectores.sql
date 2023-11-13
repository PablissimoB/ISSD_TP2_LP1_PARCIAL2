CREATE PROCEDURE DirectoresGet
AS
BEGIN
    SELECT id, apellido, nombre
    FROM Directores;
END;