using NachaProcessor.Models;

namespace NachaProcessor
{
    public static class ProcessorExtensions
    {
        public static NachaFileFormatted ConvertToFormatted(this NachaFile file)
        {
            return new NachaFileFormatted();
        }
    }
}
