using NachaProcessor.Exceptions;
using NachaProcessor.Models;
using System;
using System.Collections.Generic;
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

        /// <summary>
        /// Process the file
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        private async Task<NachaFile> ProcessFile(byte[] file)
        {
            var retVal = new NachaFile();

            try
            {
                var content = Encoding.UTF8.GetString(file, 0, file.Length);

                var lines = GetLines(content);

                foreach (var line in lines)
                {
                    switch(line[0])
                    {
                        case '1': // File Header Record
                            retVal.FileHeader = await ProcessFileHeaderRecord(line);
                            break;

                        case '5': // Batch Header Record

                            break;

                        case '6': // Entry Detail Record

                            break;

                        case '7': // Entry Detail Addenda Record

                            break;

                        case '8': // Batch Control Total

                            break;

                        case '9': // File Control Record
                            retVal.FileControl = await ProcessFileControlRecord(line);
                            break;
                    }
                }
            }
            catch
            {
                throw new NachaProcessorException();
            }

            return await Task.FromResult(retVal);
        }

        /// <summary>
        /// Get the lines from the content
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        private IEnumerable<string> GetLines(string content)
        {
            // Split the lines based on new line indicator
            string[] lines = content.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

            // Dispose of any lines that are empty
            for (int i = 0; i < lines.Length; i++)
            {
                if (string.IsNullOrEmpty(lines[i]))
                {
                    yield return lines[i];
                }
            }
        }

        private Task<NachaFile.FileControlRecord> ProcessFileControlRecord(string line)
        {
            Task<NachaFile.FileControlRecord> task = Task<NachaFile.FileControlRecord>.Factory.StartNew(() =>
            {
                var result = new NachaFile.FileControlRecord();

                return result;
            });

            return task;
        }

        private Task<NachaFile.FileHeaderRecord> ProcessFileHeaderRecord(string line)
        {
            Task<NachaFile.FileHeaderRecord> task = Task<NachaFile.FileHeaderRecord>.Factory.StartNew(() =>
            {
                var result = new NachaFile.FileHeaderRecord();

                return result;
            });

            return task;
        }
    }
}