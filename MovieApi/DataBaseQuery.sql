create table Category(
Id int not null,
MovieType nvarchar(max),
primary key (Id)
);

Create table Movie(
Id uniqueidentifier not null,
CategoryId int,
Title nvarchar(max) not null,
ReleaseDate Datetime,
MDescription nvarchar(max),
Score decimal,
ImageSrc nvarchar(max),
Primary key(Id),
Foreign key (CategoryId) references Category(Id)
);

Create table Actor(
Id uniqueidentifier not null,
FirstName nvarchar(max) not null,
LastName nvarchar(max) not null,
Birthdate datetime,
Primary key (Id),
);

create table MovieActor(
ActorId uniqueidentifier,
MovieId uniqueidentifier,
Foreign key (ActorId) references Actor(Id),
foreign key (MovieId) references Movie(Id),
Unique(ActorId,MovieId)
);

Insert into Category values (1,'Action')
Insert into Category values (2,'Adventure')
Insert into Category values (3,'Comedy')
Insert into Category values (4,'Drama')
Insert into Category values (5,'horror')
Insert into Category values (6,'musicals')
Insert into Category values (7,'mystery')
Insert into Category values (8,'science fiction')
Insert into Category values (9,'sports')
Insert into Category values (10,'thriller')
Insert into Category values (11,'Western')

Insert into Movie values('54dc859e-e666-48c9-8d8b-50a590943c4d',3,'Cocaine Bear','2023-22-02','An oddball group of cops, criminals, tourists and teens converge on a Georgia forest where a huge black bear goes on a murderous rampage after unintentionally ingesting cocaine.',
6.4,'https://www.imdb.com/title/tt14209916/mediaviewer/rm184234241/?ref_=tt_ov_i');

Insert into Movie values('e3ab7825-99bd-4371-ba8a-53c9c7787fb6',2,'We Have a Ghost','2023-02-24','Finding a ghost named Ernest haunting their new home turns Kevin`s family into overnight social media sensations. But when Kevin and Ernest investigate the mystery of Ernest`s past, they become a target of the CIA.',
6.1,'https://www.imdb.com/title/tt7798604/mediaviewer/rm2491035649/?ref_=tt_ov_i')

Insert into Movie values ('56e120b5-8ff0-499c-ae3b-798480af93fd',1,'Ant-Man and the Wasp: Quantumania','2023-02-15','Scott Lang and Hope Van Dyne, along with Hank Pym and Janet Van Dyne, explore the Quantum Realm, where they interact with strange creatures and embark on an adventure that goes beyond the limits of what they thought was possible.',
6.5,'https://www.imdb.com/title/tt10954600/mediaviewer/rm2537959681/?ref_=tt_ov_i')

Insert into Movie values ('0fba9fd7-e654-4d41-98c0-ed5ba10aaee0',4,'The Whale','2022-09-11','A reclusive, morbidly obese English teacher attempts to reconnect with his estranged teenage daughter.',
7.8,'https://www.imdb.com/title/tt13833688/mediaviewer/rm752499201/?ref_=tt_ov_i')

insert into Movie values ('a2793ef2-7089-4572-a3e4-541c527856e6',9,'Creed 3','2023-03-01','Adonis has been thriving in both his career and family life, but when a childhood friend and former boxing prodigy resurfaces, the face-off is more than just a fight.',
7.4,'https://www.imdb.com/title/tt11145118/mediaviewer/rm1156461569/?ref_=tt_ov_i')

insert into Movie values ('6c5f29d8-3e76-4de7-91b3-c42d4787476f',1,'Everything Everywhere All at Once','2022-03-24','A middle-aged Chinese immigrant is swept up into an insane adventure in which she alone can save existence by exploring other universes and connecting with the lives she could have led.',
8.0,'https://www.imdb.com/title/tt6710474/mediaviewer/rm316021249/?ref_=tt_ov_i')

insert into Movie values ('09de008e-c9ae-4070-ac4f-6fabf86fc447',4,'Babylon','2022-12-23','A tale of outsized ambition and outrageous excess, it traces the rise and fall of multiple characters during an era of unbridled decadence and depravity in early Hollywood.',
7.3,'https://www.imdb.com/title/tt10640346/mediaviewer/rm865155841/?ref_=tt_ov_i')

