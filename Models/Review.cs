using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace MVCMusicStore.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        public string Contents { get; set; }
        [Display(Name="Email Address")]
        [DataType(DataType.EmailAddress)]
        [Required]
        public string ReviewrEmail { get; set; }
        public Album Album { get; set; }
        public int AlbumID { get; set; }
    }
}
