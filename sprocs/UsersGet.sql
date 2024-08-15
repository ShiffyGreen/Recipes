create or alter procedure dbo.UsersGet(
	@UsersId int = 0, 
	@LastName varchar(50) = '', 
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = ''  output
)
as 
begin
	declare @return int = 0
	select @LastName = nullif(@LastName,'')

	select u.UsersId,u.FirstName,u.LastName,u.UserName,FullName = concat(u.FirstName,' ',u.LastName)
	from Users u
	where u.UsersId = @UsersId
	or @All = 1
	or u.LastName like '%' + @LastName + '%'
	union select 0,'','','',''
	where @IncludeBlank = 1
	order by u.LastName, u.FirstName

	return @return
end
go
/*
exec UsersGet

exec UsersGet @All = 1

exec UsersGet @All = 1, @includeblank = 1

exec UsersGet @LastName = ''

exec UsersGet @LastName = 'a'

declare @UsersId int
select top 1 @UsersId = u.UsersId from Users u
exec UsersGet @UsersId = @UsersId
*/