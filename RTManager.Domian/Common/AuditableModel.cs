﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RTManager.Domian.Common
{
    public class AuditableModel
    {
        public int Id { get; set; }
        public int CreatedById { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int? ModifiedById { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
    }
}