using System.Collections.Generic;

namespace NachaProcessor.Models
{
    public class NachaFile
    {
        public NachaFile()
        {
            FileHeader = new FileHeaderRecord();

            FileControl = new FileControlRecord();
        }

        public FileHeaderRecord FileHeader { get; set; }

        public IEnumerable<BatchRecord> Batches { get; set; }

        public FileControlRecord FileControl { get; set; }


        public class FileControlRecord
        {

        }

        public class FileHeaderRecord
        {

        }

        public class BatchRecord
        {
            public BatchRecord()
            {
                BatchControl = new BatchControlRecord();
                BatchHeader = new BatchHeaderRecord();
            }

            public BatchHeaderRecord BatchHeader { get; set; }

            public BatchControlRecord BatchControl { get; set; }


            public class BatchControlRecord
            {

            }

            public class BatchHeaderRecord
            {

            }
        }
    }
}
