using Microsoft.AspNetCore.Mvc;
using RecipeSystem;

namespace RecipeAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class CookbookRecipeController
    {
        [HttpGet]
        public List<bizCookbookRecipe> Get()
        {
            return new bizCookbookRecipe().GetList();
        }
        [HttpGet("byId/{cookbookId:int:min(0)}")]
        public List<bizCookbookRecipe> GetByCookbookId(int cookbookId)
        {
            return new bizCookbookRecipe().GetListByCookbookId(cookbookId);
        }
        [HttpGet("Byname/{cookbookName:int:min(0)}")]
        public List<bizCookbookRecipe> GetByCookbookName(string cookbookname)
        {
            return new bizCookbookRecipe().GetListByCookbookName(cookbookname);
        }
    }
}
