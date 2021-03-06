using NuKeeper.Inspection.RepositoryInspection;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NuKeeper.Engine.Packages
{
    public interface IPackageUpdateSelection
    {
        Task<List<PackageUpdateSet>> SelectTargets(
            ForkData pushFork,
            IEnumerable<PackageUpdateSet> potentialUpdates);
    }
}
