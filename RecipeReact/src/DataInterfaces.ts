export interface IRecipe {
    recipeId: number;
    cuisineId: number;
    usersId: number;
    recipeName: string;
    calorieCount: number;
    dateDrafted: string;
    datePublished: string;
    dateArchived: string;
    vegan: number;
}

export interface ICookbook {
    cookbookId: number;
    cookbookName: string;
    userName: string;
    numofRecipes: number;
    skillDesc: string;
}

export interface IMeal {
    userName: string;
    mealName: string;
    numCalories: number;
    numCourses: number;
    numRecipes: number;
    description: string;
}

export interface ICuisine {
    cuisineId: number;
    cuisineType: string;
}