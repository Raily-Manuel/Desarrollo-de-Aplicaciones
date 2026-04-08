insert into Usuarios(Nom_Usuario, Email, Telefono, Usuario, Clave, id_Rol) values
('Sebastian Sanchez', 'sebastiansanchez@gmail.com', '829-409-8594', 'Pokesebas', 'greninja21', 1),
('Perla Zapata', 'perlazapata@gmail.com', '829-672-9044', 'Perla Z.', '20092209', 1),
('Juan Duarte', 'vivard@gmail.com', '809-394-9490', 'Juan D.', '593801', 2),
('Ramon Mella', 'trabucazohdtm@gmail.com', '849-941-4092', 'Ramon M.', '0686076', 2),
('Francisco Snchez', 'banderapati@gmail.com', '809-685-5925', 'Francisco S.', '3974810', 2);
select * from Usuarios


insert into Roles(Nom_Rol) values
('Administrador'),
('Bibliotecario');
select * from Roles
truncate table Roles


insert into Autores(Nom_Autor, Pais, Email) values
('Gabriel Garcia Marquez', 'Colombia', 'gabrielgarcia@gmail.com'),
('Isabel Allende', 'Chile', 'isabelallende@gmail.com'),
('Mario Vargas Llosa', 'Peru', 'mariovargas@gmail.com'),
('Jane Austen', 'Inglaterra', 'janeausten@gmail.com'),
('George Orwell', 'Inglaterra', 'george@gmail.com'),
('J.K. Rowling', 'Reino Unido', 'j.k.@gmail.com'),
('Stephen King', 'Estados Unidos', 'stephenking@gmail.com'),
('Paulo Coelho', 'Brasil', 'paulocoelho@gmail.com'),
('Miguel de Cervantes', 'España', 'migueldecer@gmail.com'),
('William Shakespeare', 'Inglaterra', 'williamshak@gmail.com'),
('Agatha Christie', 'Reino Unido', 'agathachristie@gmail.com'),
('Fyodor Dostoevsky', 'Rusia', 'fyodordos@gmail.com'),
('Leo Tolstoy', 'Rusia', 'leotolstoy@gmail.com'),
('Ernest Hemingway', 'Estados Unidos', 'ernesthemingway@gmail.com'),
('J.R.R. Tolkien', 'Inglaterra', 'j.r.r.@gmail.com'),
('Victor Hugo', 'Francia', 'victorhugo@gmail.com');
Select * from Autores


insert into Generos(Nom_Genero, Descripcion) values
('Realismo magico', 'Mezcla hechos cotidianos con elementos fantásticos o mágicos que los personajes consideran normales.'),
('Novela romantica', 'Se centra en relaciones amorosas entre los personajes, explorando emociones, conflictos sentimentales y desarrollo de las relaciones.'),
('Distopia', 'Presenta sociedades imaginarias con gobiernos opresivos o situaciones extremas que reflejan problemas sociales o políticos.'),
('Fantasia', 'Incluye mundos imaginarios, criaturas mágicas, poderes sobrenaturales y aventuras en universos ficticios.'),
('Terror/Horror', 'Busca provocar miedo o tensión en el lector mediante situaciones sobrenaturales, psicológicas o monstruosas.'),
('Misterio', 'La historia gira alrededor de un crimen o enigma que debe ser resuelto, generalmente por un detective.'),
('Drama/Tragedia', 'Obras centradas en conflictos humanos profundos, decisiones difíciles y consecuencias trágicas para los personajes.'),
('Novela histórica', 'Relata historias ambientadas en épocas pasadas e incorpora eventos históricos reales.'),
('Novela de aventura', 'Se enfoca en viajes, exploraciones, peligros y experiencias emocionantes vividas por los protagonistas.'),
('Ciencia ficcion', 'Explora ideas científicas, tecnología avanzada, futuros posibles o mundos alternativos.'),
('Novela psicologica', 'Se centra en los pensamientos, emociones y conflictos internos de los personajes.'),
('Novela filosofica', 'Explora preguntas profundas sobre la existencia, la moral, la justicia o el sentido de la vida.'),
('Novela social', 'Analiza problemas sociales como pobreza, desigualdad, injusticia o lucha de clases.'),
('Literatura juvenil', 'Dirigida principalmente a adolescentes y jóvenes, con protagonistas jóvenes y temas de crecimiento personal.'),
('Fábula/Alegoria', 'Utiliza historias simbólicas o personajes animales para representar ideas políticas o morales.'),
('Novela gótica', 'Combina misterio, terror y escenarios oscuros como castillos, monstruos o ambientes sobrenaturales.'),
('Novela existencialista', 'Explora el sentido de la vida, la alienación, la libertad y la existencia humana.'),
('Novela de formacion', 'Relata el crecimiento y desarrollo personal de un personaje desde la juventud hasta la madurez.');
select * from Generos


