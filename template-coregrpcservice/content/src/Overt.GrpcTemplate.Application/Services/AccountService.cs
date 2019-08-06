using AutoMapper;
using Overt.GrpcTemplate.Application.Constracts;
using Overt.GrpcTemplate.Application.Models;
using Overt.GrpcTemplate.Domain.Contracts;
using System.Threading.Tasks;

namespace Overt.GrpcTemplate.Application.Services
{
    public class AccountService : IAccountService
    {
        IMapper _mapper;
        IAccountRepository _accountRepository;
        public AccountService(IMapper mapper, IAccountRepository accountRepository)
        {
            _mapper = mapper;
            _accountRepository = accountRepository;
        }

        public async Task<AccountModel> GetAsync(long aId)
        {
            if (aId <= 0)
                return null;

            var entity = await _accountRepository.GetAsync(oo => oo.AId == aId);
            return _mapper.Map<AccountModel>(entity);
        }
    }
}
