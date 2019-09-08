using NachaProcessor.Models;
using System.Threading.Tasks;

namespace NachaProcessor
{
    public interface INachaProcessor
    {
        NachaFile Process(byte[] file);

        Task<NachaFile> ProcessAsync(byte[] file);
    }
}
