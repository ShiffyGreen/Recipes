create or alter proc dbo.CuisineUpdate(
	@CuisineId int = 0,
	@All bit = 0,
	@CuisineType varchar(50) = '',
	@Message varchar(500) = ''  output
)
as 
begin 
	declare @return int = 0
	select @cuisineId = isnull(@cuisineId,0)

	if @CuisineId = 0 
	begin 
		insert Cuisine(CuisineType)
		values (@CuisineType)
	end

	else
	begin
		update Cuisine
		set CuisineType = @CuisineType
		where CuisineId = @CuisineId
	end
	return @return
end