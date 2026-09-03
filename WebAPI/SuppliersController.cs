using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Webapplication1.Models;

[Route("api/[controller]")]
[ApiController]
public class SuppliersController : ControllerBase
{
    private readonly SupplierContext _context;
    public SuppliersController(SupplierContext context)
    {
        _context = context;
    }

    // GET: api/Supplier
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Supplier>>> GetSupplier()
    {
        return await _context.Suppliers.ToListAsync();
    }

    // GET: api/Supplier/5
    [HttpGet("{supplierid}")]
    public async Task<ActionResult<Supplier>> GetSupplier(int supplierid)
    {
        var supplier = await _context.Suppliers.FindAsync(supplierid);

        if (supplier == null)
        {
            return NotFound();
        }

        return supplier;
    }

    // PUT: api/Supplier/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{supplierid}")]
    public async Task<IActionResult> PutSupplier(int? supplierid, Supplier supplier)
    {
        if (supplierid != supplier.SupplierId)
        {
            return BadRequest();
        }

        _context.Entry(supplier).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!SupplierExists(supplierid))
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

    // POST: api/Supplier
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Supplier>> PostSupplier(Supplier supplier)
    {
        _context.Suppliers.Add(supplier);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetSupplier", new { supplierid = supplier.SupplierId }, supplier);
    }

    // DELETE: api/Supplier/5
    [HttpDelete("{supplierid}")]
    public async Task<IActionResult> DeleteSupplier(int? supplierid)
    {
        var supplier = await _context.Suppliers.FindAsync(supplierid);
        if (supplier == null)
        {
            return NotFound();
        }

        _context.Suppliers.Remove(supplier);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool SupplierExists(int? supplierid)
    {
        return _context.Suppliers.Any(e => e.SupplierId == supplierid);
    }
}
