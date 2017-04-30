create table Users(
ID int primary key not null,
Name varchar(255),
Role varchar(50),
Email varchar(255),
Password varchar(MAX),
);


create table Kategoria
(
	ID int primary key not null,
	EmriKategori varchar(255) not null,
	PershkrimKategori varchar(500),
	FotoKategori varbinary(MAX)
);

create table Produktet
(
	ID int primary key not null,
	EmerProdukt varchar(255) not null,
	CmimProdukt int not null,
	ProduktKategoriID int foreign key references Kategoria(ID) not null,
	PershkrimProdukt varchar(500),
	FotoProdukt varbinary(MAX),

);

create table Shitje 
(
	ID int primary key not null,
	DataShitje datetime not null,
	KamarierID int foreign key references Users(ID) not null,
	Total int not null,
	FatureHapur bit 
);

create table ShitjeProdukt
(
	ID int primary key not null,
	EmerProdukt varchar(255) not null,
	CmimProdukt int not null,
	SasiProdukt int not null,
	TotalProdukt int not null,
	ShitjeID int foreign key references Shitje(ID) not null
);

create table Furnitor
(
	ID int primary key not null,
	EmerFurnitor varchar(255)
);

create table Furnizim 
(
	ID int primary key not null,
	FurnitorID int foreign key references Furnitor(ID) not null,
	NrFature varchar(255) not null,
	DataFurnizim datetime not null,
	Total int not null  
);


create table ProduktFurnizim
(
	ID int primary key not null,
	EmerProdukt varchar(255) not null,
	SasiProdukt int not null,
	CmimProdukt int not null,
	Total int not null,
	FurnizimID int foreign key references Furnizim(ID) not null
);


create table Tavoline
(
	ID int primary key not null,
	EmerTavoline varchar(255) not null
);



alter table Shitje add TavolineID int foreign key references Tavoline(ID) not null;