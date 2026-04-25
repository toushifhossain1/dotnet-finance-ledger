using Microsoft.AspNetCore.Mvc;
using FinanceSystem.Services;
using FinanceSystem.Models;
using FinanceSystem.DTOs;

namespace FinanceSystem.Controllers;

[ApiController]
[Route("api/[controller]")]
public class InvoiceController : ControllerBase
{
    private readonly InvoiceService _invoiceService;

    public InvoiceController(InvoiceService invoiceService)
    {
        _invoiceService = invoiceService;
    }

    [HttpPost]
    public IActionResult CreateInvoice([FromBody] CreateInvoiceRequest request)
    {
        var invoice = _invoiceService.CreateInvoice(
            request.CustomerId,
            request.Amount,
            request.DueDate
        );

        return Ok(invoice);
    }

    [HttpGet("{id}")]
    public IActionResult GetInvoice(int id)
    {
        var invoice = _invoiceService.GetById(id);

        if (invoice == null)
            return NotFound();

        return Ok(invoice);
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_invoiceService.GetAll());
    }
}