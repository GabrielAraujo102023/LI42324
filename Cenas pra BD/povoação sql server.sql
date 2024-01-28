
SELECT * FROM Leilao;
SELECT * FROM Vinil;
 
SELECT DB_NAME() AS CurrentDatabase;




Use VinilDB;

-- Insert data into Cliente
INSERT INTO Cliente (Email, Pass, Dinheiro) VALUES ('joao@example.com', 5, 150);
INSERT INTO Cliente (Email, Pass, Dinheiro) VALUES ('maria@example.com', 8, 200);
INSERT INTO Cliente (Email, Pass, Dinheiro) VALUES ('pedro@example.com', 3, 250);
INSERT INTO Cliente (Email, Pass, Dinheiro) VALUES ('ana@example.com', 10, 300);
INSERT INTO Cliente (Email, Pass, Dinheiro) VALUES ('carlos@example.com', 6, 350);
INSERT INTO Cliente (Email, Pass, Dinheiro) VALUES ('sofia@example.com', 1, 400);
INSERT INTO Cliente (Email, Pass, Dinheiro) VALUES ('ricardo@example.com', 9, 450);
INSERT INTO Cliente (Email, Pass, Dinheiro) VALUES ('mariana@example.com', 4, 500);
INSERT INTO Cliente (Email, Pass, Dinheiro) VALUES ('luis@example.com', 7, 550);
INSERT INTO Cliente (Email, Pass, Dinheiro) VALUES ('ines@example.com', 11, 600);
INSERT INTO Cliente (Email, Pass, Dinheiro) VALUES ('eduardo@example.com', 2, 650);
GO


-- Insert data into Leilao
INSERT INTO Leilao (Estado, Comprador, Valor_base, Valor_minimo, Preco_venda, Vendedor) VALUES ('aberto', NULL, 100, 80, 100, 3);
INSERT INTO Leilao (Estado, Comprador, Valor_base, Valor_minimo, Preco_venda, Vendedor) VALUES ('aberto', NULL, 150, 120, 129, 4);
INSERT INTO Leilao (Estado, Comprador, Valor_base, Valor_minimo, Preco_venda, Vendedor) VALUES ('catalogado', NULL, 200, 160, 200, 5);
INSERT INTO Leilao (Estado, Comprador, Valor_base, Valor_minimo, Preco_venda, Vendedor) VALUES ('fechado', 10, 250, 200, 200, 6);
INSERT INTO Leilao (Estado, Comprador, Valor_base, Valor_minimo, Preco_venda, Vendedor) VALUES ('fechado', 2, 300, 240, 252, 8);
GO


-- Insert data into Vinil
INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao) VALUES ('The Beatles', 'Abbey Road', '1969-01-01', 3, 4, 'Rock', 40, 12, 33, 'LP', 'Apple Records', 1, 1, 'https://upload.wikimedia.org/wikipedia/en/4/42/Beatles_-_Abbey_Road.jpg', 1, 1);
INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao) VALUES ('Pink Floyd', 'The Dark Side of the Moon', '1973-01-01', 2, 5, 'Rock', 42, 12, 33, 'LP', 'Harvest', 1, 1, 'https://miro.medium.com/v2/resize:fit:1358/1*8FkvzbSdSJ4HNxtuZo5kLg.jpeg', 2, 1);
INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao) VALUES ('Michael Jackson', 'Thriller', '1982-01-01', 5, 5, 'Pop', 42, 12, 33, 'LP', 'Epic Records', 1, 1, 'https://static.dw.com/image/63920593_605.jpg', 3, 3);
INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao) VALUES ('Led Zeppelin', 'IV', '1971-01-01', 1, 3, 'Rock', 42, 12, 33, 'LP', 'Atlantic Records', 1, 1, 'https://upload.wikimedia.org/wikipedia/pt/4/4b/LedZeppelinIV.jpg', 4, 4);
INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao) VALUES ('Queen', 'A Night at the Opera', '1975-01-01', 1, 4, 'Rock', 43, 12, 33, 'LP', 'EMI', 1, 1, 'https://upload.wikimedia.org/wikipedia/pt/b/bf/A_Night_at_the_Opera_Queen.jpg', 5, 4);
INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao) VALUES ('Bob Dylan', 'Highway 61 Revisited', '1965-01-01', 5, 3, 'Folk', 41, 12, 33, 'LP', 'Columbia Records', 1, 1, 'https://upload.wikimedia.org/wikipedia/en/9/95/Bob_Dylan_-_Highway_61_Revisited.jpg', 6, 2);
INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao) VALUES ('The Rolling Stones', 'Sticky Fingers', '1971-01-01', 4, 2, 'Rock', 42, 12, 33, 'LP', 'Rolling Stones Records', 1, 1, 'https://upload.wikimedia.org/wikipedia/en/5/57/The_Rolling_Stones_-_Sticky_Fingers.png', 7, 3);
INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao) VALUES ('Nirvana', 'Nevermind', '1991-01-01', 3, 3, 'Grunge', 42, 12, 33, 'LP', 'DGC Records', 1, 1, 'https://upload.wikimedia.org/wikipedia/pt/3/3f/Nevermind.jpg', 8, 4);
INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao) VALUES ('David Bowie', 'The Rise and Fall of Ziggy Stardust', '1972-01-01', 4, 5, 'Rock', 42, 12, 33, 'LP', 'RCA Records', 1, 1, 'https://upload.wikimedia.org/wikipedia/en/0/01/ZiggyStardust.jpg', 9, 5);
INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao) VALUES ('The Who', 'Whos Next', '1971-01-01', 5, 4, 'Rock', 42, 12, 33, 'LP', 'Track Records', 1, 1, 'https://upload.wikimedia.org/wikipedia/en/4/44/Whosnext.jpg', 10, 1);
INSERT INTO Vinil (Artista, Album, AnoLancamento, Condicao_disco, Condicao_capa, Categoria, Duracao, Tamanho, Rotacoes, Tipo, Gravadora, Edicao_especial, Remasterizado, Fotos_Vinil, Cliente, Leilao) VALUES ('Elvis Presley', 'Elvis Presley', '1956-01-01', 3, 4, 'Rock', 33, 12, 33, 'LP', 'RCA Records', 1, 1, 'https://upload.wikimedia.org/wikipedia/en/f/f5/Elvis_Presley_LPM-1254_Album_Cover.jpg', 11, NULL);
INSERT INTO Vinil (Cliente) VALUES (3);
GO


