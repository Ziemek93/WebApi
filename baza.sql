CREATE TABLE dbo.Users
(
  Id int  NOT NULL PRIMARY KEY IDENTITY(1,1),
  Name VARCHAR (45) NOT NULL,
  Login VARCHAR (45) UNIQUE NOT NULL,
  Password VARCHAR (100) NOT NULL
  );

CREATE TABLE dbo.Documents
(
  Id int NOT NULL PRIMARY KEY IDENTITY(1,1),
  Id_fku int,
  numer_klienta int,
  data_dokumentu DATE NOT NULL,
  nazwa VARCHAR (45) NOT NULL UNIQUE,
   FOREIGN KEY
	(Id_fku) REFERENCES dbo.Users
	(Id)
  );
  
CREATE TABLE dbo.Things
(
  Id int NOT NULL PRIMARY KEY IDENTITY(1,1),
  nazwa_artykulu VARCHAR (45) NOT NULL UNIQUE,
  cena_netto float (20) NOT NULL,
  cena_brutto float (20) NOT NULL
);  
  
Create Table dbo.Documents_Things 
(
	Id int NOT NULL PRIMARY KEY IDENTITY(1,1),
	Id_fkd int,
	Id_fkt int,
	ilosc int NOT NULL,
	 FOREIGN KEY
	(Id_fkd) REFERENCES dbo.Documents
	(Id),
	FOREIGN KEY
	(Id_fkt) REFERENCES dbo.Things
	(Id)
);
  

Insert into  dbo.Users
  (name, login, password)
values
  ('Grzegorz', 'GrzegBrzecz', 'passwd');
  
Insert into  dbo.Things
  (nazwa_artykulu, cena_netto, cena_brutto)
values
  ('Jablko', '2.42', '2.78');  
  
  Insert into  dbo.Things
  (nazwa_artykulu, cena_netto, cena_brutto)
values
  ('JakiesCos', '42.42', '65.22'); 
  
  Insert into  dbo.Things
  (nazwa_artykulu, cena_netto, cena_brutto)
values
  ('InnyProdukt', '133.42', '155.78'); 
  
 Insert into  dbo.Documents
  (Id_fku, numer_klienta, data_dokumentu, nazwa)
values
  ('1', '4442121', '2000-11-29 12:58:28', 'Doc2'); 
  
  Insert into  dbo.Documents
  (Id_fku, numer_klienta, data_dokumentu, nazwa)
values
  ('1', '4442121', '2011-10-19 12:58:28', 'Doc1'); 
  
 Insert into  dbo.Documents_Things
  (Id_fkd, Id_fkt, ilosc)
values
  ('1', '1', '15');   
  
  Insert into  dbo.Documents_Things
  (Id_fkd, Id_fkt, ilosc)
values
  ('1', '3', '41');   
  
   Insert into  dbo.Documents_Things
  (Id_fkd, Id_fkt, ilosc)
values
  ('2', '2', '13');   
   
  
