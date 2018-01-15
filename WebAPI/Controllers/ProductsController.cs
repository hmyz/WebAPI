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
            return Ok(result);
        }

        [Route("{id}")]
        public IHttpActionResult GetById(string Id)
        {
            var result = this.products.GetById(Id, CancellationToken.None);
            return Ok(result);
        }

        [Route("{id}")]
        public IHttpActionResult Delete(string Id)
        {
            return Ok(this.products.Delete(Id, CancellationToken.None));
        }

        [Route("")]
        public IHttpActionResult Post([FromBody] Product product)
        {
            return Ok(this.products.Post(product, CancellationToken.None));
        }
    }
}