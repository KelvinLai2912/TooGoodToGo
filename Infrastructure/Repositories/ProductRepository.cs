using System.Collections.Generic;
using System.Linq;
using Core.Domain;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{

    public class ProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetProductsByPackage(Package package)
        {
            return _context.Products.Where(p => p.PackageId == package.Id).ToList();
        }

        // Add other CRUD methods as needed
    }
}
