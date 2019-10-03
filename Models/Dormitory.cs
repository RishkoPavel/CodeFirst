﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL
{
    public class Dormitory
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(30)]
        public string NameDormitory { get; set; }

        public List<Student> Students { get; set; }
    }
}
