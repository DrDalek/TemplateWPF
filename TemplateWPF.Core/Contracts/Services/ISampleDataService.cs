using System.Collections.Generic;
using System.Threading.Tasks;

using TemplateWPF.Core.Models;

namespace TemplateWPF.Core.Contracts.Services
{
    public interface ISampleDataService
    {
        Task<IEnumerable<SampleOrder>> GetMasterDetailDataAsync();
    }
}
