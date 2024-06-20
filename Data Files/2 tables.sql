-- SM Excellent! 100%
use HeartyHearthDB
go
drop table if exists CookbookRecipe
drop table if exists Cookbook
drop table if exists MealCourseRecipe
drop table if exists MealCourse
drop table if exists Meal
drop table if exists Course
drop table if exists Directions
drop table if exists RecipeIngredient
drop table if exists UnitOfMeasure
drop table if exists Recipe
drop table if exists Users
drop table if exists Ingredient
drop table if exists Cuisine
go
create table dbo.Cuisine(
    CuisineId int not null identity primary key,
    CuisineType varchar(50) not null
        constraint u_CuisineType unique
        constraint c_Cuisine_CuisineType_cannot_be_blank check(CuisineType <> '')
)
create table dbo.Ingredient(
    IngredientId int not null identity primary key,
    IngredientName varchar(40) not null
        constraint u_IngredientName unique
        constraint c_Ingredient_IngredientName_cannot_be_blank check(IngredientName <> ''),
    PictureName as concat('Ingredient_',replace(IngredientName,' ','_'),'.jpg') persisted
)
create table dbo.Users(
    UsersId int not null identity primary key,
    FirstName varchar(25) not null
        constraint c_Users_FirstName_cannot_be_blank check(FirstName <> ''),
    LastName varchar(25) not null
        constraint c_Users_LastName_cannot_be_blank check(lastname <> ''),
    UserName varchar(25) not null
        constraint u_UserName unique
        constraint c_Users_UserName_cannot_be_blank check(username <> '')
)
create table dbo.Recipe(
    RecipeId int not null identity primary key,
    CuisineId int not null
        constraint f_Recipe_Cuisine foreign key references cuisine(cuisineid),
    UsersId int not null
        constraint f_recipe_Users foreign key references users(usersid),
    RecipeName varchar (50) not null
        constraint u_recipeName unique
        constraint c_Recipe_RecipeName_cannot_be_blank check(recipename <> ''),
    CalorieCount int not null
        constraint ck_Recipe_CalorieCount_positive check (CalorieCount >= 0),
    DateDrafted datetime not null
       constraint ck_datedrafted_cannot_be_future check (DateDrafted <= getdate ()),
    DatePublished datetime
        constraint ck_datePublished_cannot_be_future check (DatePublished <= getdate ()),
    DateArchived datetime
        constraint ck_datearchived_cannot_be_future check (DateArchived <= getdate ()),
    CurrentStatus as case
        when DatePublished is null and DateArchived is null then 'draft'
        when DatePublished is not null and DateArchived is null then 'published'
        else 'archived'
        end,
    PictureName as concat('Recipe_',replace(recipename,' ','_'),'.jpg') persisted,
    constraint ck_DateCreated_before_DatePublished_and_Archived_and_datepublished_before_archived check (DateDrafted <= DatePublished and isnull (DatePublished, DateDrafted) <= DateArchived )
)
create table dbo. UnitOfMeasure(
    UnitOfMeasureId int not null identity primary key,
    MeasureName varchar (30)
        constraint u_UnitOfMeasure_Name unique
        constraint c_UnitofMeasure_MeasureName_cant_be_blank check(measurename <> '')
)
create table dbo.RecipeIngredient(
    RecipeIngredientId int not null identity primary key,
    RecipeId int not null
        constraint f_RecipeIngredient_Recipe foreign key references recipe(recipeid),
    IngredientId int not null
        constraint f_RecipeIngredient_Ingredient foreign key references Ingredient(IngredientId),
    UnitOfMeasureId int null
        constraint f_RecipeIngredient_UnitOfMeasure foreign key references UnitOfMeasure(UnitOfMeasureId),
    IngredientSequence int not null
        constraint  ck_RecipeIngredients_Sequence_greater_than_0 check (IngredientSequence > 0),
    Amount decimal(4,2) not null
        constraint ck_recipeingredient_amount_greater_than_zero check (Amount > 0),
    constraint u_recipeid_ingredientid_unique unique(RecipeId,IngredientId),
    constraint u_recipeid_sequencenum_unique unique (RecipeId, IngredientSequence)
    )
