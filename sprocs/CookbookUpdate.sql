create or alter proc dbo.CookbookUpdate(
	@CookbookId int = 0,
	@UsersId int = 0,
	@CookbookName varchar(50) = '',
	@Price decimal(5,2) = 0,
	@ActiveorNot bit = 0,
	@DateCreated date = getdate

)
as
begin 
	select @CookbookId = ISNULL(@CookbookId,0)

	if @CookbookId = 0
	begin
		insert Cookbook(UsersId,CookbookName,Price,ActiveOrNot,DateCreated)
		values(@UsersId,@CookbookName,@Price,@ActiveorNot,@DateCreated)

		select @CookbookId = SCOPE_IDENTITY()
	end

	else
	begin
		update Cookbook
		set UsersId = @UsersId,
			CookbookName = @CookbookName,
			Price = @Price,
			ActiveOrNot = @ActiveorNot,
			DateCreated = @DateCreated
		where CookbookId = @CookbookId
	end
end 
go

exec dbo.cookbookupdate @cookbookid = 0, @UsersId = 127, @cookbookname = 'abc', @price = 12.32, @activeornot = 1, @datecreated = '1-1-24'

select * from cookbook order by cookbookid desc 
