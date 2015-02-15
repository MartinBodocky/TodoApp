using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.ApiContracts.DataContracts
{
    [DataContract]
    public class TodoDto : BaseTableDto
    {
        [DataMember]
        public long TodoId { get; set; }

        [DataMember]
        public string Text { get; set; }

        [DataMember]
        public long CreatedById { get; set; }

        [DataMember]
        public bool IsPublic { get; set; }

        [DataMember]
        public CustomerDto[] RequiredUsers { get; set; }
    }
}
