using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repository.Models
{
    class CollectorLikes
    {
        [Key]
        public bool IsDislike { get; set; }

        [Key, ForeignKey("Collector")]
        public int CollectorId { get; set; }
        public Collector Collector { get; set; }

        [Key, ForeignKey("ItemId")]
        public int ItemId { get; set; }
        public Item Item { get; set; }

    }
}
