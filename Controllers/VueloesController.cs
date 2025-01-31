﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaReservasViajes.Context;
using SistemaReservasViajes.Models;

namespace SistemaReservasViajes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VueloesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public VueloesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Vueloes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vuelo>>> GetVuelo()
        {
            return await _context.Vuelo.ToListAsync();
        }

        // GET: api/Vueloes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Vuelo>> GetVuelo(int id)
        {
            var vuelo = await _context.Vuelo.FindAsync(id);

            if (vuelo == null)
            {
                return NotFound();
            }

            return vuelo;
        }

        // PUT: api/Vueloes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVuelo(int id, Vuelo vuelo)
        {
            if (id != vuelo.VueloID)
            {
                return BadRequest();
            }

            _context.Entry(vuelo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VueloExists(id))
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

        // POST: api/Vueloes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Vuelo>> PostVuelo(Vuelo vuelo)
        {
            _context.Vuelo.Add(vuelo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVuelo", new { id = vuelo.VueloID }, vuelo);
        }

        // DELETE: api/Vueloes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVuelo(int id)
        {
            var vuelo = await _context.Vuelo.FindAsync(id);
            if (vuelo == null)
            {
                return NotFound();
            }

            _context.Vuelo.Remove(vuelo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VueloExists(int id)
        {
            return _context.Vuelo.Any(e => e.VueloID == id);
        }
    }
}
