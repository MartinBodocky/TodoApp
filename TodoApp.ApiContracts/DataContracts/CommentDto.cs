using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.ApiContracts.DataContracts
{
    [DataContract]
    public class CommentDto : BaseTableDto
    {
        [DataMember]
        public long CustomerId { get; set; }

        [DataMember]
        public string Text { get; set; }
    }
}
