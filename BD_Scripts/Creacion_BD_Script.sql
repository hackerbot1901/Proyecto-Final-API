-- Crear la tabla PROYECTO
CREATE TABLE PROYECTO (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Descripcion NVARCHAR(255),
    FechaInicio DATE,
    FechaFin DATE,
    Estado NVARCHAR(50)
);

-- Crear la tabla TAREAS
CREATE TABLE TAREAS (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Descripcion NVARCHAR(255),
    FechaInicio DATE,
    FechaFin DATE,
    Estado NVARCHAR(50),
    ProyectoId INT NOT NULL,
    FOREIGN KEY (ProyectoId) REFERENCES PROYECTO(Id)
);


-- Inserci�n de datos en la tabla PROYECTO
INSERT INTO PROYECTO (Nombre, Descripcion, FechaInicio, FechaFin, Estado)
VALUES 
    ('Proyecto A', 'Descripci�n del Proyecto A', '2023-01-01', '2023-06-30', 'En progreso'),
    ('Proyecto B', 'Descripci�n del Proyecto B', '2023-02-15', '2023-09-30', 'Pendiente'),
    ('Proyecto C', 'Descripci�n del Proyecto C', '2023-03-20', '2023-07-15', 'Completado'),
    ('Proyecto D', 'Descripci�n del Proyecto D', '2023-04-10', '2023-08-20', 'En pausa'),
    ('Proyecto E', 'Descripci�n del Proyecto E', '2023-05-05', '2023-10-10', 'En progreso');

-- Inserci�n de datos en la tabla TAREAS
INSERT INTO TAREAS (Nombre, Descripcion, FechaInicio, FechaFin, Estado, ProyectoId)
VALUES 
    ('Tarea 1', 'Descripci�n de la Tarea 1', '2023-01-05', '2023-01-15', 'En progreso', 1),
    ('Tarea 2', 'Descripci�n de la Tarea 2', '2023-02-20', '2023-03-10', 'Pendiente', 2),
    ('Tarea 3', 'Descripci�n de la Tarea 3', '2023-03-25', '2023-04-05', 'Completado', 3),
    ('Tarea 4', 'Descripci�n de la Tarea 4', '2023-04-15', '2023-05-01', 'En progreso', 4),
    ('Tarea 5', 'Descripci�n de la Tarea 5', '2023-05-20', '2023-06-10', 'Pendiente', 5);

	-- Inserci�n de datos en la tabla PROYECTO (proyectos de software)
INSERT INTO PROYECTO (Nombre, Descripcion, FechaInicio, FechaFin, Estado)
VALUES 
    ('Sistema de Gesti�n de Clientes', 'Desarrollo de un sistema para gestionar clientes.', '2023-01-01', '2023-06-30', 'En progreso'),
    ('Plataforma E-Commerce', 'Desarrollo de una plataforma de comercio electr�nico.', '2023-02-15', '2023-09-30', 'Pendiente'),
    ('Aplicaci�n de Chat', 'Desarrollo de una aplicaci�n de mensajer�a instant�nea.', '2023-03-20', '2023-07-15', 'Completado'),
    ('Sistema de Administraci�n de Proyectos', 'Desarrollo de un sistema para administrar proyectos.', '2023-04-10', '2023-08-20', 'En pausa'),
    ('App de Gesti�n de Tareas', 'Desarrollo de una aplicaci�n para gestionar tareas.', '2023-05-05', '2023-10-10', 'En progreso');

-- Inserci�n de datos en la tabla TAREAS (asignadas a proyectos de software)
INSERT INTO TAREAS (Nombre, Descripcion, FechaInicio, FechaFin, Estado, ProyectoId)
VALUES 
    ('Dise�o de interfaz de usuario', 'Crear y dise�ar la interfaz de usuario del sistema.', '2023-01-05', '2023-01-15', 'En progreso', 1),
    ('Implementaci�n de la base de datos', 'Configurar la base de datos del E-Commerce.', '2023-02-20', '2023-03-10', 'Pendiente', 2),
    ('Desarrollo de funciones de chat', 'Programar las funciones de chat en la aplicaci�n.', '2023-03-25', '2023-04-05', 'Completado', 5),
    ('Investigaci�n de tecnolog�as', 'Realizar investigaci�n para el nuevo sistema de proyectos.', '2023-04-15', '2023-05-01', 'En progreso', 1),
    ('Implementaci�n de gesti�n de tareas', 'Desarrollar el m�dulo de gesti�n de tareas en la app.', '2023-05-20', '2023-06-10', 'Pendiente', 4);

	select * from proyecto;
	select * from TAREAS;
