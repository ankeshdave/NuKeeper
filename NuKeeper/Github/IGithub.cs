using System.Collections.Generic;
using System.Threading.Tasks;
using NuKeeper.Engine;
using Octokit;

namespace NuKeeper.Github
{
    public interface IGithub
    {
        Task<Account> GetCurrentUser();

        Task OpenPullRequest(ForkData target, NewPullRequest request);

        Task<IReadOnlyList<Repository>> GetRepositoriesForOrganisation(string organisationName);

        Task<Repository> GetUserRepository(string userName, string repositoryName);

        Task<Repository> MakeUserFork(string owner, string repositoryName);

        Task<Branch> GetRepositoryBranch(string userName, string repositoryName, string branchName);
    }
}
