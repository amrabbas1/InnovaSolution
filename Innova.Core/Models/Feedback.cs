﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innova.Core.Models
{
    public class Feedback
    {
        public string Id { get; set; }
        public string Content { get; set; }
        public string? UserId { get; set; }//FK
        public User User { get; set; }
    }
}
