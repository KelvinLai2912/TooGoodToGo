using Microsoft.AspNetCore.Mvc;
using Core.Domain;
using Infrastructure.Repositories;

namespace TooGoodToGo.Controllers
{
    public class PackageController : Controller
    {
        private readonly PackageRepository _packageRepository;

        public PackageController(PackageRepository packageRepository)
        {
            _packageRepository = packageRepository;
        }

        public IActionResult AvailablePackages()
        {
            var availablePackages = _packageRepository.GetAvailablePackages();
            return View(availablePackages);
        }

        public IActionResult ReservedPackages(Student student) // The student should be obtained from the logged-in context
        {
            var reservedPackages = _packageRepository.GetReservedPackagesByStudent(student);
            return View(reservedPackages);
        }
    }
}
