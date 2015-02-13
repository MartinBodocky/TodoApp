using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.DataContracts.Entities
{
    /// <summary>
    /// Base table for entity
    /// </summary>
    public class BaseTable
    {
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
