﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Insight.Core.Models
{
    public class Medical
    {
        [Key]
        public int Id { get; set; }

        public Person Person { get; set; }

        public Status OverallStatus { get; set; }

        public Status Dental { get; set; }

        public Status Immunizations { get; set; }

        public Status Lab { get; set; }

        public Status PHA { get; set; }
    }
}
