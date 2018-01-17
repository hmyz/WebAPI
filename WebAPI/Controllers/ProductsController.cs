using System.Threading;
using System.Web.Http;
using WebAPI.Models;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [RoutePrefix("api/products")]
    public class ProductsController : ApiController
    {
        IProductService products;

        public ProductsController(IProductService userService)
        {
            this.products = userService;
        }

        [Route("")]
        public IHttpActionResult GetAll()
        {
            var result = this.products.GetAll(CancellationToken.None);
            if (result != null)
                return Ok(result);
            else
                return Ok("There are 0 products in database.");
        }

        [Route("{id}")]
        public IHttpActionResult GetById(string Id)
        {
            var result = this.products.GetById(Id, CancellationToken.None);
            if (result != null)
                return Ok(result);
            else
                return Ok("Product with id \"" + Id + "\" was not found.");
        }

        [Route("{id}")]
        public IHttpActionResult Delete(string Id)
        {
            var result = this.products.Delete(Id, CancellationToken.None);
            if (result != null)
                return Ok(result);
            else
                return Ok("Product with id \"" + Id + "\" was not found.");
        }

        [Route("")]
        public IHttpActionResult Post([FromBody] Product product)
        {
            return Ok(this.products.Post(product, CancellationToken.None));
        }
    }
}