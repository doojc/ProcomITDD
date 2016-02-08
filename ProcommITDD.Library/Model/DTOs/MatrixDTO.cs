using ProcommITDD.Library.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProcommITDD.Library.Model.DTOs
{
    public class MatrixDTO
    {
        public string TopicName { get; set; }

        public bool IsTopicAsssigned { get; set; }

        public List<InformantDTO> Informants { get; set; }

    }
}