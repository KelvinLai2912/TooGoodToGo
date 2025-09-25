using Core.Domain;


namespace Core.DomainServices.Repo.Intf
{
    public interface IPackageRepository
    {
        IEnumerable<Package> GetAvailablePackages();
        IEnumerable<Package> GetReservedPackagesByStudent(Student student);
    }

}