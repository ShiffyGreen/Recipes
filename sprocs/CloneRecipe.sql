create or alter proc dbo.CloneRecipe(
	@RecipeId int = 0,
	@NewRecipeId int = 0 output,
	@Message varchar(500) = '' output
)
as
begin

	declare @CuisineId INT,
            @UsersId INT,
            @RecipeName VARCHAR(100),
            @CalorieCount INT,
            @DateDrafted DATETIME2,
            @DatePublished DATETIME2,
            @DateArchived DATETIME2;

	SELECT @CuisineId = CuisineId,
           @UsersId = UsersId,
           @RecipeName = RecipeName,
           @Caloriecount = caloriecount,
           @DateDrafted = DateDrafted,
           @DatePublished = DatePublished,
           @DateArchived = DateArchived
    FROM Recipe
    WHERE RecipeId = @RecipeId

	IF @RecipeName IS NULL
	BEGIN
        SET @Message = 'Recipe not found';
        RETURN;
    END

    SET @RecipeName = @RecipeName + ' - clone';
    
	INSERT INTO Recipe (CuisineId, UsersId, RecipeName, CalorieCount, DateDrafted, DatePublished, DateArchived)
    VALUES (@CuisineId, @UsersId, @RecipeName, @CalorieCount, @DateDrafted, @DatePublished, @DateArchived);
    
	SET @NewRecipeId = SCOPE_IDENTITY();
    
	INSERT INTO RecipeIngredient (RecipeId, IngredientId, UnitOfMeasureId, Amount, IngredientSequence)
    SELECT @NewRecipeId, IngredientId, UnitOfMeasureId,	Amount, IngredientSequence
    FROM RecipeIngredient
    WHERE RecipeId = @RecipeId;
    
	INSERT INTO Directions(RecipeId, Instructions, DirectionsSequence)
    SELECT @NewRecipeId, Instructions, DirectionsSequence
    FROM Directions
    WHERE RecipeId = @RecipeId;
    
	SET @Message = 'Recipe cloned successfully';
    RETURN;
END;
GO


--exec clonerecipe @recipeid = 336

--select * from recipe r
--left join directions d 
--on r.recipeid = d.recipeid