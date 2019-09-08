using NachaProcessor.Exceptions;
using NachaProcessor.Models;
using System;
using System.Text;
using System.Threading.Tasks;

namespace NachaProcessor
{
    public class Processor : INachaProcessor
    {
        public NachaFile Process(byte[] file)
        {
            return ProcessFile(file).GetAwaiter().GetResult();
        }

        public async Task<NachaFile> ProcessAsync(byte[] file)
        {
            return await ProcessFile(file);
        }

        private async Task<NachaFile> ProcessFile(byte[] file)
        {
            var retVal = new NachaFile();

            try
            {
                string content = Encoding.UTF8.GetString(file, 0, file.Length);


            }
            catch
            {
                throw new NachaProcessorException();
            }

            return await Task.FromResult(retVal);
        }
    }
}
