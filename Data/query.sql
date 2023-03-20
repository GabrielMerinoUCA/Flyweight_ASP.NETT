use Flyweight

create table BookType(
	id int not null unique identity(1,1),
	bookType nvarchar(45),
	author nvarchar(45),
	other nvarchar(45),
	Primary Key (id)
)

create table Book(
	id int not null unique identity(1,1),
	title nvarchar(45),
	price float,
	bookType int,
	Primary Key (id),
	Foreign key (bookType) References BookType(id)
)