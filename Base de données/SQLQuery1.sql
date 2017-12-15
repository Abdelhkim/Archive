drop Database ARCHIVE_MJ
create database ARCHIVE_MJ COLLATE Arabic_CI_AI
set dateformat dmy
create table Employes(
	ID_Employe				int Primary key not null,
	Nom						varchar(255),
	Prenom					varchar(255),
	Username				varchar(255) unique not null,
	Password				varchar(255) not null,
	Type_Compte				bit default 0,
	Numero_Telephone		Varchar(255),
	Email					varchar(255)
)
select Top(1)* from Verssements order by Numero_Verssement desc
update Employes set Username = 'Kiko',Nom='kaki',Prenom='koko' where ID_Employe=2
select * from Employes
Create table TCA(
	Code_Tribunal_TCA		varchar(30) Primary key,
	Nom_tribunal_TCA		varchar(255)
)
go 

create table TPI(
	Code_Tribunal_TPI		varchar(30) primary key,
	Nom_Tribunal_TPI		varchar(255),
	Code_TCA				varchar(30) foreign key references TCA(Code_Tribunal_TCA) on delete cascade
)
go
create table CJ(
	Code_Tribunal_CJ		varchar(30) primary key,
	Nom_Tribunal_CJ			varchar(255),
	Code_TPI				varchar(30) foreign key references TPI(Code_Tribunal_TPI) on delete cascade
)
go
insert into Verssements(Code_Tribunal,Nom_Administration,Responsable,Employe_ID,Date_Vessement,Nombre_Box,Metrage,Stocker,Date_Stockage)
select * from Verssements
DBCC CHECKIDENT ('Verssements',RESEED,0)
select * from Verssements
select top(1)* from Verssements order by Numero_Verssement desc
create table Verssements(
	Numero_Verssement		int primary key identity(1,1),
	Code_Tribunal			varchar(30),
	Nom_Administration		varchar(255),
	Responsable				varchar(255),
	N_Tele_Responsable		varchar(255),
	Employe_ID				int Foreign key references Employes(ID_Employe) on delete cascade,
	Date_Vessement			Date,
	Nombre_Box				int,
	Metrage					float,
	Stocker					bit default 0,
	Date_Stockage			Date,
	Permission				bit default 0)
create table Addressage(
	Id_Address				int primary key,
	Position				varchar(255),
	N_Verssement			int foreign key references Verssements(Numero_Verssement) on delete cascade,
	Libre_Etat				bit default 0,
	)

)
go
--create table Modele(
--	id_Modele				int primary key,
--	Nom_Modele				varchar(255),
--	Numero_Modele			int,
--	Duree_Archive			int)
Go
create table Proces(
	Code_Proces				int primary key,
	Nom_Proces				varchar(255),
	Tribunal				varchar(30),
	Duree_Archive			int,

)
select * from Proces
insert into Proces(Code_Proces,Nom_Proces,Tribunal,Duree_Archive) select Code,Nom,Tribunal,Duréé from Sheet1$
go
drop table 
create table Carton(
	Numero_Verssement		int foreign key references Verssements(Numero_Verssement) on delete cascade,
	Type_Archive			varchar(20),
	Numero_Box				int,
	Anné_Proce				int,
	Id_Address				int foreign key references Addressage(Id_Address),
	primary key(Numero_Verssement,Type_Archive,Numero_Box),
	Code_Proce				int foreign key references Proces(Code_Proces) on delete cascade,
	NBRdossier				int,
	)
	alter table Carton
			add  NBRdossier int 

create table Dossier(
	Id_Dossier				int,
	Numero_Dossier			int,
	Anne_Ouverture			Date,
	Numero_jujment			int,
	Numero_Ver				int,
	Type_Archi				varchar(20),
	Numero_BoX				int,
	foreign key				(Numero_Ver,Type_Archi,Numero_BoX) references Carton(Numero_Verssement,Type_Archive,Numero_Box) on delete cascade,
	fiche_ph				bit default 0,
	phontome				varchar(255),
	description				text
	)
	


