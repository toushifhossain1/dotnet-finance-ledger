using Microsoft.AspNetCore.Mvc;
using FinanceSystem.Services;

namespace FinanceSystem.Controllers;

[ApiController]
[Route("api/[controller]")]
public class JournalController : ControllerBase
{
    private readonly JournalService _journalService;

    public JournalController(JournalService journalService)
    {
        _journalService = journalService;
    }

    // 🔹 Get all journal entries
    [HttpGet]
    public IActionResult GetAll()
    {
        var entries = _journalService.GetAll();
        return Ok(entries);
    }

    // 🔹 Get specific journal entry by ID
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var entry = _journalService
            .GetAll()
            .FirstOrDefault(e => e.JournalEntryId == id);

        if (entry == null)
            return NotFound();

        return Ok(entry);
    }
}