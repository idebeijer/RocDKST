using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RocDKST.Api.Models.Requests;

namespace RocDKST.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public BranchController(DatabaseContext context)
        {
            _context = context;
        }
        
        [HttpPost("GetMemberAccessStatus")]
        public async Task<IActionResult> GetMemberAccessStatus(AccessBranchRequest request)
        {
            var user = await _context.Users.FindAsync(request.UserId);
            if (user == null)
            {
                return NotFound();
            }

            if (user.Subscription == null)
            {
                return Unauthorized("User is not subscribed");
            }

            return Ok("User is subscribed");
        }
    }
}
