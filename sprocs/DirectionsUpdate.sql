create or alter proc dbo.DirectionsUpdate(
	@DirectionsId int = 0,
	@RecipeId int = 0,
	@Instructions varchar(100) = '',
	@DirectionsSequence int = 0,
	@Message varchar(500) = ''  output
	
)
as 
begin
	declare @return int = 0
	select @DirectionsId = isnull(@DirectionsId,0)

	if @DirectionsId = 0
	begin
		insert Directions(RecipeId,Instructions,DirectionsSequence)
		values(@RecipeId,@Instructions,@DirectionsSequence)

		select @DirectionsId = SCOPE_IDENTITY()
	end

	else 
	begin
		update Directions 
		set RecipeId = @RecipeId,
			Instructions = @Instructions,
			DirectionsSequence = @DirectionsSequence
		where DirectionsId = @DirectionsId

	end
	return @return
end


