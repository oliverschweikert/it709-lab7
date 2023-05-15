using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using backend.Models;
using backend.Data;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturerFoodsController : ControllerBase
    {
        private readonly Lab7Context _context;

        public ManufacturerFoodsController(Lab7Context context)
        {
            _context = context;
        }

        // GET: api/ManufacturerFoods
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ManufacturerFood>>> GetManufacturerFood()
        {
          if (_context.ManufacturerFood == null)
          {
              return NotFound();
          }
            return await _context.ManufacturerFood.ToListAsync();
        }

        // GET: api/ManufacturerFoods/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ManufacturerFood>> GetManufacturerFood(int id)
        {
          if (_context.ManufacturerFood == null)
          {
              return NotFound();
          }
            var manufacturerFood = await _context.ManufacturerFood.FindAsync(id);

            if (manufacturerFood == null)
            {
                return NotFound();
            }

            return manufacturerFood;
        }

        // PUT: api/ManufacturerFoods/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutManufacturerFood(int id, ManufacturerFood manufacturerFood)
        {
            if (id != manufacturerFood.Id)
            {
                return BadRequest();
            }

            _context.Entry(manufacturerFood).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ManufacturerFoodExists(id))
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

        // POST: api/ManufacturerFoods
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ManufacturerFood>> PostManufacturerFood(ManufacturerFood manufacturerFood)
        {
          if (_context.ManufacturerFood == null)
          {
              return Problem("Entity set 'Lab7Context.ManufacturerFood'  is null.");
          }
            _context.ManufacturerFood.Add(manufacturerFood);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetManufacturerFood", new { id = manufacturerFood.Id }, manufacturerFood);
        }

        // DELETE: api/ManufacturerFoods/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteManufacturerFood(int id)
        {
            if (_context.ManufacturerFood == null)
            {
                return NotFound();
            }
            var manufacturerFood = await _context.ManufacturerFood.FindAsync(id);
            if (manufacturerFood == null)
            {
                return NotFound();
            }

            _context.ManufacturerFood.Remove(manufacturerFood);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ManufacturerFoodExists(int id)
        {
            return (_context.ManufacturerFood?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