create table TGC(
	Code_Tribunal_TGC		varchar(30),
	Nom_Tribunal_TGC		varchar(255)
)
drop table TD
create table SDR(
	Code_Tribunal_SDR		varchar(30),
	Nom_Tribunal_SDR		varchar(255)
)


create table Connexions(
	id_Connexion			int primary key,
	Date_Connexion			Datetime,
	Date_Deconnexion		Datetime,
	id_Employé				int foreign key references Employes(ID_Employe)on delete cascade
)
go
create table Taches(
	id_Tache				int primary key,
	id_Employe				int foreign key references Employes(ID_Employe)on delete cascade,
	Tache					varchar(255),
	Date_Tache				Date
)
alter table Verssements
	add	Stocker			bit default 0,
		Date_Stockage	Date,
		Permission		bit	Default 0
select * from Verssements
select * from ver$
insert into Verssements(Code_Tribunal,Nom_Administration,Responsable,N_Tele_Responsable,Employe_ID,Date_Vessement,Nombre_Box,Metrage,Stocker,Date_Stockage) 
	select codetr,service,noresponsable,nutel,0,date,nbreboite,volueboite,etats,date from ver$ order by codever

insert into Employes values(0,'DefaultN','DefaultP','DefaultUser','123456789','0642019202','mansoumabdelhkim@outlook.com',0)
insert into Employes values(1,'mansoum','Abdelhkim','hakim','123456','0642019202','mansoumabdelhkim@outlook.com',1)
insert into Employes values(2,'Adham','ahram','Adham','123456','0642019202','mansoumabdelhkim@outlook.com',0)

--select * from Addressage

--update Addressage set Libre_Etat = 1 where N_Verssement != ''

--insert into TCA(Code_Tribunal_TCA,Nom_tribunal_TCA) select tca_Code,tca_Nom from MJ_CA.dbo.TCA
--select * from TCA
--insert into TPI(Code_Tribunal_TPI,Nom_Tribunal_TPI,Code_TCA) select tpi_Code,tpi_Nom,TCA from MJ_CA.dbo.TPI
--insert into CJ(Code_Tribunal_CJ,Nom_Tribunal_CJ,Code_TPI) select cj_Code,cj_Nom,TPI from MJ_CA.dbo.CJ
--delete Employes
--select * from Employes
--alter table Employes
--	add Type_Compte bit default 0 

select * from TPI
insert into TGC Values('CD1101001','محكمة جماعات زرقط')
insert into TGC Values('CD1101002','محكمة جماعات أسني')
insert into TGC Values('CD1101003','محكمة جماعات ويركان')

insert into SDR values('SDR1100','لدى محكمة الإستناف بمراكش')
insert into SDR values('SDR0300','لدى محكمة الإستناف بأكادير ')
insert into SDR values('SDR0400','لدى محكمة الإستناف بورزازات')
insert into SDR values('SDR1600','لدى محكمة الإستناف بأسفي')
insert into SDR values('SDR0700','لدى محكمة الإستناف ببني ملال')
delete TPI where Code_Tribunal_TPI = 'CD1101003'
select * from Carton
update boite set typearch = 'EY' where annee = 1989 and typearch is null
select * from boite where adresse = 'A-07A3-094-06'
select * from boite where annee = 1989
	insert into Carton(Numero_Verssement,Type_Archive,Numero_Box,Anné_Proce,Id_Address,Code_Proce)
	select codever,typearch,numboite,annee,id_adress,codeobj from Boite

select * from boite
alter table boite
	add id_adress int
update boite set boite.id_adress = Addressage.Id_Address
		from boite inner join Addressage on boite.adresse = Addressage.Position
select * from TPI
Select  top(1)Numero_Verssement from Verssements where Employe_ID = 2 order by Numero_Verssement desc
select * from Addressage where Libre_Etat = 0
insert into Carton(Numero_Verssement,Type_Archive,Numero_Box,Id_Address,Code_Proce,Anné_proce)
select * from Dossier
insert into Dossier(Id_Dossier,Numero_Dossier,Anne_Ouverture,Numero_jujment,description,Numero_Ver,Type_Archi,Numero_BoX) Values(@id_Dossier,@Numero_Dossier,@Ann_over,@N_jujment,@Description,@Numero_V,@T_Arch,N_Box)
select * from Addressage