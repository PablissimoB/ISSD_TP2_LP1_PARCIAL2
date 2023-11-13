CREATE TABLE Directores (
    id INT  PRIMARY KEY IDENTITY(1,1),
    apellido VARCHAR(50),
    nombre VARCHAR(50),
	activo int NULL
);

CREATE TABLE Peliculas (
    id INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(150),
    idDirector INT,
	activo int NULL,
    FOREIGN KEY (idDirector) REFERENCES Directores(id)
);