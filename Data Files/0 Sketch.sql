-- SM Excellent sketch! See comments, fix and resubmit.

/*
HeartyHearth
Cuisine
CuisineId
CuisineType varchar(50) not null unique not blank

Ingredients
IngredientsId
IngredientName varchar(40) not null not blank unique

-- SM You can't use "user" as table name, it's a reserved word. Either use Users or Staff.
Users
UsersId
firstname varchar(25) not null not blank
lastname varchar(25) not null not blank
username varchar(25) not null unique not blank

Recipe
recipeid
cuisineid
userid
RecipeName varchar (50) not null unique not blank
CurrentStatus ? computed column case statement
DateDrafted datetime
DatePublished datetime
DateArchived datetime
CalorieCount int not null not negative
date created before date published or archived

-- SM Each ingredient in a recipe are in specific order.
recipeingridient
recipeingridientid
recipeid
ingridientid
sequencenumber int not null not negative
MeasurementTypeId (fk)
Measurement int not null not negative
constraint recipeid and ingredientid unique
sequenceid recipeid unique

-- SM You should have a dropdown of measurement types. Like that it wont lead to mistakes.
MeasurementType
MeasurementId
MeasurementTypeName varchar (35) not null not blank unique

Directions
DirectionId
Instructions varchar(100) not null not blank
recipeid
SequenceNumber int not null greater than zero

Courses
courseid
course name varchar(35) not null not blank unique
-- SM The recipes don't have courses and the courses don't have recipes. You have meals, and each meal has courses, each course in the meal has recipes.
-- A meal can only have once each course, a meals courser can only have once each recipe. 
-- You can have multiple times the same recipe in the same meal as long as they're in different courses.
-- You can have multiple times the same recipe in the same course as long as they are in different meals.

Meal
mealid
userid foreign key
mealname(20) not null unique
activeornot bit deafult true

mealcourse
mealcourseid
mealid
courseid
constraint mealid and courseid unique

mealcourserecipe
mealcourserecipeid
mealcourseid (fk)
recipeid (fk)
mealcourse id and recipeid unique

cookbook
cookbookid
userid
cookbookname varchar(15) not null unique not blank
price decimal(5,2) not null not negative

-- SM You can only have once each recipe in a cookbook. And the recipes are in a specific order in the books.
cookbookrecipe
cookbookrecipeid
cookbookid
recipeid
sequencenumber int not null not negative
cookbookid and recipeid unique
sequenceid and cookbookid unique
*/
