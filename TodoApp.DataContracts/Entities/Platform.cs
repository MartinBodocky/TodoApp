using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.DataContracts.Entities
{
    /// <summary>
    /// Represent platform of device
    /// </summary>
    public class Platform : BaseTable
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PlatformId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
    }
}
