import type { ICookbook, IMeal, IRecipe, ICuisine } from "./DataInterfaces";

const baseUrl = 'https://heartyhearthapi.azurewebsites.net/api/';

async function fetchData<T>(url: string): Promise<T> {
    url = baseUrl + url;
    const r = await fetch(url);
    const data = await r.json();
    return data;

}

export async function fetchRecipes() {
    return await fetchData<IRecipe[]>('recipes');
}

export async function fetchRecipeById(recipeId: number) {
    return await fetchData<IRecipe[]>(`recipe/${recipeId}`);
}
export async function fetchCookbooks() {
    return await fetchData<ICookbook[]>('cookbook');
}

export async function fetchMeals() {
    return await fetchData<IMeal[]>('meals');
}
export async function fetchCuisine() {
    return await fetchData<ICuisine[]>('cuisine');
}

export async function fetchRecipeByCuisine(cuisineId: number) {
    return await fetchData<IRecipe[]>(`recipe/cuisine/${cuisineId}`);
}