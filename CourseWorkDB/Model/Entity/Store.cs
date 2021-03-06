﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkDB.Model.Entity
{
    class Store
    {
        public int Id { get; set; }      

        public string Name { get; set; }
        public string Address { get; set; }

        public int? DepotId { get; set; }
        [Required]
        public Depot Depot { get; set; }
    }
}