insert into Movie values ('b736e7ba-c636-4ebf-88e6-f0070b8a7a6a',2,'Peter Pan & Wendy','2023-04-28','Live-action adaptation of J.M. Barrie`s classic tale of a boy who wouldn`t grow up and recruits three young siblings in London to join him on a magical adventure to the enchanted Neverland island.',
null,'https://www.imdb.com/title/tt5635026/mediaviewer/rm188364545/?ref_=tt_ov_i')

insert into Movie values ('574f0469-c89b-4d2c-9098-e79a14c270e8',5,'Knock at the Cabin','2023-02-01','While vacationing, a girl and her parents are taken hostage by armed strangers who demand that the family make a choice to avert the apocalypse.',
6.1,'https://www.imdb.com/title/tt15679400/mediaviewer/rm3083615233/?ref_=tt_ov_i')

insert into Movie values ('87b2c43b-c154-4bb9-b757-8aee2d2c545b',10,'The Strays','2023-02-22','A Black woman`s meticulously crafted life of privilege starts to unravel when two strangers show up in her quaint suburban town.',
4.7,'https://www.imdb.com/title/tt16437278/mediaviewer/rm1054094849/?ref_=tt_ov_i')

insert into Movie values ('2ee663d5-011b-4b81-a5e3-3eb25873b152',10,'The Test','2023-02-22','A Black woman`s meticulously crafted life of privilege starts to unravel when two strangers show up in her quaint suburban town.',
4.7,'https://www.imdb.com/title/tt16437278/mediaviewer/rm1054094849/?ref_=tt_ov_i')

insert into Actor values('d317c4c9-d6bb-4bc4-bf8e-b6c12cb322b7','Jesse Tyler','Ferguson','1975-10-22')

insert into Actor values ('70018e7b-8e10-4132-9d53-0c95202e5a12','Anthony','Mackie','1978-10-23')

insert into Actor values ('83060afb-912c-4e29-9089-c8ac9059265f','Paul','Rudd','1969-04-06')

insert into Actor values ('3904d152-4469-41b3-94dc-fcd5f5bf6ebf','Brandon', 'Fraser','1968-12-03')

insert into Actor values ('57e2f852-e476-48c3-9e38-9d36c262f829','Michael b.','Jordan','1987-02-09')

insert into Actor values ('f681cf05-f88e-47cd-9eea-79cf012eb1de','Michelle','Yeoh','1962-08-6')

insert into Actor values ('5bd49249-314b-497f-ae44-f34cfdc1303c','Brad','Pitt','1963-12-18')

insert into Actor values ('05941e1f-cd60-4705-87aa-fe9210ba44ba','Alexander','Molony','2006-09-12')

insert into Actor values ('e896a551-b279-463d-9da8-03866b2bdabe','Dave','Bautista','1969-01-18')

insert into Actor values ('f0568cc9-1122-48e5-9cf2-620c971aa7f9','Ashley','Madekwe','1981-12-06')

insert into Actor values ('5588a044-123b-4786-9a29-45494d12c182','Bukky','Bakray',null)

insert into MovieActor values('70018e7b-8e10-4132-9d53-0c95202e5a12','e3ab7825-99bd-4371-ba8a-53c9c7787fb6')
insert into MovieActor values('70018e7b-8e10-4132-9d53-0c95202e5a12','56e120b5-8ff0-499c-ae3b-798480af93fd')
insert into MovieActor values('83060afb-912c-4e29-9089-c8ac9059265f','56e120b5-8ff0-499c-ae3b-798480af93fd')
insert into MovieActor values('3904d152-4469-41b3-94dc-fcd5f5bf6ebf','0fba9fd7-e654-4d41-98c0-ed5ba10aaee0')
insert into MovieActor values('57e2f852-e476-48c3-9e38-9d36c262f829','a2793ef2-7089-4572-a3e4-541c527856e6')
insert into MovieActor values('f681cf05-f88e-47cd-9eea-79cf012eb1de','6c5f29d8-3e76-4de7-91b3-c42d4787476f')
insert into MovieActor values('5bd49249-314b-497f-ae44-f34cfdc1303c','09de008e-c9ae-4070-ac4f-6fabf86fc447')
insert into MovieActor values('05941e1f-cd60-4705-87aa-fe9210ba44ba','b736e7ba-c636-4ebf-88e6-f0070b8a7a6a')
insert into MovieActor values('e896a551-b279-463d-9da8-03866b2bdabe','574f0469-c89b-4d2c-9098-e79a14c270e8')
insert into MovieActor values ('f0568cc9-1122-48e5-9cf2-620c971aa7f9','87b2c43b-c154-4bb9-b757-8aee2d2c545b')
insert into MovieActor values ('5588a044-123b-4786-9a29-45494d12c182','87b2c43b-c154-4bb9-b757-8aee2d2c545b')


