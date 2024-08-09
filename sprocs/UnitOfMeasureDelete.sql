create or alter procedure dbo.UnitOfMeasureDelete(
	@UnitOfMeasureId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @UnitOfMeasureId = isnull(@UnitOfMeasureId,0)

	delete RecipeIngredient where UnitOfMeasureId = @UnitOfMeasureId
	delete UnitOfMeasure where UnitOfMeasureId = @UnitOfMeasureId

	return @return
end
go


