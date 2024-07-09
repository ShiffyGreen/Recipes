create or alter function dbo.CaloriesPerMeal(@MealId int)
returns varchar(50)
as
begin 
	declare @value varchar(50)

	select @value = sum(r.CalorieCount)
	from Meal m 
	join MealCourse mc 
	on mc.mealid = m.MealId
	join mealcourserecipe mcr
	on mcr.MealCourseId = mc.MealCourseId
	join Recipe r 
	on mcr.RecipeId = r.RecipeId
	where m.MealId = @MealId
	group by m.MealName

	return @value
end
go 

select CaloriesPerMeal = dbo.CaloriesPerMeal(m.MealId)
from meal m


