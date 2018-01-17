using System.Threading;
using System.Web.Http;
using WebAPI.Models;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [RoutePrefix("api/users")]
    public class UsersController : ApiController
    {
        IUserService users;

        public UsersController(IUserService userService)
        {
            this.users = userService;
        }

        [Route("")]
        public IHttpActionResult GetAll()
        {
            var result = this.users.GetAll(CancellationToken.None);
            if (result != null)
                return Ok(result);
            else
                return Ok("There are 0 users in database.");
        }

        [Route("{id}")]
        public IHttpActionResult GetById(string Id)
        {
            var result = this.users.GetById(Id, CancellationToken.None);
            if (result != null)
                return Ok(result);
            else
                return Ok("User with id \"" + Id + "\" was not found.");
        }

        [Route("{id}")]
        public IHttpActionResult Delete(string Id)
        {
            var result = this.users.Delete(Id, CancellationToken.None);
            if (result != null)
                return Ok(result);
            else
                return Ok("User with id \"" + Id + "\" was not found.");
        }

        [Route("")]
        public IHttpActionResult Post([FromBody] User user)
        {
            return Ok(this.users.Post(user, CancellationToken.None));
        }
    }
}