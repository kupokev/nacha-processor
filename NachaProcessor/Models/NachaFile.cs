using System.Collections.Generic;

namespace NachaProcessor.Models
{
    public class NachaFile
    {
        public NachaFile()
        {
            Batches = new List<BatchRecord>();
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
            /// <summary>
            /// Position: 01-01
            /// Length: 1
            /// </summary>
            public string RecordTypeCode { get; set; }

            /// <summary>
            /// Position: 02-03
            /// Length: 2
            /// </summary>
            public string PriorityCode { get; set; }

            /// <summary>
            /// Position: 04-13
            /// Length: 10
            /// </summary>
            public string ImmediateDestination { get; set; }

            /// <summary>
            /// Position: 14-23
            /// Length: 10
            /// </summary>
            public string ImmediateOrigin { get; set; }

            /// <summary>
            /// Position: 24-29
            /// Length: 6
            /// </summary>
            public string FileCreationDate { get; set; }

            /// <summary>
            /// Position: 30-33
            /// Length: 4
            /// </summary>
            public string FileCreationTime { get; set; }

            /// <summary>
            /// Position: 34-34
            /// Length: 1
            /// </summary>
            public string FileIdModifier { get; set; }

            /// <summary>
            /// Position: 35-37
            /// Length: 3
            /// </summary>
            public string RecordSize { get; set; }

            /// <summary>
            /// Position: 38-39
            /// Length: 2
            /// </summary>
            public string BlockingFactor { get; set; }

            /// <summary>
            /// Position: 40-40
            /// Length: 1
            /// </summary>
            public string FormatCode { get; set; }

            /// <summary>
            /// Position: 41-63
            /// Length: 23
            /// </summary>
            public string ImmediateDestinationName { get; set; }

            /// <summary>
            /// Position: 64-86
            /// Length: 23
            /// </summary>
            public string ImmediateOriginName { get; set; }

            /// <summary>
            /// Position: 87-94
            /// Length: 8
            /// </summary>
            public string ReferenceCode { get; set; }
        }

        public class BatchRecord
        {
            public BatchRecord()
            {
                BatchControl = new BatchControlRecord();
                EntryDetails = new List<BatchDetailRecord>();
                BatchHeader = new BatchHeaderRecord();
            }

            public BatchHeaderRecord BatchHeader { get; set; }

            public IEnumerable<BatchDetailRecord> EntryDetails { get; set; }

            public BatchControlRecord BatchControl { get; set; }


            public class BatchControlRecord
            {

            }

            public class BatchDetailRecord
            {

            }

            public class BatchHeaderRecord
            {

            }
        }
    }
}
