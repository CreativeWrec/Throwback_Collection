using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repository.Models
{
    public class CollectionObj
    {
        [Key]
        public int CollectionId { get; set; }
        public string Name { get; set; }
        public string GameTitle { get; set; }
        public string Genre { get; set; }
        public string System { get; set; }

        [ForeignKey("Collector")]
        public int CollectorId { get; set; }
        public Collector Collector { get; set; }

        [ForeignKey("Item")]
        public int ItemId { get; set; }
        public Item Item { get; set; }
    }
}
