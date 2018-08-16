using Microsoft.AspNetCore.Mvc;
using WebApi.RavenDB.Database;

namespace WebApi.RavenDB.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {
            var productRepository = new ProductRepository();
            productRepository.SaveNewProduct();

            var result = productRepository.GetListOfNames();
            return Json(result);
        }
    }
}