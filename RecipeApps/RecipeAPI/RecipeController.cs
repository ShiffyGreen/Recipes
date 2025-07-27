using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeSystem;

namespace RecipeAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        [HttpGet]
        public List<bizRecipe> Get()
        {
            return new bizRecipe().GetList();
        }
        [HttpGet("{id:int:min(0)}")]
        public bizRecipe Get(int id)
        {
            bizRecipe r = new bizRecipe();
            r.Load(id);
            return r;
        }

        [HttpGet("cuisine/{cuisineid:int:min(0)}")]
        public List<bizRecipe> GetbyCuisineId(int cuisineid)
        {
            return new bizRecipe().CuisId(cuisineid);
        }

        [HttpPost]
        public IActionResult Post([FromForm]bizRecipe recipe)
        {
            try
            {
                recipe.Save();
                return Ok(new { message = "recipe saved", recipeid = recipe.RecipeId });
            }
            catch(Exception ex)
            {
                return BadRequest(new { ex.Message });
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                bizRecipe r = new();
                r.Delete(id);
                return Ok(new { message = "party deleted" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { ex.Message });
            }
        }

    }
}
