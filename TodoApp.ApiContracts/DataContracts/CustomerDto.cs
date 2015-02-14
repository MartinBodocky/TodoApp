using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.ApiContracts.DataContracts
{
    [DataContract]
    public class CustomerDto : BaseTableDto
    {
        [DataMember]
        public long CustomerId { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string Lastname { get; set; }
        
        [DataMember(EmitDefaultValue = true)]
        public DateTime? BirthDate { get; set; }
        
        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string MobilePhone { get; set; }

        [DataMember]
        public bool IsBlocked { get; set; }

        [DataMember]
        public bool? AcceptsTerms { get; set; }        
    }
}
