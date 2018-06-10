-- =========================================
-- Create table template Windows Azure SQL Database 
-- =========================================

use RestaurantDB;
go
--Создаем таблицу Продуктов
CREATE TABLE tbProducts
(
	Id int identity primary key,
	Name nvarchar(32) NOT NULL,
	Unit nvarchar(10) not null
)

--Создаем таблицу Рецептов
CREATE TABLE tbRecipes
(
	Id int identity primary key,
	NameDishes nvarchar(32) NOT NULL,
	Recipe nvarchar(1000) not null
)

--Создаем таблицу Блюд
CREATE TABLE tbDishes
(
	Id int identity primary key,
	Name nvarchar(32) NOT NULL,
	RecipeId int not null,
	PortionSize int not null,
	Unit nvarchar(10),
	Price float not null
)
alter table tbDishes add foreign key(RecipeId) references tbRecipes(Id)

--Создаем таблицу Раскладки
CREATE TABLE tbLayout
(
	Id int identity primary key,
	IdDish int not null,
	IdProduct int NOT NULL,
	Quantity float not null,
)
alter table tbLayout add foreign key(IdDish) references tbDishes(Id)
alter table tbLayout add foreign key(IdProduct) references tbProducts(Id)

--Создаем таблицу Заказов
create table tbPurchases
(
	Id int  identity primary key,
	IdProduct int  not null,
	Quantity float not null,
	Price float not null,
	Unit nvarchar(10),
	TotalAmount float not null
)
alter table tbPurchases add foreign key(IdProduct) references tbProducts(Id)

--Создаем таблицу Продаж
create table tbSales
(
	Id int identity primary key,
	IdDish int not null,
	NumOfSales int not null,
	TotalAmount float not null
)
alter table tbSales add foreign key(IdDish) references tbDishes(Id)
GO