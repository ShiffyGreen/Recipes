create or alter proc dbo.UsersUpdate(
	@UsersId int = 0,
	@FirstName varchar(25) = '',
	@LastName varchar(25) = '',
	@UserName varchar(25) = '',
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0
	select @UsersId = isnull(@UsersId,0)

	if @UsersId = 0
	begin
		insert Users(FirstName,LastName,UserName)
		values(@FirstName,@LastName,@UserName)

		select @UsersId = SCOPE_IDENTITY()
	end

	else
	begin
		update Users
		set FirstName = @FirstName,
			LastName = @LastName,
			UserName = @UserName
		where UsersId = @UsersId 
	end
	return @return 
end

select * from users