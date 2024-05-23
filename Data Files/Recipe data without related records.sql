use heartyhearthdb
go

insert Recipe(CalorieCount,CuisineId,UsersId,RecipeName,DateArchived,DateDrafted,DatePublished)
select 473,(select CuisineId from cuisine where CuisineType = 'American'),(select UsersId from Users where LastName = 'Segal'),'Chocolate Cakes',null,'3-2-23','5-15-23'
union select 275, (select CuisineId from cuisine where CuisineType = 'French'),(select UsersId from Users where LastName = 'Kaufman'),'Potato Kugel',null,'5-1-24',null


