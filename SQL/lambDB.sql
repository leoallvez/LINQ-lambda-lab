sp_help people;

--DROP TABLE people;

CREATE TABLE Pessoa (
	Id INT NOT NULL PRIMARY KEY,
	Idade INT NOT NULL,
	Nome VARCHAR(100)
);

INSERT INTO Pessoa VALUES(1, 22, 'Maria');
INSERT INTO Pessoa VALUES(2, 23, 'Pedro');
INSERT INTO Pessoa VALUES(3, 24, 'Elias');
INSERT INTO Pessoa VALUES(4, 25, 'Sônia');
INSERT INTO Pessoa VALUES(5, 26, 'Paula');

SELECT * FROM Pessoa;

CREATE TABLE Matricula(
	Id INT NOT NULL PRIMARY KEY,
	Descricao VARCHAR(100),
	PessoaId INT NOT NULL,
	CONSTRAINT FK_PESSOA_MATRICULA FOREIGN KEY (PessoaId) REFERENCES Pessoa (Id)
);

INSERT INTO Matricula VALUES(1, 'Matricula 1', 1);
INSERT INTO Matricula VALUES(2, 'Matricula 2', 2);
INSERT INTO Matricula VALUES(3, 'Matricula 3', 3);
INSERT INTO Matricula VALUES(4, 'Matricula 4', 4);
INSERT INTO Matricula VALUES(5, 'Matricula 5', 5);

SELECT * FROM Matricula; 

SELECT * FROM Pessoa p
Inner Join Matricula m ON m.PessoaId = p.Id