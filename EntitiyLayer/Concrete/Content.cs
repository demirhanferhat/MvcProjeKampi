using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class Content
    {
        [Key]
        public int ContentID { get; set; }
        [StringLength(1000)]
        public string ContentValue { get; set; }

        public DateTime ContentDate { get; set; }
        public bool ContentStatus { get; set; }

        //ContentYazar
        //ContentBaşlık

        //Heading Id ile Content ilişkilendirilme alanı yani açılan kapı ile buradan oraya gidiyoruz
        public int HeadingID { get; set; }
        public virtual Heading Heading { get; set; }

        //Writer Id ile Content ilişkilendirilme alanı yani açılan kapı ile buradan oraya gidiyoruz
        public int? WriterID { get; set; }
        public virtual Writer Writer { get; set; }
    }
}
