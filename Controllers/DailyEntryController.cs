using DailyHilfy.Models;
using Microsoft.AspNetCore.Mvc;
using DailyHilfy.DTOs;
using DailyHilfy.Data;
using Microsoft.EntityFrameworkCore;

namespace DailyHilfy.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DailyEntryController : ControllerBase
{
    private readonly DailyHilfyContext _context;

    public DailyEntryController(DailyHilfyContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<DailyEntry>>> GetAll()
    {
        var entries = await _context.DailyEntries.AsNoTracking().ToListAsync();

        return Ok(entries);
    }

    [HttpPost]
    public async Task<ActionResult<DailyEntry>> Create(CreateDailyEntryDto dto)
    {
        var entry = new DailyEntry
        {
            Date = dto.Date,
            WorkMinutes = dto.WorkMinutes,
            WorkDescription = dto.WorkDescription,
            ExerciseMinutes = dto.ExerciseMinutes,
            ExerciseDescription = dto.ExerciseDescription,
            FinanceAmount = dto.FinanceAmount,
            FinanceType = dto.FinanceType,
            FinanceDescription = dto.FinanceDescription,
            Notes = dto.Notes
        };

        _context.DailyEntries.Add(entry);

        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetById),
            new { id = entry.Id },
            entry);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<DailyEntry>> GetById(int id)
    {
        var entry = await _context.DailyEntries.AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        if (entry == null)
        {
            return NotFound();
        }
        return Ok(entry);
    }
}