Select MovieId, C.MovieType, Title, MDescription, Score, ImageSrc from Movie M
inner join Category C
on M.CategoryId = C.CategoryId

Select * from Movie

Select m.Title, c.MovieType, m.Score, a.FirstName, a.LastName from Movie m
inner join Category c on m.CategoryId = c.CategoryId
inner join MovieActor ma on m.MovieId = ma.MovieId
inner join Actor a on a.ActorId = ma.ActorId
Where Title = 'Ant-Man and the Wasp: Quantumania'

select Title, ReleaseDate, Score, ImageSrc from Movie

Select Title, ReleaseDate, MDescription, Score, ImageSrc, MovieType from Movie m
inner join Category c on m.CategoryId = c.Id
where m.Id= '87B2C43B-C154-4BB9-B757-8AEE2D2C545B'


Select Id, FirstName, LastName, Birthdate from Actor a
inner join MovieActor ma on a.Id=ma.ActorId
where ma.MovieId = '87B2C43B-C154-4BB9-B757-8AEE2D2C545B'

--First site queryes

Create procedure spMovie_GetAll
as
begin
	select * from Movie
end

Create procedure spMovieInfo_GetAllFromId (@Id uniqueidentifier)
as
begin
	Select m.Id, Title, ReleaseDate, MDescription, Score, ImageSrc, CategoryId from Movie m
	where m.Id = @Id
end

Create procedure spMovieInfo_GetAll
as
begin
	Select m.Id, Title, ReleaseDate, MDescription, Score, ImageSrc, MovieType from Movie m
	inner join Category c on m.CategoryId = c.Id
end

Create procedure spActors_GetAllFromMovieId (@Id uniqueidentifier)
as
begin
	Select Id, FirstName, LastName, Birthdate from Actor a
	inner join MovieActor ma on a.Id=ma.ActorId
	where ma.MovieId = @Id
end


Create procedure spMovie_InsertInto (@Id uniqueidentifier, @CategoryId int, @Title nvarchar(max), @ReleaseDate datetime,@MDescription nvarchar(max),@Score int,@ImageSrc nvarchar(max))
as
begin
insert into Movie
values (@Id, @CategoryId , @Title, @ReleaseDate,@MDescription,@Score,@ImageSrc)
end

create procedure spMovie_Update (@Id uniqueidentifier, @CategoryId int, @Title nvarchar(max), @ReleaseDate datetime,@MDescription nvarchar(max),@Score int,@ImageSrc nvarchar(max))
as
begin
update Movie
set CategoryId=@CategoryId, Title=@Title, ReleaseDate=@ReleaseDate, MDescription=@MDescription,Score=@Score,ImageSrc=@ImageSrc
Where Id=@Id
end

create procedure spMovie_Delete (@Id uniqueidentifier)
as
begin
Delete from Movie
where Id=@Id
end

create procedure spActor_GetAll
as
begin
Select * from Actor
end

create procedure spActor_GetOneFromId(@Id uniqueidentifier)
as
begin
Select * from Actor
where Id=@Id
end

create procedure spActor_InsertInto(@Id uniqueidentifier,@FirstName nvarchar(max), @LastName nvarchar(max), @Birthdate datetime)
as
begin
Insert into Actor 
values (@Id, @FirstName, @LastName, @Birthdate)
end

create procedure spActor_Update(@Id uniqueidentifier, @FirstName nvarchar(max), @LastName nvarchar(max), @Birthdate datetime)
as
begin
update Actor
set FirstName=@FirstName, LastName=@LastName, Birthdate=@Birthdate
where Id=@Id
end

Create procedure spActor_Delete(@Id uniqueidentifier)
as
begin
delete from Actor
where Id=@Id
end