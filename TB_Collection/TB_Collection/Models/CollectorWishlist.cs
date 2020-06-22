using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TB_Collection.Models
{
    public class CollectorWishlist
    {
        [Key]
        public int WishListId { get; set; }
        public string WishList { get; set; }


        [ForeignKey("CollectorId")]
        public int CollectorId { get; set; }
        public Collector Collector { get; set; }

        [ForeignKey("ItemId")]
        public int ItemId { get; set; }
        public Item Item { get; set; }


    }
}
