using System.Threading.Tasks;

namespace TemplateWPF.Contracts.Services
{
    public interface IApplicationHostService
    {
        Task StartAsync();

        Task StopAsync();
    }
}
