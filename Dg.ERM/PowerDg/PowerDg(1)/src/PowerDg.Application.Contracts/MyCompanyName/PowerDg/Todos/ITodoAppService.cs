using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace PowerDg.Todos
{
    public interface ITodoAppService
    {
        Task<PagedResultDto<TodoDto>> GetListAsync();
    }
}