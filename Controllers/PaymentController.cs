using Microsoft.AspNetCore.Mvc;
using FinanceSystem.Services;
using FinanceSystem.Models;
using FinanceSystem.DTOs;

namespace FinanceSystem.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PaymentController : ControllerBase
{
    private readonly PaymentService _paymentService;

    public PaymentController(PaymentService paymentService)
    {
        _paymentService = paymentService;
    }

    [HttpPost]
    public IActionResult MakePayment([FromBody] CreatePaymentRequest request)
    {
        try
        {
            _paymentService.MakePayment(request.InvoiceId, request.Amount);
            return Ok("Payment successful");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}