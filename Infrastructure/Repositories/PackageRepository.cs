using System.Collections.Generic;
using System.Linq;
using Core.Domain;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class PackageRepository
    {
        private readonly AppDbContext _context;

        public PackageRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Package> GetAvailablePackages()
        {
            return _context.Packages.Where(p => p.ReservedBy == null).ToList();
        }

        public IEnumerable<Package> GetReservedPackagesByStudent(Student student)
        {
            return _context.Packages.Where(p => p.ReservedBy == student).ToList();
        }

        // Add other CRUD methods as needed
    }
}

