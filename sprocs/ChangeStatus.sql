create or alter proc dbo.ChangeStatus(
	@RecipeId int, 
	@DateDrafted datetime output,
	@DatePublished datetime output,
	@DateArchived datetime output
)
as 
begin 
	if @DateArchived is null and @DatePublished is null 
	begin 
		update Recipe 
		set DateDrafted = @DateDrafted
		where RecipeId = @RecipeId
	end
end 