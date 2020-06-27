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
        
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        
        [Display(Name = "Favorite Gaming Moment")]
        public string FavoriteGamingMoment { get; set; }
        
        [Display(Name = "Favorite Console")]
        public string FavoriteConsole { get; set;}
        
        [Display(Name = "Favorite Game")]
        public string FavoriteGame { get; set; }
        
        [Display(Name = "Favorite Genre")]
        public string FavoriteGenre { get; set; }
        
        [Display(Name = "Profile Picture")]
        public string Uimg { get; set; }
        

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
