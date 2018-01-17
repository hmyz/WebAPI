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
            if (result != null)
                return Ok(result);
            else
                return Ok("There are 0 rentals in database.");
        }

        [Route("{id}")]
        public IHttpActionResult GetById(string Id)
        {
            var result = this.rentals.GetById(Id, CancellationToken.None);
            if (result != null)
                return Ok(result);
            else
                return Ok("Rental with id \"" + Id + "\" was not found.");
        }

        [Route("{id}")]
        public IHttpActionResult Delete(string Id)
        {
            var result = this.rentals.Delete(Id, CancellationToken.None);
            if (result != null)
                return Ok(result);
            else
                return Ok("Rental with id \"" + Id + "\" was not found.");
        }

        [Route("")]
        public IHttpActionResult Post([FromBody] Rental rental)
        {
            var result = this.rentals.Post(rental, CancellationToken.None);
            if (result != null)
                return Ok(result);
            else
                return Ok("Rental could not be posted.");
        }
    }


}
