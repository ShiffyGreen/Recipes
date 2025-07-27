import { useEffect, useState } from "react";
import RecipeCard from "./RecipeCard";
import type { IRecipe } from "./DataInterfaces";
import { fetchRecipeByCuisine } from "./DataUtil";

interface Props {
    cuisineId: number;
}

export default function MainScreen({ cuisineId }: Props) {
    const [isLoading, setIsLoading] = useState(false);
    const [RecipeList, setRecipeList] = useState<IRecipe[]>([]);
    ``
    useEffect(() => {
        if (cuisineId > 0) {
            setIsLoading(true);
            setRecipeList([]);
            const fetchData = async () => {
                const data = await fetchRecipeByCuisine(cuisineId);
                setRecipeList(data);
                setIsLoading(false);
            }

            fetchData();
        }
    }, [cuisineId]);

    return (
        <>
            <div className="row">
                <div className={isLoading ? "placeholder-glow" : ""}>
                    <h2 className="mt-2 bg-light ">
                        <span className={isLoading ? "placeholder" : ""}>{RecipeList.length} Recipes</span>
                    </h2>

                </div>
            </div>
            <div className="row">
                {RecipeList.map(r =>
                    <div key={r.recipeId} className="col-md-6 col-lg-3 mb-2">
                        <RecipeCard recipe={r} />
                    </div>)}
            </div>
        </>
    )
}   