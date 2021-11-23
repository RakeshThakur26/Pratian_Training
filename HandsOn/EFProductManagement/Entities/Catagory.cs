﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProductManagement.Entities
{
    public class Catagory
    {
        [Key]
        public int CatagoryId { get; set; }
        [Required][StringLength(40)] 
        public string Name { get; set; }
    }
}
