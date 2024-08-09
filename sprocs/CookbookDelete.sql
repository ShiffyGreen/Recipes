create or alter proc dbo.CookbookDelete(
	@CookbookId int = 0,
	@Message varchar(500) = '' output
)
as 
begin
	declare @return int = 0

	begin try 
		begin tran
		delete cookbookrecipe where cookbookId = @cookbookId
		delete cookbook where cookbookId = @cookbookId
		commit
	end try
	begin catch
		rollback;
		throw
	end catch
	return @return
end
go

exec dbo.cookbookdelete @cookbookid = 93


select * from cookbook 

--delete cr 
--from cookbookrecipe cr
--join cookbook c 
--on c.cookbookId = cr.cookbookId 
--where c.cookbookname = 'Sweet Eats'
--delete cookbook where cookbookname = 'Sweet Eats'