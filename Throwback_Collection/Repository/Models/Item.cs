using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repository.Models
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Genre { get; set; }
        public int Release { get; set;  }

        [ForeignKey("Collector")]
        public int CollectorId { get; set; }
        public Collector Collector { get; set; }
    }
}
