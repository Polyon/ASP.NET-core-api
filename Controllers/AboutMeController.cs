using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MineApi.Data;
using MineApi.Models;

namespace MineApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutMeController : ControllerBase
    {
        private readonly AboutMeContext _context;

        public AboutMeController(AboutMeContext context)
        {
            _context = context;
        }

        // GET: api/AboutMe/1
        [HttpGet("{userId}")]
        public async Task<ActionResult<IEnumerable<AboutMe>>> GetAbouts(int userId)
        {
            var abouts= _context.Abouts.Where(uid => uid.UserId == userId);
            return await abouts.ToListAsync();
        }

        // GET: api/AboutMe/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AboutMe>> GetAboutMe(int id)
        {
            var aboutMe = await _context.Abouts.FindAsync(id);

            if (aboutMe == null)
            {
                return NotFound();
            }

            return aboutMe;
        }

        // PUT: api/AboutMe/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAboutMe(int id, AboutMe aboutMe)
        {
            if (id != aboutMe.ID)
            {
                return BadRequest();
            }

            _context.Entry(aboutMe).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AboutMeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/AboutMe
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AboutMe>> PostAboutMe(AboutMe aboutMe)
        {
            _context.Abouts.Add(aboutMe);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAboutMe", new { id = aboutMe.ID }, aboutMe);
        }

        // DELETE: api/AboutMe/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAboutMe(int id)
        {
            var aboutMe = await _context.Abouts.FindAsync(id);
            if (aboutMe == null)
            {
                return NotFound();
            }

            _context.Abouts.Remove(aboutMe);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AboutMeExists(int id)
        {
            return _context.Abouts.Any(e => e.ID == id);
        }
    }
}