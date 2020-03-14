using Overt.GrpcTemplate.Application.Models;
using System.Threading.Tasks;

namespace Overt.GrpcTemplate.Application.Constracts
{
    public interface IAccountService
    {
        /// <summary>
        /// 获取分页数据
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        Task<AccountModel> GetAsync(long aId);
    }
}
