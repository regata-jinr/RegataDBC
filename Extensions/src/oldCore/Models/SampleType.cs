﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OldCore.Models
{
    [Table("SampleTypes")]
    public class SampleTypes
    {
        [Key]
        public string Type { get; set; }
        [Key]
        public string SubType { get; set; }

    }
}

