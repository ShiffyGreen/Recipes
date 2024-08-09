create or alter proc dbo.CourseGet(
	@CourseId int = 0,
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = ''  output
)
as 
begin
	declare @return int = 0
	
	select CourseId, CourseName, CourseSequence 
	from Course c
	where c.CourseId = @CourseId
	or @All = 1
	union select 0,'',0
	where @IncludeBlank = 1
	order by c.coursename
	
	return @return 
end
go

exec CourseGet @All = 1, @includeblank = 1