create table dbo.Directions(
    DirectionsId int not null identity primary key,
     RecipeId int not null
        constraint f_RecipeDirections_Recipes foreign key references recipe(recipeid),
    Instructions varchar(100) not null
        constraint c_Instructions_Directions_cannot_be_blank check(Instructions <> ''),
    DirectionsSequence int not null
        constraint ck_recepiedirections_directionsequence_positive check (DirectionsSequence > 0),
    constraint u_directionsequence_recipeid unique (DirectionsSequence, RecipeId)
)

create table dbo.Course(
    CourseId int not null identity primary key,
    CourseName varchar(35) not null
        constraint u_Course_CourseName unique
        constraint ck_Course_CourseName_not_blank check (CourseName <> ''),
    CourseSequence int not null 
        constraint u_course_courseSequence unique
        constraint c_course_CourseSequence_must_be_greater_then_0 check(CourseSequence > 0), 
)
create table dbo.Meal(
    MealId int not null identity primary key,
    UsersId int not null
        constraint f_Meal__User_UserId foreign key references Users(UsersId),
    MealName varchar(20) not null
        constraint u_Meal_MealName unique
        constraint c_Meal_MealName_cannot_be_blank check(MealName <> ''),
    ActiveOrNot bit not null default 1,
    DateCreated date not null default getdate()
        constraint ck_Meal_DateCreated_not_future check (DateCreated <= getdate ())
)
create table dbo.MealCourse(
    MealCourseId int not null identity primary key,
    MealId int not null
        constraint f_MealCourse_Meal foreign key references Meal(MealId),
    CourseId int not null
        constraint f_MealCourse_Courses foreign key references course(courseid),
    constraint u_mealcourse_MealId_CourseId unique(MealId,CourseId)
)
create table dbo.MealCourseRecipe(
    MealCourseRecipeId int not null identity primary key,
    RecipeId int not null
        constraint f_MealCourseRecipe_Recipes foreign key references Recipe(RecipeId),
    MealCourseId int not null
        constraint f_MealCourseRecepie_MealCourse foreign key references MealCourse(MealCourseId),
    IsMainDish bit not null,
    constraint u_MealCourseRecipe_RecipeId_MealCourseId unique (RecipeId, MealCourseId)
)
create table dbo.Cookbook(
    CookbookId int not null identity primary key,
    UsersId int not null
        constraint f_Cookbook_User_UserId foreign key references Users(UsersId),
    CookbookName varchar(30) not null
        constraint u_Cookbook_CookbookName unique
        constraint  c_Cookbook_Name_cannot_be_blank check(CookbookName <> ''),
    Price decimal(5,2) not null
        constraint ck_Cookbook_Price_not_negative check (Price > 0),
    ActiveOrNot bit not null default 1,
    DateCreated date not null default getdate()
       constraint ck_Cookbook_DateCreated_not_future check (DateCreated <= getdate ())

)
create table dbo.CookbookRecipe(
    CookbookRecipeId int not null identity primary key,
    CookbookId int not null
        constraint f_CookbookRecipe_Cookbook foreign key references cookbook(CookbookId),
    RecipeId int not null
        constraint f_CookbookRecipe_Recipes foreign key references recipe(RecipeId),
    SequenceNumber int not null
        constraint ck_CookbookRecepie_sequencenumber_positive check (SequenceNumber > 0),
    constraint u_CookbookRecipe_CookbookId_RecipeId_unique unique (CookbookId, RecipeId),
    constraint u_CookbookRecipe_CookbookId_SequenceNumber_unique unique (cookbookid,SequenceNumber))

