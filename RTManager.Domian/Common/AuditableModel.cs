using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace RTManager.Domian.Common
{
    public class AuditableModel
    {
        [XmlAttribute("Id")]
        public int Id { get; set; }
        [XmlElement]
        public int CreatedById { get; set; }
        [XmlElement]
        public DateTime CreatedDateTime { get; set; }
        [XmlElement]
        public int? ModifiedById { get; set; }
        [XmlElement]
        public DateTime? ModifiedDateTime { get; set; }
    }
}
