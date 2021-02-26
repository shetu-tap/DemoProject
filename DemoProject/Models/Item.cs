﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Who Borrowed")]
        public string Borrower { get; set; }
        public string Lender { get; set; }
        [DisplayName("Item name")]
        public string ItemName { get; set; }
    }
}
