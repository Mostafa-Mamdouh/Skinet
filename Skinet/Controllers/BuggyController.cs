using Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Skinet.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Skinet.Controllers
{
  
    public class BuggyController : BaseController
    {
        private readonly StoreContext _context;

        public BuggyController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet("notfount")]
        public ActionResult GetNoFoundRequest() 
        {
            var thing = _context.Products.Find(42);
            if (thing==null)
            {
                return NotFound(new ApiResponse(404));
            }
            return Ok(thing);
        }
        [HttpGet("servererror")]
        public ActionResult GetFoundRequest()
        {
            var thing = _context.Products.Find(42);
            var thingToReturn = thing.ToString();
            return Ok();
        }
        [HttpGet("badrequest")]
        public ActionResult GetBadRequest()
        {
            return BadRequest(new ApiResponse(400));
        }
        [HttpGet("badrequest/{id}")]
        public ActionResult GetNoFoundRequest(int id)
        {
            return Ok();
        }
    }
}
