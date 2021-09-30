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
    [ApiController]
    [Route("api/[controller]")]
    public class SkillDataController : ControllerBase
    {
        private readonly SkillDataContext _context;

        public SkillDataController(SkillDataContext context)
        {
            _context = context;
        }

        // GET: api/SkillData/1
        [HttpGet("{userId}")]
        public async Task<ActionResult<IEnumerable<SkillsData>>> GetSkills(int userId)
        {
            var skills = _context.Skills.Where(uid => uid.UserId == userId);
            return await skills.ToListAsync();
        }

        // GET: api/AboutMe/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SkillsData>> GetSkillsData(int id)
        {
            var skillsData= await _context.Skills.FindAsync(id);

            if (skillsData == null)
            {
                return NotFound();
            }

            return skillsData;
        }

        // PUT: api/AboutMe/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSkillsData(int id, SkillsData skillsData)
        {
            if (id != skillsData.ID)
            {
                return BadRequest();
            }

            _context.Entry(skillsData).State = EntityState.Modified;
            
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SkillsDataExists(id))
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
        public async Task<ActionResult<SkillsData>> PostSkillsData(SkillsData skillsData)
        {
            _context.Skills.Add(skillsData);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSkillsData", new { id = skillsData.ID }, skillsData);
        }

        // DELETE: api/AboutMe/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSkillsData(int id)
        {
            var skillsData = await _context.Skills.FindAsync(id);
            if (skillsData == null)
            {
                return NotFound();
            }

            _context.Skills.Remove(skillsData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SkillsDataExists(int id)
        {
            return _context.Skills.Any(e => e.ID == id);
        }
    }
}