using System;
using System.Runtime.Serialization;

namespace ProcommITDD.Library.Model.DTOs
{
    [DataContract]
    public class ProjectDTO
    {
        [DataMember]
        public int ProjectId { get; set; }

        [DataMember]
        public string ProjectName { get; set; }

        [DataMember]
        public DateTime CreatedDate { get; set; }

        [DataMember]
        public string Completion { get; set; }

        [DataMember]
        public string State { get; set; }
    }
}
