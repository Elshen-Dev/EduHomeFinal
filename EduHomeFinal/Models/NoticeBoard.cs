﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeFinal.Models
{
    public class NoticeBoard
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public string Title { get; set; }
        public bool IsDeactive { get; set; }
    }
}
