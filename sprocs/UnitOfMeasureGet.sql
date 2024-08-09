create or alter procedure dbo.UnitOfMeasureGet(
	@UnitOfMeasureId int = 0, 
	@MeasureName varchar(50) = '', 
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = ''  output
)
as 
begin
	declare @return int = 0
	select @MeasureName = isnull(@MeasureName,'')

	select u.UnitOfMeasureId,u.MeasureName
	from UnitOfMeasure u 
	where u.UnitOfMeasureId = @UnitOfMeasureId
	or @All = 1
	or u.MeasureName like '%' + @MeasureName + '%'
	union select 0,''
	where @IncludeBlank = 1
	order by u.MeasureName

	return @return
end
go

exec UnitOfMeasureGet @all = 1, @includeblank = 1