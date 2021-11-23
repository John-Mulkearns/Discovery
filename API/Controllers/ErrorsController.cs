using System;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

//#region What is this?  

// This controller generates multiple different error types depening upon what requests are made,
// there are a few starting points in Postman Collection.
//the two Find(-1) will clearly fail generating errors as ni user has an id if -1.
// There are multiple message formats that could be returned, the body is different e.g. depending upon the
// validation constraints
// e.g. adding string length min/max on password in RegisterDto
// so this is just a basic start to produce a generic error handler

//#endregion



namespace API.Controllers
{
    public class ErrorsController : BaseApiController
    {
        private readonly DataContext _context;
        public ErrorsController(DataContext context)
        {
            _context = context;
        }
        

        [Authorize]
        [HttpGet("auth")]
        public ActionResult<string> GetSecret()
        {
            return "secret text";
        }

        [HttpGet("not-found")]
        public ActionResult<AppUser> GetNotFound()
        {
            var thing = _context.Users.Find(-1);

            if (thing == null) return NotFound();

            return Ok(thing);
        }

        [HttpGet("server-error")]
        public ActionResult<string> GetServerError()
        {
            var thing = _context.Users.Find(-1);

            var thingToReturn = thing.ToString();

            return thingToReturn;
        }

        [HttpGet("bad-request")]
        public ActionResult<string> GetBadRequest()
        {
            return BadRequest();
        }
    }
}