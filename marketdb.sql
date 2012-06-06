use marketdb;

create table bills
(
	billID int identity(1,1) not null,
	sumPrice float not null,
	time date,
	primary key(billID)
);

create table cards
(
	cardID int identity(1,1) not null,
	password varchar(150) not null,
	amount float not null,
	primary key(cardID)
);

create table facility
(
	facilityID int identity(1,1) not null,
	facilityName varchar(30) null,
	state bit,
	primary key(facilityID)
);

create table items
(
	itemID int identity(1,1) not null,
	itemName varchar(30),
	itemPrice float not null,
	itemQuan int not null,
	repertory int not null,
	itemType varchar(20),
	primary key(itemID)
);

create table itemsList
(
	itemsListID int identity(1,1) not null,
	billID int not null,
	itemID int not null,
	itemNum int not null,
	primary key(itemsListID),
	foreign key(billID) references bills(billID),
	foreign key(itemID) references items(itemID)	
);

create table loginInfo
(	
	loginID int identity(1,1) not null,
	userName varchar(50) not null,
	password varchar(150) not null,
	privilege tinyint not null,
	primary key(loginID)
);

create table outcome
(
	outcomeID int identity(1,1) not null,
	type varchar(50),
	amount float not null,
	time date,
	department varchar(50),
	primary key(outcomeID)
);

create table position
(
	positionID int identity(1,1) not null,
	department varchar(20) not null,
	positionName varchar(30) not null,
	salary float not null,
	primary key(positionID)
);

create table workers
(
	workerID int identity(1,1) not null,
	gender bit,
	firstName varchar(30) not null,
	lastName varchar(30) not null,
	positionID int not null,
	primary key(workerID),
	foreign key(positionID) references position(positionID)
);

insert into workers(gender, firstName, lastName, positionID) 
values('true', 'Pan', 'Liang', 1);
insert into workers(gender, firstName, lastName, positionID) 
values('true', 'Wu', 'Wei', 2);
insert into workers(gender, firstName, lastName, positionID) 
values('false', 'Wang', 'Mei', 3);
insert into workers(gender, firstName, lastName, positionID) 
values('true', 'Cai', 'Peng', 4);
insert into workers(gender, firstName, lastName, positionID) 
values('false', 'Zhang', 'Yuan', 5);
insert into workers(gender, firstName, lastName, positionID) 
values('false', 'Li', 'Pei', 6);
insert into workers(gender, firstName, lastName, positionID) 
values('true', 'Xia', 'Ye', 7);
insert into workers(gender, firstName, lastName, positionID) 
values('true', 'Liu', 'Wangchen', 8);
insert into workers(gender, firstName, lastName, positionID) 
values('true', 'Yang', 'Zhenwei', 9);
insert into workers(gender, firstName, lastName, positionID) 
values('true', 'Peng', 'Yiwei', 10);
insert into workers(gender, firstName, lastName, positionID) 
values('false', 'Zhu', 'Yan', 11);
insert into workers(gender, firstName, lastName, positionID) 
values('true', 'Zhang', 'Tianyun', 12);
insert into workers(gender, firstName, lastName, positionID) 
values('false', 'Qiu', 'Ya', 13);
insert into workers(gender, firstName, lastName, positionID) 
values('false', 'Su', 'Hang', 14);

insert into position(department, positionName, salary)
values('persinnel', 'manager', 5000);
insert into position(department, positionName, salary)
values('commodity', 'manager', 5100);
insert into position(department, positionName, salary)
values('sales', 'manager', 5000);
insert into position(department, positionName, salary)
values('technology', 'manager', 4900);
insert into position(department, positionName, salary)
values('security', 'manager', 4700);
insert into position(department, positionName, salary)
values('service', 'manager', 5500);
insert into position(department, positionName, salary)
values('office', 'general manager', 8000);
insert into position(department, positionName, salary)
values('persinnel', 'clerk', 4000);
insert into position(department, positionName, salary)
values('commodity', 'clerk', 4200);
insert into position(department, positionName, salary)
values('sales', 'clerk', 4100);
insert into position(department, positionName, salary)
values('technology', 'clerk', 3900);
insert into position(department, positionName, salary)
values('security', 'clerk', 3900);
insert into position(department, positionName, salary)
values('service', 'clerk', 3100);
insert into position(department, positionName, salary)
values('office', 'secretary', 4700);

insert into items(itemName, itemPrice, itemQuan, repertory, itemType) 
values('apple', 5.5, 100, 100, 'fruit');
insert into items(itemName, itemPrice, itemQuan, repertory, itemType) 
values('banana', 4.5, 80, 80, 'fruit');
insert into items(itemName, itemPrice, itemQuan, repertory, itemType) 
values('orange', 5.0, 200, 100, 'fruit');
insert into items(itemName, itemPrice, itemQuan, repertory, itemType) 
values('cucumber', 3.0, 80, 90, 'vegetable');
insert into items(itemName, itemPrice, itemQuan, repertory, itemType) 
values('potato', 4.5, 120, 100, 'vegetable');
insert into items(itemName, itemPrice, itemQuan, repertory, itemType) 
values('tomato', 4.0, 50, 20, 'vegetable');