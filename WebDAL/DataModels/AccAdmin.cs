﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDAL.DataModels
{
    class AccAdmin
    {
        [Key]
        public string Id { get; set; }
        public string Username { get; set; }
        public string password { get; set; }
    }
}