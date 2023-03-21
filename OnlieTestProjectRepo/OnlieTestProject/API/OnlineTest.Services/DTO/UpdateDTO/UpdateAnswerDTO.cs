﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTest.Services.DTO.UpdateDTO
{
    public class UpdateAnswerDTO
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string AName { get; set; }
    }
}