using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreFront.DATA.EF;

namespace StoreFront.DATA.EF
{
    [MetadataType(typeof(ArtistMetadata))]
    public partial class Artist
    {
        [Display(Name ="Name")]
        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }
    }

    public class ArtistMetadata
    {
        [Required]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }
    }
}
