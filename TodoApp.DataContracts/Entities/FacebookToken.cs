using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.DataContracts.Entities
{
    public class FacebookToken : BaseTable
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [MaxLength(20)]
        public string FacebookUserID { get; set; }
        public string AccessToken { get; set; }
        public DateTime Expires { get; set; }
        public string MachineId { get; set; }
    }
}
