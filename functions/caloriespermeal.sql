create or alter function dbo.CaloriesPerMeal(@MealId int)
returns int
as
begin 
	declare @value int

	select @value = sum(r.CalorieCount)
	from MealCourse mc 
	join mealcourserecipe mcr
	on mcr.MealCourseId = mc.MealCourseId
	join Recipe r 
	on mcr.RecipeId = r.RecipeId
	where mc.MealId = @MealId

	return @value
end
go 

select CaloriesPerMeal = dbo.CaloriesPerMeal(m.MealId)
from meal m


