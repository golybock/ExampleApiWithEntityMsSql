create table Role
(
    id int primary key identity,
    name varchar(150) not null
)

create table Worker
(
    id int primary key identity,
    name varchar(150) not null,
    role_id int foreign key references Role(id)
)