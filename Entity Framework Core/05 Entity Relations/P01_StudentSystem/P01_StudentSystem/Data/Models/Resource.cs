﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using  P01_StudentSystem.Data.Enumerations;


namespace P01_StudentSystem.Data.Models
{
     public  class Resource
    {
        public int ResourceId { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public string Url { get; set; }

        public ResourceType ResourceType { get; set; }

        public int  CourseId { get; set; }

        public Course Course { get; set; }

    }
}
