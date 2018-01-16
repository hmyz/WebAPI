using System.Threading;
using System.Web.Http;
using WebAPI.Models;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [RoutePrefix("api/rentals")]
    public class RentalsController : ApiController
    {
        IRentalService rentals;

        public RentalsController(IRentalService rentalService)
        {
            this.rentals = rentalService;
        }

        [Route("")]
        public IHttpActionResult GetAll()
        {
            var result = this.rentals.GetAll(CancellationToken.None);
            return Ok(result);
        }

        [Route("{id}")]
        public IHttpActionResult GetById(string Id)
        {
            var result = this.rentals.GetById(Id, CancellationToken.None);
            return Ok(result);
        }

        [Route("{id}")]
        public IHttpActionResult Delete(string Id)
        {
            return Ok(this.rentals.Delete(Id, CancellationToken.None));
        }

        [Route("")]
        public IHttpActionResult Post([FromBody] Rental rental)
        {
            return Ok(this.rentals.Post(rental, CancellationToken.None));
        }
    }


}
