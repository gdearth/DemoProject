using DemoProject.Api.Interfaces;
using DemoProject.Api.Models;

namespace DemoProject.Api.BusinessLogic;

public class CategoryBL : ICategoryBL
{
    private readonly ICategoryDA _dataAccess;

    public CategoryBL(ICategoryDA dataAccess)
    {
        _dataAccess = dataAccess;
    }

    public Task<IEnumerable<Category>> GetCategories(CancellationToken cancellationToken) 
        => _dataAccess.GetCategories(cancellationToken);
}