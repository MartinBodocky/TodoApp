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
    /// Represent Todo in system
    /// </summary>
    public class Todo : BaseTable
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long TodoId { get; set; }
        public string Text { get; set; }

        public virtual ICollection<Customer> Required { get; set; }

        [ForeignKey("CreatedBy")]
        public long CreatedById { get; set; }
        public Customer CreatedBy { get; set; }

        public bool IsPublic { get; set; }
    }
}
