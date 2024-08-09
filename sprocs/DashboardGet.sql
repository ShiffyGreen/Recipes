create or alter proc dbo.DashboardGet(
	@Message varchar(500) = ''
)
as 
begin
	select DashboardType = 'Recipes', Number = count(*) from recipe r 
	union select DashboardType = 'Meals', Number = count(*) from Meal m 
	union select DashboardType = 'Cookbooks', Number = count(*) from Cookbook c 
	order by DashboardType desc 
end

go 
exec DashboardGet


