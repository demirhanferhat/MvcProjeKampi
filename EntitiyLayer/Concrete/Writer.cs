﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }
        [StringLength(50)]
        public string WriterName { get; set; }
        [StringLength(50)]
        public string WriterSurname { get; set; }
        [StringLength(100)]
        public string WriterImage { get; set; }
        [StringLength(50)]
        public string WriterMail { get; set; }
        [StringLength(20)]
        public string WriterPassword { get; set; }

        //Writer ile Heading ilişkilendirilme alanı yani buraya kapı açmıs oluyoruz
        public ICollection<Heading> Headings { get; set; }

        //Writer ile Content ilişkilendirilme alanı yani buraya kapı açmıs oluyoruz
        public ICollection<Content> Contents { get; set; }
    }
}
