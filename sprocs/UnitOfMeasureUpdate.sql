create or alter proc dbo.unitOfMeasureUpdate(
	@UnitOfMeasureId int = 0 output,
	@MeasureName varchar(50) = '',
	@Message varchar(500) = ''  output
)
as 
begin
	declare @return int = 0
	select @UnitOfMeasureId = ISNULL(@UnitOfMeasureId,0)

	if @UnitOfMeasureId = 0
	begin 
		insert UnitOfMeasure(MeasureName)
		values(@MeasureName)

		select @UnitOfMeasureId = SCOPE_IDENTITY()
	end

	else 
	begin
		update UnitOfMeasure
		set MeasureName = @MeasureName
		where UnitOfMeasureId = @UnitOfMeasureId
	end

	return @return 
end

select * from UnitOfMeasure