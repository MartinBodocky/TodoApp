using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.DataContracts.Entities
{
    public class ExceptionLog
    {
        /// <summary>
        ///     The primary key.
        /// </summary>
        /// <value>
        ///     The exception log ID.
        /// </value>
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid ExceptionLogId { get; set; }

        /// <summary>
        ///     The exception message/text.
        /// </summary>
        /// <value>
        ///     The text.
        /// </value>
        [Required]
        public string Message { get; set; }

        /// <summary>
        ///     More detailed information about the exception, typically from a call to the ToString() method.
        /// </summary>
        /// <value>
        ///     The details.
        /// </value>
        public string Details { get; set; }

        /// <summary>
        ///     The stack trace.
        /// </summary>
        /// <value>
        ///     The exception.
        /// </value>
        public string StackTrace { get; set; }

        /// <summary>
        ///     The unique ID of the device that made the request the caused the exception.
        /// </summary>
        /// <value>
        ///     The device GUID.
        /// </value>
        public Guid? DeviceGuid { get; set; }

        /// <summary>
        ///     The date and time that the error occurred.
        /// </summary>
        /// <value>
        ///     The time stamp.
        /// </value>
        public DateTime TimeStamp { get; set; }
    }
}
