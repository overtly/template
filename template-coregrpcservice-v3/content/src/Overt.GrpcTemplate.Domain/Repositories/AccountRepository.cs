using Microsoft.Extensions.Configuration;
using Overt.Core.Data;
using Overt.GrpcTemplate.Domain.Contracts;
using Overt.GrpcTemplate.Domain.Entities;

namespace Overt.GrpcTemplate.Domain.Repositories
{
    public class AccountRepository : BaseRepository<AccountEntity>, IAccountRepository
    {
        public AccountRepository(IConfiguration configuration)
            : base(configuration, Constants.AclDbNameKey)
        {
        }

    }
}