insert into Lectores(Nom_Lector, Direc_Lector, Tel_Lector, Email_Lector) values
('Pedro Vargas', 'Calle No.4, Barrio Marta', '809-422-4901', 'pedrovargas@gmail.com'),
('Pepito Martinez', 'Barrio Juan Pablo, Calle No.11', '829-857-4093', 'pepitomartinez@gmail.com'),
('Ana Pérez', 'Calle Duarte No.15, Villa Juana', '809-555-1021', 'anaperez@gmail.com'),
('Luis Rodríguez', 'Av. Independencia No.220', '829-555-2045', 'luisrodriguez@gmail.com'),
('María López', 'Calle Sánchez No.8, Los Mina', '809-555-3342', 'marialopez@gmail.com'),
('Carlos Fernández', 'Calle Mella No.33, Herrera', '829-555-4451', 'carlosfernandez@gmail.com'),
('Rosa Castillo', 'Av. Las Américas Km 5', '809-555-5567', 'rosacastillo@gmail.com'),
('Jorge Ramírez', 'Calle Restauración No.12', '829-555-6678', 'jorgeramirez@gmail.com'),
('Luisa Gómez', 'Calle 27 de Febrero No.44', '809-555-7789', 'luisagomez@gmail.com'),
('Miguel Herrera', 'Barrio San Carlos, Calle 3', '829-555-8891', 'miguelherrera@gmail.com'),
('Patricia Núñez', 'Calle Central No.19, Ensanche Ozama', '809-555-9902', 'patricianunez@gmail.com'),
('Andrés Cruz', 'Calle Primera No.7, Sabana Perdida', '829-555-1123', 'andrescruz@gmail.com'),
('Laura Santana', 'Av. Charles de Gaulle No.90', '809-555-2234', 'laurasantana@gmail.com'),
('Fernando Díaz', 'Calle 10, Barrio Libertad', '829-555-3345', 'fernandodiaz@gmail.com'),
('Daniel Torres', 'Calle Las Flores No.5', '809-555-4456', 'danieltorres@gmail.com');
select * from Lectores


