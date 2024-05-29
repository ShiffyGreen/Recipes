create or alter procedure dbo.UsersGet(@UsersId int = 0, @LastName varchar(50) = '', @All bit = 0)
as 
begin
	
	select @LastName = nullif(@LastName,'')

	select u.UsersId,u.FirstName,u.LastName,u.UserName
	from Users u
	where u.UsersId = @UsersId
	or @All = 1
	or u.LastName like '%' + @LastName + '%'
	order by u.LastName, u.FirstName
end
go

exec UsersGet

exec UsersGet @All = 1

exec UsersGet @LastName = ''

exec UsersGet @LastName = 'a'

declare @UsersId int
select top 1 @UsersId = u.UsersId from Users u
exec UsersGet @UsersId = @UsersId