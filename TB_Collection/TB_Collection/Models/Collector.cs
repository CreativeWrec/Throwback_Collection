using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TB_Collection.Models
{
    public class Collector
    {
        [Key]
        public int CollectorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
        
        //[ForeignKey("Collection")]
        //public int CollectionId { get; set; }
        //public CollectionObj Collection { get; set; }

        //[ForeignKey("Item")]
        //public int ItemId { get; set; }
        //public Item Item { get; set; }

        //[ForeignKey("WishList")]
        //public int WishListId { get; set; }
        //public CollectorWishlist WishList { get; set; }
    }
}
