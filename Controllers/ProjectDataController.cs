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
    public class ProjectDataController : ControllerBase
    {
        private readonly ProjectDataContext _context;

        public ProjectDataController(ProjectDataContext context)
        {
            _context = context;
        }

        // GET: api/ProjectData/1
        [HttpGet("{user}")]
        public async Task<ActionResult<IEnumerable<ProjectData>>> GetProjects(int userId)
        {
            var projects = _context.Projects.Where(uid => uid.AuthUser == userId);
            return await projects.ToListAsync();
        }

        // GET: api/AboutMe/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProjectData>> GetProjectData(int id)
        {
            var projectData = await _context.Projects.FindAsync(id);

            if (projectData == null)
            {
                return NotFound();
            }

            return projectData;
        }

        // PUT: api/AboutMe/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProjectData(int id, ProjectData projectData)
        {
            if (id != projectData.ID)
            {
                return BadRequest();
            }

            _context.Entry(projectData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProjectDataExists(id))
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
        public async Task<ActionResult<ProjectData>> PostProjectData(ProjectData projectData)
        {
            _context.Projects.Add(projectData);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProjectData", new { id = projectData.ID }, projectData);
        }

        // DELETE: api/ProjectData/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProjectData(int id)
        {
            var projectData = await _context.Projects.FindAsync(id);
            if (projectData == null)
            {
                return NotFound();
            }

            _context.Projects.Remove(projectData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProjectDataExists(int id)
        {
            return _context.Projects.Any(e => e.ID == id);
        }
    }
}