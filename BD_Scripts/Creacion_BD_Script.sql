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


-- Inserción de datos en la tabla PROYECTO
INSERT INTO PROYECTO (Nombre, Descripcion, FechaInicio, FechaFin, Estado)
VALUES 
    ('Proyecto A', 'Descripción del Proyecto A', '2023-01-01', '2023-06-30', 'En progreso'),
    ('Proyecto B', 'Descripción del Proyecto B', '2023-02-15', '2023-09-30', 'Pendiente'),
    ('Proyecto C', 'Descripción del Proyecto C', '2023-03-20', '2023-07-15', 'Completado'),
    ('Proyecto D', 'Descripción del Proyecto D', '2023-04-10', '2023-08-20', 'En pausa'),
    ('Proyecto E', 'Descripción del Proyecto E', '2023-05-05', '2023-10-10', 'En progreso');

-- Inserción de datos en la tabla TAREAS
INSERT INTO TAREAS (Nombre, Descripcion, FechaInicio, FechaFin, Estado, ProyectoId)
VALUES 
    ('Tarea 1', 'Descripción de la Tarea 1', '2023-01-05', '2023-01-15', 'En progreso', 1),
    ('Tarea 2', 'Descripción de la Tarea 2', '2023-02-20', '2023-03-10', 'Pendiente', 2),
    ('Tarea 3', 'Descripción de la Tarea 3', '2023-03-25', '2023-04-05', 'Completado', 3),
    ('Tarea 4', 'Descripción de la Tarea 4', '2023-04-15', '2023-05-01', 'En progreso', 4),
    ('Tarea 5', 'Descripción de la Tarea 5', '2023-05-20', '2023-06-10', 'Pendiente', 5);

	-- Inserción de datos en la tabla PROYECTO (proyectos de software)
INSERT INTO PROYECTO (Nombre, Descripcion, FechaInicio, FechaFin, Estado)
VALUES 
    ('Sistema de Gestión de Clientes', 'Desarrollo de un sistema para gestionar clientes.', '2023-01-01', '2023-06-30', 'En progreso'),
    ('Plataforma E-Commerce', 'Desarrollo de una plataforma de comercio electrónico.', '2023-02-15', '2023-09-30', 'Pendiente'),
    ('Aplicación de Chat', 'Desarrollo de una aplicación de mensajería instantánea.', '2023-03-20', '2023-07-15', 'Completado'),
    ('Sistema de Administración de Proyectos', 'Desarrollo de un sistema para administrar proyectos.', '2023-04-10', '2023-08-20', 'En pausa'),
    ('App de Gestión de Tareas', 'Desarrollo de una aplicación para gestionar tareas.', '2023-05-05', '2023-10-10', 'En progreso');

-- Inserción de datos en la tabla TAREAS (asignadas a proyectos de software)
INSERT INTO TAREAS (Nombre, Descripcion, FechaInicio, FechaFin, Estado, ProyectoId)
VALUES 
    ('Diseño de interfaz de usuario', 'Crear y diseñar la interfaz de usuario del sistema.', '2023-01-05', '2023-01-15', 'En progreso', 1),
    ('Implementación de la base de datos', 'Configurar la base de datos del E-Commerce.', '2023-02-20', '2023-03-10', 'Pendiente', 2),
    ('Desarrollo de funciones de chat', 'Programar las funciones de chat en la aplicación.', '2023-03-25', '2023-04-05', 'Completado', 5),
    ('Investigación de tecnologías', 'Realizar investigación para el nuevo sistema de proyectos.', '2023-04-15', '2023-05-01', 'En progreso', 1),
    ('Implementación de gestión de tareas', 'Desarrollar el módulo de gestión de tareas en la app.', '2023-05-20', '2023-06-10', 'Pendiente', 4);

	select * from proyecto;
	select * from TAREAS;
