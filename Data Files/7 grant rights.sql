use HeartyHearthDB
go 
--select concat('grant execute on ', r.ROUTINE_NAME,' to reciperole')
--from INFORMATION_SCHEMA.ROUTINES r 

grant execute on CuisineGet to reciperole
grant execute on RecipeDelete to reciperole
grant execute on RecipeUpdate to reciperole
grant execute on RecipeDesc to reciperole
grant execute on CaloriesPerMeal to reciperole
grant execute on UsersGet to reciperole
grant execute on RecipeGet to reciperole
grant execute on RecipeIngredientGet to reciperole
grant execute on IngredientGet to reciperole
grant execute on UnitOfMeasureGet to reciperole
grant execute on DirectionsGet to reciperole
grant execute on RecipeListGet to reciperole
grant execute on CloneRecipe to reciperole
grant execute on CoursesGet to reciperole
grant execute on CoursesUpdate to reciperole
grant execute on CuisineUpdate to reciperole
grant execute on DirectionsUpdate to reciperole
grant execute on IngredientUpdate to reciperole
grant execute on unitOfMeasureUpdate to reciperole
grant execute on UsersUpdate to reciperole
grant execute on CoursesDelete to reciperole
grant execute on CourseGet to reciperole
grant execute on CourseDelete to reciperole
grant execute on CuisineDelete to reciperole
grant execute on DirectionsDelete to reciperole
grant execute on IngredientDelete to reciperole
grant execute on UnitOfMeasureDelete to reciperole
grant execute on UsersDelete to reciperole
grant execute on MealListGet to reciperole
grant execute on CookbookListGet to reciperole
grant execute on CookbookGet to reciperole
grant execute on CookbookUpdate to reciperole
grant execute on CookbookDelete to reciperole
grant execute on RecipeIngredientUpdate to reciperole
grant execute on AutoCreateCookbook to reciperole
grant execute on Dashboard to reciperole
grant execute on DashboardGet to reciperole
grant execute on RecipeIngredientDelete to reciperole
grant execute on CookbookRecipeGet to reciperole
grant execute on CookbookRecipeUpdate to reciperole
grant execute on CookbookRecipeDelete to reciperole
grant execute on CourseUpdate to reciperole
grant execute on ChangeStatus to reciperole