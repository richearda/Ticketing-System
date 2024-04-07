﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Application.DTOs
{
    public class AttachmentDto
    {
        public int AttachementID { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string UploadedBy { get; set; }
        public DateOnly UploadedDate { get; set; }
    }
}
