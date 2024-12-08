using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniversityCourseSelection.Data;
using UniversityCourseSelection.Models;

namespace UniversityCourseSelection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvisorsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AdvisorsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Advisors>>> GetAdvisors()
        {
            return await _context.Advisors.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Advisors>> PostAdvisor(Advisors advisor)
        {
            _context.Advisors.Add(advisor);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetAdvisors", new { id = advisor.AdvisorsID }, advisor);
        }
    }

}
