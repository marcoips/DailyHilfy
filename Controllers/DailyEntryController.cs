using DailyHilfy.Models;
using Microsoft.AspNetCore.Mvc;

namespace DailyHilfy.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DailyEntryController : ControllerBase
{
    private static readonly List<DailyEntry> Entries = new();
    private static int _nextId = 1;

    [HttpGet]
    public ActionResult<IEnumerable<DailyEntry>> GetAll()
    {
        return Ok(Entries);
    }

    [HttpPost]
    public ActionResult<DailyEntry> Create(DailyEntry entry)
    {
        entry.Id = _nextId++;
        Entries.Add(entry);

        return CreatedAtAction(
            nameof(GetById),
            new { id = entry.Id },
            entry);
    }

    [HttpGet("{id:int}")]
    public ActionResult<DailyEntry> GetById(int id)
    {
        var entry = Entries.FirstOrDefault(e => e.Id == id);

        if (entry is null)
        {
            return NotFound();
        }

        return Ok(entry);
    }
}
