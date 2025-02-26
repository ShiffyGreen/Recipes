using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeSystem;

namespace RecipeAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class CookbookController : ControllerBase
    {
        [HttpGet]
        public List<bizCookbookList> Get()
        {
            return new bizCookbookList().GetList();
        }
        [HttpGet("{id:int:min(0)}")]
        public bizCookbookList Get(int id)
        {
            bizCookbookList c = new bizCookbookList();
            c.Load(id);
            return c;
        }
    }
}
