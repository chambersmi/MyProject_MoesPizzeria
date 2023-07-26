using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoesPizzeriaAPI.Models;

namespace MoesPizzeriaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppetizerMenuController : ControllerBase
    {
        private readonly ItemDetailContext _context;

        public AppetizerMenuController(ItemDetailContext context)
        {
            _context = context;
        }

        // GET: api/AppetizerMenu
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemModel>>> GetAppetizerMenu()
        {
          if (_context.AppetizerMenu == null)
          {
              return NotFound();
          }
            return await _context.AppetizerMenu.ToListAsync();
        }

        // GET: api/AppetizerMenu/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemModel>> GetItemModel(int id)
        {
          if (_context.AppetizerMenu == null)
          {
              return NotFound();
          }
            var itemModel = await _context.AppetizerMenu.FindAsync(id);

            if (itemModel == null)
            {
                return NotFound();
            }

            return itemModel;
        }

        // PUT: api/AppetizerMenu/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItemModel(int id, ItemModel itemModel)
        {
            if (id != itemModel.ItemId)
            {
                return BadRequest();
            }

            _context.Entry(itemModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemModelExists(id))
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

        // POST: api/AppetizerMenu
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ItemModel>> PostItemModel(ItemModel itemModel)
        {
          if (_context.AppetizerMenu == null)
          {
              return Problem("Entity set 'ItemDetailContext.AppetizerMenu'  is null.");
          }
            _context.AppetizerMenu.Add(itemModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetItemModel", new { id = itemModel.ItemId }, itemModel);
        }

        // DELETE: api/AppetizerMenu/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItemModel(int id)
        {
            if (_context.AppetizerMenu == null)
            {
                return NotFound();
            }
            var itemModel = await _context.AppetizerMenu.FindAsync(id);
            if (itemModel == null)
            {
                return NotFound();
            }

            _context.AppetizerMenu.Remove(itemModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ItemModelExists(int id)
        {
            return (_context.AppetizerMenu?.Any(e => e.ItemId == id)).GetValueOrDefault();
        }
    }
}
