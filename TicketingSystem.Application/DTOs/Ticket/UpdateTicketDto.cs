﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Application.DTOs.Ticket
{
    public class UpdateTicketDto
    {
        public int TicketID { get; set; }
        public string TicketNo { get; set; }
        public int RequestedBy { get; set; }
        public DateOnly RequestedDate { get; set; }
        public string Title { get; set; }
        public string ProblemDescription { get; set; }
        public string Severity { get; set; }
        public int AssignedBy { get; set; }
        public int AssignedTo { get; set; }
        public DateOnly DueDate { get; set; }
        public DateTime DateTimeStarted { get; set; }
        public DateTime DateTimeCompleted { get; set; } = DateTime.Now;
        public string Remarks { get; set; }
        public string ProblemAnalysis { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string UploadedBy { get; set; }
        public DateOnly UploadedDate { get; set; }
    }
}
