using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restoran.models;

namespace Restoran.Controllers
{
    [Route("/restaurantUnits")]
    [ApiController]
    public class RestaurantUnitsController : ControllerBase
    {
        private readonly RestoranDBContext _context;

        public RestaurantUnitsController(RestoranDBContext context)
        {
            _context = context;
        }

        // GET: api/RestaurantUnits
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RestaurantUnit>>> GetrestaurantUnits()
        {
            return await _context.restaurantUnits.ToListAsync();
        }

        // GET: api/RestaurantUnits/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RestaurantUnit>> GetRestaurantUnit(int id)
        {
            var restaurantUnit = await _context.restaurantUnits.FindAsync(id);

            if (restaurantUnit == null)
            {
                return NotFound();
            }

            return restaurantUnit;
        }

        // PUT: api/RestaurantUnits/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRestaurantUnit(int id, RestaurantUnit restaurantUnit)
        {
            if (id != restaurantUnit.UnitId)
            {
                return BadRequest();
            }

            _context.Entry(restaurantUnit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RestaurantUnitExists(id))
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

        // POST: api/RestaurantUnits
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<RestaurantUnit>> PostRestaurantUnit(RestaurantUnit restaurantUnit)
        {
            _context.restaurantUnits.Add(restaurantUnit);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRestaurantUnit", new { id = restaurantUnit.UnitId }, restaurantUnit);
        }

        // DELETE: api/RestaurantUnits/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<RestaurantUnit>> DeleteRestaurantUnit(int id)
        {
            var restaurantUnit = await _context.restaurantUnits.FindAsync(id);
            if (restaurantUnit == null)
            {
                return NotFound();
            }

            _context.restaurantUnits.Remove(restaurantUnit);
            await _context.SaveChangesAsync();

            return restaurantUnit;
        }

        private bool RestaurantUnitExists(int id)
        {
            return _context.restaurantUnits.Any(e => e.UnitId == id);
        }
    }
}
