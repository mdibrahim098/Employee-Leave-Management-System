﻿using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Web.Models.LeaveTypes
{
    public class LeaveTypeEditVM
    {
        public int Id { get; set; }
       
        [Required]
        [Length(4,90, ErrorMessage ="You have violated the length requirements")]
        public string Name { get; set; } = string.Empty;
       
        [Required]
        [Range(1,90)]
        public int NumberOfDays { get; set; }
    }
         
}
