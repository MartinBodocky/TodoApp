using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.DataContracts.Entities
{
    /// <summary>
    /// Device entity for representation of mobile client
    /// </summary>
    public class Device : BaseTable
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long DeviceId { get; set; }
        public Guid DeviceGuid { get; set; }
        public string PushToken { get; set; }
        
        [ForeignKey("Platform")]
        public int PlatformId { get; set; }
        public Platform Platform { get; set; }
        
        public DbGeography Location { get; set; }
        
        [ForeignKey("Customer")]
        public long? CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        
        [MaxLength(30)]
        public string AuthorizationToken { get; set; }
        public bool IsLoggedIn { get; set; }
    }
}
