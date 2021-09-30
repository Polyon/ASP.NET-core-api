using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MineApi.Data;
using MineApi.Models;

namespace MinsApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TrainingDataController : ControllerBase
    {
        private readonly TrainingDataContext _context;

        public TrainingDataController(TrainingDataContext context)
        {
            _context = context;
        }

        // GET: api/AboutMe/1
        [HttpGet("{userId}")]
        public async Task<ActionResult<IEnumerable<TrainingData>>> GetTrainings(int userId)
        {
            var trainings = _context.Trainings.Where(uid => uid.UserID == userId);
            return await trainings.ToListAsync();
        }

        // GET: api/AboutMe/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TrainingData>> GetTrainingData(int id)
        {
            var trainingData = await _context.Trainings.FindAsync(id);

            if (trainingData == null)
            {
                return NotFound();
            }

            return trainingData;
        }

        // PUT: api/AboutMe/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrainingData(int id, TrainingData trainingData)
        {
            if (id != trainingData.ID)
            {
                return BadRequest();
            }

            _context.Entry(trainingData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrainingDataExists(id))
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
        public async Task<ActionResult<TrainingData>> PostTrainingData(TrainingData trainingData)
        {
            _context.Trainings.Add(trainingData);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTrainingData", new { id = trainingData.ID }, trainingData);
        }

        // DELETE: api/AboutMe/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTrainingData(int id)
        {
            var trainingData = await _context.Trainings.FindAsync(id);
            if (trainingData == null)
            {
                return NotFound();
            }

            _context.Trainings.Remove(trainingData);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TrainingDataExists(int id)
        {
            return _context.Trainings.Any(e => e.ID == id);
        }
    }
}