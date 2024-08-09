create or alter procedure dbo.CourseDelete(
	@CourseId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @CourseId = isnull(@CourseId,0)

	delete mealcourse where courseid = @courseId
	delete course where courseid = @courseid

	return @return
end
go

select * from course