CREATE PROCEDURE DirectorInsert
    @apellido VARCHAR(50),
    @nombre VARCHAR(50)
AS
BEGIN
    INSERT INTO Directores (apellido, nombre)
    VALUES (@apellido, @nombre);
END;