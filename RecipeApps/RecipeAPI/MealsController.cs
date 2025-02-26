using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeSystem;

namespace RecipeAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealsController : ControllerBase
    {
        [HttpGet]
        public List<bizMealList> Get()
        {
            return new bizMealList().GetList();
        }
    }
}
