﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Steward.Context.Models
{
    public class Year
    {
        [Key]
        public int StupidId { get; set; }
        public int CurrentYear { get; set; }
    }
}
