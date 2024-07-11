using DemoProject.Api.Interfaces;
using DemoProject.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoProject.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController : ControllerBase
{
    private readonly ICategoryBL _businessLogic;

    public CategoryController(ICategoryBL businessLogic)
    {
        _businessLogic = businessLogic;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Category>>> Get(CancellationToken cancellationToken)
    {
        IEnumerable<Category> categories = await _businessLogic.GetCategories(cancellationToken);
        return Ok(categories);
    }
}