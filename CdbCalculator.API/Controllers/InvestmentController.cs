using CdbCalculator.Application;
using CdbCalculator.Application.Arguments;
using CdbCalculator.Application.interfaces;
using CdbCalculator.Application.Services;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class InvestmentController : ControllerBase
{
    private readonly IInvestmentService _investmentService;

    public InvestmentController(IInvestmentService investmentService)
    {
        _investmentService = investmentService;
    }

    [HttpPost]
    public ServiceResult<InvestmentResponse> CalculateFinalValue(InvestmentRequest request)
    {
        var response = _investmentService.Calculate(request);
        return response;
    }
}
