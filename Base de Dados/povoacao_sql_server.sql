
Use VinilDB;

SELECT * FROM Leilao;
SELECT * FROM Vinil;
SELECT * FROM Cliente;
 
SELECT DB_NAME() AS CurrentDatabase;


-- Insert data into Cliente
INSERT INTO Cliente (Email, Pass, Dinheiro) VALUES ('admin', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', 10000000); --pass admin
INSERT INTO Cliente (Email, Pass, Dinheiro) VALUES ('joaonqferreira@gmail.com', '20f3765880a5c269b747e1e906054a4b4a3a991259f1e16b5dde4742cec2319a', 150); --pass = 54321
INSERT INTO Cliente (Email, Pass, Dinheiro) VALUES ('maria@example.com', '5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5', 200);
INSERT INTO Cliente (Email, Pass, Dinheiro) VALUES ('pedro@example.com', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 250);
INSERT INTO Cliente (Email, Pass, Dinheiro) VALUES ('ana@example.com', '1c453256914c9869df19081ac3dc23aaeef19f290971b7346108ce4bec651708', 300);
INSERT INTO Cliente (Email, Pass, Dinheiro) VALUES ('carlos@example.com', 'cb3293cff5abc2bbd6fa9472e7b4c01c20ec5700dd5881cbf4d80d6508e19f4b', 350);
INSERT INTO Cliente (Email, Pass, Dinheiro) VALUES ('sofia@example.com', 'f85690ecc0931dd8edcea9cb8c58ffa4dab5e43b5a7ffa778558d71b31e8512e', 400);
INSERT INTO Cliente (Email, Pass, Dinheiro) VALUES ('ricardo@example.com', '75d872cc6878bc56bd5feb569a67d010d8c582dbf6da068c14f7897bda63141d', 450);
INSERT INTO Cliente (Email, Pass, Dinheiro) VALUES ('mariana@example.com', '6c85e1199b2c802dac3b61eaab8271b1674107786092603c5e538ec3ff3709f6', 500);
INSERT INTO Cliente (Email, Pass, Dinheiro) VALUES ('luis@example.com', 'baf06c744961daeb897023455efee0f1beca7c045cadacd4a61d819abbf6dd49', 550);
INSERT INTO Cliente (Email, Pass, Dinheiro) VALUES ('ines@example.com', 'a447c51ca2808552fa28a95a3b440cc97d4cb3f1eeffea4a17af90410afdd83c', 600);
INSERT INTO Cliente (Email, Pass, Dinheiro) VALUES ('eduardo@example.com', 'c34ae04b892e736bd3b54da5d1a469184d2114e115c7ed9f3c9373204ca69b5a', 650);
GO


-- Insert data into Leilao										 
INSERT INTO Leilao (Estado, Comprador, Valor_base, Valor_minimo, TempoCriacao, Preco_venda, Vendedor) 
	VALUES ('lastChance', NULL, 100, 80, DATEADD(HOUR, -20, GETDATE()), 80, 5);
INSERT INTO Leilao (Estado, Comprador, Valor_base, Valor_minimo, TempoCriacao, Preco_venda, Vendedor) 
	VALUES ('aberto', NULL, 150, 120, DATEADD(HOUR, -11, GETDATE()), 147, 7);
INSERT INTO Leilao (Estado, Comprador, Valor_base, Valor_minimo, TempoCriacao, Preco_venda, Vendedor) 
	VALUES ('catalogado', NULL, 200, 160, DATEADD(HOUR, -1, GETDATE()), 180, 1);
INSERT INTO Leilao (Estado, Comprador, Valor_base, Valor_minimo, TempoCriacao, Preco_venda, Vendedor) 
	VALUES ('fechado', 10, 250, 200, DATEADD(HOUR, -17, GETDATE()), 200, 2);
INSERT INTO Leilao (Estado, Comprador, Valor_base, Valor_minimo, TempoCriacao, Preco_venda, Vendedor) 
	VALUES ('fechado', 2, 300, 240, DATEADD(HOUR, -13, GETDATE()), 252, 3);
INSERT INTO Leilao (Estado, Comprador, Valor_base, Valor_minimo, TempoCriacao, Preco_venda, Vendedor) 
	VALUES ('aberto', NULL, 300, 200, DATEADD(HOUR, -22, GETDATE()), 228, 3);
GO


-- Insert data into Vinil
INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao)
VALUES ('The Beatles', 'Abbey Road', '1969-01-01', 3, 4, 'Rock', 40, 12, 33, 'LP', 'Apple Records', 1, 1, 'https://upload.wikimedia.org/wikipedia/en/4/42/Beatles_-_Abbey_Road.jpg', 2, 6);

INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao)
VALUES ('Pink Floyd', 'The Dark Side of the Moon', '1973-01-01', 2, 5, 'Rock', 42, 12, 33, 'LP', 'Harvest', 1, 1, 'https://miro.medium.com/v2/resize:fit:1358/1*8FkvzbSdSJ4HNxtuZo5kLg.jpeg', 2, 6);

INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao)
VALUES ('Michael Jackson', 'Thriller', '1982-01-01', 5, 5, 'Pop', 42, 12, 33, 'LP', 'Epic Records', 1, 1, 'https://static.dw.com/image/63920593_605.jpg', 3, 6);

INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao)
VALUES ('Led Zeppelin', 'IV', '1971-01-01', 1, 3, 'Rock', 42, 12, 33, 'LP', 'Atlantic Records', 1, 1, 'https://upload.wikimedia.org/wikipedia/pt/4/4b/LedZeppelinIV.jpg', 4, 6);

INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao)
VALUES ('Queen', 'A Night at the Opera', '1975-01-01', 1, 4, 'Rock', 43, 12, 33, 'LP', 'EMI', 1, 1, 'https://upload.wikimedia.org/wikipedia/pt/b/bf/A_Night_at_the_Opera_Queen.jpg', 5, 6);

INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao)
VALUES ('Bob Dylan', 'Highway 61 Revisited', '1965-01-01', 5, 3, 'Folk', 41, 12, 33, 'LP', 'Columbia Records', 1, 1, 'https://upload.wikimedia.org/wikipedia/en/9/95/Bob_Dylan_-_Highway_61_Revisited.jpg', 6, 6);

INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao)
VALUES ('The Rolling Stones', 'Sticky Fingers', '1971-01-01', 4, 2, 'Rock', 42, 12, 33, 'LP', 'Rolling Stones Records', 1, 1, 'https://upload.wikimedia.org/wikipedia/en/5/57/The_Rolling_Stones_-_Sticky_Fingers.png', 7, 3);

INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao)
VALUES ('Nirvana', 'Nevermind', '1991-01-01', 3, 3, 'Grunge', 42, 12, 33, 'LP', 'DGC Records', 1, 1, 'https://upload.wikimedia.org/wikipedia/pt/3/3f/Nevermind.jpg', 8, 4);

INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao)
VALUES ('David Bowie', 'The Rise and Fall of Ziggy Stardust', '1972-01-01', 4, 5, 'Rock', 42, 12, 33, 'LP', 'RCA Records', 1, 1, 'https://upload.wikimedia.org/wikipedia/en/0/01/ZiggyStardust.jpg', 9, 5);

INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao)
VALUES ('The Who', 'Whos Next', '1971-01-01', 5, 4, 'Rock', 42, 12, 33, 'LP', 'Track Records', 1, 1, 'https://upload.wikimedia.org/wikipedia/en/4/44/Whosnext.jpg', 10, 1);

INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao)
VALUES ('Elvis Presley', 'Elvis Presley', '1956-01-01', 3, 4, 'Rock', 33, 12, 33, 'LP', 'RCA Records', 1, 1, 'https://upload.wikimedia.org/wikipedia/en/f/f5/Elvis_Presley_LPM-1254_Album_Cover.jpg', 2, NULL);

INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao)
VALUES ('The Doors', 'The Doors', '1967-01-01', 3, 4, 'Rock', 44, 12, 33, 'LP', 'Elektra Records', 1, 1, 'https://upload.wikimedia.org/wikipedia/en/thumb/9/98/TheDoorsTheDoorsalbumcover.jpg/220px-TheDoorsTheDoorsalbumcover.jpg', 2, 2);

INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao)
VALUES ('AC/DC', 'Back in Black', '1980-01-01', 2, 3, 'Hard Rock', 42, 12, 33, 'LP', 'Atlantic Records', 1, 1, 'https://i.ebayimg.com/images/g/aK8AAOSwVHlez~hV/s-l1600.jpg', 2, 3);

INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao)
VALUES ('The Beach Boys', 'Pet Sounds', '1966-01-01', 3, 4, 'Pop', 37, 12, 33, 'LP', 'Capitol Records', 1, 1, 'https://m.media-amazon.com/images/I/810rL61zIRL._UF1000,1000_QL80_.jpg', 2, 4);

INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao)
VALUES ('Jimi Hendrix', 'Are You Experienced', '1967-01-01', 3, 4, 'Rock', 38, 12, 33, 'LP', 'Track Records', 1, 1, 'https://upload.wikimedia.org/wikipedia/commons/3/33/Are_You_Experienced_-_US_cover-edit.jpg', 2, 5);

INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao)
VALUES ('Metallica', 'Master of Puppets', '1986-01-01', 1, 2, 'Metal', 54, 12, 33, 'LP', 'Elektra Records', 1, 1, 'https://midias.correiobraziliense.com.br/_midias/png/2022/07/13/1000x1000/1_metallica-26046466.png?20220713152408?20220713152408', 2, 1);

INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao)
VALUES ('Prince', 'Purple Rain', '1984-01-01', 2, 3, 'Pop', 43, 12, 33, 'LP', 'Warner Bros. Records', 1, 1, 'https://upload.wikimedia.org/wikipedia/en/9/9c/Princepurplerain.jpg', 2, 2);

INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao)
VALUES ('U2', 'The Joshua Tree', '1987-01-01', 2, 4, 'Rock', 50, 12, 33, 'LP', 'Island Records', 1, 1, 'https://pure-music.co.uk/wp-content/uploads/2019/03/The-Joshua-Tree-Album-Cover-500x321.png', 2, 3);

INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao)
VALUES ('Fleetwood Mac', 'Rumours', '1977-01-01', 2, 4, 'Rock', 40, 12, 33, 'LP', 'Warner Bros. Records', 1, 1, 'https://upload.wikimedia.org/wikipedia/pt/f/fb/FMacRumours.PNG', 2, 4);

INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao)
VALUES ('Radiohead', 'OK Computer', '1997-01-01', 2, 5, 'Alternative', 53, 12, 33, 'LP', 'Parlophone', 1, 1, 'https://static.fnac-static.com/multimedia/Images/PT/NR/4e/a0/02/172110/1540-6/tsp20160815151428/Ok-Computer.jpg', 2, 5);

INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao)
VALUES ('Bob Marley', 'Legend', '1984-01-01', 1, 2, 'Reggae', 54, 12, 33, 'LP', 'Island Records', 1, 1, 'https://upload.wikimedia.org/wikipedia/pt/c/cc/Legend_Bob_Marley.jpg', 2, 1);

INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao)
VALUES ('Elton John', 'Goodbye Yellow Brick Road', '1973-01-01', 3, 3, 'Rock', 47, 12, 33, 'LP', 'MCA Records', 1, 1, 'https://upload.wikimedia.org/wikipedia/pt/9/94/Elton_John_-_1973_-_Goodbye_Yellow_Brick_Road.jpg', 2, 2);

INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao)
VALUES ('Ramones', 'Ramones', '1976-01-01', 2, 4, 'Punk', 29, 12, 33, 'LP', 'Sire Records', 1, 1, 'https://upload.wikimedia.org/wikipedia/en/b/bb/Ramones_-_Ramones_cover.jpg', 2, 3);

INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao)
VALUES ('Blur', 'Parklife', '1994-01-01', 1, 2, 'Britpop', 52, 12, 33, 'LP', 'Food Records', 1, 1, 'https://www.louielouie.pt/pub/media/catalog/product/cache/image/1000x1320/e9c3970ab036de70892d86c6d221abfe/b/l/blur_parklife_cd.jpg', 2, 4);

INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao)
VALUES ('The Clash', 'London Calling', '1979-01-01', 2, 3, 'Punk Rock', 65, 12, 33, 'LP', 'CBS Records', 1, 1, 'https://upload.wikimedia.org/wikipedia/en/0/00/TheClashLondonCallingalbumcover.jpg', 2, 5);

INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao)
VALUES ('Green Day', 'Dookie', '1994-01-01', 1, 2, 'Punk Rock', 39, 12, 33, 'LP', 'Reprise Records', 1, 1, 'https://upload.wikimedia.org/wikipedia/pt/b/b2/Green_Day_-_Dookie.jpg', 2, NULL);

INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao)
VALUES ('The Police', 'Synchronicity', '1983-01-01', 2, 4, 'Rock', 44, 12, 33, 'LP', 'A&M Records', 1, 1, 'https://upload.wikimedia.org/wikipedia/en/7/7f/Police-album-synchronicity.jpg', 2, 3);

INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao)
VALUES ('R.E.M.', 'Automatic for the People', '1992-01-01', 2, 3, 'Alternative', 48, 12, 33, 'LP', 'Warner Bros. Records', 1, 1, 'https://www.udiscovermusic.com/wp-content/uploads/2019/10/Automatic-For-The-People-album-cover-820-820x820.jpg', 2, 4);

INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao)
VALUES ('Radiohead', 'Kid A', '2000-01-01', 1, 1, 'Alternative', 49, 12, 33, 'LP', 'Parlophone', 1, 1, 'https://upload.wikimedia.org/wikipedia/pt/4/44/KidA.jpg', 2, 5);

INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao)
VALUES ('Nirvana', 'In Utero', '1993-01-01', 2, 4, 'Grunge', 41, 12, 33, 'LP', 'DGC Records', 1, 1, 'https://upload.wikimedia.org/wikipedia/pt/b/b4/InUtero.jpeg', 2, 2);

INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao)
VALUES ('The Rolling Stones', 'Let It Bleed', '1969-01-01', 3, 3, 'Rock', 42, 12, 33, 'LP', 'Decca Records', 1, 1, 'https://m.media-amazon.com/images/I/81Ut0SKKVhL._UF1000,1000_QL80_.jpg', 2, 2);

INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao)
VALUES ('Pink Floyd', 'Wish You Were Here', '1975-01-01', 2, 4, 'Rock', 44, 12, 33, 'LP', 'Harvest', 1, 1, 'https://i1.sndcdn.com/artworks-rZvUWUOFMMxzEyy8-Q7FffA-t500x500.jpg', 2, 4);

INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao)
VALUES ('Bob Dylan', 'Blonde on Blonde', '1966-01-01', 3, 3, 'Folk', 70, 12, 33, 'LP', 'Columbia Records', 1, 1, 'https://i.ytimg.com/vi/hKB-_iO2qy4/hqdefault.jpg', 2, 3);

INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao)
VALUES ('Queen', 'News of the World', '1977-01-01', 3, 3, 'Rock', 40, 12, 33, 'LP', 'EMI', 1, 1, 'https://upload.wikimedia.org/wikipedia/pt/7/7d/Queen-News_of_the_World.jpg', 2, NULL);

INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao)
VALUES ('Led Zeppelin', 'Physical Graffiti', '1975-01-01', 2, 4, 'Rock', 82, 12, 33, 'LP', 'Swan Song Records', 1, 1, 'https://upload.wikimedia.org/wikipedia/en/e/e3/Led_Zeppelin_-_Physical_Graffiti.jpg', 2, NULL);

INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao)
VALUES ('David Bowie', 'Hunky Dory', '1971-01-01', 2, 3, 'Rock', 41, 12, 33, 'LP', 'RCA Records', 1, 1, 'https://upload.wikimedia.org/wikipedia/pt/4/40/David_Bowie_-_Hunky_Dory.jpg', 2, NULL);

INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao)
VALUES ('The Who', 'Quadrophenia', '1973-01-01', 1, 2, 'Rock', 81, 12, 33, 'LP', 'Track Records', 1, 1, 'https://upload.wikimedia.org/wikipedia/en/8/8a/Quadrophenia_%28album%29.jpg', 2, NULL);

GO