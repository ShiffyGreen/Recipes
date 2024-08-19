create or alter proc dbo.ChangeStatus(
	@RecipeId int, 
	@NewStatus varchar(50),
	@Message varchar(500) = '' output
)
as 
begin 
	declare @CurrentDate date = cast(getdate() as date)
	declare @CurrentStatus varchar(50)
	
	if not exists (select 1 from Recipe where RecipeId = @RecipeId)
	begin
		select @Message = 'Recipe not found'
		return
	end

	select @CurrentStatus = case when DateArchived is not null then 'archived'
								 when DatePublished is not null then 'published'
								 when DateDrafted is not null then 'drafted'
								 end
	from Recipe
	where recipeid = @RecipeId

	if @NewStatus = 'drafted'
	begin
		if @CurrentStatus = 'published' or @CurrentStatus = 'archived'
		begin 
			update Recipe 
			set DateDrafted = @CurrentDate,
				DatePublished = null,
				DateArchived = null
			where RecipeId = @RecipeId
			set @Message = 'Recipe status was changed to drafted'
		end
		else
        begin
            set @Message = 'Cannot change to Drafted from the current status.'
            return
        end
	end
	else if @NewStatus = 'published'
	begin
		if @CurrentStatus = 'drafted' or @CurrentStatus = 'archived'
		begin 
			update Recipe 
			set DateDrafted = DateDrafted,
				DatePublished = @CurrentDate,
				DateArchived = null
			where RecipeId = @RecipeId
			set @Message = 'Recipe status was changed to published'
		end
		else
        begin
            set @Message = 'Cannot change to Published from the current status.'
            return
        end
	end
	else if @NewStatus = 'archived'
	begin
		if @CurrentStatus <> 'archived'
		begin 
			update Recipe 
			set DateDrafted = DateDrafted,
				DatePublished = DatePublished,
				DateArchived = @CurrentDate
			where RecipeId = @RecipeId
			set @Message = 'Recipe status was changed to published'
		end
		else
        begin
            set @Message = 'Recipe is already Archived.'
            return
        end
	end
end 