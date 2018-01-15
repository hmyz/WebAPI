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
            return Ok(result);
        }

        [Route("{id}")]
        public IHttpActionResult GetById(string Id)
        {
            var result = this.users.GetById(Id, CancellationToken.None);
            return Ok(result);
        }

        [Route("{id}")]
        public IHttpActionResult Delete(string Id)
        {
            return Ok(this.users.Delete(Id, CancellationToken.None));
        }

        [Route("")]
        public IHttpActionResult Post([FromBody] User user)
        {
            return Ok(this.users.Post(user, CancellationToken.None));
        }
    }
}