using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KAS.Models;

namespace KAS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChartOfAccountsController : ControllerBase
    {
        private readonly ChartOfAccountsContext _context;

        public ChartOfAccountsController(ChartOfAccountsContext context)
        {
            _context = context;
        }

        // GET: api/ChartOfAccounts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChartOfAccounts>>> GetChartOfAccounts()
        {
            return await _context.ChartOfAccounts.ToListAsync();
        }

        // GET: api/ChartOfAccounts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChartOfAccounts>> GetChartOfAccounts(int id)
        {
            var chartOfAccounts = await _context.ChartOfAccounts.FindAsync(id);

            if (chartOfAccounts == null)
            {
                return NotFound();
            }

            return chartOfAccounts;
        }

        // PUT: api/ChartOfAccounts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChartOfAccounts(int id, ChartOfAccounts chartOfAccounts)
        {
            if (id != chartOfAccounts.AccountID)
            {
                return BadRequest();
            }

            _context.Entry(chartOfAccounts).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChartOfAccountsExists(id))
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

        // POST: api/ChartOfAccounts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ChartOfAccounts>> PostChartOfAccounts(ChartOfAccounts chartOfAccounts)
        {
            _context.ChartOfAccounts.Add(chartOfAccounts);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetChartOfAccounts", new { id = chartOfAccounts.AccountID }, chartOfAccounts);
        }

        // DELETE: api/ChartOfAccounts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChartOfAccounts(int id)
        {
            var chartOfAccounts = await _context.ChartOfAccounts.FindAsync(id);
            if (chartOfAccounts == null)
            {
                return NotFound();
            }

            _context.ChartOfAccounts.Remove(chartOfAccounts);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ChartOfAccountsExists(int id)
        {
            return _context.ChartOfAccounts.Any(e => e.AccountID == id);
        }
    }
}
