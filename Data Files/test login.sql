--IMPORTANT CREATE LOGIN IN MASTER 
--USE master
create login test with PASSWORD = 'Hello123!'
--important switch ro RecordKeeperDb
create user test_user from login test

use HeartyHearthDB
go 
drop role if exists recipetest
go 
create role recipetest
go 
alter role recipetest add member test_user

--select concat('grant execute on ', r.ROUTINE_NAME,' to recipetest')
--from INFORMATION_SCHEMA.ROUTINES r 

grant execute on unitOfMeasureUpdate to recipetest
grant execute on UnitOfMeasureGet to recipetest
grant execute on UnitOfMeasureDelete to recipetest
grant execute on RecipeListGet to recipetest
grant execute on RecipeIngredientUpdate to recipetest
grant execute on RecipeIngredientGet to recipetest
grant execute on RecipeIngredientDelete to recipetest
grant execute on MealListGet to recipetest
grant execute on IngredientUpdate to recipetest
grant execute on IngredientGet to recipetest
grant execute on IngredientDelete to recipetest
grant execute on DirectionsUpdate to recipetest
grant execute on DirectionsGet to recipetest
grant execute on DirectionsDelete to recipetest
grant execute on DashboardGet to recipetest
grant execute on RecipeGet to recipetest
grant execute on CuisineGet to recipetest
grant execute on UsersGet to recipetest
grant execute on RecipeDelete to recipetest
grant execute on CaloriesPerMeal to recipetest
grant execute on RecipeUpdate to recipetest
grant execute on CuisineUpdate to recipetest
grant execute on CuisineDelete to recipetest
grant execute on CourseUpdate to recipetest
grant execute on CourseGet to recipetest
grant execute on CourseDelete to recipetest
grant execute on CookbookUpdate to recipetest
grant execute on CookbookRecipeUpdate to recipetest
grant execute on CookbookRecipeGet to recipetest
grant execute on CookbookRecipeDelete to recipetest
grant execute on CookbookListGet to recipetest
grant execute on CookbookGet to recipetest
grant execute on CookbookDelete to recipetest
grant execute on CloneRecipe to recipetest
grant execute on ChangeStatus to recipetest
grant execute on AutoCreateCookbook to recipetest
grant execute on UsersUpdate to recipetest
grant execute on UsersDelete to recipetest