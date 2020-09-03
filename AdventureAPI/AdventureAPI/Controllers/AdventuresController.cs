using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AdventureAPI.Modules;
using AdventureAPI.DTOs;

namespace AdventureAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdventuresController : ControllerBase
    {
        private readonly Context _context;

        public AdventuresController(Context context)
        {
            _context = context;
        }

        // GET: api/Adventures
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Adventure>>> GetAdventure()
        {
            return await _context.Adventure.ToListAsync();
        }

        // GET: api/Adventures/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Adventure>> GetAdventure(int id)
        {
            var adventure = await _context.Adventure.FindAsync(id);

            if (adventure == null)
            {
                return NotFound();
            }

            adventure.Characters = _context.Character.Where(x => x.AdventureId == id).ToList();

            return adventure;
        }

        // PUT: api/Adventures/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdventure(int id, Adventure adventure)
        {
            if (id != adventure.Id)
            {
                return BadRequest();
            }

            _context.Entry(adventure).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdventureExists(id))
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

        // POST: api/Adventures
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Adventure>> PostAdventure(Adventure adventure)
        {
            _context.Adventure.Add(adventure);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAdventure", new { id = adventure.Id }, adventure);
        }

        // DELETE: api/Adventures/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Adventure>> DeleteAdventure(int id)
        {
            var adventure = await _context.Adventure.FindAsync(id);
            if (adventure == null)
            {
                return NotFound();
            }

            _context.Adventure.Remove(adventure);
            await _context.SaveChangesAsync();

            return adventure;
        }

        private bool AdventureExists(int id)
        {
            return _context.Adventure.Any(e => e.Id == id);
        }
    }
}
