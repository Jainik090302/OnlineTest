﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTest.Services.DTO.UpdateDTO
{
    public class UpdateAnswerSheetDTO
    {
        [Key]
        public int Id { get; set; }
        //public Guid Token { get; set; }
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }
        //[Column(TypeName = "DateTime")]
        //public DateTime CreatedTime { get; set; }
    }
}
