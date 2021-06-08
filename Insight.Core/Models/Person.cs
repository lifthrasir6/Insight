﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Insight.Core.Models
{
    public class Person
    {
        /// <summary>
        ///     This the primary Key for the Person class. It is NOT an int because DoDIDs
        ///     are 10 digits long and ints won't cover DoDIDs larger than 2.1 bil.
        /// </summary>
        [Key]
        public long Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Phone { get; set; }

        public AFSC AFSC { get; set; }

        public Organization Organization { get; set; }

        public PEX PEX { get; set; }
    }
}