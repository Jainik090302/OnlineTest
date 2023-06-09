﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTest.Models
{
    public class MailOutbound
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("TestLink")]
        public int TestLinkId { get; set; }
        public string  To { get; set; }
        public string Content { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedOn { get; set; } 
        public int CreatedBy { get; set; }
        public TestLink TestLink { get; set; }
    }
}
