use marketdb;
drop table dbo.itemsList;
drop table dbo.bills;

create table bills
(
	billID int identity(1,1) not null,
	sumPrice float not null,
	time date default getdate(), /*更改date变量为数据库自动插入*/
	primary key(billID)
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
insert into dbo.cards (password, amount)values('333333', 50);
insert into dbo.cards (password, amount)values('123456', 500);
insert into dbo.cards (password, amount)values('abcdef', 1000);
