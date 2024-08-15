create or alter proc dbo.MealListGet(
	@Message varchar(500) = '' output
)
as 
begin 

	select m.MealName, UserName = concat(u.firstname,' ',u.lastname), NumCalories = sum (r.CalorieCount), NumCourses = count (distinct mc.CourseId), NumRecipes = count (distinct r.RecipeId)
	from meal m
	join users u
	on m.UsersId = u.UsersId
	join MealCourse mc
	on m.MealId = mc.MealId
	join MealCourseRecipe mcr
	on mcr.MealCourseId = mc.MealCourseId
	join recipe r
	on mcr.RecipeId = r.RecipeId
	group by m.MealName,u.firstname,u.lastname
	order by m.MealName

	
end

go 
exec MealListGet 