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
    /// Represent comment in the system
    /// </summary>
    public class Comment: BaseTable
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CommentId { get; set; }

        [ForeignKey("Customer")]
        public long CustomerId { get; set; }
        public string Text { get; set; }

        public Customer Customer { get; set; }
    }
}
