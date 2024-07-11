using DemoProject.Api.Interfaces;
using DemoProject.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoProject.Api.DataAccess;

public class CategoryDA : ICategoryDA
{
    private readonly NorthwindsContext _context;
    
    public CategoryDA(NorthwindsContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Category>> GetCategories(CancellationToken cancellationToken)
    {
        return await _context.Categories.ToListAsync(cancellationToken);
    }
}