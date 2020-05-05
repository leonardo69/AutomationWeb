namespace AutomationWeb.Common.DAL
{
    public class Repository: IRepository
    {
        private readonly RepositoryContext _repositoryContext;

        public Repository(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }
    }
}
