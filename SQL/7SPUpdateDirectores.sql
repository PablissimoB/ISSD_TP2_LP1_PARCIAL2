CREATE PROCEDURE DirectorUpdate
    @id INT,
    @apellido VARCHAR(50),
    @nombre VARCHAR(50)
AS
BEGIN
    UPDATE Directores
    SET apellido = @apellido,
        nombre = @nombre
    WHERE id = @id;
END;