insert into Libros(Titulo_Libro, id_Genero, id_Autor, Isbn, Cant_Paginas, id_Ubicacion, id_Usuario, Stock, Fecha_Creacion) values
('Cien años de soledad', 1, 1, '9788420471839', 417, 1, 2, 46, '1967-05-30'),
('La casa de los espíritus', 1, 2, '9788401337202', 433, 18, 1, 22, '1982-03-15'),
('Eva Luna', 1, 2, '9788401337219', 285, 7, 2, 14, '1987-09-10'),
('Paula', 12, 2, '9788401337226', 320, 41, 1, 9, '1994-10-08'),
('El amante japonés', 2, 2, '9781501116999', 352, 12, 2, 31, '2015-02-03'),
('La ciudad y los perros', 13, 3, '9788437604947', 448, 30, 1, 17, '1963-10-17'),
('La casa verde', 13, 3, '9788437604954', 430, 5, 2, 19, '1966-06-01'),
('Conversación en La Catedral', 13, 3, '9788437604961', 601, 23, 1, 11, '1969-07-04'),
('La fiesta del Chivo', 8, 3, '9788420471831', 518, 44, 2, 26, '2000-11-05'),
('Orgullo y prejuicio', 2, 4, '9780141439518', 432, 8, 1, 35, '1813-01-28'),
('Sentido y sensibilidad', 2, 4, '9780141439662', 409, 53, 2, 28, '1811-10-30'),
('Emma', 2, 4, '9780141439587', 474, 36, 1, 16, '1815-12-23'),
('Persuasión', 2, 4, '9780141439686', 279, 27, 2, 13, '1817-12-20'),
('1984', 3, 5, '9780451524935', 328, 14, 1, 42, '1949-06-08'),
('Rebelión en la granja', 15, 5, '9780451526342', 112, 49, 2, 24, '1945-08-17'),
('Homenaje a Cataluña', 8, 5, '9780156421171', 232, 10, 1, 12, '1938-04-25'),
('Sin blanca en París y Londres', 13, 5, '9780156262248', 213, 33, 2, 18, '1933-01-09'),
('Harry Potter y la piedra filosofal', 4, 6, '9788478884452', 309, 2, 1, 45, '1997-06-26'),
('Harry Potter y la cámara secreta', 4, 6, '9788478884957', 341, 25, 2, 27, '1998-07-02'),
('Harry Potter y el prisionero de Azkaban', 4, 6, '9788478885190', 435, 31, 1, 33, '1999-07-08'),
('Harry Potter y el cáliz de fuego', 4, 6, '9788478886456', 636, 52, 2, 40, '2000-07-08'),
('El resplandor', 5, 7, '9780307743657', 447, 6, 1, 20, '1977-01-28'),
('It', 5, 7, '9781501142974', 1138, 48, 2, 29, '1986-09-15'),
('Carrie', 5, 7, '9780307743664', 199, 16, 1, 23, '1974-04-05'),
('Misery', 5, 7, '9781501143100', 310, 38, 2, 32, '1987-06-08'),
('El alquimista', 12, 8, '9780061122415', 208, 3, 1, 37, '1988-05-01'),
('Brida', 12, 8, '9780061762703', 288, 47, 2, 15, '1990-03-15'),
('Once minutos', 2, 8, '9780060589288', 288, 20, 1, 21, '2003-04-01'),
('Veronika decide morir', 12, 8, '9780061124266', 240, 9, 2, 17, '1998-09-01'),
('Don Quijote de la Mancha', 9, 9, '9788491050296', 863, 29, 1, 34, '1605-01-16'),
('Novelas ejemplares', 9, 9, '9788491050302', 560, 50, 2, 19, '1613-08-12'),
('La Galatea', 2, 9, '9788491050319', 320, 13, 1, 8, '1585-03-01'),
('Persiles y Sigismunda', 9, 9, '9788491050326', 400, 42, 2, 14, '1617-04-19'),
('Hamlet', 7, 10, '9780743477123', 160, 11, 1, 30, '1603-01-01'),
('Macbeth', 7, 10, '9780743477109', 132, 46, 2, 18, '1606-05-01'),
('Romeo y Julieta', 7, 10, '9780743477116', 256, 21, 1, 24, '1597-01-29'),
('Otelo', 7, 10, '9780743477550', 314, 54, 2, 22, '1604-11-01'),
('Asesinato en el Orient Express', 6, 11, '9780062693662', 256, 17, 1, 31, '1934-01-01'),
('Muerte en el Nilo', 6, 11, '9780062073556', 333, 28, 2, 20, '1937-11-01'),
('Diez negritos', 6, 11, '9780062073488', 272, 40, 1, 36, '1939-11-06'),
('El asesinato de Roger Ackroyd', 6, 11, '9780007527526', 312, 4, 2, 27, '1926-06-01'),
('Crimen y castigo', 11, 12, '9780143058144', 671, 26, 1, 41, '1866-01-01'),
('El idiota', 11, 12, '9780140447927', 656, 32, 2, 18, '1869-01-01'),
('Los hermanos Karamazov', 12, 12, '9780374528379', 824, 15, 1, 39, '1880-11-01'),
('Demonios', 11, 12, '9780141441412', 768, 34, 2, 25, '1872-01-01'),
('Guerra y paz', 8, 13, '9780199232765', 1225, 37, 1, 50, '1869-01-01'),
('Anna Karenina', 11, 13, '9780143035008', 864, 45, 2, 44, '1877-04-01'),
('Resurrección', 12, 13, '9780486411329', 608, 22, 1, 12, '1899-01-01'),
('La muerte de Iván Ilich', 11, 13, '9780140449617', 96, 24, 2, 10, '1886-01-01'),
('El viejo y el mar', 12, 14, '9780684801223', 127, 35, 1, 33, '1952-09-01'),
('Por quién doblan las campanas', 8, 14, '9780684803357', 480, 19, 2, 28, '1940-10-21'),
('Fiesta', 13, 14, '9780743297332', 251, 43, 1, 14, '1926-10-22'),
('Adiós a las armas', 8, 14, '9780684801469', 355, 39, 2, 23, '1929-09-27'),
('El hobbit', 4, 15, '9780261103344', 310, 51, 1, 48, '1937-09-21'),
('La comunidad del anillo', 4, 15, '9780261102354', 423, 6, 2, 26, '1954-07-29'),
('Las dos torres', 4, 15, '9780261102361', 352, 55, 1, 34, '1954-11-11'),
('El retorno del rey', 4, 15, '9780261102378', 416, 1, 2, 29, '1955-10-20'),
('Los miserables', 8, 16, '9780451419439', 1463, 18, 1, 52, '1862-04-03'),
('Nuestra Señora de París', 16, 16, '9780140443530', 940, 12, 2, 31, '1831-03-16'),
('El hombre que ríe', 8, 16, '9780140439885', 704, 33, 1, 17, '1869-04-01'),
('Noventa y tres', 8, 16, '9780140444308', 352, 7, 2, 21, '1874-02-19'),
('El coronel no tiene quien le escriba', 13, 1, '9788437604978', 120, 47, 1, 16, '1961-01-01'),
('Crónica de una muerte anunciada', 13, 1, '9788437604985', 122, 5, 2, 24, '1981-03-01'),
('El amor en los tiempos del cólera', 2, 1, '9780307389732', 348, 28, 1, 42, '1985-09-05'),
('El otoño del patriarca', 13, 1, '9780307389749', 255, 8, 2, 18, '1975-01-01');
select * from Libros


