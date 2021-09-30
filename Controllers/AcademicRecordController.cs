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
    public class AcademicRecordController : ControllerBase
    {
        private readonly AcademicRecordContext _context;

        public AcademicRecordController(AcademicRecordContext context)
        {
            _context = context;
        }

        //GET: api/AcademicRecord/1
        [HttpGet("{userId}")]
        public async Task<ActionResult<IEnumerable<AcademicRecord>>> GetAcademics(int userId)
        {
            var academics = _context.Academics.Where(uid => uid.UserId == userId);
            return await academics.ToListAsync();
        }

        // GET: api/AcademicRecord/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AcademicRecord>> GetAcademicsRecord(int id)
        {
            var academicRecord = await _context.Academics.FindAsync(id);

            if (academicRecord == null)
            {
                return NotFound();
            }

            return academicRecord;
        }

        // PUT: api/AboutMe/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAcademics(int id, AcademicRecord academicRecord)
        {
            if (id != academicRecord.ID)
            {
                return BadRequest();
            }
            
            _context.Entry(academicRecord).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AcademicRecordExists(id))
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
        public async Task<ActionResult<AcademicRecord>> PostAcademics(AcademicRecord academicRecord)
        {
            _context.Academics.Add(academicRecord);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAcamicRecord", new { id = academicRecord.ID }, academicRecord);
        }

        // DELETE: api/AcademicRecord/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAcademicRecord(int id)
        {
            var academicRecord = await _context.Academics.FindAsync(id);
            if (academicRecord == null)
            {
                return NotFound();
            }

            _context.Academics.Remove(academicRecord);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AcademicRecordExists(int id)
        {
            return _context.Academics.Any(e => e.ID == id);
        }
    }
}