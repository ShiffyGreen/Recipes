create or alter proc CookbookGet(
	@CookbookId int = 0,
	@CookbookName varchar(50) = '',
	@All bit = 0
)
as
begin
	select c.CookbookId,c.UsersId,c.CookbookName,c.Price,c.ActiveOrNot,c.DateCreated 
	from Cookbook c 
	where c.CookbookId = @CookbookId
    or @all = 1
    order by c.CookbookName
end
go 
exec CookbookGet @All = 1

select * from Cookbook