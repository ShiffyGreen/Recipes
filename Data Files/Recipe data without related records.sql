use heartyhearthdb
go

insert Recipe(CalorieCount,CuisineId,UsersId,RecipeName,DateArchived,DateDrafted,DatePublished)
select 473,'102',1040,'Chocolate Cake',null,'3-2-23','5-15-23'
union select 275, 1030,1039,'Potato Kugel',null,'5-1-24',null
