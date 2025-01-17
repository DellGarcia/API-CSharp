﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETL.Project.Models
{
    [Table("biblioteca")]
    public class Library
    {
        public int Id { get; set; }

        public DateTime AquisitionDate { get; set; }

        public User User { get; set; }

        public Game Game { get; set; }
    }
}
