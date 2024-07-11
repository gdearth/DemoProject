using DemoProject.Api.Models;

namespace DemoProject.Api.Interfaces;

public interface ICategoryDA
{
    Task<IEnumerable<Category>> GetCategories(CancellationToken cancellationToken);
}