using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class Heading
    {
        [Key]
        public int HeadingID { get; set; }
        [StringLength(50)]
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }

        //Category Id ile Heading ilişkilendirilme alanı yani açılan kapı ile buradan oraya gidiyoruz
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        //Writer Id ile Heading ilişkilendirilme alanı yani açılan kapı ile buradan oraya gidiyoruz
        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; }

        //Heading ile Content ilişkilendirilme alanı yani buraya kapı açmıs oluyoruz
        public ICollection<Content> Contents { get; set; }
    }
}
