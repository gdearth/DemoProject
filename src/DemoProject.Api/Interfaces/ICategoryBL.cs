using DemoProject.Api.Models;

namespace DemoProject.Api.Interfaces;

public interface ICategoryBL
{
    Task<IEnumerable<Category>> GetCategories(CancellationToken cancellationToken);
}