insert into Ubicacion(Pasillo, Estanteria) values
('A', 1), ('A', 2), ('A', 3), ('A', 4),
('B', 1), ('B', 2), ('B', 3), ('B', 4),
('C', 1), ('C', 2), ('C', 3), ('C', 4),
('D', 1), ('D', 2), ('D', 3), ('D', 4),
('E', 1), ('E', 2), ('E', 3), ('E', 4),
('F', 1), ('F', 2), ('F', 3), ('F', 4),
('G', 1), ('G', 2), ('G', 3), ('G', 4),
('H', 1), ('H', 2), ('H', 3), ('H', 4),
('I', 1), ('I', 2), ('I', 3), ('I', 4),
('J', 1), ('J', 2), ('J', 3), ('J', 4),
('K', 1), ('K', 2), ('K', 3), ('K', 4),
('N', 1), ('N', 2), ('N', 3), ('N', 4),
('M', 1), ('M', 2), ('M', 3), ('M', 4),
('R', 1), ('R', 2), ('R', 3), ('R', 4);
select * from Ubicacion


insert into Prestamos(Fecha_Prestamo, id_Lector, Fecha_Entrega, Fecha_Devolucion, id_Usuario) values
('2026-02-09', 7, '2026-03-09', '2026-03-10', 4),
('2026-03-01', 14, '2026-04-01', '2026-03-22', 3);
select * from Prestamos
truncate table Prestamos

insert into Detalle_Prestamo(id_Prestamo, id_Libro) values
(1, 44),
(2, 3);
select * from Detalle_Prestamo