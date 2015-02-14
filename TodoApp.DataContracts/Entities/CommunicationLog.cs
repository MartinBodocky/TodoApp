using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.DataContracts.Entities
{
    public class CommunicationLog
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CommunicationLogId { get; set; }
        public Guid DeviceGuid { get; set; }
        public Guid CorrelationId { get; set; }
        public Guid? ExceptionLogId { get; set; }
        public string Address { get; set; }
        public string Message { get; set; }
        public DateTime TimeStamp { get; set; }

        [MaxLength(50)]
        public string Ip { get; set; }

        [MaxLength(50)]
        public string Result { get; set; }
    }
}
